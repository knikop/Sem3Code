
namespace Groupboxes_and_Panels
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.byeButton = new System.Windows.Forms.Button();
            this.hiButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.byeButton);
            this.groupBox1.Controls.Add(this.hiButton);
            this.groupBox1.Location = new System.Drawing.Point(96, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main GroupBox";
            // 
            // byeButton
            // 
            this.byeButton.Location = new System.Drawing.Point(364, 37);
            this.byeButton.Name = "byeButton";
            this.byeButton.Size = new System.Drawing.Size(140, 40);
            this.byeButton.TabIndex = 2;
            this.byeButton.Text = "Bye";
            this.byeButton.UseVisualStyleBackColor = true;
            this.byeButton.Click += new System.EventHandler(this.byeButton_Click);
            this.byeButton.Enter += new System.EventHandler(this.byeButton_Click);
            // 
            // hiButton
            // 
            this.hiButton.Location = new System.Drawing.Point(38, 37);
            this.hiButton.Name = "hiButton";
            this.hiButton.Size = new System.Drawing.Size(146, 40);
            this.hiButton.TabIndex = 1;
            this.hiButton.Text = "Hi";
            this.hiButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.hiButton_Click);
            this.hiButton.Enter += new System.EventHandler(this.hiButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.rightButton);
            this.panel1.Controls.Add(this.leftButton);
            this.panel1.Location = new System.Drawing.Point(96, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 131);
            this.panel1.TabIndex = 1;
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(491, 13);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(159, 44);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Far Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            this.rightButton.Enter += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(23, 13);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(124, 44);
            this.leftButton.TabIndex = 2;
            this.leftButton.Text = "Far Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            this.leftButton.Enter += new System.EventHandler(this.leftButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(90, 352);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(544, 45);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "messageLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "GroupBoxPanelExample";

            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button hiButton;
        private System.Windows.Forms.Button byeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

