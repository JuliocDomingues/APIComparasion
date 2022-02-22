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
using APIComparasion.FaceDetectionCustom;

namespace APIComparasion
{
    public partial class Form1 : Form
    {
        #region Variables
        private VideoCapture _captureOpenCv = null;
        //private VideoCapture _captureFace = null;
        private Emgu.CV.Capture _captureEmgu = null;
        private bool centerFace = false;
        private bool emguCvFlag = false; 
        private bool faceRecognition = false;
        Mat imageOpenCv;
        //Mat imageFace;
        Emgu.CV.Mat imageEmgu = new Emgu.CV.Mat();
        VideoCapture videoCapture;
        CameraModule cameraModule;
        #endregion

        public Form1()
        {
            InitializeComponent();

            switchParametersOptionsVisibility(false);
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (centerFace)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                imageOpenCv = Helpers.GetFrame(_captureOpenCv, 1.0);

                Mat mat = CenterFaceDotNetAPI.DetectFaces(imageOpenCv, picFace.Width, picFace.Height, detectionTime, drawingTime);

                picCapture.Image = mat.ToBitmap();
                picFace.Image = CenterFaceDotNetAPI.smallImage;

                watch.Stop();
                totalTime.Text = "Total time: " + watch.ElapsedMilliseconds.ToString() + " ms";
            }
            else if (emguCvFlag)
            {
                var scaleFactorValue = decimal.ToDouble(scaleFactor.Value);
                var neighborsValue = decimal.ToInt32(neighbors.Value);

                var watch = System.Diagnostics.Stopwatch.StartNew();

                _captureEmgu.Retrieve(imageEmgu, 0);
                picCapture.Image = EmguCvAPI.DetectFaces(imageEmgu,
                    picCapture.Width,
                    picCapture.Height,
                    scaleFactorValue,
                    neighborsValue,
                    detectionTime,
                    drawingTime)
                    .Bitmap;

                picFace.SizeMode = PictureBoxSizeMode.StretchImage;
                if (EmguCvAPI.resultImage != null)
                {
                    picFace.Image = EmguCvAPI.resultImage.Bitmap;
                }

                watch.Stop();
                totalTime.Text = "Total time: " + watch.ElapsedMilliseconds.ToString() + " ms";
            }
            else if (faceRecognition)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                picCapture.Image = FaceRecognitionDNet.FaceRecDotNet.InitFace(videoCapture, cameraModule, detectionTime, drawingTime);

               // picFace.SizeMode = PictureBoxSizeMode.StretchImage;
                if (FaceRecognitionDNet.FaceRecDotNet.resultImage != null)
                {
                    picFace.Image = FaceRecognitionDNet.FaceRecDotNet.resultImage;
                }

                watch.Stop();
                totalTime.Text = "Total time: " + watch.ElapsedMilliseconds.ToString() + " ms";
            }
            else
            {
                imageOpenCv = Helpers.GetFrame(_captureOpenCv, 1.0);
                picCapture.Image = imageOpenCv.ToBitmap();
            }
        }

        private void btnCenterFace_Click(object sender, EventArgs e)
        {
            if (!emguCvFlag && !faceRecognition)
            {
                switchParametersOptionsVisibility(false);

                _captureOpenCv = new VideoCapture(0);
                centerFace = true;

                Application.Idle += ProcessFrame;
            }
        }

        private void btnEmgu_Click(object sender, EventArgs e)
        {
            if (!centerFace && !faceRecognition)
            {
                switchParametersOptionsVisibility(true);

                _captureEmgu = new Emgu.CV.Capture();
                emguCvFlag = true;

                Application.Idle += ProcessFrame;
            }
        }

        private void btnFaceRecognition_Click(object sender, EventArgs e)
        {
            if (!centerFace && !emguCvFlag)
            {
                videoCapture = new VideoCapture(0); // '0' to default system camera device
                cameraModule = new CameraModule();

                switchParametersOptionsVisibility(false);
                faceRecognition = true;
                
                Application.Idle += ProcessFrame;
            }
                
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        public void switchParametersOptionsVisibility(bool visibility)
        {
            // Labels
            scaleFactorLbl.Visible = visibility;
            scaleFactor.Visible = visibility;

            // Inputs
            neighborsLbl.Visible = visibility;
            neighbors.Visible = visibility;
        }

        
    }
}
