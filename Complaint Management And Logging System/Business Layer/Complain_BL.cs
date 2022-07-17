using Complaint_Management_And_Logging_System.Data_Layer;
using Complaint_Management_And_Logging_System.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_Management_And_Logging_System.Business_Layer
{
    class Complain_BL
    {
        private Complain_DL cDL;
        public Complain_BL()
        {
            cDL = new Complain_DL();

        }
        internal void Add_Complain(Complain_DTO cdto)
        {
             cDL.AddingToComplain(cdto);
        }
        internal void Delete_Complain(Complain_DTO cdto)
        {
            cDL.DeleteComplain(cdto);
        }
        internal void Update_Complain(Complain_DTO cdto)
        {
            cDL.UpdateComplain(cdto);
        }
        public string Check_Complain(Complain_DTO cdto)
        {
            Complain_DTO check = cDL.CheckComplain(cdto);
            if (check == null)
            {
                return null;
            }
            else
            {
                return check.ComplainId;

            }
            
        }
        public string Track_Complain(Complain_DTO cdto)
        {
            Complain_DTO check = cDL.TrackComplain(cdto);
            if (check == null)
            {
                return null;
            }
            else
            {
                return check.ComplainId;

            }

        }


    }
}
