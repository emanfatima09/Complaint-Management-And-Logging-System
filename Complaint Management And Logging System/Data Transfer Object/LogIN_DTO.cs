using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_Management_And_Logging_System.Data_Transfer_Object
{
    public class LogIN_DTO
    {

        private string _userID;
        private string _userName;
        private string _password;
        private string _role;

        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
        public string UserID { get => _userID; set => _userID = value; }
        public string UserName { get => _userName; set => _userName = value; }
    }
}
