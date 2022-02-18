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
using OpenCvSharp.Extensions;

namespace APIComparasion
{
    public partial class Form1 : Form
    {
        #region Variables
        private VideoCapture _capture = null;
        private bool centerFace = false;
        Mat image;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            _capture = new VideoCapture(0);
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (centerFace)
            {
                image = Helpers.GetFrame(_capture, 1.0);

                OpenCvSharp.Mat mat = CenterFaceDotNetAPI.DetectFaces(image, picFace.Width, picFace.Height);

                picCapture.Image = mat.ToBitmap();
                picFace.Image = CenterFaceDotNetAPI.smallImage;
            }
            else
            {
                image = Helpers.GetFrame(_capture, 1.0);
                picCapture.Image = image.ToBitmap();
            }
        }

        private void btnCenterFace_Click(object sender, EventArgs e)
        {
            centerFace = true;
        }
    }
}
