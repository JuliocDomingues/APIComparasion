using System.Drawing;
using System.IO;
using System.Linq;
using CenterFaceDotNet;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using APIComparasion.HelperMethods;
using System.Windows.Forms;

namespace APIComparasion.CenterFaceAPI
{
    public class CenterFaceDotNetAPI
    {
        #region Variables

        public static Bitmap smallImage { get; set; }

        private static CenterFace _centerFace = CenterFace.Create(new CenterFaceParameter
        {
            BinFilePath = Directory.GetCurrentDirectory() + @"\centerface.bin",
            ParamFilePath = Directory.GetCurrentDirectory() + @"\centerface.param"
        });

        #endregion

        public CenterFaceDotNetAPI()
        {

        }

        public static Mat DetectFaces(Mat image, int width, int height, Label detectionTimeLabel, Label drawingTimeLabel)
        {
            // Start watch to mesure time to detect
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var inMat = NcnnDotNet.Mat.FromPixels(image.Data, NcnnDotNet.PixelType.Bgr2Gray, image.Cols, image.Rows);
            var faceInfos = _centerFace.Detect(inMat, image.Cols, image.Rows).ToArray();

            watch.Stop();
            detectionTimeLabel.Text = "Detection time: " + watch.ElapsedMilliseconds.ToString() + " ms";

            // Restart watch to mesure time to draw
            watch.Restart();

            foreach (FaceInfo face in faceInfos)
            {
                var pt3 = new System.Drawing.Point((int)face.X1, (int)face.Y1);
                var size = new System.Drawing.Size((int)(face.X2 - face.X1), (int)(face.Y2 - face.Y1));

                smallImage = Helpers.ResizeBitmap(Helpers.CropBitmap(image.ToBitmap(), new Rectangle(pt3, size)), width, height);
            }

            foreach (FaceInfo face in faceInfos)
            {
                var pt1 = new OpenCvSharp.Point(face.X1, face.Y1);
                var pt2 = new OpenCvSharp.Point(face.X2, face.Y2);
                Cv2.Rectangle(image, pt1, pt2, new Scalar(0, 255, 0), 2);

                for (var j = 0; j < 5; j++)
                {
                    var center = new OpenCvSharp.Point(face.Landmarks[2 * j], face.Landmarks[2 * j + 1]);
                    Cv2.Circle(image, center, 2, new Scalar(255, 255, 0), 2);
                }
            }

            watch.Stop();
            drawingTimeLabel.Text = "Drawing time: " + watch.ElapsedMilliseconds.ToString() + " ms";

            return image;
        }
    }
}
