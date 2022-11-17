using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFMotorTax.Models;
using WPFMotorTax.Repositories;

namespace WPFMotorTax.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        string connectionString = "Server = tcp:motortaxserver.database.windows.net,1433; Initial Catalog = motortaxdata; Persist Security Info = False; User ID = motortaxadmin; Password = WokPassword1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";

        public MainView()
        {
            InitializeComponent();
            




        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            /*
            string readString = "select * from [dbo.user] where regNo=@username";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(readString, connection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = "131-KY-224";
                    

             SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                regNoBox.Text = reader.GetString(0);

            }
                    
                

            */



            

            
        }
    }
}
