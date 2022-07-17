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
    public partial class LogIN : Form
    {
        private LogIN_DTO _lgDTO;
        private LogIN_BL _lgBL;
        public string userRole;
        public LogIN()
        {
            InitializeComponent();
            _lgDTO = new LogIN_DTO();
            _lgBL = new LogIN_BL();
        }

        private void signUp_label_Click(object sender, EventArgs e)
        {
            CustomerAccount customAcc = new CustomerAccount();
            customAcc.Show();
        }

        private void logIN_btn_Click(object sender, EventArgs e)
        {

            _lgDTO.UserID = user_Text.Text;
            _lgDTO.Password = password_Text.Text;
            _lgDTO.Role = userRole;
            string check = _lgBL.VerifyUser(_lgDTO);
            if (check != null)
            {
                if (_lgDTO.Role == "Admin")
                {
                    Admin_Panel adm = new Admin_Panel();
                    adm.Show();
                }
                else
                {
                    Customer_Complain custm = new Customer_Complain(_lgDTO);
                    
                    custm.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong username/password");
            }

           

        }

        private void user_Text_TextChanged(object sender, EventArgs e)
        {
            if (user_Text.Text == string.Empty)
            {
                errorProvider1.SetError(user_Text, "Please enter user ID");
            }
            else
            {
                errorProvider1.SetError(user_Text, "");
            }


        }

        private void password_Text_TextChanged(object sender, EventArgs e)
        {
            if (password_Text.Text == string.Empty)
            {
                errorProvider1.SetError(password_Text, "Please enter user password");
            }
            else
            {
                errorProvider1.SetError(password_Text, "");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adm_chk_CheckStateChanged(object sender, EventArgs e)
        {
            if (adm_chk.Checked == true)
            {
                _lgDTO.Role = adm_chk.Text;
            }
            else
            {
                _lgDTO.Role = "Customer";
            }
        }

        private void adm_chk_CheckedChanged(object sender, EventArgs e)
        {
            userRole = adm_chk.Text;
            if(adm_chk.Checked==true)
            {
                customerChk.Enabled = false;
            }
            else
            {
                customerChk.Enabled = true;
            }
            
        }

        private void customerChk_CheckedChanged(object sender, EventArgs e)
        {
            userRole = customerChk.Text;
            if(customerChk.Checked==true)
            {
             adm_chk.Enabled = false;
            }
            else
            {
                adm_chk.Enabled = true;
            }
            

        }
    }
}
