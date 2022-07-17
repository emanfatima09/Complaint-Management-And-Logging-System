using Complaint_Management_And_Logging_System.Data_Layer;
using Complaint_Management_And_Logging_System.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_Management_And_Logging_System.Business_Layer
{
    class LogIN_BL
    {
        private LogIN_DL _lgDl;
        public LogIN_BL()
        {
            _lgDl = new LogIN_DL();
        }
        public string VerifyUser(LogIN_DTO dto)
        {
            LogIN_DTO ret = _lgDl.VerifyUserFromDB(dto);
            if (ret == null)
            {
                return null;
            }
            else 
            {
                return ret.Role;

            }
            

        }
        internal void CreateAccount(LogIN_DTO dto)
        {
            _lgDl.Create_Account(dto);
        }
        public string CheckUser(LogIN_DTO dto)
        {
            LogIN_DTO ret = _lgDl.CheckUserFromDB(dto);
            if (ret == null)
            {
                return null;
            }
            else
            {
                return ret.UserID;

            }


        }

    }
}
