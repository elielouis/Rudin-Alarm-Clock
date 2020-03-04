namespace Rudin
{
    partial class QuestionsForm
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
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.labelCaptchaName = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Enabled = false;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(42, 79);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(635, 56);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // labelCaptchaName
            // 
            this.labelCaptchaName.AutoSize = true;
            this.labelCaptchaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelCaptchaName.ForeColor = System.Drawing.Color.Red;
            this.labelCaptchaName.Location = new System.Drawing.Point(228, 18);
            this.labelCaptchaName.Name = "labelCaptchaName";
            this.labelCaptchaName.Size = new System.Drawing.Size(235, 39);
            this.labelCaptchaName.TabIndex = 1;
            this.labelCaptchaName.Text = "CaptchaName";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(249, 229);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(203, 53);
            this.buttonAnswer.TabIndex = 3;
            this.buttonAnswer.Text = "Answer";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(42, 166);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(635, 22);
            this.textBoxAnswer.TabIndex = 4;
            this.textBoxAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswer_KeyDown);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 294);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.labelCaptchaName);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Name = "QuestionsForm";
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.Label labelCaptchaName;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
    }
}