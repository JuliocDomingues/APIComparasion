using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static Image<Bgr, Byte> DetectFaces(Mat frame, int width, int height)
        {
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(width, height, Inter.Cubic);

            Mat grayImage = new Mat();
            CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayImage, grayImage);

            Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

            if(faces.Length > 0)
            {
                foreach(var face in faces)
                {
                    resultImage = currentFrame.Convert<Bgr, Byte>();
                    resultImage.ROI = face;

                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                }
            }
            
            return currentFrame;
        }

    }
}
