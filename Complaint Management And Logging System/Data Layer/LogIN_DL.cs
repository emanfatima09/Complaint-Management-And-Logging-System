using Complaint_Management_And_Logging_System.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_Management_And_Logging_System.Data_Layer
{
    class LogIN_DL
    {
        DB_Connect con;
        public LogIN_DL()
        {
            con = new DB_Connect();
        }
        public LogIN_DTO VerifyUserFromDB(LogIN_DTO dto)
        {
            LogIN_DTO retDTO = new LogIN_DTO();
            con.Con.Open();
            string queryString = "SELECT * FROM User_System WHERE User_Id='" + dto.UserID + "' AND Password='" + dto.Password + "';";
            SqlCommand com = new SqlCommand(queryString, con.Con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                retDTO.UserID = reader["User_Id"].ToString();
                retDTO.Password = reader["Password"].ToString();
                retDTO.Role = reader["Role"].ToString();
                con.Con.Close();
                return retDTO;
            }
            con.Con.Close();
            return null;

        }
    }
}
