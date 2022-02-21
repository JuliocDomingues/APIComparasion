using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace APIComparasion.EmguCVAPI
{
    public class EmguCvAPI
    {
        #region Variables
        private static CascadeClassifier faceCasacdeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        private static Image<Bgr, Byte> currentFrame = null;
        #endregion

        #region Getters/Setters
        public static Image<Bgr, Byte> resultImage { get; set; }
        #endregion

        public EmguCvAPI()
        {

        }

        public static Image<Bgr, Byte> DetectFaces(Mat frame, int width, int height, Label detectionTimeLabel, Label drawingTimeLabel)
        {
            // Start watch to mesure time to detect
            var watch = System.Diagnostics.Stopwatch.StartNew();

            currentFrame = frame.ToImage<Bgr, Byte>().Resize(width, height, Inter.Cubic);

            Mat grayImage = new Mat();
            CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayImage, grayImage);

            Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

            watch.Stop();
            detectionTimeLabel.Text = "Detection time: " + watch.ElapsedMilliseconds.ToString() + " ms";

            // Restart watch to mesure time to draw
            watch.Restart();

            if (faces.Length > 0)
            {
                foreach(var face in faces)
                {
                    resultImage = currentFrame.Convert<Bgr, Byte>();
                    resultImage.ROI = face;

                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                }
            }

            watch.Stop();
            drawingTimeLabel.Text = "Drawing time: " + watch.ElapsedMilliseconds.ToString() + " ms";

            return currentFrame;
        }

    }
}
