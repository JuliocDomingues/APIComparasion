using System;
using System.Drawing;
using Pnt = System.Drawing.Point;
using FaceRecognitionDotNet;
using OpenCvSharp;
using System.Linq;
using System.IO;
using APIComparasion.FaceDetectionCustom;
using System.Windows.Forms;
using APIComparasion.HelperMethods;

namespace APIComparasion.FaceRecognitionDNet
{
    public class FaceRecDotNet
    {
        #region Variables
        private static FaceRecognition _faceRecognition;
        #endregion

        #region Getters/Setters
        public static Bitmap resultImage { get; set; }
        #endregion

        public static Bitmap InitFace(VideoCapture videoCapture, CameraModule cameraModule, Label detectionTimeLabel, Label drawingTimeLabel)
        {
            string modelsDirectory = @".\models\";

            Enum.TryParse<Model>(modelsDirectory, true, out var model);

            _faceRecognition = FaceRecognition.Create(Path.GetFullPath("models"));

            return OpenAndTest(videoCapture, cameraModule, model, detectionTimeLabel,drawingTimeLabel);
        }

        private static Bitmap OpenAndTest(VideoCapture videoCapture, CameraModule cameraModule, Model model, Label detectionTimeLabel, Label drawingTimeLabel)
        {

            Mat mat = videoCapture.RetrieveMat();

            Bitmap bitmap = MatToBitmap(mat);

            bitmap = TestImage(bitmap, model, detectionTimeLabel, drawingTimeLabel);

            mat = BitmapToMat(bitmap);

            //Cv2.ImShow("Image Show", mat);
            return bitmap;
        }

        private static Bitmap MatToBitmap(Mat mat)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
        }

        private static Mat BitmapToMat(Bitmap bitmap)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToMat(bitmap);
        }

        public static Bitmap TestImage(Bitmap unknownBitmap, Model model, Label detectionTimeLabel, Label drawingTimeLabel)
        {
            

            using (var unknownImage = FaceRecognition.LoadImage(unknownBitmap))
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                var faceLocations = _faceRecognition.FaceLocations(unknownImage, 0, model).ToArray();
                
                watch.Stop();
                detectionTimeLabel.Text = "Detection time: " + watch.ElapsedMilliseconds.ToString() + " ms";

                watch.Restart();

                Bitmap bitmap = unknownImage.ToBitmap();

                if (faceLocations.Count() == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var faceLocation in faceLocations)
                    {
                        resultImage = Helpers.ResizeBitmap(
                            Helpers.CropBitmap(bitmap,
                            new Rectangle(faceLocation.Left, faceLocation.Top, faceLocation.Right - faceLocation.Left, faceLocation.Right - faceLocation.Left)),
                            faceLocation.Right - faceLocation.Left,
                            faceLocation.Bottom - faceLocation.Top);

                        DrawRect(bitmap, faceLocation);
                        Console.WriteLine($"{faceLocation.Top}, " +
                                          $"{faceLocation.Right}, {faceLocation.Bottom},{faceLocation.Left}");

                    }
                }
                watch.Stop();
                drawingTimeLabel.Text = "Drawing time: " + watch.ElapsedMilliseconds.ToString() + " ms";

                return bitmap;
            }
        }

        private static void DrawRect(Bitmap bitmap, Location faceLocation)
        {
            int left = faceLocation.Left;
            int top = faceLocation.Top;
            int right = faceLocation.Right;
            int bottom = faceLocation.Bottom;

            Pnt topLeft = new Pnt(left, top),
                bottomLeft = new Pnt(left, bottom),
                topRight = new Pnt(right, top),
                bottomRight = new Pnt(right, bottom);

            DrawLine(bitmap, topLeft, topRight);
            DrawLine(bitmap, topRight, bottomRight);
            DrawLine(bitmap, bottomRight, bottomLeft);
            DrawLine(bitmap, bottomLeft, topLeft);
        }

        private static void DrawLine(Bitmap bitmap, Pnt point1, Pnt point2)
        {
            Pen pen = new Pen(Color.Red, 3);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawLine(pen, point1, point2);
            }
        }
    }
}
