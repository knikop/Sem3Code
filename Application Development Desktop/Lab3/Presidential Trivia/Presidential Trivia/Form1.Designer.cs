
namespace Presidential_Trivia
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
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(256, 355);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(263, 54);
            this.showAnswerButton.TabIndex = 0;
            this.showAnswerButton.Text = "Show the Answer";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(269, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 142);
            this.label1.TabIndex = 1;
            this.label1.Text = "Whar former U.S. President is known for going on an African safari?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Location = new System.Drawing.Point(256, 211);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(315, 75);
            this.answerLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAnswerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showAnswerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label answerLabel;
    }
}

