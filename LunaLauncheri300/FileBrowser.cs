using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaLauncheri30
{
    internal class FileBrowser
    {
        public static void LoadFilesIntoTree(TreeView treeView, List<string> validExtensions, string SourceFolder)
        {
            string igRoot = Environment.GetEnvironmentVariable("IG_ROOT");
            if (string.IsNullOrEmpty(igRoot))
            {
                MessageBox.Show("The IG_ROOT environment variable is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construct the source directory path
            string sourcePath = Path.Combine(igRoot, "i30", "devel", "assets", SourceFolder);

            // Check if the source directory exists
            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show($"The source directory does not exist: {sourcePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing nodes in the TreeView
            treeView.Nodes.Clear();

            // Create the root node for the TreeView
            TreeNode rootNode = new TreeNode(SourceFolder)
            {
                Tag = sourcePath // Store the full path in the Tag property for later use
            };
            treeView.Nodes.Add(rootNode);

            // Recursively load files and folders
            LoadDirectory(sourcePath, rootNode, validExtensions);

            // Expand the root node
            rootNode.Expand();
        }

        private static void LoadDirectory(string directoryPath, TreeNode parentNode, List<string> validExtensions)
        {
            try
            {
                // Load subdirectories
                string[] subdirectories = Directory.GetDirectories(directoryPath);
                foreach (string subdirectory in subdirectories)
                {
                    // Create a node for the directory
                    string directoryName = Path.GetFileName(subdirectory);
                    TreeNode directoryNode = new TreeNode(directoryName)
                    {
                        Tag = subdirectory // Store the full path
                    };
                    parentNode.Nodes.Add(directoryNode);

                    // Recursively load the contents of the directory
                    LoadDirectory(subdirectory, directoryNode, validExtensions);
                }

                // Load files
                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    // Get file extension
                    string fileExtension = Path.GetExtension(file).ToLower();

                    // Check if the file's extension is valid
                    if (validExtensions.Contains(fileExtension))
                    {
                        // Create a node for the file
                        string fileName = Path.GetFileName(file);
                        TreeNode fileNode = new TreeNode(fileName)
                        {
                            Tag = file // Store the full path
                        };
                        parentNode.Nodes.Add(fileNode);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle access errors gracefully
                MessageBox.Show($"Access denied to directory: {directoryPath}\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void SearchTreeView(TreeView treeView, TextBox searchTextBox)
        {
            // Get the search term from the TextBox and split it into keywords
            string searchTerm = searchTextBox.Text.Trim();
            var keywords = searchTerm.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries); // Split by spaces or commas

            // If the search term is empty, reload the entire tree view
            if (keywords.Length == 0)
            {
                LoadFilesIntoTree(treeView, LunaRocketPanel.validExtensions, "source");
                return;
            }

            // Clear the TreeView for search results
            treeView.Nodes.Clear();

            // Get the IG_ROOT environment variable
            string igRoot = Environment.GetEnvironmentVariable("IG_ROOT");
            if (string.IsNullOrEmpty(igRoot))
            {
                MessageBox.Show("The IG_ROOT environment variable is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construct the source directory path
            string sourcePath = Path.Combine(igRoot, "i30", "devel", "assets", "source");

            // Check if the source directory exists
            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show($"The source directory does not exist: {sourcePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a root node for search results
            TreeNode rootNode = new TreeNode("Search Results");
            treeView.Nodes.Add(rootNode);

            // Perform a recursive search, passing the valid extensions to filter files
            PerformSearch(sourcePath, keywords, rootNode, LunaRocketPanel.validExtensions);

            // Expand the search results
            rootNode.Expand();
        }

        private static void PerformSearch(string directoryPath, string[] keywords, TreeNode parentNode, List<string> validExtensions)
        {
            try
            {
                // Search in subdirectories
                string[] subdirectories = Directory.GetDirectories(directoryPath);
                foreach (string subdirectory in subdirectories)
                {
                    string directoryName = Path.GetFileName(subdirectory);

                    // Check if any keyword matches the directory name
                    if (keywords.All(keyword => directoryName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        TreeNode directoryNode = new TreeNode(directoryName)
                        {
                            Tag = subdirectory // Store the full path
                        };
                        parentNode.Nodes.Add(directoryNode);
                    }

                    // Recursively search within the directory
                    PerformSearch(subdirectory, keywords, parentNode, validExtensions);
                }

                // Search in files
                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);

                    // Check if the file has a valid extension and if any keyword matches the file name
                    if (validExtensions.Any(ext => fileName.EndsWith(ext, StringComparison.OrdinalIgnoreCase)) &&
                        keywords.All(keyword => fileName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        TreeNode fileNode = new TreeNode(fileName)
                        {
                            Tag = file // Store the full path
                        };
                        parentNode.Nodes.Add(fileNode);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle access errors gracefully
                MessageBox.Show($"Access denied to directory: {directoryPath}\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}