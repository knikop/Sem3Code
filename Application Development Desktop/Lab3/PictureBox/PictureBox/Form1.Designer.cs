
namespace PictureBox
{
    partial class PictureBoxTest
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
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePictureBox.Image = global::PictureBox.Properties.Resources.image0;
            this.imagePictureBox.Location = new System.Drawing.Point(164, 87);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(547, 324);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(190, 28);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(201, 53);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next Image";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // PictureBoxTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.imagePictureBox);
            this.Name = "PictureBoxTest";
            this.Text = "PictureBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button nextButton;
    }
}

