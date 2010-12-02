namespace HumanResources.Customer
{
    partial class FrmLinkmanList
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
            this.txtLinkMan_Email = new System.Windows.Forms.TextBox();
            this.txtLinkman_position = new System.Windows.Forms.TextBox();
            this.txtLinkman_Comment = new System.Windows.Forms.TextBox();
            this.txtLinkman_add = new System.Windows.Forms.TextBox();
            this.txtLinkman_mobileP = new System.Windows.Forms.TextBox();
            this.txtLinkman_nameE = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.txtLinkman_fax = new System.Windows.Forms.TextBox();
            this.txtLinkman_phone = new System.Windows.Forms.TextBox();
            this.txtLinkman_name = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.btnAddLinkman = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Linkman_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkman_nameE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkman_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkman_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkman_mobileP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkMan_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkman_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkman_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.clientTableAdapter();
            this.linkmanTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.linkmanTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLinkMan_Email
            // 
            this.txtLinkMan_Email.Location = new System.Drawing.Point(470, 39);
            this.txtLinkMan_Email.Name = "txtLinkMan_Email";
            this.txtLinkMan_Email.Size = new System.Drawing.Size(122, 21);
            this.txtLinkMan_Email.TabIndex = 15;
            // 
            // txtLinkman_position
            // 
            this.txtLinkman_position.Location = new System.Drawing.Point(470, 12);
            this.txtLinkman_position.Name = "txtLinkman_position";
            this.txtLinkman_position.Size = new System.Drawing.Size(122, 21);
            this.txtLinkman_position.TabIndex = 18;
            // 
            // txtLinkman_Comment
            // 
            this.txtLinkman_Comment.Location = new System.Drawing.Point(88, 98);
            this.txtLinkman_Comment.Multiline = true;
            this.txtLinkman_Comment.Name = "txtLinkman_Comment";
            this.txtLinkman_Comment.Size = new System.Drawing.Size(504, 38);
            this.txtLinkman_Comment.TabIndex = 19;
            // 
            // txtLinkman_add
            // 
            this.txtLinkman_add.Location = new System.Drawing.Point(279, 67);
            this.txtLinkman_add.Name = "txtLinkman_add";
            this.txtLinkman_add.Size = new System.Drawing.Size(313, 21);
            this.txtLinkman_add.TabIndex = 16;
            // 
            // txtLinkman_mobileP
            // 
            this.txtLinkman_mobileP.Location = new System.Drawing.Point(279, 40);
            this.txtLinkman_mobileP.Name = "txtLinkman_mobileP";
            this.txtLinkman_mobileP.Size = new System.Drawing.Size(120, 21);
            this.txtLinkman_mobileP.TabIndex = 17;
            // 
            // txtLinkman_nameE
            // 
            this.txtLinkman_nameE.Location = new System.Drawing.Point(279, 13);
            this.txtLinkman_nameE.Name = "txtLinkman_nameE";
            this.txtLinkman_nameE.Size = new System.Drawing.Size(120, 21);
            this.txtLinkman_nameE.TabIndex = 22;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(405, 43);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(59, 12);
            this.label63.TabIndex = 13;
            this.label63.Tag = "";
            this.label63.Text = "电子邮箱:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(405, 16);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(35, 12);
            this.label60.TabIndex = 7;
            this.label60.Tag = "";
            this.label60.Text = "职位:";
            // 
            // txtLinkman_fax
            // 
            this.txtLinkman_fax.Location = new System.Drawing.Point(88, 68);
            this.txtLinkman_fax.Name = "txtLinkman_fax";
            this.txtLinkman_fax.Size = new System.Drawing.Size(120, 21);
            this.txtLinkman_fax.TabIndex = 23;
            // 
            // txtLinkman_phone
            // 
            this.txtLinkman_phone.Location = new System.Drawing.Point(88, 41);
            this.txtLinkman_phone.Name = "txtLinkman_phone";
            this.txtLinkman_phone.Size = new System.Drawing.Size(120, 21);
            this.txtLinkman_phone.TabIndex = 20;
            // 
            // txtLinkman_name
            // 
            this.txtLinkman_name.Location = new System.Drawing.Point(88, 14);
            this.txtLinkman_name.Name = "txtLinkman_name";
            this.txtLinkman_name.Size = new System.Drawing.Size(120, 21);
            this.txtLinkman_name.TabIndex = 21;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(16, 98);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(35, 12);
            this.label66.TabIndex = 9;
            this.label66.Text = "备注:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(214, 71);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(35, 12);
            this.label65.TabIndex = 10;
            this.label65.Text = "地址:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(214, 44);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(59, 12);
            this.label62.TabIndex = 8;
            this.label62.Text = "移动电话:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(214, 17);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(59, 12);
            this.label54.TabIndex = 6;
            this.label54.Text = "姓名(英):";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(16, 72);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(35, 12);
            this.label64.TabIndex = 14;
            this.label64.Text = "传真:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(16, 45);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(35, 12);
            this.label61.TabIndex = 11;
            this.label61.Text = "电话:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(16, 18);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(59, 12);
            this.label53.TabIndex = 12;
            this.label53.Text = "姓名(中):";
            // 
            // btnAddLinkman
            // 
            this.btnAddLinkman.Location = new System.Drawing.Point(475, 284);
            this.btnAddLinkman.Name = "btnAddLinkman";
            this.btnAddLinkman.Size = new System.Drawing.Size(75, 22);
            this.btnAddLinkman.TabIndex = 5;
            this.btnAddLinkman.Text = "添加联系人";
            this.btnAddLinkman.UseVisualStyleBackColor = true;
            this.btnAddLinkman.Click += new System.EventHandler(this.btnAddLinkman_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linkman_name,
            this.Linkman_nameE,
            this.Linkman_position,
            this.Linkman_phone,
            this.Linkman_mobileP,
            this.LinkMan_Email,
            this.Linkman_fax,
            this.Linkman_add});
            this.dataGridView1.Location = new System.Drawing.Point(13, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(618, 245);
            this.dataGridView1.TabIndex = 4;
            // 
            // Linkman_name
            // 
            this.Linkman_name.DataPropertyName = "Linkman_name";
            this.Linkman_name.HeaderText = "姓名(中)";
            this.Linkman_name.Name = "Linkman_name";
            this.Linkman_name.ReadOnly = true;
            // 
            // Linkman_nameE
            // 
            this.Linkman_nameE.DataPropertyName = "Linkman_nameE";
            this.Linkman_nameE.HeaderText = "姓名(英)";
            this.Linkman_nameE.Name = "Linkman_nameE";
            this.Linkman_nameE.ReadOnly = true;
            // 
            // Linkman_position
            // 
            this.Linkman_position.DataPropertyName = "Linkman_position";
            this.Linkman_position.HeaderText = "职位";
            this.Linkman_position.Name = "Linkman_position";
            this.Linkman_position.ReadOnly = true;
            // 
            // Linkman_phone
            // 
            this.Linkman_phone.DataPropertyName = "Linkman_phone";
            this.Linkman_phone.HeaderText = "电话";
            this.Linkman_phone.Name = "Linkman_phone";
            this.Linkman_phone.ReadOnly = true;
            // 
            // Linkman_mobileP
            // 
            this.Linkman_mobileP.DataPropertyName = "Linkman_mobileP";
            this.Linkman_mobileP.HeaderText = "移动电话";
            this.Linkman_mobileP.Name = "Linkman_mobileP";
            this.Linkman_mobileP.ReadOnly = true;
            // 
            // LinkMan_Email
            // 
            this.LinkMan_Email.DataPropertyName = "LinkMan_Email";
            this.LinkMan_Email.HeaderText = "电子邮箱";
            this.LinkMan_Email.Name = "LinkMan_Email";
            this.LinkMan_Email.ReadOnly = true;
            // 
            // Linkman_fax
            // 
            this.Linkman_fax.DataPropertyName = "Linkman_fax";
            this.Linkman_fax.HeaderText = "传真";
            this.Linkman_fax.Name = "Linkman_fax";
            this.Linkman_fax.ReadOnly = true;
            // 
            // Linkman_add
            // 
            this.Linkman_add.DataPropertyName = "Linkman_add";
            this.Linkman_add.HeaderText = "地址";
            this.Linkman_add.Name = "Linkman_add";
            this.Linkman_add.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Controls.Add(this.txtLinkMan_Email);
            this.panel1.Controls.Add(this.label61);
            this.panel1.Controls.Add(this.txtLinkman_position);
            this.panel1.Controls.Add(this.label64);
            this.panel1.Controls.Add(this.txtLinkman_Comment);
            this.panel1.Controls.Add(this.label54);
            this.panel1.Controls.Add(this.txtLinkman_add);
            this.panel1.Controls.Add(this.label62);
            this.panel1.Controls.Add(this.txtLinkman_mobileP);
            this.panel1.Controls.Add(this.label65);
            this.panel1.Controls.Add(this.txtLinkman_nameE);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.label63);
            this.panel1.Controls.Add(this.txtLinkman_name);
            this.panel1.Controls.Add(this.label60);
            this.panel1.Controls.Add(this.txtLinkman_phone);
            this.panel1.Controls.Add(this.txtLinkman_fax);
            this.panel1.Location = new System.Drawing.Point(20, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 165);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(517, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(436, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(556, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.tableAdapterManager1.clientTableAdapter = this.clientTableAdapter1;
            this.tableAdapterManager1.contractTableAdapter = null;
            this.tableAdapterManager1.degreeTableAdapter = null;
            this.tableAdapterManager1.dimensionsTableAdapter = null;
            this.tableAdapterManager1.educationTableAdapter = null;
            this.tableAdapterManager1.employeesnumberTableAdapter = null;
            this.tableAdapterManager1.evaluateTableAdapter = null;
            this.tableAdapterManager1.invoicestateTableAdapter = null;
            this.tableAdapterManager1.invoiceTableAdapter = null;
            this.tableAdapterManager1.jobsdetailTableAdapter = null;
            this.tableAdapterManager1.jobsTableAdapter = null;
            this.tableAdapterManager1.linkmanTableAdapter = this.linkmanTableAdapter1;
            this.tableAdapterManager1.mingzTableAdapter = null;
            this.tableAdapterManager1.nationalityTableAdapter = null;
            this.tableAdapterManager1.operationmodelTableAdapter = null;
            this.tableAdapterManager1.order_stateTableAdapter = null;
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
            this.tableAdapterManager1.rolesTableAdapter = null;
            this.tableAdapterManager1.teamTableAdapter = null;
            this.tableAdapterManager1.tradeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = null;
            this.tableAdapterManager1.weeklyc_detailsTableAdapter = null;
            this.tableAdapterManager1.weeklyc_particularsTableAdapter = null;
            this.tableAdapterManager1.wekkly_consultantTableAdapter = null;
            this.tableAdapterManager1.work_experienceTableAdapter = null;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // linkmanTableAdapter1
            // 
            this.linkmanTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "客户名称:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(77, 9);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(0, 12);
            this.lblClientName.TabIndex = 25;
            // 
            // FrmLinkmanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 313);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddLinkman);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLinkmanList";
            this.Text = "联系人信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinkMan_Email;
        private System.Windows.Forms.TextBox txtLinkman_position;
        private System.Windows.Forms.TextBox txtLinkman_Comment;
        private System.Windows.Forms.TextBox txtLinkman_add;
        private System.Windows.Forms.TextBox txtLinkman_mobileP;
        private System.Windows.Forms.TextBox txtLinkman_nameE;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtLinkman_fax;
        private System.Windows.Forms.TextBox txtLinkman_phone;
        private System.Windows.Forms.TextBox txtLinkman_name;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button btnAddLinkman;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkman_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkman_nameE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkman_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkman_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkman_mobileP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkMan_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkman_fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkman_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.clientTableAdapter clientTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.linkmanTableAdapter linkmanTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientName;
    }
}