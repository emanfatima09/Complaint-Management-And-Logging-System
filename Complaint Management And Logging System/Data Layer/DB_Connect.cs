using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_Management_And_Logging_System.Data_Layer
{
    class DB_Connect
    {
        private SqlConnection con;
        private string _conString;
        public DB_Connect()
        {
            _conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\92318\source\repos\Complaint Management And Logging System\Complaint Management And Logging System\Complaint_System.mdf; Integrated Security = True";
            con = new SqlConnection(_conString);
        }

        public SqlConnection Con { get => con; set => con = value; }
    }
}
