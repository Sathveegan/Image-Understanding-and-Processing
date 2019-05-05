namespace FirstApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.pbOutput1 = new System.Windows.Forms.PictureBox();
            this.pbOutput2 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSlobel = new System.Windows.Forms.Button();
            this.btnLaplacian = new System.Windows.Forms.Button();
            this.btnLaplacianWithoutNoise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInput
            // 
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pbInput, "pbInput");
            this.pbInput.Name = "pbInput";
            this.pbInput.TabStop = false;
            // 
            // pbOutput1
            // 
            this.pbOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pbOutput1, "pbOutput1");
            this.pbOutput1.Name = "pbOutput1";
            this.pbOutput1.TabStop = false;
            // 
            // pbOutput2
            // 
            this.pbOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pbOutput2, "pbOutput2");
            this.pbOutput2.Name = "pbOutput2";
            this.pbOutput2.TabStop = false;
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSlobel
            // 
            resources.ApplyResources(this.btnSlobel, "btnSlobel");
            this.btnSlobel.Name = "btnSlobel";
            this.btnSlobel.UseVisualStyleBackColor = true;
            this.btnSlobel.Click += new System.EventHandler(this.btnSlobel_Click);
            // 
            // btnLaplacian
            // 
            resources.ApplyResources(this.btnLaplacian, "btnLaplacian");
            this.btnLaplacian.Name = "btnLaplacian";
            this.btnLaplacian.UseVisualStyleBackColor = true;
            this.btnLaplacian.Click += new System.EventHandler(this.btnLaplacian_Click);
            // 
            // btnLaplacianWithoutNoise
            // 
            resources.ApplyResources(this.btnLaplacianWithoutNoise, "btnLaplacianWithoutNoise");
            this.btnLaplacianWithoutNoise.Name = "btnLaplacianWithoutNoise";
            this.btnLaplacianWithoutNoise.UseVisualStyleBackColor = true;
            this.btnLaplacianWithoutNoise.Click += new System.EventHandler(this.btnLaplacianWithoutNoise_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLaplacianWithoutNoise);
            this.Controls.Add(this.btnLaplacian);
            this.Controls.Add(this.btnSlobel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbOutput2);
            this.Controls.Add(this.pbOutput1);
            this.Controls.Add(this.pbInput);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.PictureBox pbOutput1;
        private System.Windows.Forms.PictureBox pbOutput2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSlobel;
        private System.Windows.Forms.Button btnLaplacian;
        private System.Windows.Forms.Button btnLaplacianWithoutNoise;
    }
}