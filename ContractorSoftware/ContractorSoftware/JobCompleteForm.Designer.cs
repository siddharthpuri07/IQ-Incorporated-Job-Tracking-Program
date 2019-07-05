namespace ContractorSoftware
{
    partial class JobCompleteForm
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
            this.DoneButton = new System.Windows.Forms.Button();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateCompletedPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.JobIDComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(340, 487);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(256, 216);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(250, 91);
            this.DescriptionBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount Charged";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(256, 183);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(250, 20);
            this.AmountBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Completed";
            // 
            // DateCompletedPicker
            // 
            this.DateCompletedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateCompletedPicker.Location = new System.Drawing.Point(256, 151);
            this.DateCompletedPicker.Name = "DateCompletedPicker";
            this.DateCompletedPicker.Size = new System.Drawing.Size(250, 20);
            this.DateCompletedPicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "JobID";
            // 
            // JobIDComboBox
            // 
            this.JobIDComboBox.FormattingEnabled = true;
            this.JobIDComboBox.Location = new System.Drawing.Point(256, 124);
            this.JobIDComboBox.Name = "JobIDComboBox";
            this.JobIDComboBox.Size = new System.Drawing.Size(249, 21);
            this.JobIDComboBox.TabIndex = 8;
            // 
            // JobCompleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 595);
            this.Controls.Add(this.JobIDComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateCompletedPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DoneButton);
            this.Name = "JobCompleteForm";
            this.Text = "JobCompleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateCompletedPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JobIDComboBox;
    }
}