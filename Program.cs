using System.Drawing;
using System;


namespace Image_generation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define image size and create new bitmap object
            double width = 1024;
            double height = 1024;
            Bitmap image = new Bitmap(Convert.ToInt32(width), Convert.ToInt32(height));

            // Loop through every pixel with two nested loops
            for (double x = 0; x < width; x++)
            {
                for (double y = 0; y < height; y++)
                {
                    // Calculate values with pixelGen()
                    int a = 255;
                    int r = (Convert.ToInt32(pixelGen(x, y)));
                    int b = (Convert.ToInt32(pixelGen(x, y)));
                    int g = (Convert.ToInt32(pixelGen(x, y)));
                    // Write calculated values to bitmap object
                    image.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.FromArgb(a, r, g, b));
                }
            }
            // Save bitmap as Image.bmp in Image directory
            image.Save("images/Image.bmp");
            Console.WriteLine("Done!");
        }

        // Function for calculating rgb values 
        static double pixelGen(double x, double y)
        {
            return Math.Abs(Math.Sqrt(x * y) % 255);
        }
    }
}
