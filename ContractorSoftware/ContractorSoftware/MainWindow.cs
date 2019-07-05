using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace ContractorSoftware
{
    public partial class MainWindow : Form
    {
        SqlConnection connection;
        string connectionString;

        public MainWindow()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ContractorDBConnectionString"].ConnectionString;

            PopulateJobGridView();
            PopulateContractorComboBox();
        }

        private void PopulateJobGridView()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter jobAdapter = new SqlDataAdapter("SELECT * FROM Jobs", connection);
            DataTable jobTable = new DataTable();
            jobAdapter.Fill(jobTable);
            JobGridView.DataSource = jobTable;

            connection.Close();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV files (*.csv)|*.csv";
            fileDialog.Title = "Import";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = fileDialog.FileName;

                connection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("INSERT INTO Jobs " +
                    "(Client, Description, Location, Date, Time, Priority) " +
                    "VALUES(@Client, @Description, @Location, @Date, @Time, @Priority)", connection);

                cmd.Parameters.Add("@Client", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@Description", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@Location", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@Date", System.Data.SqlDbType.Date);
                cmd.Parameters.Add("@Time", System.Data.SqlDbType.Time);
                cmd.Parameters.Add("@Priority", System.Data.SqlDbType.VarChar);

                using (StreamReader stream = new StreamReader(path))
                {
                    while (!stream.EndOfStream)
                    {
                        cmd.Parameters["@Client"].Value = stream.ReadLine();
                        cmd.Parameters["@Description"].Value = stream.ReadLine();
                        cmd.Parameters["@Location"].Value = stream.ReadLine();
                        cmd.Parameters["@Date"].Value = stream.ReadLine();
                        cmd.Parameters["@Time"].Value = stream.ReadLine();
                        cmd.Parameters["@Priority"].Value = stream.ReadLine();

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
            PopulateJobGridView();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            JobCompleteForm newForm = new JobCompleteForm();
            newForm.ShowDialog();

            PopulateJobGridView();
        }


        private void PopulateContractorComboBox()
        {
            connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Contractor", connection);
            DataTable table = new DataTable();
            //adapter.Fill(table);
            //contractorBox.DataSource = table;
            //contractorBox.ValueMember = "Name";

            //contractorBox.SelectedIndex = -1;

        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileD = new SaveFileDialog();
            fileD.Filter = "CSV files (*.csv)|*.csv";
            fileD.Title = "Export";

            if (fileD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = fileD.FileName;

                StreamWriter streamWriter = new StreamWriter(path);
                connection = new SqlConnection(connectionString);

                string sql = string.Format("SELECT * FROM Jobs");

                SqlCommand cmd = new SqlCommand(sql, connection);
                //try
                {
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        using (streamWriter)
                        {
                            while (reader.Read())
                            {
                                streamWriter.WriteLine(reader["Client"].ToString());
                                streamWriter.WriteLine(reader["Description"].ToString());
                                streamWriter.WriteLine(reader["Location"].ToString());
                                streamWriter.WriteLine(reader["Date"]);
                                streamWriter.WriteLine(reader["Time"].ToString());
                                streamWriter.WriteLine(reader["Priority"].ToString());
                                streamWriter.WriteLine(reader["DateCompleted"].ToString());
                                streamWriter.WriteLine(reader["AmountCharged"].ToString());

                            }
                        }
                    }

                }

                {
                    connection.Close();
                }


            }


        }

        private void PrintInvoiceButton_Click(object sender, EventArgs e)
        {
            //Using bring dialog
            //PrintDialog PnewForm = new PrintDialog(JobGridView);
            //PnewForm.Show();

            //Using Crystal Reporting
            PrintDialog newForm = new PrintDialog();
            newForm.Show();

            //PrintInvoice pi = new PrintInvoice();
            //TextObject text = (TextObject)pi.ReportDefinition.Sections["Section2"].ReportObjects["pID"];
            //text.Text = "test";
            //crystalReportViewer1.ReportSource = pi;

            //PrintInvoice pi = new PrintInvoice();

            //TextObject text = (TextObject)pi.ReportDefinition.Sections["pID"].ReportObjects["pID"];
            //text.Text = "test";
            //CrystalReportViewer.ReportSource = pi;
            //newExportForm.ShowDialog();

        }

    }
}
