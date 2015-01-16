using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FovChanger
{
    public partial class FOVCalculator : Form
    {
        System.Text.Encoding enc = System.Text.Encoding.UTF8;

        int ResWidth = 1024;
        int ResHeight = 768;
        double VerticalRadians = 0;
        double HorizontalRadians = 0;
        double VerticalFOV = 0;
        double HorizontalFOV = 0;

        public FOVCalculator()
        {
            InitializeComponent();
        }

        public double ConvertToDegrees(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        private double ConvertToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_SetResolution_Click(object sender, EventArgs e)
        {
            var res1 = 0;
            var res2 = 0;
            if (int.TryParse(TBResolutionWidth.Text, out res1))
            {
                ResWidth = res1;
            }
            if (int.TryParse(TBResolutionHeight.Text, out res2))
            {
                ResHeight= res2;
            }
        }

        private void BRadiansToDegrees_Click(object sender, EventArgs e)
        {
            var res = 0d;
            if (double.TryParse(TB_VerticalRadians.Text, out res))
            {
                VerticalRadians = res;
            }

            // VerticalRadians to Vertical FOV
            VerticalFOV = ConvertToDegrees(VerticalRadians);
            TB_VerticalFOV.Text = VerticalFOV.ToString();

            //Vertical Radians to Horizontal Radians to Horizontal FOV
            HorizontalRadians = 2 * Math.Atan(Math.Tan(VerticalRadians / 2) * (ResWidth * 1.0 / ResHeight * 1.0));
            TB_HorizontalRadians.Text = HorizontalRadians.ToString();

            //Horizontal Radians to Horizontal FOV
            HorizontalFOV = ConvertToDegrees(HorizontalRadians);
            TB_HorizontalFOV.Text = HorizontalFOV.ToString();
        }

        private void BVerticalFOVtoRadians_Click(object sender, EventArgs e)
        {
            var res = 0d;
            if (double.TryParse(TB_VerticalFOV.Text, out res))
            {
                VerticalFOV = res;
            }

            // VerticalFOV to Vertical Radians
            VerticalRadians = ConvertToRadians(VerticalFOV);
            TB_VerticalRadians.Text = VerticalRadians.ToString();

            // Vertical FOV to Horizontal FOV
            HorizontalRadians = 2 * Math.Atan(Math.Tan(VerticalRadians / 2) * (ResWidth * 1.0 / ResHeight * 1.0));
            TB_HorizontalRadians.Text = HorizontalRadians.ToString();

            // Horizontal radians to horizontal FOV
            HorizontalFOV = ConvertToDegrees(HorizontalRadians);
            TB_HorizontalFOV.Text = HorizontalFOV.ToString();
        }

        private void BHorizontalFOVtoRadians_Click(object sender, EventArgs e)
        {
            var res = 0d;
            if (double.TryParse(TB_HorizontalFOV.Text, out res))
            {
                HorizontalFOV = res;
            }

            // Horizontal FOV to Horizontal Radians
            HorizontalRadians = ConvertToRadians(HorizontalFOV);
            TB_HorizontalRadians.Text = HorizontalRadians.ToString();

            // Horizontal Radians to Vertical Radians
            VerticalRadians = 2 * Math.Atan(Math.Tan(HorizontalRadians / 2) * (ResHeight * 1.0 / ResWidth * 1.0));
            TB_VerticalRadians.Text = VerticalRadians.ToString();

            // Vertical Radians to Vertical FOV
            VerticalFOV = ConvertToDegrees(VerticalRadians);
            TB_VerticalFOV.Text = VerticalFOV.ToString();
        }

        private void B_HorizontalRadiansToDegrees_Click(object sender, EventArgs e)
        {
            var res = 0d;
            if (double.TryParse(TB_HorizontalRadians.Text, out res))
            {
                HorizontalRadians = res;
            }
           
            
            // Horizontal radians to horizontal FOV
            HorizontalFOV = ConvertToDegrees(HorizontalRadians);
            TB_HorizontalFOV.Text = HorizontalFOV.ToString();

            // Horizontal Radians to Vertical Radians
            VerticalRadians = 2 * Math.Atan(Math.Tan(HorizontalRadians / 2) * (ResHeight * 1.0 / ResWidth * 1.0));
            TB_VerticalRadians.Text = VerticalRadians.ToString();

            // Vertical Radians to Vertical FOV
            VerticalFOV = ConvertToDegrees(VerticalRadians);
            TB_VerticalFOV.Text = VerticalFOV.ToString();

        }

    }
}
