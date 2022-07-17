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
    public partial class TrackComplain : Form
    {
        private Complain_DTO _cdto;
        private Complain_BL _cBL;
        public TrackComplain()
        {
            InitializeComponent();
            _cdto = new Complain_DTO();
            _cBL = new Complain_BL();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void track_Click(object sender, EventArgs e)
        {
            _cdto.ComplainId = compId.Text;
            string chk = _cBL.Track_Complain(_cdto);
            if(chk!=null)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                cId.Visible = true;
                csId.Visible = true;
                cstatus.Visible = true;
                ctype.Visible = true;
                cdes.Visible = true;
                cId.Text = _cdto.ComplainId;
                csId.Text = _cdto.CustomerId;
                cstatus.Text = _cdto.Status;
                ctype.Text = _cdto.Type;
                cdes.Text = _cdto.Description;

            }
            else
            {
                MessageBox.Show("error");
            }
           
            
            

        }

        private void TrackComplain_Load(object sender, EventArgs e)
        {

        }
    }
}
