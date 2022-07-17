
namespace Complaint_Management_And_Logging_System
{
    partial class Admin_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.complaint_SystemDataSet = new Complaint_Management_And_Logging_System.Complaint_SystemDataSet();
            this.complainDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complain_DataTableAdapter = new Complaint_Management_And_Logging_System.Complaint_SystemDataSetTableAdapters.Complain_DataTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.complainIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.compId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updt_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.updt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.complaint_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // complaint_SystemDataSet
            // 
            this.complaint_SystemDataSet.DataSetName = "Complaint_SystemDataSet";
            this.complaint_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complainDataBindingSource
            // 
            this.complainDataBindingSource.DataMember = "Complain_Data";
            this.complainDataBindingSource.DataSource = this.complaint_SystemDataSet;
            // 
            // complain_DataTableAdapter
            // 
            this.complain_DataTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complainIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.complainTypeDataGridViewTextBoxColumn,
            this.complainDescriptionDataGridViewTextBoxColumn,
            this.complainStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.complainDataBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(851, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // complainIdDataGridViewTextBoxColumn
            // 
            this.complainIdDataGridViewTextBoxColumn.DataPropertyName = "Complain_Id";
            this.complainIdDataGridViewTextBoxColumn.HeaderText = "Complain_Id";
            this.complainIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.complainIdDataGridViewTextBoxColumn.Name = "complainIdDataGridViewTextBoxColumn";
            this.complainIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "Customer_Id";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Customer_Id";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // complainTypeDataGridViewTextBoxColumn
            // 
            this.complainTypeDataGridViewTextBoxColumn.DataPropertyName = "Complain_Type";
            this.complainTypeDataGridViewTextBoxColumn.HeaderText = "Complain_Type";
            this.complainTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.complainTypeDataGridViewTextBoxColumn.Name = "complainTypeDataGridViewTextBoxColumn";
            this.complainTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // complainDescriptionDataGridViewTextBoxColumn
            // 
            this.complainDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Complain_Description";
            this.complainDescriptionDataGridViewTextBoxColumn.HeaderText = "Complain_Description";
            this.complainDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.complainDescriptionDataGridViewTextBoxColumn.Name = "complainDescriptionDataGridViewTextBoxColumn";
            this.complainDescriptionDataGridViewTextBoxColumn.Width = 180;
            // 
            // complainStatusDataGridViewTextBoxColumn
            // 
            this.complainStatusDataGridViewTextBoxColumn.DataPropertyName = "Complain_Status";
            this.complainStatusDataGridViewTextBoxColumn.HeaderText = "Complain_Status";
            this.complainStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.complainStatusDataGridViewTextBoxColumn.Name = "complainStatusDataGridViewTextBoxColumn";
            this.complainStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // complainDataBindingSource1
            // 
            this.complainDataBindingSource1.DataMember = "Complain_Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Complain Id:";
            // 
            // compId
            // 
            this.compId.Location = new System.Drawing.Point(196, 254);
            this.compId.Name = "compId";
            this.compId.Size = new System.Drawing.Size(111, 26);
            this.compId.TabIndex = 2;
            this.compId.TextChanged += new System.EventHandler(this.compId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter status:";
            this.label2.Visible = false;
            // 
            // updt_btn
            // 
            this.updt_btn.Location = new System.Drawing.Point(407, 254);
            this.updt_btn.Name = "updt_btn";
            this.updt_btn.Size = new System.Drawing.Size(128, 40);
            this.updt_btn.TabIndex = 5;
            this.updt_btn.Text = "Update Status";
            this.updt_btn.UseVisualStyleBackColor = true;
            this.updt_btn.Click += new System.EventHandler(this.updt_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(598, 254);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(160, 40);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete Complain ";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // updt
            // 
            this.updt.Location = new System.Drawing.Point(407, 304);
            this.updt.Name = "updt";
            this.updt.Size = new System.Drawing.Size(128, 38);
            this.updt.TabIndex = 7;
            this.updt.Text = "Update";
            this.updt.UseVisualStyleBackColor = true;
            this.updt.Visible = false;
            this.updt.Click += new System.EventHandler(this.updt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Review",
            "Rejected",
            "Actioned"});
            this.status.Location = new System.Drawing.Point(196, 304);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 28);
            this.status.TabIndex = 8;
            this.status.Visible = false;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(938, 372);
            this.Controls.Add(this.status);
            this.Controls.Add(this.updt);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.updt_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Panel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.complaint_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Complaint_SystemDataSet complaint_SystemDataSet;
        private System.Windows.Forms.BindingSource complainDataBindingSource;
        private Complaint_SystemDataSetTableAdapters.Complain_DataTableAdapter complain_DataTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox compId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updt_btn;
        private System.Windows.Forms.Button delete_btn;
        
        private System.Windows.Forms.BindingSource complainDataBindingSource1;
        private System.Windows.Forms.Button updt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox status;
    }
}