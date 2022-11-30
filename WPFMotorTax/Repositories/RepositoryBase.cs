using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPFMotorTax.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Server=tcp:motortaxserver1.database.windows.net,1433;Initial Catalog=motortax;Persist Security Info=False;User ID=adminlogin;Password=Adminpass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
