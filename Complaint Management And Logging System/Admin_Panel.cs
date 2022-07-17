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
    public partial class Admin_Panel : Form
    {
        private Complain_DTO cdto;
        private Complain_BL cBL;
        public Admin_Panel()
        {
            InitializeComponent();
            cdto = new Complain_DTO();
            cBL = new Complain_BL();
            
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'complaint_SystemDataSet.Complain_Data' table. You can move, or remove it, as needed.
            this.complain_DataTableAdapter.Fill(this.complaint_SystemDataSet.Complain_Data);

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            cdto.ComplainId = compId.Text;
            string chk = cBL.Check_Complain(cdto);
            if (chk != null)
            {
                
                cBL.Delete_Complain(cdto);
                MessageBox.Show("Complain deleted successfully", "Complain Deleted");

            }
            else
            {
                MessageBox.Show("Enter Valid complain id!", "Error");
            }

           }

        private void updt_btn_Click(object sender, EventArgs e)
        {
            if(compId.Text==string.Empty)
            {
                errorProvider1.SetError(compId, "Please enter Id");
            }
            else
            {
                errorProvider1.SetError(compId, "");
                updt_btn.Visible = false;
                label2.Visible = true;
                status.Visible = true;
                updt.Visible = true;
            }
        }

        private void updt_Click(object sender, EventArgs e)
        {
            cdto.ComplainId = compId.Text;
            string chk = cBL.Check_Complain(cdto);
            if (chk != null)
            {
                
                    errorProvider1.SetError(status, "");
                    cdto.Status = status.SelectedItem.ToString();
                    cBL.Update_Complain(cdto);
                    MessageBox.Show("Status successfully updated", "Status Update");
                    updt_btn.Visible = true;
                    label2.Visible = false;
                    status.Visible = false;
                    updt.Visible = false;
                
               
            }
            else
            {
                MessageBox.Show("Enter Valid complain id!", "Error");
            }
    
        }

        private void compId_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
