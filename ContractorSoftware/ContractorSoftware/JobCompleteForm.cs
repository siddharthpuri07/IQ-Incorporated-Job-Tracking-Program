using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractorSoftware
{
    public partial class JobCompleteForm : Form
    {
        SqlConnection connection;
        string connectionString;

        public JobCompleteForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ContractorDBConnectionString"].ConnectionString;

            DateCompletedPicker.Value = DateTime.Now;
            DateCompletedPicker.MaxDate = DateTime.Now;

            PopulateJobIDComboBox();
        }

        private void PopulateJobIDComboBox()
        {
            connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id FROM Jobs", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            JobIDComboBox.DataSource = table;
            JobIDComboBox.ValueMember = "Id";

            // set empty default value for comboboxes
            JobIDComboBox.SelectedIndex = -1;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (JobIDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("A Valid Job ID Must be Selected");
            } else
            {
                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Jobs " +
                    "SET DateCompleted = @DateCompleted, AmountCharged = @AmountCharged " +
                    "WHERE Id = @JobID";
                cmd.Parameters.AddWithValue("@DateCompleted", DateCompletedPicker.Value);
                cmd.Parameters.AddWithValue("@AmountCharged", AmountBox.Text);
                cmd.Parameters.AddWithValue("@JobID", JobIDComboBox.Text);
                cmd.Connection = connection;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
        }
    }
}
