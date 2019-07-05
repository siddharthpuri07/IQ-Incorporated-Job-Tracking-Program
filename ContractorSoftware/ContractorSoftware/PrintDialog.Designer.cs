namespace ContractorSoftware
{
    partial class PrintDialog
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
            this.printBtn = new System.Windows.Forms.Button();
            this.contractorBox = new System.Windows.Forms.ComboBox();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractorDBDataSet = new ContractorSoftware.ContractorDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.jobsTableAdapter = new ContractorSoftware.ContractorDBDataSetTableAdapters.JobsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(102, 117);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 5;
            this.printBtn.Text = "Print ";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // contractorBox
            // 
            this.contractorBox.DataSource = this.jobsBindingSource;
            this.contractorBox.DisplayMember = "Client";
            this.contractorBox.FormattingEnabled = true;
            this.contractorBox.Location = new System.Drawing.Point(40, 66);
            this.contractorBox.Name = "contractorBox";
            this.contractorBox.Size = new System.Drawing.Size(215, 21);
            this.contractorBox.TabIndex = 4;
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "Jobs";
            this.jobsBindingSource.DataSource = this.contractorDBDataSet;
            // 
            // contractorDBDataSet
            // 
            this.contractorDBDataSet.DataSetName = "ContractorDBDataSet";
            this.contractorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Select the Customer Data to print";
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // PrintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 184);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.contractorBox);
            this.Controls.Add(this.label1);
            this.Name = "PrintDialog";
            this.Text = "PrintDialog";
            this.Load += new System.EventHandler(this.PrintDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.ComboBox contractorBox;
        private System.Windows.Forms.Label label1;
        private ContractorDBDataSet contractorDBDataSet;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private ContractorDBDataSetTableAdapters.JobsTableAdapter jobsTableAdapter;
    }
}