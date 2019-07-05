namespace HomeBaseSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.AddContractorBtn = new System.Windows.Forms.Button();
            this.AddJobBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.welcomePage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.IQIncorporatedTitle = new System.Windows.Forms.Label();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.contractorsPage = new System.Windows.Forms.TabPage();
            this.ContractorGridView = new System.Windows.Forms.DataGridView();
            this.jobsPage = new System.Windows.Forms.TabPage();
            this.UpdateJobsButton = new System.Windows.Forms.Button();
            this.ExportJobsBtn = new System.Windows.Forms.Button();
            this.JobGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.welcomePage.SuspendLayout();
            this.clientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            this.contractorsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractorGridView)).BeginInit();
            this.jobsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddClientBtn.Location = new System.Drawing.Point(1055, 140);
            this.AddClientBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(128, 28);
            this.AddClientBtn.TabIndex = 6;
            this.AddClientBtn.Text = "Add Client";
            this.AddClientBtn.UseVisualStyleBackColor = true;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // AddContractorBtn
            // 
            this.AddContractorBtn.Location = new System.Drawing.Point(1043, 145);
            this.AddContractorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddContractorBtn.Name = "AddContractorBtn";
            this.AddContractorBtn.Size = new System.Drawing.Size(128, 28);
            this.AddContractorBtn.TabIndex = 7;
            this.AddContractorBtn.Text = "Add Contractor";
            this.AddContractorBtn.UseVisualStyleBackColor = true;
            this.AddContractorBtn.Click += new System.EventHandler(this.AddContractorBtn_Click);
            // 
            // AddJobBtn
            // 
            this.AddJobBtn.Location = new System.Drawing.Point(1095, 95);
            this.AddJobBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddJobBtn.Name = "AddJobBtn";
            this.AddJobBtn.Size = new System.Drawing.Size(128, 28);
            this.AddJobBtn.TabIndex = 8;
            this.AddJobBtn.Text = "Add Job";
            this.AddJobBtn.UseVisualStyleBackColor = true;
            this.AddJobBtn.Click += new System.EventHandler(this.AddJobBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.welcomePage);
            this.tabControl.Controls.Add(this.clientsPage);
            this.tabControl.Controls.Add(this.contractorsPage);
            this.tabControl.Controls.Add(this.jobsPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1261, 521);
            this.tabControl.TabIndex = 9;
            // 
            // welcomePage
            // 
            this.welcomePage.Controls.Add(this.label1);
            this.welcomePage.Controls.Add(this.IQIncorporatedTitle);
            this.welcomePage.Location = new System.Drawing.Point(4, 25);
            this.welcomePage.Margin = new System.Windows.Forms.Padding(4);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Padding = new System.Windows.Forms.Padding(4);
            this.welcomePage.Size = new System.Drawing.Size(1253, 492);
            this.welcomePage.TabIndex = 3;
            this.welcomePage.Text = "Welcome";
            this.welcomePage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1109, 466);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version: Home Base";
            // 
            // IQIncorporatedTitle
            // 
            this.IQIncorporatedTitle.AutoSize = true;
            this.IQIncorporatedTitle.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQIncorporatedTitle.Location = new System.Drawing.Point(183, 149);
            this.IQIncorporatedTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IQIncorporatedTitle.Name = "IQIncorporatedTitle";
            this.IQIncorporatedTitle.Size = new System.Drawing.Size(816, 123);
            this.IQIncorporatedTitle.TabIndex = 0;
            this.IQIncorporatedTitle.Text = "IQIncorporated";
            this.IQIncorporatedTitle.Click += new System.EventHandler(this.IQIncorporatedTitle_Click);
            // 
            // clientsPage
            // 
            this.clientsPage.Controls.Add(this.ClientGridView);
            this.clientsPage.Controls.Add(this.AddClientBtn);
            this.clientsPage.Location = new System.Drawing.Point(4, 25);
            this.clientsPage.Margin = new System.Windows.Forms.Padding(4);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Padding = new System.Windows.Forms.Padding(4);
            this.clientsPage.Size = new System.Drawing.Size(1253, 492);
            this.clientsPage.TabIndex = 0;
            this.clientsPage.Text = "Clients";
            this.clientsPage.UseVisualStyleBackColor = true;
            // 
            // ClientGridView
            // 
            this.ClientGridView.AllowUserToAddRows = false;
            this.ClientGridView.AllowUserToDeleteRows = false;
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientGridView.Location = new System.Drawing.Point(4, 4);
            this.ClientGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.ReadOnly = true;
            this.ClientGridView.Size = new System.Drawing.Size(991, 484);
            this.ClientGridView.TabIndex = 1;
            // 
            // contractorsPage
            // 
            this.contractorsPage.Controls.Add(this.ContractorGridView);
            this.contractorsPage.Controls.Add(this.AddContractorBtn);
            this.contractorsPage.Location = new System.Drawing.Point(4, 25);
            this.contractorsPage.Margin = new System.Windows.Forms.Padding(4);
            this.contractorsPage.Name = "contractorsPage";
            this.contractorsPage.Padding = new System.Windows.Forms.Padding(4);
            this.contractorsPage.Size = new System.Drawing.Size(1253, 492);
            this.contractorsPage.TabIndex = 1;
            this.contractorsPage.Text = "Contractors";
            this.contractorsPage.UseVisualStyleBackColor = true;
            // 
            // ContractorGridView
            // 
            this.ContractorGridView.AllowUserToAddRows = false;
            this.ContractorGridView.AllowUserToDeleteRows = false;
            this.ContractorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractorGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContractorGridView.Location = new System.Drawing.Point(4, 4);
            this.ContractorGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ContractorGridView.Name = "ContractorGridView";
            this.ContractorGridView.ReadOnly = true;
            this.ContractorGridView.Size = new System.Drawing.Size(991, 484);
            this.ContractorGridView.TabIndex = 4;
            // 
            // jobsPage
            // 
            this.jobsPage.Controls.Add(this.UpdateJobsButton);
            this.jobsPage.Controls.Add(this.ExportJobsBtn);
            this.jobsPage.Controls.Add(this.JobGridView);
            this.jobsPage.Controls.Add(this.AddJobBtn);
            this.jobsPage.Location = new System.Drawing.Point(4, 25);
            this.jobsPage.Margin = new System.Windows.Forms.Padding(4);
            this.jobsPage.Name = "jobsPage";
            this.jobsPage.Padding = new System.Windows.Forms.Padding(4);
            this.jobsPage.Size = new System.Drawing.Size(1253, 492);
            this.jobsPage.TabIndex = 2;
            this.jobsPage.Text = "Jobs";
            this.jobsPage.UseVisualStyleBackColor = true;
            // 
            // UpdateJobsButton
            // 
            this.UpdateJobsButton.Location = new System.Drawing.Point(1095, 266);
            this.UpdateJobsButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateJobsButton.Name = "UpdateJobsButton";
            this.UpdateJobsButton.Size = new System.Drawing.Size(128, 28);
            this.UpdateJobsButton.TabIndex = 10;
            this.UpdateJobsButton.Text = "Update Jobs";
            this.UpdateJobsButton.UseVisualStyleBackColor = true;
            this.UpdateJobsButton.Click += new System.EventHandler(this.UpdateJobsButton_Click);
            // 
            // ExportJobsBtn
            // 
            this.ExportJobsBtn.Location = new System.Drawing.Point(1095, 181);
            this.ExportJobsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExportJobsBtn.Name = "ExportJobsBtn";
            this.ExportJobsBtn.Size = new System.Drawing.Size(128, 28);
            this.ExportJobsBtn.TabIndex = 9;
            this.ExportJobsBtn.Text = "Export Jobs";
            this.ExportJobsBtn.UseVisualStyleBackColor = true;
            this.ExportJobsBtn.Click += new System.EventHandler(this.ExportJobsBtn_Click);
            // 
            // JobGridView
            // 
            this.JobGridView.AllowUserToAddRows = false;
            this.JobGridView.AllowUserToDeleteRows = false;
            this.JobGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.JobGridView.Location = new System.Drawing.Point(4, 4);
            this.JobGridView.Margin = new System.Windows.Forms.Padding(4);
            this.JobGridView.Name = "JobGridView";
            this.JobGridView.ReadOnly = true;
            this.JobGridView.Size = new System.Drawing.Size(1065, 484);
            this.JobGridView.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1253, 492);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "AboutUs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(943, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(314, 457);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(651, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(294, 492);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 492);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(943, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(310, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 521);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "IQIncorporated (Version: Home Base)";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.welcomePage.ResumeLayout(false);
            this.welcomePage.PerformLayout();
            this.clientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            this.contractorsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContractorGridView)).EndInit();
            this.jobsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JobGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddClientBtn;
        private System.Windows.Forms.Button AddContractorBtn;
        private System.Windows.Forms.Button AddJobBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage clientsPage;
        private System.Windows.Forms.DataGridView ClientGridView;
        private System.Windows.Forms.TabPage contractorsPage;
        private System.Windows.Forms.DataGridView ContractorGridView;
        private System.Windows.Forms.TabPage jobsPage;
        private System.Windows.Forms.DataGridView JobGridView;
        private System.Windows.Forms.TabPage welcomePage;
        private System.Windows.Forms.Label IQIncorporatedTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportJobsBtn;
        private System.Windows.Forms.Button UpdateJobsButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}