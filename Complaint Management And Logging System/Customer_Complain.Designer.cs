
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Complain_details = new System.Windows.Forms.RichTextBox();
            this.reg_Complain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complain type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Service",
            "Product"});
            this.comboBox1.Location = new System.Drawing.Point(266, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(43, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // Complain_details
            // 
            this.Complain_details.Location = new System.Drawing.Point(49, 181);
            this.Complain_details.Name = "Complain_details";
            this.Complain_details.Size = new System.Drawing.Size(484, 128);
            this.Complain_details.TabIndex = 3;
            this.Complain_details.Text = "";
            // 
            // reg_Complain
            // 
            this.reg_Complain.BackColor = System.Drawing.Color.Black;
            this.reg_Complain.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reg_Complain.Location = new System.Drawing.Point(326, 384);
            this.reg_Complain.Name = "reg_Complain";
            this.reg_Complain.Size = new System.Drawing.Size(207, 73);
            this.reg_Complain.TabIndex = 4;
            this.reg_Complain.Text = "Register Complain";
            this.reg_Complain.UseVisualStyleBackColor = false;
            this.reg_Complain.Click += new System.EventHandler(this.reg_Complain_Click);
            // 
            // Customer_Complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Complaint_Management_And_Logging_System.Properties.Resources.Grocery_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 499);
            this.Controls.Add(this.reg_Complain);
            this.Controls.Add(this.Complain_details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Complain";
            this.Text = "Customer Complain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Complain_details;
        private System.Windows.Forms.Button reg_Complain;
    }
}