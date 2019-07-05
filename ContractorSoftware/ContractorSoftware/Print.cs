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
    public partial class Print : Form
    {
        private SqlConnection connection;

        public Print(string cont)
        {
            
            InitializeComponent();
            NumberLabel.Text = "09283475";
            string connectionString = ConfigurationManager.ConnectionStrings["ContractorDBConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            string sql = string.Format("SELECT * FROM Job WHERE Client = '{0}'", cont);

            SqlCommand cmd = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("asdsa");
                    while (reader.Read())
                    {
                        
                        ClientLabel.Text = (reader["Client"].ToString());
                        DetailsLabel.Text = (reader["Description"].ToString());
                        string loc = (reader["Location"].ToString());
                        string date = (reader["Date"].ToString());
                        string time = (reader["Time"].ToString());
                        string pri = (reader["Priority"].ToString());
                        ContLabel.Text = (reader["Contractor"].ToString());
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
