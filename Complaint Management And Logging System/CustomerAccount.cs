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
    public partial class CustomerAccount : Form
    {
        private LogIN_DTO lgdto;
        private LogIN_BL lgBL;
        public CustomerAccount()
        {
            InitializeComponent();
            lgdto = new LogIN_DTO();
            lgBL = new LogIN_BL();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string chk = lgBL.CheckUser(lgdto);
            if (chk != null)
            {
                MessageBox.Show("User Id already exists!", "Error");
            }
            else
            {
                lgdto.UserID = usrId.Text;
                lgdto.UserName = userName.Text;
                lgdto.Password = password.Text;
                lgdto.Role = "Customer";
                lgBL.CreateAccount(lgdto);
                MessageBox.Show("Account Created Successfully!", "Account Success");
            }
           
        }

        private void usrId_TextChanged(object sender, EventArgs e)
        {
            if(!usrId.Text.StartsWith("C00"))
            {
               errorProvider1.SetError(ActiveControl, "Enter id starting with C00");
            }
            else
            {
                errorProvider1.SetError(ActiveControl, "");
            }
           
        }
    }
}
