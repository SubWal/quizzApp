namespace quizApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton optionRadioButton1;
        private System.Windows.Forms.RadioButton optionRadioButton2;
        private System.Windows.Forms.RadioButton optionRadioButton3;
        private System.Windows.Forms.RadioButton optionRadioButton4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label scoreLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.questionLabel = new System.Windows.Forms.Label();
            this.optionRadioButton1 = new System.Windows.Forms.RadioButton();
            this.optionRadioButton2 = new System.Windows.Forms.RadioButton();
            this.optionRadioButton3 = new System.Windows.Forms.RadioButton();
            this.optionRadioButton4 = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(12, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(73, 17);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            // 
            // optionRadioButton1
            // 
            this.optionRadioButton1.AutoSize = true;
            this.optionRadioButton1.Location = new System.Drawing.Point(15, 50);
            this.optionRadioButton1.Name = "optionRadioButton1";
            this.optionRadioButton1.Size = new System.Drawing.Size(75, 21);
            this.optionRadioButton1.TabIndex = 1;
            this.optionRadioButton1.TabStop = true;
            this.optionRadioButton1.Text = "Option1";
            this.optionRadioButton1.UseVisualStyleBackColor = true;
            // 
            // optionRadioButton2
            // 
            this.optionRadioButton2.AutoSize = true;
            this.optionRadioButton2.Location = new System.Drawing.Point(15, 77);
            this.optionRadioButton2.Name = "optionRadioButton2";
            this.optionRadioButton2.Size = new System.Drawing.Size(75, 21);
            this.optionRadioButton2.TabIndex = 2;
            this.optionRadioButton2.TabStop = true;
            this.optionRadioButton2.Text = "Option2";
            this.optionRadioButton2.UseVisualStyleBackColor = true;
            // 
            // optionRadioButton3
            // 
            this.optionRadioButton3.AutoSize = true;
            this.optionRadioButton3.Location = new System.Drawing.Point(15, 104);
            this.optionRadioButton3.Name = "optionRadioButton3";
            this.optionRadioButton3.Size = new System.Drawing.Size(75, 21);
            this.optionRadioButton3.TabIndex = 3;
            this.optionRadioButton3.TabStop = true;
            this.optionRadioButton3.Text = "Option3";
            this.optionRadioButton3.UseVisualStyleBackColor = true;
            // 
            // optionRadioButton4
            // 
            this.optionRadioButton4.AutoSize = true;
            this.optionRadioButton4.Location = new System.Drawing.Point(15, 131);
            this.optionRadioButton4.Name = "optionRadioButton4";
            this.optionRadioButton4.Size = new System.Drawing.Size(75, 21);
            this.optionRadioButton4.TabIndex = 4;
            this.optionRadioButton4.TabStop = true;
            this.optionRadioButton4.Text = "Option4";
            this.optionRadioButton4.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(15, 170);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(12, 210);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(49, 17);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.optionRadioButton4);
            this.Controls.Add(this.optionRadioButton3);
            this.Controls.Add(this.optionRadioButton2);
            this.Controls.Add(this.optionRadioButton1);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form1";
            this.Text = "Quiz App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
