using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Data.Common;

namespace HomeBaseSoftware
{
    public partial class MainWindow : Form
    {
        string connectionString;
        SqlConnection connection;

        public MainWindow()
        {
            InitializeComponent();

            // get connection string from App.config file and connect it
            connectionString = ConfigurationManager.ConnectionStrings["IQIncorporated.Properties.Settings.IQIncConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            PopulateGridViews();
        }

        private void PopulateGridViews()
        {
            connection.Open();

            // Populate Client GridView
            SqlDataAdapter clientAdapter = new SqlDataAdapter("SELECT * FROM Client", connection);
            DataTable clientTable = new DataTable();
            clientAdapter.Fill(clientTable);
            ClientGridView.DataSource = clientTable;

            // Populate Contractor GridView
            SqlDataAdapter contractorAdapter = new SqlDataAdapter("SELECT * FROM Contractor", connection);
            DataTable contractorTable = new DataTable();
            contractorAdapter.Fill(contractorTable);
            ContractorGridView.DataSource = contractorTable;

            // Populate Job GridView
            SqlDataAdapter jobAdapter = new SqlDataAdapter("SELECT * FROM Job", connection);
            DataTable jobTable = new DataTable();
            jobAdapter.Fill(jobTable);
            JobGridView.DataSource = jobTable; 

            connection.Close();
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            ClientAddition newClientForm = new ClientAddition();
            newClientForm.ShowDialog();

            PopulateGridViews();
        }

        private void AddContractorBtn_Click(object sender, EventArgs e)
        {
            ContractorAddition newContractorForm = new ContractorAddition();
            newContractorForm.ShowDialog();

            PopulateGridViews();
        }

        private void AddJobBtn_Click(object sender, EventArgs e)
        {
            JobAddition newJobForm = new JobAddition();
            newJobForm.ShowDialog();

            PopulateGridViews();
        }

        private void ExportJobsBtn_Click(object sender, EventArgs e)
        {
            ExportJobsDialog newExportForm = new ExportJobsDialog(JobGridView);
            newExportForm.ShowDialog();
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 100;
            
            toolTip.ShowAlways = true;
            
            toolTip.SetToolTip(UpdateJobsButton, "Update Your List of Jobs by Importing a CSV File From Contractor Software");
        }

        private void UpdateJobsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV files (*.csv)|*.csv";
            fileDialog.Title = "Import";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = fileDialog.FileName;

                connection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("UPDATE Job " +
                    "SET DateCompleted = @dateCompleted, AmountCharged = @amountCharged " +
                    "WHERE Client = @client", connection);

                cmd.Parameters.Add("@dateCompleted", System.Data.SqlDbType.Date);
                cmd.Parameters.Add("@amountCharged", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@client", System.Data.SqlDbType.VarChar);
                

                using (StreamReader stream = new StreamReader(path))
                {
                    while (!stream.EndOfStream)
                    {
                        cmd.Parameters["@Client"].Value = stream.ReadLine();
                        stream.ReadLine(); 
                        stream.ReadLine();
                        stream.ReadLine();
                        stream.ReadLine();
                        stream.ReadLine();
                        cmd.Parameters["@dateCompleted"].Value = stream.ReadLine();
                        cmd.Parameters["@amountCharged"].Value = stream.ReadLine();

                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (SqlException)
                        {
                            Console.WriteLine("Error With Database Connection");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
            PopulateGridViews();
        }

        private void IQIncorporatedTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello,i am sidharth puri and i can tell you that next 1 and 1 befor me are bad liers!!");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi,my name is isaac nelson and i am smarter than other 3 guys!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi adam, i am ahmad rezaei and recentlly changed my name to James bond");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fabian Tauriello is here and i have no idea how to be funny! but i am honest and can tell we are all like isaac nelson");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
