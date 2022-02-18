using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace APIComparasion.HelperMethods
{
    public class Helpers
    {
        public Helpers()
        {

        }


        public static OpenCvSharp.Mat GetFrame(VideoCapture cap, double scalingFactor)
        {
            Mat frame = new Mat();
            bool ret = cap.Read(frame);
            Cv2.Resize(frame, frame, new OpenCvSharp.Size(), fx: scalingFactor, fy: scalingFactor, interpolation: InterpolationFlags.Area);

            return frame;
        }

        public static Bitmap CropBitmap(Bitmap image, Rectangle rect)
        {
            Bitmap tmpImage = new Bitmap(image);
            Bitmap cropImage = tmpImage.Clone(rect, tmpImage.PixelFormat);

            return cropImage;
        }

        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

    }
}
