using Complaint_Management_And_Logging_System.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_Management_And_Logging_System.Data_Layer
{
    class Complain_DL
    {
        DB_Connect con;
      

        public Complain_DL()
        {
            con = new DB_Connect();


        }

        public void AddingToComplain(Complain_DTO cdto)
        {
            try
            {
                con.Con.Open();
                string queryString = "INSERT INTO Complain_Data VALUES (@Customer_Id,@Complain_Type,@Complain_Description,@Complain_Status);";
                SqlCommand com = new SqlCommand(queryString, con.Con);
                com.Parameters.AddWithValue("@Customer_Id", cdto.CustomerId);
                com.Parameters.AddWithValue("@Complain_Type", cdto.Type);
                com.Parameters.AddWithValue("@Complain_Description", cdto.Description);
                com.Parameters.AddWithValue("@Complain_Status", cdto.Status);
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Con.Close();
            }
        }
        public void DeleteComplain(Complain_DTO cdto)
        {
            con.Con.Open();
            string deleteQuery = "DELETE FROM Complain_Data WHERE Complain_Id= @Complain_Id;";
            SqlCommand com = new SqlCommand(deleteQuery, con.Con);
            com.Parameters.AddWithValue("@Complain_Id", cdto.ComplainId);
            com.ExecuteNonQuery();
            con.Con.Close();
        }
        public void UpdateComplain(Complain_DTO cdto)
        {
            con.Con.Open();
            string updateQuery = "UPDATE  Complain_Data SET Complain_Status=@Complain_Status WHERE Complain_Id= @Complain_Id;";
            SqlCommand com = new SqlCommand(updateQuery, con.Con);
            com.Parameters.AddWithValue("@Complain_Id", cdto.ComplainId);
            com.Parameters.AddWithValue("@Complain_Status", cdto.Status);
            com.ExecuteNonQuery();
            con.Con.Close();
        }
        public Complain_DTO CheckComplain(Complain_DTO cdto)
        {
            con.Con.Open();
            string checkQuery = "SELECT * FROM Complain_Data WHERE Complain_Id='" + cdto.ComplainId + "' ;";
            SqlCommand com = new SqlCommand(checkQuery, con.Con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cdto.ComplainId = reader["Complain_Id"].ToString();
                cdto.CustomerId = reader["Customer_id"].ToString();
                cdto.Type = reader["Complain_Type"].ToString();
                cdto.Status = reader["Complain_Description"].ToString();
                cdto.Description = reader["Complain_Status"].ToString();
                con.Con.Close();
                return cdto;
            }
            con.Con.Close();
            return null;
        }
        public Complain_DTO TrackComplain(Complain_DTO cdto)
        {
            con.Con.Open();
            string checkQuery = "SELECT * FROM Complain_Data WHERE Complain_Id='" + cdto.ComplainId + "' ;";
            SqlCommand com = new SqlCommand(checkQuery, con.Con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cdto.ComplainId = reader["Complain_Id"].ToString();
                cdto.CustomerId = reader["Customer_id"].ToString();
                cdto.Type = reader["Complain_Type"].ToString();
                cdto.Status = reader["Complain_Description"].ToString();
                cdto.Description = reader["Complain_Status"].ToString();
                con.Con.Close();
                return cdto;
            }
            con.Con.Close();
            return null;
        }
    }  
}
