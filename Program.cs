using System.Drawing;
using System;


namespace Image_generation
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 1024;
            double height = 1024;


            Bitmap image = new Bitmap(Convert.ToInt32(width), Convert.ToInt32(height));

            for (double x = 0; x < width; x++)
            {


                for (double y = 0; y < height; y++)
                {
                    int a = 255;
                    int r = (Convert.ToInt32(pixelGen(10, 10)));
                    int b = (Convert.ToInt32(pixelGen(x, y)));
                    int g = (Convert.ToInt32(pixelGen(x, y)));

                    image.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.FromArgb(a, r, g, b));
                }
            }
            image.Save("images/Image.bmp");
            Console.WriteLine("Done!");
        }

        static double pixelGen(double x, double y)
        {
            return Math.Abs(Math.Sqrt(x * y) % 255);
        }
    }
}
