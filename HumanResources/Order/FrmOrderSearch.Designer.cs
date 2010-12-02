namespace HumanResources.Order
{
    partial class FrmOrderSearch
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSearchPanelVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.llblJobsDetail = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpOrder_StimeE = new System.Windows.Forms.DateTimePicker();
            this.dtpOrder_StimeS = new System.Windows.Forms.DateTimePicker();
            this.txtPositionN = new System.Windows.Forms.TextBox();
            this.txtClient_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboOrderState = new System.Windows.Forms.ComboBox();
            this.cbouser = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Stime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_positionN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_realname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOrderInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmirecommended = new System.Windows.Forms.ToolStripMenuItem();
            this.vw_orderTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.vw_orderTableAdapter();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.cityTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.cityTableAdapter();
            this.order_stateTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.order_stateTableAdapter();
            this.usersTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearchPanelVisible});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSearchPanelVisible
            // 
            this.tsmiSearchPanelVisible.Name = "tsmiSearchPanelVisible";
            this.tsmiSearchPanelVisible.Size = new System.Drawing.Size(672, 21);
            this.tsmiSearchPanelVisible.Text = "隐藏/显示查询面板";
            this.tsmiSearchPanelVisible.Click += new System.EventHandler(this.tsmiSearchPanelVisible_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.llblJobsDetail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpOrder_StimeE);
            this.panel1.Controls.Add(this.dtpOrder_StimeS);
            this.panel1.Controls.Add(this.txtPositionN);
            this.panel1.Controls.Add(this.txtClient_Name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboCity);
            this.panel1.Controls.Add(this.cboOrderState);
            this.panel1.Controls.Add(this.cbouser);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 117);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // llblJobsDetail
            // 
            this.llblJobsDetail.AutoSize = true;
            this.llblJobsDetail.Location = new System.Drawing.Point(75, 91);
            this.llblJobsDetail.Name = "llblJobsDetail";
            this.llblJobsDetail.Size = new System.Drawing.Size(41, 12);
            this.llblJobsDetail.TabIndex = 6;
            this.llblJobsDetail.TabStop = true;
            this.llblJobsDetail.Text = "请选择";
            this.llblJobsDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblJobsDetail_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "职位属性:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "职位名称:";
            // 
            // dtpOrder_StimeE
            // 
            this.dtpOrder_StimeE.Location = new System.Drawing.Point(342, 39);
            this.dtpOrder_StimeE.Name = "dtpOrder_StimeE";
            this.dtpOrder_StimeE.Size = new System.Drawing.Size(200, 21);
            this.dtpOrder_StimeE.TabIndex = 4;
            // 
            // dtpOrder_StimeS
            // 
            this.dtpOrder_StimeS.Location = new System.Drawing.Point(101, 39);
            this.dtpOrder_StimeS.Name = "dtpOrder_StimeS";
            this.dtpOrder_StimeS.Size = new System.Drawing.Size(200, 21);
            this.dtpOrder_StimeS.TabIndex = 4;
            this.dtpOrder_StimeS.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtPositionN
            // 
            this.txtPositionN.Location = new System.Drawing.Point(77, 63);
            this.txtPositionN.Name = "txtPositionN";
            this.txtPositionN.Size = new System.Drawing.Size(122, 21);
            this.txtPositionN.TabIndex = 3;
            // 
            // txtClient_Name
            // 
            this.txtClient_Name.Location = new System.Drawing.Point(272, 15);
            this.txtClient_Name.Name = "txtClient_Name";
            this.txtClient_Name.Size = new System.Drawing.Size(100, 21);
            this.txtClient_Name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "客户名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "至";
            // 
            // cboCity
            // 
            this.cboCity.AutoCompleteCustomSource.AddRange(new string[] {
            "成都市"});
            this.cboCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(273, 63);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(121, 20);
            this.cboCity.TabIndex = 1;
            // 
            // cboOrderState
            // 
            this.cboOrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderState.FormattingEnabled = true;
            this.cboOrderState.Location = new System.Drawing.Point(445, 15);
            this.cboOrderState.Name = "cboOrderState";
            this.cboOrderState.Size = new System.Drawing.Size(121, 20);
            this.cboOrderState.TabIndex = 1;
            // 
            // cbouser
            // 
            this.cbouser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbouser.FormattingEnabled = true;
            this.cbouser.Location = new System.Drawing.Point(78, 15);
            this.cbouser.Name = "cbouser";
            this.cbouser.Size = new System.Drawing.Size(121, 20);
            this.cbouser.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "所在城市:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "订单状态:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "订单开始时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属顾问:";
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
            this.client_name,
            this.Order_Stime,
            this.Order_positionN,
            this.city_name,
            this.订单状态,
            this.user_realname});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(679, 547);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // client_name
            // 
            this.client_name.DataPropertyName = "client_name";
            this.client_name.HeaderText = "客户名称";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            // 
            // Order_Stime
            // 
            this.Order_Stime.DataPropertyName = "Order_Stime";
            this.Order_Stime.HeaderText = "订单开始时间";
            this.Order_Stime.Name = "Order_Stime";
            this.Order_Stime.ReadOnly = true;
            // 
            // Order_positionN
            // 
            this.Order_positionN.DataPropertyName = "Order_positionN";
            this.Order_positionN.HeaderText = "职位名称";
            this.Order_positionN.Name = "Order_positionN";
            this.Order_positionN.ReadOnly = true;
            // 
            // city_name
            // 
            this.city_name.DataPropertyName = "city_name";
            this.city_name.HeaderText = "所在城市";
            this.city_name.Name = "city_name";
            this.city_name.ReadOnly = true;
            // 
            // 订单状态
            // 
            this.订单状态.DataPropertyName = "Order_State_Name";
            this.订单状态.HeaderText = "订单状态";
            this.订单状态.Name = "订单状态";
            this.订单状态.ReadOnly = true;
            // 
            // user_realname
            // 
            this.user_realname.DataPropertyName = "user_realname";
            this.user_realname.HeaderText = "所属顾问";
            this.user_realname.Name = "user_realname";
            this.user_realname.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrderInfo,
            this.tsmiClientinfo,
            this.tsmiUserInfo,
            this.tsmirecommended});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 92);
            // 
            // tsmiOrderInfo
            // 
            this.tsmiOrderInfo.Name = "tsmiOrderInfo";
            this.tsmiOrderInfo.Size = new System.Drawing.Size(148, 22);
            this.tsmiOrderInfo.Text = "查看详细";
            this.tsmiOrderInfo.Click += new System.EventHandler(this.tsmiOrderInfo_Click);
            // 
            // tsmiClientinfo
            // 
            this.tsmiClientinfo.Name = "tsmiClientinfo";
            this.tsmiClientinfo.Size = new System.Drawing.Size(148, 22);
            this.tsmiClientinfo.Text = "查看客户详情";
            this.tsmiClientinfo.Click += new System.EventHandler(this.tsmiClientinfo_Click);
            // 
            // tsmiUserInfo
            // 
            this.tsmiUserInfo.Name = "tsmiUserInfo";
            this.tsmiUserInfo.Size = new System.Drawing.Size(148, 22);
            this.tsmiUserInfo.Text = "查看顾问详情";
            this.tsmiUserInfo.Click += new System.EventHandler(this.tsmiUserInfo_Click);
            // 
            // tsmirecommended
            // 
            this.tsmirecommended.Name = "tsmirecommended";
            this.tsmirecommended.Size = new System.Drawing.Size(148, 22);
            this.tsmirecommended.Text = "推荐候选人";
            this.tsmirecommended.Click += new System.EventHandler(this.tsmirecommended_Click);
            // 
            // vw_orderTableAdapter1
            // 
            this.vw_orderTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager1.cityTableAdapter = this.cityTableAdapter1;
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
            this.tableAdapterManager1.order_stateTableAdapter = this.order_stateTableAdapter1;
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
            this.tableAdapterManager1.tradeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = this.usersTableAdapter1;
            this.tableAdapterManager1.work_experienceTableAdapter = null;
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // order_stateTableAdapter1
            // 
            this.order_stateTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmOrderSearch";
            this.Text = "FrmOrderSearch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchPanelVisible;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbouser;
        private System.Windows.Forms.TextBox txtClient_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpOrder_StimeE;
        private System.Windows.Forms.DateTimePicker dtpOrder_StimeS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llblJobsDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPositionN;
        private System.Windows.Forms.ComboBox cboOrderState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrderInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientinfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmirecommended;
        private HumanResources.humanresourcesDataSetTableAdapters.vw_orderTableAdapter vw_orderTableAdapter1;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.cityTableAdapter cityTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.order_stateTableAdapter order_stateTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Stime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_positionN;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_realname;
    }
}