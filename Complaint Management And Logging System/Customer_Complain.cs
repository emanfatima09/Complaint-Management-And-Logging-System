using Complaint_Management_And_Logging_System.Business_Layer;
using Complaint_Management_And_Logging_System.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complaint_Management_And_Logging_System
{
    public partial class Customer_Complain : Form
    {
        private LogIN_DTO logDTO;
        private Complain_DTO _cdto;
        private Complain_BL _cBL;
        
        public Customer_Complain(LogIN_DTO lgDto)
        {
            InitializeComponent();
            logDTO = lgDto;
            _cdto = new Complain_DTO();
            _cBL = new Complain_BL();
            

        }

        private void reg_Complain_Click(object sender, EventArgs e)
        {
            
             
           
            _cdto.CustomerId = logDTO.UserID;
            _cdto.Type = comboBox1.Text;
            _cdto.Description = Complain_details.Text;
            _cdto.Status = "In progress";
            _cBL.Add_Complain(_cdto);
            MessageBox.Show("Complaint registered successfully!");
            

        }
    }
}
