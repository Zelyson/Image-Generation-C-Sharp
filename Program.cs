using System.Drawing;
using System;


namespace Image_generation
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 500;
            double height = 500;
            double current = 0.4;
            double growth = 8;


            Bitmap image = new Bitmap(Convert.ToInt32(width), Convert.ToInt32(height));

            for (double x = 0; x < width; x++)
            {


                for (double y = 0; y < height; y++)
                {
                    int a = 255;
                    current = pixelGen(current, growth);
                    int r = (Convert.ToInt32(current));
                    current = pixelGen(current, growth);
                    int b = (Convert.ToInt32(current));
                    current = pixelGen(current, growth);
                    int g = (Convert.ToInt32(current));

                    image.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.FromArgb(a, r, g, b));
                }
            }
            image.Save("images/Image.bmp");
            Console.WriteLine(current);
        }

        static double pixelGen(double current, double growth)
        {
            return Math.Abs((growth * current * (1 - current) * 255) % 255);
        }
    }
}
