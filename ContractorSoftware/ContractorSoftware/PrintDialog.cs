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


namespace ContractorSoftware
{
    public partial class PrintDialog : Form
    {
        DataGridView gridView;
        SqlConnection connection;
        string connectionString;

        public PrintDialog()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["ContractorDBConnectionString"].ConnectionString;


            PopulateContractorComboBox();
        }

        private void PopulateContractorComboBox()
        {
            connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Client FROM Jobs", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            contractorBox.DataSource = table;
            contractorBox.ValueMember = "Client";

            contractorBox.SelectedIndex = -1;

        }

        private void PrintDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contractorDBDataSet.Jobs' table. You can move, or remove it, as needed.
            this.jobsTableAdapter.Fill(this.contractorDBDataSet.Jobs);
            string sql = string.Format("SELECT * FROM Job WHERE Contractor = '{0}'", contractorBox.SelectedValue);
            //SqlCommand cmd = new SqlCommand(sql, connection);
            //try
            //{
            //    connection.Open();

            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    {



            //    }
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Print printer = new Print(contractorBox.SelectedValue.ToString());
                printer.Show();
            }
            catch
            {

            }
        }
    }
}


