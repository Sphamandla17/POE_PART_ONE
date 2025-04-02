using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    public class Authentication
    {
        public void Authorize()
        {
            string imagePath = "AuthenticationAndAuthorization.jpg";

            if (!File.Exists(imagePath))
            {
                Console.WriteLine($"Error: Image file not found at {Path.GetFullPath(imagePath)}");
                return;
            }

            try
            {
                using (Bitmap image = new Bitmap(imagePath))
                {
                    int newWidth = Math.Min(80, image.Width);
                    int newHeight = (int)(image.Height * ((double)newWidth / image.Width));
                    newHeight = Math.Min(newHeight, 50);

                    using (Bitmap resizedImage = new Bitmap(newWidth, newHeight))
                    {
                        using (Graphics g = Graphics.FromImage(resizedImage))
                        {
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            g.DrawImage(image, 0, 0, newWidth, newHeight);
                        }

                        string asciiChars = "@%#*+=-:. ";
                        for (int y = 0; y < resizedImage.Height; y++)
                        {
                            for (int x = 0; x < resizedImage.Width; x++)
                            {
                                Color pixelColor = resizedImage.GetPixel(x, y);
                                double brightness = 0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B;
                                int index = (int)(brightness / 255 * (asciiChars.Length - 1));
                                Console.Write(asciiChars[Math.Clamp(index, 0, asciiChars.Length - 1)]);
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing image: {ex.Message}");
            }
        }
    }
}
