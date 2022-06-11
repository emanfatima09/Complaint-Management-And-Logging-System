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
        public Customer_Complain()
        {
            InitializeComponent();
        }

        private void reg_Complain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complaint registered successfully!");
        }
    }
}
