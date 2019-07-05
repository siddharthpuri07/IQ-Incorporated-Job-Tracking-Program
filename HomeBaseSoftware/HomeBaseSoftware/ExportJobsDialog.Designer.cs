namespace HomeBaseSoftware
{
    partial class ExportJobsDialog
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
            this.contractorBox = new System.Windows.Forms.ComboBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select a Contractor to Export Jobs for. ";
            // 
            // contractorBox
            // 
            this.contractorBox.FormattingEnabled = true;
            this.contractorBox.Location = new System.Drawing.Point(91, 98);
            this.contractorBox.Name = "contractorBox";
            this.contractorBox.Size = new System.Drawing.Size(215, 21);
            this.contractorBox.TabIndex = 1;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(153, 149);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Export As CSV";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ExportJobsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 267);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.contractorBox);
            this.Controls.Add(this.label1);
            this.Name = "ExportJobsDialog";
            this.Text = "ExportJobsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox contractorBox;
        private System.Windows.Forms.Button ExportButton;
    }
}