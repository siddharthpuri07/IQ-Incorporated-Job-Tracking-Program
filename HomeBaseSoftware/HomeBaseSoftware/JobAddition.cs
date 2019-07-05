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

namespace HomeBaseSoftware
{
    public partial class JobAddition : Form
    {

        SqlConnection connection;
        string connectionString;

        public JobAddition()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["IQIncorporated.Properties.Settings.IQIncConnectionString"].ConnectionString;

            // set default values of dateTimePicker so a date in the past cannot be selected
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.MinDate = DateTime.Now;

            PopulateClientComboBox();
            PopulateContractorComboBox();
        }

        private void PopulateClientComboBox() 
        {
            connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Client", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            clientBox.DataSource = table;
            clientBox.ValueMember = "Name";
            
            // set empty default value for comboboxes
            clientBox.SelectedIndex = -1;
            
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (clientBox.SelectedIndex == -1 || contractorBox.SelectedIndex == -1)
            {
                MessageBox.Show("A Client and a Contractor For This Job Must Be Entered!");
            }
            else
            {
                connection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "" +
                    "INSERT INTO Job (Client, Contractor, Description, Location, Date, Time, Priority) " +
                    "VALUES(@Client, @Contractor, @Description, @Location, @Date, @Time, @Priority)";
                cmd.Parameters.AddWithValue("@Client", clientBox.SelectedValue);
                cmd.Parameters.AddWithValue("@Description", descriptionBox.Text);
                cmd.Parameters.AddWithValue("@Contractor", contractorBox.Text);
                cmd.Parameters.AddWithValue("@Location", locationBox.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker.Text);
                cmd.Parameters.AddWithValue("@Time", dateTimePicker.Text);
                cmd.Parameters.AddWithValue("@Priority", priorityBox.Text);
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

                clientBox.Text = "";
                descriptionBox.Text = "";
                locationBox.Text = "";
                dateTimePicker.Text = "";
                priorityBox.Text = "";

                this.Close();
            }
        }


    }
}
