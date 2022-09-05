
namespace Labels__Textboxes_and_buttons
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
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.inputPasswordTextbox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.Location = new System.Drawing.Point(66, 250);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(536, 49);
            this.displayPasswordLabel.TabIndex = 0;
            this.displayPasswordLabel.Click += new System.EventHandler(this.displayPasswordLabel_Click);
            // 
            // inputPasswordTextbox
            // 
            this.inputPasswordTextbox.Location = new System.Drawing.Point(72, 127);
            this.inputPasswordTextbox.Name = "inputPasswordTextbox";
            this.inputPasswordTextbox.PasswordChar = '*';
            this.inputPasswordTextbox.Size = new System.Drawing.Size(598, 38);
            this.inputPasswordTextbox.TabIndex = 1;
            this.inputPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(245, 329);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(208, 69);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Me";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.inputPasswordTextbox);
            this.Controls.Add(this.displayPasswordLabel);
            this.Name = "Form1";
            this.Text = "Labels, Textboxes and buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.TextBox inputPasswordTextbox;
        private System.Windows.Forms.Button showButton;
    }
}

