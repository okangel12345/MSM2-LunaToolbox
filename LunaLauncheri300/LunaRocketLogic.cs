using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LunaLauncheri30
{
    internal class LunaRocketLogic
    {
        private static bool isCompiling;

        private static void ClearTextSafe(RichTextBox richTextBox)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.Invoke(new Action(() => richTextBox.Clear()));
            }
            else
            {
                richTextBox.Clear();
            }
        }
        public static async Task CompileAsset(string inputPath, string outputPath, bool header, bool cleanup, bool stage,
                                   string stageName, string stageAuthor, string stageGame, string stagePath, RichTextBox richTextBox)
        {

            ClearTextSafe(richTextBox);

            if (string.IsNullOrWhiteSpace(inputPath) || string.IsNullOrWhiteSpace(outputPath))
            {
                AppendTextSafe(richTextBox, "Error: Input or output path is empty.");
                return;
            }
            

            string extension = Path.GetExtension(inputPath).ToLower();
            string program = null, platform = null;
            bool isDualPlatform = false;

            switch (extension)
            {
                case ".actor":
                    program = "ActorBuilder.exe";
                    platform = "Win";
                    break;
                case ".config":
                    program = "ConfigBuilder.exe";
                    platform = "Win";
                    break;
                case ".nodegraph":
                    program = "NodegraphBuilder.exe";
                    platform = "Win";
                    break;
                case ".texture":
                    program = "TextureBuilder.exe";
                    platform = "Win";
                    break;
                case ".material":
                    program = "MaterialBuilder.exe";
                    isDualPlatform = true;
                    break;
                case ".materialgraph":
                    program = "MaterialTemplateBuilder.exe";
                    isDualPlatform = true;
                    break;
                default:
                    richTextBox.AppendText($"Error: Unsupported file extension {extension}.\n");
                    return;
            }

            string fileName = Path.GetFileName(inputPath);
            string folderPath = Path.GetDirectoryName(inputPath);

            if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(folderPath))
            {
                AppendTextSafe(richTextBox, "Error: Failed to parse the input path.");

                return;
            }

            string workingDirectory = Path.Combine(Environment.GetEnvironmentVariable("IG_ROOT"), @"i30\devel\code\output");

            isCompiling = true;

            // Execute for a single or dual platform
            if (isDualPlatform)
            {
                await ExecuteCommandAsync(program, fileName, folderPath, outputPath, "PID", workingDirectory, richTextBox);
                await ExecuteCommandAsync(program, fileName, folderPath, outputPath, "Win", workingDirectory, richTextBox);
            }
            else
            {
                await ExecuteCommandAsync(program, fileName, folderPath, outputPath, platform, workingDirectory, richTextBox);
            }

            isCompiling = false;

            if (cleanup) richTextBox.AppendText("Processing cleanup...\n");
            if (stage)
            {
                if (string.IsNullOrWhiteSpace(stageName) || string.IsNullOrWhiteSpace(stageAuthor) ||
                    string.IsNullOrWhiteSpace(stageGame) || string.IsNullOrWhiteSpace(stagePath))
                {
                    richTextBox.AppendText("Error: Missing stage parameters.\n");
                }
                else
                {
                    richTextBox.AppendText("Processing stage...\n\n");
                }
            }
            HandleOutputFile(outputPath, fileName, richTextBox, header, stage, stageName, stageAuthor, stageGame, stagePath, cleanup);
        }

        private static async Task UniversalHeaderSwap(string filePath, RichTextBox richTextBox)
        {
            try
            {
                // Read the file into a byte array
                byte[] fileBytes = File.ReadAllBytes(filePath);

                // Get the file extension
                string fileExtension = Path.GetExtension(filePath).ToLower();

                // Initialize the bytes to prepend
                byte[] headerBytes = GetHeaderBytes(fileExtension, fileBytes);

                if (headerBytes == null)
                {
                    AppendTextSafe(richTextBox, $"No universal header found for extension: {fileExtension}\n");
                    return;
                }

                // Create a new byte array for the modified file
                byte[] newFileBytes = new byte[headerBytes.Length + fileBytes.Length];
                Buffer.BlockCopy(headerBytes, 0, newFileBytes, 0, headerBytes.Length);
                Buffer.BlockCopy(fileBytes, 0, newFileBytes, headerBytes.Length, fileBytes.Length);

                // Write the modified bytes back to the file
                File.WriteAllBytes(filePath, newFileBytes);

                AppendTextSafe(richTextBox, $"Header swapped and bytes prepended for: {filePath}\n");
            }
            catch (Exception ex)
            {
                AppendTextSafe(richTextBox, $"Error during header swap: {ex.Message}\n");
            }
        }

        private static byte[] GetHeaderBytes(string fileExtension, byte[] fileBytes)
        {
            // Extract the size bytes (positions 8 to A)
            byte[] sizeBytes = fileBytes.Skip(8).Take(3).ToArray();

            // Dictionary of file extensions and their corresponding header and additional bytes
            var headerDictionary = new Dictionary<string, (byte[] header, byte[] additionalBytes)>
    {
        {
            ".actor", (
                new byte[] {0x42,0xEC,0x2F,0x55,0x00,0x01,0x00,0x00},
                new byte[] { 0x80, 0x73, 0x00, 0x00, 0x10, 0xC8, 0x86, 0x78, 0x3E, 0x00, 0x02, 0x10, 0x00, 0x50, 0x00, 0x00, 0x00, 0xD6, 0x11, 0x00, 0x10, 0x00, 0x80, 0x00, 0x00}
            )
        },
        {
            ".config", (
                new byte[] { 0xA5,0xAF,0xF7,0x35,0x00,0x01,0x00,0x00 },
                new byte[] { 0x40, 0x88, 0x02, 0x00, 0x10, 0x44, 0xFB, 0xDF, 0x41, 0x00, 0x01, 0x00, 0x00, 0x20, 0x00, 0x00, 0xC0, 0x07, 0x00, 0x00, 0x10, 0xC8, 0x86, 0x78, 0x3E }
            )
        },
        {
            ".material", (
                new byte[] { 0x68,0x67,0x6C,0x4C,0x00,0x01,0x00,0x00 },
                new byte[] { 0x80, 0x7F, 0x00, 0x00, 0x10, 0x6A, 0xF6, 0xB1, 0x28, 0x00, 0x02, 0x00, 0x00, 0x40, 0x04, 0x00, 0x00, 0xC9, 0x09, 0x00, 0x10, 0x00, 0x37, 0x00, 0x00 }
            )
        },
        {
            ".materialgraph", (
                new byte[] { 0x5B,0xDC,0x1A,0x1C,0x00,0x01,0x00,0x00},
                new byte[] { 0x40, 0x71, 0x55, 0x00, 0x10, 0x0C, 0x53, 0x77, 0xBA, 0x00, 0x04, 0x10, 0x00, 0x40, 0x10, 0x00, 0x80, 0x45, 0x0D, 0x00, 0x10, 0x4C, 0x51, 0x00, 0x80 }
            )
        },
        {
            ".nodegraph", (
                new byte[] {0xC0,0xA4,0x8E,0x5C,0x00,0x01,0x00,0x00},
                new byte[] { 0xC0, 0xC0, 0x4F, 0x00, 0x10, 0x68, 0x67, 0x6C, 0x4C, 0x00, 0x01, 0x00, 0x00, 0x40, 0x06, 0x00, 0x80, 0xD3, 0x00, 0x00, 0x10, 0x44, 0xFB, 0xDF, 0x41 }
            )
        }
        // Add more file extensions and their corresponding header and additional bytes as needed
    };

            if (headerDictionary.ContainsKey(fileExtension))
            {
                var (header, additionalBytes) = headerDictionary[fileExtension];
                return header.Concat(sizeBytes).Concat(additionalBytes).ToArray();
            }

            // Return null if no header modification is found for the file extension
            return null;
        }


        private static async void HandleOutputFile(string outputPath, string inputFileName, RichTextBox richTextBox, Boolean Header, Boolean Stage, string StageName, string StageAuthor, string StageGame, string StagePath, Boolean Cleanup)
        {
            string destinationPath = Path.Combine(outputPath, inputFileName);

            if (File.Exists(destinationPath))
            { 
                File.Delete(destinationPath);
            }
            else { }

            try
            {
                var mostRecentFile = Directory.GetFiles(outputPath, "*", SearchOption.AllDirectories)
                                               .Select(f => new FileInfo(f))
                                               .OrderByDescending(f => f.CreationTime)
                                               .FirstOrDefault();

                if (mostRecentFile == null)
                {
                    AppendTextSafe(richTextBox, "Error: No files found in the output folder.\n");
                    return;
                }


                File.Copy(mostRecentFile.FullName, destinationPath);
              

                AppendTextSafe(richTextBox, $"File copied to: {destinationPath}\n");

                // Prepare the command to decompress the file
                string igRootPath = Environment.GetEnvironmentVariable("IG_ROOT");
                string decompressPath = Path.Combine(igRootPath, @"i30\devel\code\output");

                string decompressionExecutable = Path.Combine(decompressPath, "DecompressAsset.exe");

                // Ensure the file exists before attempting to decompress
                if (!File.Exists(decompressionExecutable))
                {
                    AppendTextSafe(richTextBox, "Error: DecompressAsset.exe not found.\n");
                    return;
                }

                // Execute the decompression command
                await ExecuteDecompressionCommand(decompressionExecutable, destinationPath, richTextBox);

                if (Header == true)
                {
                    UniversalHeaderSwap(destinationPath, richTextBox);
                }
                if (Cleanup == true)
                {
                    CleanupBuiltFiles(outputPath, destinationPath, richTextBox);
                }
                if (Stage == true)
                {
                    PackAsStage(outputPath, destinationPath, StageName, StageAuthor, StageGame, StagePath, richTextBox);

                }
                
            }
            catch (Exception ex)
            {
                AppendTextSafe(richTextBox, $"Error handling output file: {ex.Message}\n");
            }
        }


        private static void CleanupBuiltFiles(string outputPath, string destinationPath, RichTextBox richTextBox)
        {
            // Ensure the outputPath exists
            if (!Directory.Exists(outputPath))
            {
                AppendTextSafe(richTextBox, $"Output path does not exist: {outputPath}\n");
                return;
            }

            // Get all subdirectories in the output path
            string[] subdirectories = Directory.GetDirectories(outputPath);

            // Loop through each subdirectory and check if it contains the unwanted keywords
            foreach (string subdirectory in subdirectories)
            {
                string directoryName = Path.GetFileName(subdirectory);

                // Check if the directory name contains any of the unwanted keywords
                if (directoryName.IndexOf("PID", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    directoryName.IndexOf("Win", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    directoryName.IndexOf("PS5", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    try
                    {
                        // Attempt to delete the directory and its contents
                        Directory.Delete(subdirectory, true);
                        AppendTextSafe(richTextBox, $"Cleaned folder: {subdirectory}\n");
                    }
                    catch (Exception ex)
                    {
                        // Log any errors that occur during deletion
                        AppendTextSafe(richTextBox, $"Error deleting folder {subdirectory}: {ex.Message}\n");
                    }
                }
            }
        }


        private static void PackAsStage(string outputPath, string destinationPath, string stageName, string stageAuthor, string stageGame, string stagePath, RichTextBox richTextBox)
        {
            try
            {
                // Step 1: Move the destination file to the new path in outputPath, including renaming the file
                string targetDirectory = Path.Combine(outputPath, Path.GetDirectoryName(stagePath));
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                string targetFilePath = Path.Combine(outputPath, stagePath);
                File.Move(destinationPath, targetFilePath, true); // Move and overwrite if exists

                // Step 2: Delete all subdirectories in outputPath that do not start with "0"
                var directories = Directory.GetDirectories(outputPath);
                foreach (var dir in directories)
                {
                    if (!Path.GetFileName(dir).StartsWith("0"))
                    {
                        Directory.Delete(dir, true); // Delete non-"0" subdirectories
                    }
                }

                // Step 3: Create info.json in outputPath with provided game, name, and author as plain text
                string infoJsonContent = "{" + Environment.NewLine +
                                         $"  \"game\": \"{stageGame}\"," + Environment.NewLine +
                                         $"  \"name\": \"{stageName}\"," + Environment.NewLine +
                                         $"  \"author\": \"{stageAuthor}\"," + Environment.NewLine +
                                         "  \"headerless\": []" + Environment.NewLine +
                                         "}";

                string infoFilePath = Path.Combine(outputPath, "info.json");
                File.WriteAllText(infoFilePath, infoJsonContent);

                // Step 4: Create a zip file from the contents of outputPath, but ensure it includes files from subdirectories
                string stageZipPath = Path.Combine(outputPath, $"{stageName}.stage");

                // Ensure that we are zipping only the necessary files, not the root of outputPath
                string tempDir = Path.Combine(outputPath, "temp");
                Directory.CreateDirectory(tempDir);

                // Copy all files from the subdirectories to the temporary folder for zipping
                foreach (var file in Directory.GetFiles(outputPath, "*", SearchOption.AllDirectories))
                {
                    string relativePath = file.Substring(outputPath.Length + 1); // Remove outputPath part
                    string destinationPathForFile = Path.Combine(tempDir, relativePath);
                    string destinationDir = Path.GetDirectoryName(destinationPathForFile);

                    if (!Directory.Exists(destinationDir))
                    {
                        Directory.CreateDirectory(destinationDir);
                    }

                    File.Copy(file, destinationPathForFile, true); // Copy file to the temp directory
                }

                // Now create the zip from the temporary folder
                ZipFile.CreateFromDirectory(tempDir, stageZipPath);

                // Clean up the temporary directory after zipping
                Directory.Delete(tempDir, true);

                AppendTextSafe(richTextBox, "Stage processing has been completed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error packing stage: {ex.Message}");
            }
        }

        private static async Task ExecuteDecompressionCommand(string decompressionExecutable, string filePath, RichTextBox richTextBox)
        {
            try
            {
                // Prepare the process start information for executing the decompression command
                string arguments = $"\"{filePath}\" \"{filePath}\"";

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = decompressionExecutable,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Start the process
                using (Process process = Process.Start(startInfo))
                {
                    if (process != null)
                    {
                        // Read the output and error streams asynchronously
                        string output = await process.StandardOutput.ReadToEndAsync();
                        string error = await process.StandardError.ReadToEndAsync();


                        // Append the output to the RichTextBox
                        AppendTextSafe(richTextBox, "Asset has been decompressed. It is now ready to use.\n");
                        HighlightWords(richTextBox, wordsToHighlight);

                        if (!string.IsNullOrEmpty(error))
                        {
                            AppendTextSafe(richTextBox, $"Error during decompression: {error}\n");
                            HighlightWords(richTextBox, wordsToHighlight);
                        }

                        // Wait for the process to exit
                        await process.WaitForExitAsync();
                        HighlightWords(richTextBox, wordsToHighlight);
                    }
                }
            }
            catch (Exception ex)
            {
                AppendTextSafe(richTextBox, $"Error executing decompression command: {ex.Message}\n");
            }
        }





        private static async Task ExecuteCommandAsync(string program, string fileName, string folderPath, string outputPath,
                                           string platform, string workingDirectory, RichTextBox richTextBox)
        {
            string command = $"{program} {fileName} -source \"{folderPath}\" -built \"{outputPath}\" -plat {platform}";

            richTextBox.AppendText($"Executing for platform {platform}...\n");

            try
            {
                await Task.Run(() =>
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            Arguments = $"/C {command}",
                            WorkingDirectory = workingDirectory,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.Start();
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();
                        process.WaitForExit();

                        if (!string.IsNullOrWhiteSpace(output))
                            AppendTextSafe(richTextBox, output + "\n");
                        if (!string.IsNullOrWhiteSpace(error))
                            AppendTextSafe(richTextBox, "Error: " + error + "\n");
                    }
                });


            }
            catch (Exception ex)
            {
                AppendTextSafe(richTextBox, $"Error: Failed to execute command. {ex.Message}\n");
            }
        }

        public static Dictionary<string, Color> wordsToHighlight = new Dictionary<string, Color>
                    {
                        { "Asset ", Color.FromArgb(87, 198, 236) },
                    };

        private static void AppendTextSafe(RichTextBox richTextBox, string text)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.Invoke(new Action(() => richTextBox.AppendText(text)));
            }
            else
            {
                richTextBox.AppendText(text);  
                HighlightWords(richTextBox, wordsToHighlight);
            }
        }
        private static void HighlightWords(RichTextBox richTextBox, Dictionary<string, Color> wordsToHighlight)
        {
            // Start by clearing previous highlights
            richTextBox.SelectAll();
            richTextBox.SelectionColor = richTextBox.ForeColor;

            // Loop through each word and apply highlighting
            foreach (var wordPair in wordsToHighlight)
            {
                string word = wordPair.Key;
                Color highlightColor = wordPair.Value;

                int startIndex = 0;
                while (startIndex < richTextBox.Text.Length)
                {
                    // Find the word in the RichTextBox text, starting from the current position
                    int wordIndex = richTextBox.Text.IndexOf(word, startIndex, StringComparison.OrdinalIgnoreCase);

                    if (wordIndex == -1)
                        break; // No more occurrences of the word

                    // Set the selection to the found word
                    richTextBox.SelectionStart = wordIndex;
                    richTextBox.SelectionLength = word.Length;

                    // Change the selection color to the specified highlight color
                    richTextBox.SelectionColor = highlightColor;

                    // Move the start index to after the highlighted word to continue searching
                    startIndex = wordIndex + word.Length;
                }
            }

            // Reset the selection color to default
            richTextBox.SelectionColor = richTextBox.ForeColor;
        }
    }
}
