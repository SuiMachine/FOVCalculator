namespace FovChanger
{
    partial class FOVCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOVCalculator));
            this.TB_VerticalRadians = new System.Windows.Forms.TextBox();
            this.TB_VerticalFOV = new System.Windows.Forms.TextBox();
            this.TB_HorizontalFOV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_HorizontalRadiansToDegrees = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_HorizontalRadians = new System.Windows.Forms.TextBox();
            this.BHorizontalFOVtoRadians = new System.Windows.Forms.Button();
            this.BVerticalFOVtoRadians = new System.Windows.Forms.Button();
            this.BVerticalRadiansToDegrees = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.B_SetResolution = new System.Windows.Forms.Button();
            this.TBResolutionHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBResolutionWidth = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_VerticalRadians
            // 
            this.TB_VerticalRadians.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_VerticalRadians.Location = new System.Drawing.Point(113, 9);
            this.TB_VerticalRadians.Name = "TB_VerticalRadians";
            this.TB_VerticalRadians.Size = new System.Drawing.Size(116, 20);
            this.TB_VerticalRadians.TabIndex = 0;
            this.TB_VerticalRadians.Text = "0";
            this.TB_VerticalRadians.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_VerticalFOV
            // 
            this.TB_VerticalFOV.Location = new System.Drawing.Point(113, 58);
            this.TB_VerticalFOV.Name = "TB_VerticalFOV";
            this.TB_VerticalFOV.Size = new System.Drawing.Size(116, 20);
            this.TB_VerticalFOV.TabIndex = 1;
            this.TB_VerticalFOV.Text = "0";
            this.TB_VerticalFOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_HorizontalFOV
            // 
            this.TB_HorizontalFOV.Location = new System.Drawing.Point(113, 81);
            this.TB_HorizontalFOV.Name = "TB_HorizontalFOV";
            this.TB_HorizontalFOV.Size = new System.Drawing.Size(116, 20);
            this.TB_HorizontalFOV.TabIndex = 2;
            this.TB_HorizontalFOV.Text = "0";
            this.TB_HorizontalFOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vertical Radians";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vertical FOV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horizontal FOV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_HorizontalRadiansToDegrees);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TB_HorizontalRadians);
            this.panel1.Controls.Add(this.BHorizontalFOVtoRadians);
            this.panel1.Controls.Add(this.BVerticalFOVtoRadians);
            this.panel1.Controls.Add(this.BVerticalRadiansToDegrees);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_HorizontalFOV);
            this.panel1.Controls.Add(this.TB_VerticalFOV);
            this.panel1.Controls.Add(this.TB_VerticalRadians);
            this.panel1.Location = new System.Drawing.Point(4, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 112);
            this.panel1.TabIndex = 6;
            // 
            // B_HorizontalRadiansToDegrees
            // 
            this.B_HorizontalRadiansToDegrees.Location = new System.Drawing.Point(235, 31);
            this.B_HorizontalRadiansToDegrees.Name = "B_HorizontalRadiansToDegrees";
            this.B_HorizontalRadiansToDegrees.Size = new System.Drawing.Size(75, 23);
            this.B_HorizontalRadiansToDegrees.TabIndex = 11;
            this.B_HorizontalRadiansToDegrees.Text = "-> Degrees";
            this.B_HorizontalRadiansToDegrees.UseVisualStyleBackColor = true;
            this.B_HorizontalRadiansToDegrees.Click += new System.EventHandler(this.B_HorizontalRadiansToDegrees_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Horizontal Radians";
            // 
            // TB_HorizontalRadians
            // 
            this.TB_HorizontalRadians.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_HorizontalRadians.Location = new System.Drawing.Point(113, 33);
            this.TB_HorizontalRadians.Name = "TB_HorizontalRadians";
            this.TB_HorizontalRadians.Size = new System.Drawing.Size(116, 20);
            this.TB_HorizontalRadians.TabIndex = 9;
            this.TB_HorizontalRadians.Text = "0";
            this.TB_HorizontalRadians.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BHorizontalFOVtoRadians
            // 
            this.BHorizontalFOVtoRadians.Location = new System.Drawing.Point(235, 79);
            this.BHorizontalFOVtoRadians.Name = "BHorizontalFOVtoRadians";
            this.BHorizontalFOVtoRadians.Size = new System.Drawing.Size(75, 23);
            this.BHorizontalFOVtoRadians.TabIndex = 8;
            this.BHorizontalFOVtoRadians.Text = "-> Radians";
            this.BHorizontalFOVtoRadians.UseVisualStyleBackColor = true;
            this.BHorizontalFOVtoRadians.Click += new System.EventHandler(this.BHorizontalFOVtoRadians_Click);
            // 
            // BVerticalFOVtoRadians
            // 
            this.BVerticalFOVtoRadians.Location = new System.Drawing.Point(235, 56);
            this.BVerticalFOVtoRadians.Name = "BVerticalFOVtoRadians";
            this.BVerticalFOVtoRadians.Size = new System.Drawing.Size(75, 23);
            this.BVerticalFOVtoRadians.TabIndex = 7;
            this.BVerticalFOVtoRadians.Text = "-> Radians";
            this.BVerticalFOVtoRadians.UseVisualStyleBackColor = true;
            this.BVerticalFOVtoRadians.Click += new System.EventHandler(this.BVerticalFOVtoRadians_Click);
            // 
            // BVerticalRadiansToDegrees
            // 
            this.BVerticalRadiansToDegrees.Location = new System.Drawing.Point(235, 7);
            this.BVerticalRadiansToDegrees.Name = "BVerticalRadiansToDegrees";
            this.BVerticalRadiansToDegrees.Size = new System.Drawing.Size(75, 23);
            this.BVerticalRadiansToDegrees.TabIndex = 6;
            this.BVerticalRadiansToDegrees.Text = "-> Degrees";
            this.BVerticalRadiansToDegrees.UseVisualStyleBackColor = true;
            this.BVerticalRadiansToDegrees.Click += new System.EventHandler(this.BRadiansToDegrees_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(101, 8);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(91, 23);
            this.BClose.TabIndex = 9;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BClose);
            this.panel2.Location = new System.Drawing.Point(4, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 41);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.B_SetResolution);
            this.panel3.Controls.Add(this.TBResolutionHeight);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TBResolutionWidth);
            this.panel3.Location = new System.Drawing.Point(4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 44);
            this.panel3.TabIndex = 11;
            // 
            // B_SetResolution
            // 
            this.B_SetResolution.Location = new System.Drawing.Point(264, 10);
            this.B_SetResolution.Name = "B_SetResolution";
            this.B_SetResolution.Size = new System.Drawing.Size(46, 23);
            this.B_SetResolution.TabIndex = 9;
            this.B_SetResolution.Text = "Set";
            this.B_SetResolution.UseVisualStyleBackColor = true;
            this.B_SetResolution.Click += new System.EventHandler(this.B_SetResolution_Click);
            // 
            // TBResolutionHeight
            // 
            this.TBResolutionHeight.Location = new System.Drawing.Point(184, 11);
            this.TBResolutionHeight.Name = "TBResolutionHeight";
            this.TBResolutionHeight.Size = new System.Drawing.Size(74, 20);
            this.TBResolutionHeight.TabIndex = 3;
            this.TBResolutionHeight.Text = "768";
            this.TBResolutionHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Resolution:";
            // 
            // TBResolutionWidth
            // 
            this.TBResolutionWidth.Location = new System.Drawing.Point(84, 10);
            this.TBResolutionWidth.Name = "TBResolutionWidth";
            this.TBResolutionWidth.Size = new System.Drawing.Size(74, 20);
            this.TBResolutionWidth.TabIndex = 0;
            this.TBResolutionWidth.Text = "1024";
            this.TBResolutionWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FOVCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 221);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FOVCalculator";
            this.Text = "FOVCalculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_VerticalRadians;
        private System.Windows.Forms.TextBox TB_VerticalFOV;
        private System.Windows.Forms.TextBox TB_HorizontalFOV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BVerticalFOVtoRadians;
        private System.Windows.Forms.Button BVerticalRadiansToDegrees;
        private System.Windows.Forms.Button BHorizontalFOVtoRadians;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TBResolutionHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBResolutionWidth;
        private System.Windows.Forms.Button B_SetResolution;
        private System.Windows.Forms.Button B_HorizontalRadiansToDegrees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_HorizontalRadians;

    }
}