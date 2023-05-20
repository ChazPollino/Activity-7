namespace Activity_7
{
    partial class Activity7
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.UserTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.TitleLabel.Location = new System.Drawing.Point(195, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(953, 100);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Convert Iterations Of Pi";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DescriptionLabel.Location = new System.Drawing.Point(28, 198);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(706, 75);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Enter Number Of Iterations";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTextbox
            // 
            this.UserTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.UserTextbox.Location = new System.Drawing.Point(866, 198);
            this.UserTextbox.Multiline = true;
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.Size = new System.Drawing.Size(351, 75);
            this.UserTextbox.TabIndex = 2;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CalculateButton.Location = new System.Drawing.Point(456, 328);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(408, 85);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate Pi";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.AnswerLabel.Location = new System.Drawing.Point(299, 467);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(703, 109);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ClearButton.Location = new System.Drawing.Point(43, 613);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(327, 132);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ExitButton.Location = new System.Drawing.Point(925, 627);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(327, 132);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Activity7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1374, 829);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "Activity7";
            this.Text = "Convert Iterations Of Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox UserTextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

