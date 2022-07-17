using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_Management_And_Logging_System.Data_Transfer_Object
{
    class Complain_DTO
    {
        private string _complainId;
        private string _customerId;
        private string _type;
        private string _description;
        private string _status;

        public string ComplainId { get => _complainId; set => _complainId = value; }
        public string CustomerId { get => _customerId; set => _customerId = value; }
        public string Type { get => _type; set => _type = value; }
        public string Description { get => _description; set => _description = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
