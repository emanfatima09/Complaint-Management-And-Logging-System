
namespace Complaint_Management_And_Logging_System
{
    partial class LogIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_Text = new System.Windows.Forms.TextBox();
            this.password_Text = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.logIN_btn = new System.Windows.Forms.Button();
            this.signUp_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adm_chk = new System.Windows.Forms.CheckBox();
            this.customerChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // user_Text
            // 
            this.user_Text.Location = new System.Drawing.Point(246, 100);
            this.user_Text.Name = "user_Text";
            this.user_Text.Size = new System.Drawing.Size(193, 26);
            this.user_Text.TabIndex = 2;
            this.user_Text.TextChanged += new System.EventHandler(this.user_Text_TextChanged);
            // 
            // password_Text
            // 
            this.password_Text.Location = new System.Drawing.Point(246, 151);
            this.password_Text.Name = "password_Text";
            this.password_Text.Size = new System.Drawing.Size(193, 26);
            this.password_Text.TabIndex = 3;
            this.password_Text.UseSystemPasswordChar = true;
            this.password_Text.TextChanged += new System.EventHandler(this.password_Text_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // logIN_btn
            // 
            this.logIN_btn.BackColor = System.Drawing.Color.Gray;
            this.logIN_btn.Location = new System.Drawing.Point(246, 241);
            this.logIN_btn.Name = "logIN_btn";
            this.logIN_btn.Size = new System.Drawing.Size(193, 50);
            this.logIN_btn.TabIndex = 4;
            this.logIN_btn.Text = "Log IN";
            this.logIN_btn.UseVisualStyleBackColor = false;
            this.logIN_btn.Click += new System.EventHandler(this.logIN_btn_Click);
            // 
            // signUp_label
            // 
            this.signUp_label.AutoSize = true;
            this.signUp_label.BackColor = System.Drawing.Color.Transparent;
            this.signUp_label.ForeColor = System.Drawing.Color.DarkRed;
            this.signUp_label.Location = new System.Drawing.Point(102, 214);
            this.signUp_label.Name = "signUp_label";
            this.signUp_label.Size = new System.Drawing.Size(347, 40);
            this.signUp_label.TabIndex = 6;
            this.signUp_label.Text = "Sign UP to create new account! (Customer only)\r\n\r\n";
            this.signUp_label.Click += new System.EventHandler(this.signUp_label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(78, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Super Market Complaint System";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // adm_chk
            // 
            this.adm_chk.AutoSize = true;
            this.adm_chk.BackColor = System.Drawing.Color.Transparent;
            this.adm_chk.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adm_chk.Location = new System.Drawing.Point(246, 183);
            this.adm_chk.Name = "adm_chk";
            this.adm_chk.Size = new System.Drawing.Size(103, 28);
            this.adm_chk.TabIndex = 8;
            this.adm_chk.Text = "Admin";
            this.adm_chk.UseVisualStyleBackColor = false;
            this.adm_chk.CheckedChanged += new System.EventHandler(this.adm_chk_CheckedChanged);
            this.adm_chk.CheckStateChanged += new System.EventHandler(this.adm_chk_CheckStateChanged);
            // 
            // customerChk
            // 
            this.customerChk.AutoSize = true;
            this.customerChk.BackColor = System.Drawing.Color.Transparent;
            this.customerChk.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerChk.Location = new System.Drawing.Point(355, 183);
            this.customerChk.Name = "customerChk";
            this.customerChk.Size = new System.Drawing.Size(127, 28);
            this.customerChk.TabIndex = 9;
            this.customerChk.Text = "Customer";
            this.customerChk.UseVisualStyleBackColor = false;
            this.customerChk.CheckedChanged += new System.EventHandler(this.customerChk_CheckedChanged);
            // 
            // LogIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Complaint_Management_And_Logging_System.Properties.Resources.Grocery_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 384);
            this.Controls.Add(this.customerChk);
            this.Controls.Add(this.adm_chk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signUp_label);
            this.Controls.Add(this.logIN_btn);
            this.Controls.Add(this.password_Text);
            this.Controls.Add(this.user_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIN";
            this.Text = "Log IN";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_Text;
        private System.Windows.Forms.TextBox password_Text;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label signUp_label;
        private System.Windows.Forms.Button logIN_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox adm_chk;
        private System.Windows.Forms.CheckBox customerChk;
    }
}

