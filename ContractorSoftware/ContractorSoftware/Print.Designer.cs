namespace ContractorSoftware
{
    partial class Print
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ContLabel = new System.Windows.Forms.Label();
            this.DueLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVOICE NO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clients Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contractors Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Due:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Job Details:";
            // 
            // ContLabel
            // 
            this.ContLabel.AutoSize = true;
            this.ContLabel.Location = new System.Drawing.Point(331, 224);
            this.ContLabel.Name = "ContLabel";
            this.ContLabel.Size = new System.Drawing.Size(65, 13);
            this.ContLabel.TabIndex = 5;
            this.ContLabel.Text = "Contractor...";
            // 
            // DueLabel
            // 
            this.DueLabel.AutoSize = true;
            this.DueLabel.Location = new System.Drawing.Point(331, 254);
            this.DueLabel.Name = "DueLabel";
            this.DueLabel.Size = new System.Drawing.Size(34, 13);
            this.DueLabel.TabIndex = 6;
            this.DueLabel.Text = "$ 475";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(334, 126);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(69, 13);
            this.DetailsLabel.TabIndex = 7;
            this.DetailsLabel.Text = "Description...";
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(334, 91);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(42, 13);
            this.ClientLabel.TabIndex = 8;
            this.ClientLabel.Text = "Client...";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(106, 31);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(67, 13);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "0129384750";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 351);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.DueLabel);
            this.Controls.Add(this.ContLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Print";
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrintInvoice printInvoice1;
        private PrintInvoice PrintInvoice2;
        private PrintInvoice PrintInvoice3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ContLabel;
        private System.Windows.Forms.Label DueLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label NumberLabel;
    }
}