
namespace NumericUpDown
{
    partial class NumericUpDownTest
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
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.display = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(214, 66);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(321, 38);
            this.principalTextBox.TabIndex = 0;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(214, 127);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(321, 38);
            this.interestTextBox.TabIndex = 1;
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(214, 186);
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(321, 38);
            this.yearUpDown.TabIndex = 2;
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(602, 66);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(173, 38);
            this.display.TabIndex = 3;
            this.display.Text = "Calculate";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Principal:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Interest Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Years";
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(58, 252);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(663, 173);
            this.displayTextBox.TabIndex = 7;
            // 
            // NumericUpDownTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.principalTextBox);
            this.Name = "NumericUpDownTest";
            this.Text = "Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox displayTextBox;
    }
}

