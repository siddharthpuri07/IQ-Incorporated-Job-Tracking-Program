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

namespace HomeBaseSoftware
{
    public partial class ContractorAddition : Form
    {

        SqlConnection connection;
        string connectionString;

        public ContractorAddition()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["IQIncorporated.Properties.Settings.IQIncConnectionString"].ConnectionString;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "" +
                "INSERT INTO Contractor (Name, Address, LandLine, MobilePhone, EmployeeID, Email) " +
                "VALUES(@Name, @Address, @LandLine, @MobilePhone, @EmployeeID, @Email)";
            cmd.Parameters.AddWithValue("@Name", nameBox.Text);
            cmd.Parameters.AddWithValue("@Address", addressBox.Text);
            cmd.Parameters.AddWithValue("@LandLine", landBox.Text);
            cmd.Parameters.AddWithValue("@MobilePhone", mobileBox.Text);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeIDBox.Text);
            cmd.Parameters.AddWithValue("@Email", emailBox.Text);
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

            nameBox.Text = "";
            addressBox.Text = "";
            mobileBox.Text = "";
            landBox.Text = "";
            employeeIDBox.Text = "";
            emailBox.Text = "";

            this.Close();
        }
    }
}
