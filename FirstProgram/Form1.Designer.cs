namespace FirstProgram
{
    partial class IET
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
            this.spBox = new System.Windows.Forms.PictureBox();
            this.cpBox = new System.Windows.Forms.PictureBox();
            this.btnGrayScale = new System.Windows.Forms.Button();
            this.btnThreshold = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // spBox
            // 
            this.spBox.BackColor = System.Drawing.SystemColors.Control;
            this.spBox.Location = new System.Drawing.Point(32, 50);
            this.spBox.Name = "spBox";
            this.spBox.Size = new System.Drawing.Size(256, 301);
            this.spBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.spBox.TabIndex = 0;
            this.spBox.TabStop = false;
            // 
            // cpBox
            // 
            this.cpBox.Location = new System.Drawing.Point(693, 50);
            this.cpBox.Name = "cpBox";
            this.cpBox.Size = new System.Drawing.Size(256, 301);
            this.cpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cpBox.TabIndex = 1;
            this.cpBox.TabStop = false;
            // 
            // btnGrayScale
            // 
            this.btnGrayScale.Location = new System.Drawing.Point(405, 77);
            this.btnGrayScale.Name = "btnGrayScale";
            this.btnGrayScale.Size = new System.Drawing.Size(176, 38);
            this.btnGrayScale.TabIndex = 2;
            this.btnGrayScale.Text = "Gray Scale >>";
            this.btnGrayScale.UseVisualStyleBackColor = true;
            this.btnGrayScale.Click += new System.EventHandler(this.btnGrayScale_Click);
            // 
            // btnThreshold
            // 
            this.btnThreshold.Location = new System.Drawing.Point(405, 173);
            this.btnThreshold.Name = "btnThreshold";
            this.btnThreshold.Size = new System.Drawing.Size(176, 38);
            this.btnThreshold.TabIndex = 3;
            this.btnThreshold.Text = "Threshold >>";
            this.btnThreshold.UseVisualStyleBackColor = true;
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(405, 276);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(176, 38);
            this.btnNegative.TabIndex = 4;
            this.btnNegative.Text = "Negative >>";
            this.btnNegative.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(77, 399);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(176, 38);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // IET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 496);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnThreshold);
            this.Controls.Add(this.btnGrayScale);
            this.Controls.Add(this.cpBox);
            this.Controls.Add(this.spBox);
            this.Name = "IET";
            this.Text = "Image Enhancement Techniques";
            this.Load += new System.EventHandler(this.IET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox spBox;
        private System.Windows.Forms.PictureBox cpBox;
        private System.Windows.Forms.Button btnGrayScale;
        private System.Windows.Forms.Button btnThreshold;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnLoad;
    }
}

