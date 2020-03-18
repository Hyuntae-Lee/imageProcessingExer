using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HitAndMiss
{
    public class Process
    {
        public static Bitmap erosion(BitmapImage image, BitmapImage se)
        {
            int nPixelPerPt = image.PixelWidth / (int)image.Width;

            var retImageData = getBytesFromPngImage(image);

            //
            var imageW = retImageData.Item2;
            var imageH = retImageData.Item3;
            var imageData = retImageData.Item1;

            Bitmap retImage = new Bitmap(imageW, imageH);
            for (int y = 0; y < imageH; y++)
            {
                for (int x = 0; x < imageW; x++)
                {
                    if (isValidPixelForErosion(imageData, imageW, imageH, x, y, se))
                    {
                        retImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        retImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return retImage;
        }

        public static BitmapImage dilation(BitmapImage image, BitmapImage SE)
        {
            return image;
        }

        public static BitmapImage open(BitmapImage image, BitmapImage SE)
        {
            return image;
        }

        public static BitmapImage close(BitmapImage image, BitmapImage SE)
        {
            return image;
        }

        private static bool isValidPixelForErosion(byte[] imageData, int imageW, int imageH, int x, int y, BitmapImage se)
        {
            var retSEData = getBytesFromPngImage(se);
            int seW = retSEData.Item2;
            int seH = retSEData.Item3;
            var seData = retSEData.Item1;

            int seL = x - (int)seW / 2;
            int seT = y - (int)seH / 2;
            int seR = x + (int)seW / 2;
            int seB = y + (int)seH / 2;

            if (seL < 0 || seT < 0 || seR >= imageW || seB >= imageH)
            {
                return false;
            }

            for (int seY = 0; seY < seH; seY++)
                for (int seX = 0; seX < seW; seX++)
                {
                    int seXInImage = x - seW / 2 + seX;
                    int seYInImage = y - seH / 2 + seY;

                    var pixelOfSe = seData[seY * seW + seX];
                    var pixelOfImage = imageData[imageW * seYInImage + seXInImage];

                    if (pixelOfSe <= 0)
                        continue;

                    if (pixelOfImage <= 0)
                        return false;
                }

            return true;
        }

        private static Tuple<byte[], int, int> getBytesFromPngImage(BitmapImage bitmapSource)
        {
            // Convert png data to byte array
            int width = bitmapSource.PixelWidth;
            int height = bitmapSource.PixelHeight;
            int stride = width * ((bitmapSource.Format.BitsPerPixel + 7) / 8);
            byte[] pixels = new byte[height * stride];
            bitmapSource.CopyPixels(pixels, stride, 0);

            return new Tuple<byte[], int, int>(pixels, width, height);
        }
    }
}
