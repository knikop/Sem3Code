
namespace HugeInteger
{
    partial class HugeIntegerCalculator
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
            this.firstNumTextBox = new System.Windows.Forms.TextBox();
            this.secondNumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.choices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // firstNumTextBox
            // 
            this.firstNumTextBox.Location = new System.Drawing.Point(43, 240);
            this.firstNumTextBox.MaxLength = 40;
            this.firstNumTextBox.Name = "firstNumTextBox";
            this.firstNumTextBox.Size = new System.Drawing.Size(607, 38);
            this.firstNumTextBox.TabIndex = 0;
            this.firstNumTextBox.TextChanged += new System.EventHandler(this.firstNum_TextChanged);
            // 
            // secondNumTextBox
            // 
            this.secondNumTextBox.Location = new System.Drawing.Point(43, 409);
            this.secondNumTextBox.MaxLength = 40;
            this.secondNumTextBox.Name = "secondNumTextBox";
            this.secondNumTextBox.Size = new System.Drawing.Size(607, 38);
            this.secondNumTextBox.TabIndex = 1;
            this.secondNumTextBox.TextChanged += new System.EventHandler(this.secondNum_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Huge Integer Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Second Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Answer: ";
            // 
            // answerLabel
            // 
            this.answerLabel.Location = new System.Drawing.Point(43, 595);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(607, 198);
            this.answerLabel.TabIndex = 13;
            this.answerLabel.Text = "ans";
            // 
            // choices
            // 
            this.choices.FormattingEnabled = true;
            this.choices.Items.AddRange(new object[] {
            "Mutiply",
            "Divide",
            "Remainder",
            "Add",
            "Substract",
            "IsZero",
            "IsEqualTo",
            "IsNotEqualTo",
            "IsGreaterThan",
            "IsLessThan",
            "IsGreaterThanOrEqualTo",
            "IsLessThanOrEqualTo"});
            this.choices.Location = new System.Drawing.Point(594, 324);
            this.choices.Name = "choices";
            this.choices.Size = new System.Drawing.Size(121, 39);
            this.choices.TabIndex = 14;
            this.choices.SelectedIndexChanged += new System.EventHandler(this.choices_SelectedIndexChanged);
            // 
            // HugeIntegerCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 816);
            this.Controls.Add(this.choices);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNumTextBox);
            this.Controls.Add(this.firstNumTextBox);
            this.Name = "HugeIntegerCalculator";
            this.Text = "Huge Integer Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumTextBox;
        private System.Windows.Forms.TextBox secondNumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.ComboBox choices;
    }
}

