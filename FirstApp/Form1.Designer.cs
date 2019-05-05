namespace FirstApp
{
    partial class Form1
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
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbDes = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGrayScale = new System.Windows.Forms.Button();
            this.btnThresHold = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnExtractData = new System.Windows.Forms.Button();
            this.btnGreyLevelSlicing = new System.Windows.Forms.Button();
            this.btnLogTransformation = new System.Windows.Forms.Button();
            this.btnPowerLawTransformation = new System.Windows.Forms.Button();
            this.tBGamma = new System.Windows.Forms.TrackBar();
            this.btnGNegative = new System.Windows.Forms.Button();
            this.btnArithmeticMean = new System.Windows.Forms.Button();
            this.btnGeometricMean = new System.Windows.Forms.Button();
            this.btnHarmonicMean = new System.Windows.Forms.Button();
            this.btnContraHarmonicMean = new System.Windows.Forms.Button();
            this.btnMedianFilter = new System.Windows.Forms.Button();
            this.btnMaxFilter = new System.Windows.Forms.Button();
            this.btnMinFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSource
            // 
            this.pbSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSource.Location = new System.Drawing.Point(18, 18);
            this.pbSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(475, 462);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSource.TabIndex = 0;
            this.pbSource.TabStop = false;
            // 
            // pbDes
            // 
            this.pbDes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDes.Location = new System.Drawing.Point(747, 18);
            this.pbDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDes.Name = "pbDes";
            this.pbDes.Size = new System.Drawing.Size(475, 462);
            this.pbDes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDes.TabIndex = 1;
            this.pbDes.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(142, 566);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(192, 35);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGrayScale
            // 
            this.btnGrayScale.Location = new System.Drawing.Point(536, 51);
            this.btnGrayScale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGrayScale.Name = "btnGrayScale";
            this.btnGrayScale.Size = new System.Drawing.Size(171, 40);
            this.btnGrayScale.TabIndex = 3;
            this.btnGrayScale.Text = "Gray Scale";
            this.btnGrayScale.UseVisualStyleBackColor = true;
            this.btnGrayScale.Click += new System.EventHandler(this.btnGrayScale_Click);
            // 
            // btnThresHold
            // 
            this.btnThresHold.Location = new System.Drawing.Point(536, 134);
            this.btnThresHold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThresHold.Name = "btnThresHold";
            this.btnThresHold.Size = new System.Drawing.Size(171, 40);
            this.btnThresHold.TabIndex = 4;
            this.btnThresHold.Text = "Threshold";
            this.btnThresHold.UseVisualStyleBackColor = true;
            this.btnThresHold.Click += new System.EventHandler(this.btnThresHold_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(536, 218);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(171, 40);
            this.btnNegative.TabIndex = 5;
            this.btnNegative.Text = "Negative For Color";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnExtractData
            // 
            this.btnExtractData.Location = new System.Drawing.Point(536, 371);
            this.btnExtractData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(171, 40);
            this.btnExtractData.TabIndex = 6;
            this.btnExtractData.Text = "Extract Data";
            this.btnExtractData.UseVisualStyleBackColor = true;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
            // 
            // btnGreyLevelSlicing
            // 
            this.btnGreyLevelSlicing.Location = new System.Drawing.Point(536, 454);
            this.btnGreyLevelSlicing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGreyLevelSlicing.Name = "btnGreyLevelSlicing";
            this.btnGreyLevelSlicing.Size = new System.Drawing.Size(171, 40);
            this.btnGreyLevelSlicing.TabIndex = 7;
            this.btnGreyLevelSlicing.Text = "Grey Level Slicing";
            this.btnGreyLevelSlicing.UseVisualStyleBackColor = true;
            this.btnGreyLevelSlicing.Click += new System.EventHandler(this.btnGreyLevelSlicing_Click);
            // 
            // btnLogTransformation
            // 
            this.btnLogTransformation.Location = new System.Drawing.Point(536, 537);
            this.btnLogTransformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogTransformation.Name = "btnLogTransformation";
            this.btnLogTransformation.Size = new System.Drawing.Size(171, 40);
            this.btnLogTransformation.TabIndex = 8;
            this.btnLogTransformation.Text = "log Transformation";
            this.btnLogTransformation.UseVisualStyleBackColor = true;
            this.btnLogTransformation.Click += new System.EventHandler(this.btnLogTransformation_Click);
            // 
            // btnPowerLawTransformation
            // 
            this.btnPowerLawTransformation.Location = new System.Drawing.Point(514, 666);
            this.btnPowerLawTransformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPowerLawTransformation.Name = "btnPowerLawTransformation";
            this.btnPowerLawTransformation.Size = new System.Drawing.Size(210, 40);
            this.btnPowerLawTransformation.TabIndex = 9;
            this.btnPowerLawTransformation.Text = "Power Law transformation";
            this.btnPowerLawTransformation.UseVisualStyleBackColor = true;
            this.btnPowerLawTransformation.Click += new System.EventHandler(this.btnPowerLawTransformation_Click);
            // 
            // tBGamma
            // 
            this.tBGamma.Location = new System.Drawing.Point(474, 598);
            this.tBGamma.Minimum = -10;
            this.tBGamma.Name = "tBGamma";
            this.tBGamma.Size = new System.Drawing.Size(300, 69);
            this.tBGamma.TabIndex = 10;
            // 
            // btnGNegative
            // 
            this.btnGNegative.Location = new System.Drawing.Point(536, 295);
            this.btnGNegative.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGNegative.Name = "btnGNegative";
            this.btnGNegative.Size = new System.Drawing.Size(171, 40);
            this.btnGNegative.TabIndex = 11;
            this.btnGNegative.Text = "Negative For Grey";
            this.btnGNegative.UseVisualStyleBackColor = true;
            this.btnGNegative.Click += new System.EventHandler(this.btnGNegative_Click);
            // 
            // btnArithmeticMean
            // 
            this.btnArithmeticMean.Location = new System.Drawing.Point(818, 514);
            this.btnArithmeticMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArithmeticMean.Name = "btnArithmeticMean";
            this.btnArithmeticMean.Size = new System.Drawing.Size(144, 40);
            this.btnArithmeticMean.TabIndex = 12;
            this.btnArithmeticMean.Text = "Arithmetic Mean";
            this.btnArithmeticMean.UseVisualStyleBackColor = true;
            this.btnArithmeticMean.Click += new System.EventHandler(this.btnArithmeticMean_Click);
            // 
            // btnGeometricMean
            // 
            this.btnGeometricMean.Location = new System.Drawing.Point(1050, 514);
            this.btnGeometricMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeometricMean.Name = "btnGeometricMean";
            this.btnGeometricMean.Size = new System.Drawing.Size(144, 40);
            this.btnGeometricMean.TabIndex = 13;
            this.btnGeometricMean.Text = "Geometric Mean";
            this.btnGeometricMean.UseVisualStyleBackColor = true;
            this.btnGeometricMean.Click += new System.EventHandler(this.btnGeometricMean_Click);
            // 
            // btnHarmonicMean
            // 
            this.btnHarmonicMean.Location = new System.Drawing.Point(818, 566);
            this.btnHarmonicMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHarmonicMean.Name = "btnHarmonicMean";
            this.btnHarmonicMean.Size = new System.Drawing.Size(144, 58);
            this.btnHarmonicMean.TabIndex = 14;
            this.btnHarmonicMean.Text = "Harmonic Mean";
            this.btnHarmonicMean.UseVisualStyleBackColor = true;
            this.btnHarmonicMean.Click += new System.EventHandler(this.btnHarmonicMean_Click);
            // 
            // btnContraHarmonicMean
            // 
            this.btnContraHarmonicMean.Location = new System.Drawing.Point(1050, 566);
            this.btnContraHarmonicMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContraHarmonicMean.Name = "btnContraHarmonicMean";
            this.btnContraHarmonicMean.Size = new System.Drawing.Size(144, 58);
            this.btnContraHarmonicMean.TabIndex = 15;
            this.btnContraHarmonicMean.Text = "Contra Harmonic Mean";
            this.btnContraHarmonicMean.UseVisualStyleBackColor = true;
            this.btnContraHarmonicMean.Click += new System.EventHandler(this.btnContraHarmonicMean_Click);
            // 
            // btnMedianFilter
            // 
            this.btnMedianFilter.Location = new System.Drawing.Point(818, 647);
            this.btnMedianFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMedianFilter.Name = "btnMedianFilter";
            this.btnMedianFilter.Size = new System.Drawing.Size(144, 40);
            this.btnMedianFilter.TabIndex = 16;
            this.btnMedianFilter.Text = "Median";
            this.btnMedianFilter.UseVisualStyleBackColor = true;
            this.btnMedianFilter.Click += new System.EventHandler(this.btnMedianFilter_Click);
            // 
            // btnMaxFilter
            // 
            this.btnMaxFilter.Location = new System.Drawing.Point(1050, 647);
            this.btnMaxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaxFilter.Name = "btnMaxFilter";
            this.btnMaxFilter.Size = new System.Drawing.Size(144, 40);
            this.btnMaxFilter.TabIndex = 17;
            this.btnMaxFilter.Text = "Max";
            this.btnMaxFilter.UseVisualStyleBackColor = true;
            this.btnMaxFilter.Click += new System.EventHandler(this.btnMaxFilter_Click);
            // 
            // btnMinFilter
            // 
            this.btnMinFilter.Location = new System.Drawing.Point(941, 697);
            this.btnMinFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinFilter.Name = "btnMinFilter";
            this.btnMinFilter.Size = new System.Drawing.Size(144, 40);
            this.btnMinFilter.TabIndex = 18;
            this.btnMinFilter.Text = "Min";
            this.btnMinFilter.UseVisualStyleBackColor = true;
            this.btnMinFilter.Click += new System.EventHandler(this.btnMinFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 780);
            this.Controls.Add(this.btnMinFilter);
            this.Controls.Add(this.btnMaxFilter);
            this.Controls.Add(this.btnMedianFilter);
            this.Controls.Add(this.btnContraHarmonicMean);
            this.Controls.Add(this.btnHarmonicMean);
            this.Controls.Add(this.btnGeometricMean);
            this.Controls.Add(this.btnArithmeticMean);
            this.Controls.Add(this.btnGNegative);
            this.Controls.Add(this.tBGamma);
            this.Controls.Add(this.btnPowerLawTransformation);
            this.Controls.Add(this.btnLogTransformation);
            this.Controls.Add(this.btnGreyLevelSlicing);
            this.Controls.Add(this.btnExtractData);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnThresHold);
            this.Controls.Add(this.btnGrayScale);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbDes);
            this.Controls.Add(this.pbSource);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbDes;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGrayScale;
        private System.Windows.Forms.Button btnThresHold;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnExtractData;
        private System.Windows.Forms.Button btnGreyLevelSlicing;
        private System.Windows.Forms.Button btnLogTransformation;
        private System.Windows.Forms.Button btnPowerLawTransformation;
        private System.Windows.Forms.TrackBar tBGamma;
        private System.Windows.Forms.Button btnGNegative;
        private System.Windows.Forms.Button btnArithmeticMean;
        private System.Windows.Forms.Button btnGeometricMean;
        private System.Windows.Forms.Button btnHarmonicMean;
        private System.Windows.Forms.Button btnContraHarmonicMean;
        private System.Windows.Forms.Button btnMedianFilter;
        private System.Windows.Forms.Button btnMaxFilter;
        private System.Windows.Forms.Button btnMinFilter;
    }
}

