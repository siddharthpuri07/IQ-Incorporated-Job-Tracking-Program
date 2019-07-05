using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace HomeBaseSoftware
{
    public partial class ExportJobsDialog : Form
    {
        DataGridView gridView;
        SqlConnection connection;
        string connectionString;

        public ExportJobsDialog(DataGridView gridView)
        {
            InitializeComponent();

            this.gridView = gridView;

            connectionString = ConfigurationManager.ConnectionStrings["IQIncorporated.Properties.Settings.IQIncConnectionString"].ConnectionString;

            PopulateContractorComboBox();
        }

        private void PopulateContractorComboBox()
        {
            connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Contractor", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            contractorBox.DataSource = table;
            contractorBox.ValueMember = "Name";

            contractorBox.SelectedIndex = -1;

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

                string sql = string.Format("SELECT * FROM Job WHERE Contractor = '{0}'", contractorBox.SelectedValue);
                
                SqlCommand cmd = new SqlCommand(sql, connection);
                try
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
                                streamWriter.WriteLine(reader["Date"].ToString());
                                streamWriter.WriteLine(reader["Time"].ToString());
                                streamWriter.WriteLine(reader["Priority"].ToString());
                                
                           }
                        }

                    }
                }
                finally
                {
                    connection.Close();
                }
                

            }


        }
    }
}
