using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using APIComparasion.HelperMethods;
using APIComparasion.CenterFaceAPI;
using APIComparasion.EmguCVAPI;
using OpenCvSharp.Extensions;

namespace APIComparasion
{
    public partial class Form1 : Form
    {
        #region Variables
        private VideoCapture _captureOpenCv = null;
        private Emgu.CV.Capture _captureEmgu = null;
        private bool centerFace = false;
        private bool emguCvFlag = false;
        Mat imageOpenCv;
        Emgu.CV.Mat imageEmgu = new Emgu.CV.Mat();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCenterFace_Click(object sender, EventArgs e)
        {
            _captureOpenCv = new VideoCapture(0);
            centerFace = true;

            Application.Idle += ProcessFrame;
        }

        private void btnEmgu_Click(object sender, EventArgs e)
        {
            _captureEmgu = new Emgu.CV.Capture();
            emguCvFlag = true;

            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (centerFace)
            {
                imageOpenCv = Helpers.GetFrame(_captureOpenCv, 1.0);

               Mat mat = CenterFaceDotNetAPI.DetectFaces(imageOpenCv, picFace.Width, picFace.Height);

                picCapture.Image = mat.ToBitmap();
                picFace.Image = CenterFaceDotNetAPI.smallImage;
            }
            else if (emguCvFlag)
            {
                _captureEmgu.Retrieve(imageEmgu, 0);
                picCapture.Image = EmguCvAPI.DetectFaces(imageEmgu, picCapture.Width, picCapture.Height).Bitmap;

                picFace.SizeMode = PictureBoxSizeMode.StretchImage;
                picFace.Image = EmguCvAPI.resultImage.Bitmap;
            }
            else
            {
                imageOpenCv = Helpers.GetFrame(_captureOpenCv, 1.0);
                picCapture.Image = imageOpenCv.ToBitmap();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
