
namespace Complaint_Management_And_Logging_System
{
    partial class Customer_Complain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Complain));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Complain_details = new System.Windows.Forms.RichTextBox();
            this.reg_Complain = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.track = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Name = "label2";
            // 
            // Complain_details
            // 
            resources.ApplyResources(this.Complain_details, "Complain_details");
            this.Complain_details.Name = "Complain_details";
            // 
            // reg_Complain
            // 
            this.reg_Complain.BackColor = System.Drawing.Color.Black;
            this.reg_Complain.ForeColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.reg_Complain, "reg_Complain");
            this.reg_Complain.Name = "reg_Complain";
            this.reg_Complain.UseVisualStyleBackColor = false;
            this.reg_Complain.Click += new System.EventHandler(this.reg_Complain_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // track
            // 
            this.track.BackColor = System.Drawing.Color.Black;
            this.track.ForeColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.track, "track");
            this.track.Name = "track";
            this.track.UseVisualStyleBackColor = false;
            this.track.Click += new System.EventHandler(this.track_Click);
            // 
            // Customer_Complain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Complaint_Management_And_Logging_System.Properties.Resources.Grocery_03;
            this.Controls.Add(this.track);
            this.Controls.Add(this.reg_Complain);
            this.Controls.Add(this.Complain_details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Complain";
            this.Load += new System.EventHandler(this.Customer_Complain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Complain_details;
        private System.Windows.Forms.Button reg_Complain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button track;
    }
}