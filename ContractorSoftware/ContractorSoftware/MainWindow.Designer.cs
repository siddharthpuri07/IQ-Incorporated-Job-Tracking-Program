namespace ContractorSoftware
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.JobGridView = new System.Windows.Forms.DataGridView();
            this.iQIncDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImportButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.PrintInvoiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JobGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iQIncDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // JobGridView
            // 
            this.JobGridView.AllowUserToAddRows = false;
            this.JobGridView.AllowUserToDeleteRows = false;
            this.JobGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobGridView.Location = new System.Drawing.Point(12, 12);
            this.JobGridView.Name = "JobGridView";
            this.JobGridView.ReadOnly = true;
            this.JobGridView.Size = new System.Drawing.Size(744, 391);
            this.JobGridView.TabIndex = 0;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(781, 113);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(125, 23);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Location = new System.Drawing.Point(781, 153);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(125, 23);
            this.CompleteButton.TabIndex = 2;
            this.CompleteButton.Text = "Mark  Job As Complete";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(781, 194);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(125, 23);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "Export Jobs As CSV";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // PrintInvoiceButton
            // 
            this.PrintInvoiceButton.Location = new System.Drawing.Point(781, 235);
            this.PrintInvoiceButton.Name = "PrintInvoiceButton";
            this.PrintInvoiceButton.Size = new System.Drawing.Size(125, 23);
            this.PrintInvoiceButton.TabIndex = 4;
            this.PrintInvoiceButton.Text = "Print Invoice";
            this.PrintInvoiceButton.UseVisualStyleBackColor = true;
            this.PrintInvoiceButton.Click += new System.EventHandler(this.PrintInvoiceButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 423);
            this.Controls.Add(this.PrintInvoiceButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.JobGridView);
            this.Name = "MainWindow";
            this.Text = "IQIncorporated (Version: Contractor)";
            ((System.ComponentModel.ISupportInitialize)(this.JobGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iQIncDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView JobGridView;
        private System.Windows.Forms.BindingSource iQIncDataSetBindingSource;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button PrintInvoiceButton;
    }
}

