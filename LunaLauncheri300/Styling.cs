using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LunaLauncheri30
{
    internal class Styling
    {
        public static void ApplyButtonStyle(Control parent, FlatStyle style, Color borderColor, Color topColor, Color bottomColor, int borderSize)
        {
            Color CustomTopColor = Color.FromArgb(42,42,42);
            Color CustomBottomColor = Color.FromArgb(56,56,56);
            // Recursively apply the style to buttons in all controls
            void ApplyStyleRecursive(Control parentControl)
            {
                foreach (Control control in parentControl.Controls)
                {
                    if (control is Button button)
                    {
                        button.FlatStyle = style;
                        button.FlatAppearance.BorderColor = borderColor;
                        button.FlatAppearance.BorderSize = borderSize;
                        button.ForeColor = Color.WhiteSmoke;

                        // Attach custom paint event for gradient and hover effect
                        button.Paint += (sender, e) => ApplyGradient(sender as Button, e, CustomTopColor, CustomBottomColor);

                        // Change background color on mouse enter and leave for hover effect
                        button.MouseEnter += (sender, e) => button.Invalidate(); // Redraw the button when mouse enters
                        button.MouseLeave += (sender, e) => button.Invalidate(); // Redraw the button when mouse leaves
                    }
                    // Recursively apply to child controls
                    if (control.HasChildren)
                    {
                        ApplyStyleRecursive(control);
                    }
                }
            }

            // Start applying from the parent control (e.g., form)
            ApplyStyleRecursive(parent);
        }

        private static void ApplyGradient(Button button, PaintEventArgs e, Color topColor, Color bottomColor)
        {
            // Use a different color scheme if hovering over the button
            Color hoverTopColor = ControlPaint.Light(topColor, 0.2f);
            Color hoverBottomColor = ControlPaint.Light(bottomColor, 0.2f);

            // Determine if the button is being hovered (button state is pressed or hovered)
            bool isHovered = button.ClientRectangle.Contains(button.PointToClient(Cursor.Position));
            Color currentTopColor = isHovered ? hoverTopColor : topColor;
            Color currentBottomColor = isHovered ? hoverBottomColor : bottomColor;

            // Create a gradient brush from top to bottom
            using (var brush = new LinearGradientBrush(button.ClientRectangle, currentTopColor, currentBottomColor, 90f))
            {
                // Fill the button background with the gradient
                e.Graphics.FillRectangle(brush, button.ClientRectangle);
            }

            // Draw the button's text on top of the gradient
            TextRenderer.DrawText(
                e.Graphics,
                button.Text,
                button.Font,
                button.ClientRectangle,
                button.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

            // Optionally draw the button's border after applying the gradient
            ControlPaint.DrawBorder(e.Graphics, button.ClientRectangle, button.FlatAppearance.BorderColor, ButtonBorderStyle.Solid);
        }


        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_CAPTION_COLOR = 35;

        // Static method to set title bar color
        public static void SetTitleBarColor(IntPtr hwnd, Color color)
        {
            // Swap the Red and Blue components of the color
            Color swappedColor = Color.FromArgb(color.A, color.B, color.G, color.R);

            // Multiply each RGB component by 0.7 to darken the color
            int red = (int)(swappedColor.R * 0.7);
            int green = (int)(swappedColor.G * 0.7);
            int blue = (int)(swappedColor.B * 0.7);

            // Ensure that the values are within the valid range [0, 255]
            red = Math.Max(0, Math.Min(255, red));
            green = Math.Max(0, Math.Min(255, green));
            blue = Math.Max(0, Math.Min(255, blue));

            // Create a new color with the modified values
            Color finalColor = Color.FromArgb(swappedColor.A, red, green, blue);

            // Convert the modified color to ARGB format and set the window title bar color
            int finalColorValue = finalColor.ToArgb() & 0x00FFFFFF;

            // Call DwmSetWindowAttribute to change the title bar color
            DwmSetWindowAttribute(hwnd, DWMWA_CAPTION_COLOR, ref finalColorValue, sizeof(int));
        }
    }
}
