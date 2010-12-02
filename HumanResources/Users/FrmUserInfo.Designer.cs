namespace HumanResources.Users
{
    partial class FrmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser_superior_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUser_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUser_realName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUser_number = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCreation_time = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter();
            this.rolesTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.rolesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户编号:";
            // 
            // lblUser_id
            // 
            this.lblUser_id.AutoSize = true;
            this.lblUser_id.Location = new System.Drawing.Point(211, 9);
            this.lblUser_id.Name = "lblUser_id";
            this.lblUser_id.Size = new System.Drawing.Size(53, 12);
            this.lblUser_id.TabIndex = 1;
            this.lblUser_id.Text = "用户编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户组:";
            // 
            // lblUser_superior_id
            // 
            this.lblUser_superior_id.AutoSize = true;
            this.lblUser_superior_id.Location = new System.Drawing.Point(211, 31);
            this.lblUser_superior_id.Name = "lblUser_superior_id";
            this.lblUser_superior_id.Size = new System.Drawing.Size(41, 12);
            this.lblUser_superior_id.TabIndex = 1;
            this.lblUser_superior_id.Text = "用户组";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "登录名:";
            // 
            // lblUser_name
            // 
            this.lblUser_name.AutoSize = true;
            this.lblUser_name.Location = new System.Drawing.Point(77, 31);
            this.lblUser_name.Name = "lblUser_name";
            this.lblUser_name.Size = new System.Drawing.Size(41, 12);
            this.lblUser_name.TabIndex = 1;
            this.lblUser_name.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "姓名:";
            // 
            // lblUser_realName
            // 
            this.lblUser_realName.AutoSize = true;
            this.lblUser_realName.Location = new System.Drawing.Point(77, 9);
            this.lblUser_realName.Name = "lblUser_realName";
            this.lblUser_realName.Size = new System.Drawing.Size(41, 12);
            this.lblUser_realName.TabIndex = 1;
            this.lblUser_realName.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "工号:";
            // 
            // lblUser_number
            // 
            this.lblUser_number.AutoSize = true;
            this.lblUser_number.Location = new System.Drawing.Point(347, 9);
            this.lblUser_number.Name = "lblUser_number";
            this.lblUser_number.Size = new System.Drawing.Size(41, 12);
            this.lblUser_number.TabIndex = 1;
            this.lblUser_number.Text = "label2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "创建时间:";
            // 
            // lblCreation_time
            // 
            this.lblCreation_time.AutoSize = true;
            this.lblCreation_time.Location = new System.Drawing.Point(347, 31);
            this.lblCreation_time.Name = "lblCreation_time";
            this.lblCreation_time.Size = new System.Drawing.Size(41, 12);
            this.lblCreation_time.TabIndex = 1;
            this.lblCreation_time.Text = "label2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "角色:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(77, 53);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 12);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "label2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "备注:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 0);
            this.lblComment.MaximumSize = new System.Drawing.Size(330, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(329, 84);
            this.lblComment.TabIndex = 1;
            this.lblComment.Text = resources.GetString("lblComment.Text");
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblComment);
            this.panel1.Location = new System.Drawing.Point(55, 75);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel1.Size = new System.Drawing.Size(361, 79);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(349, 194);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCustomers.Location = new System.Drawing.Point(246, 194);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(97, 23);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "相关客户列表";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // humanresourcesDataSet1
            // 
            this.humanresourcesDataSet1.DataSetName = "humanresourcesDataSet";
            this.humanresourcesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.candidateTableAdapter = null;
            this.tableAdapterManager1.cityTableAdapter = null;
            this.tableAdapterManager1.client_followTableAdapter = null;
            this.tableAdapterManager1.clientpropertyTableAdapter = null;
            this.tableAdapterManager1.clientTableAdapter = null;
            this.tableAdapterManager1.contractTableAdapter = null;
            this.tableAdapterManager1.degreeTableAdapter = null;
            this.tableAdapterManager1.dimensionsTableAdapter = null;
            this.tableAdapterManager1.educationTableAdapter = null;
            this.tableAdapterManager1.employeesnumberTableAdapter = null;
            this.tableAdapterManager1.evaluateTableAdapter = null;
            this.tableAdapterManager1.jobsdetailTableAdapter = null;
            this.tableAdapterManager1.jobsTableAdapter = null;
            this.tableAdapterManager1.linkmanTableAdapter = null;
            this.tableAdapterManager1.mingzTableAdapter = null;
            this.tableAdapterManager1.nationalityTableAdapter = null;
            this.tableAdapterManager1.operationmodelTableAdapter = null;
            this.tableAdapterManager1.ordersTableAdapter = null;
            this.tableAdapterManager1.ownershipTableAdapter = null;
            this.tableAdapterManager1.personnelTableAdapter = null;
            this.tableAdapterManager1.provinceTableAdapter = null;
            this.tableAdapterManager1.recommended_state_remarkTableAdapter = null;
            this.tableAdapterManager1.recommended_stateTableAdapter = null;
            this.tableAdapterManager1.recommendedTableAdapter = null;
            this.tableAdapterManager1.recruitment_quantityTableAdapter = null;
            this.tableAdapterManager1.recruitmentTableAdapter = null;
            this.tableAdapterManager1.resumeTableAdapter = null;
            this.tableAdapterManager1.rightsTableAdapter = null;
            this.tableAdapterManager1.rolesTableAdapter = this.rolesTableAdapter1;
            this.tableAdapterManager1.tradeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = this.usersTableAdapter1;
            this.tableAdapterManager1.work_experienceTableAdapter = null;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(432, 229);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblCreation_time);
            this.Controls.Add(this.lblUser_number);
            this.Controls.Add(this.lblUser_realName);
            this.Controls.Add(this.lblUser_name);
            this.Controls.Add(this.lblUser_superior_id);
            this.Controls.Add(this.lblUser_id);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmUserInfo";
            this.Text = "用户信息";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUser_superior_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUser_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUser_realName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUser_number;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCreation_time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCustomers;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.rolesTableAdapter rolesTableAdapter1;
    }
}