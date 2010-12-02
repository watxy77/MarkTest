namespace HumanResources.Customer
{
    partial class FrmCusromerSearchSemple
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_nameE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrderList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLinkmanList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientFollow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContract = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucCusromerSearch2 = new HumanResources.Customer.UcCusromerSearch();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmishow = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.clientTableAdapter();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client_name,
            this.Client_nameE,
            this.Client_add});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(896, 348);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // Client_name
            // 
            this.Client_name.DataPropertyName = "Client_name";
            this.Client_name.HeaderText = "客户名称(中)";
            this.Client_name.Name = "Client_name";
            this.Client_name.ReadOnly = true;
            // 
            // Client_nameE
            // 
            this.Client_nameE.DataPropertyName = "Client_nameE";
            this.Client_nameE.HeaderText = "客户名称(英)";
            this.Client_nameE.Name = "Client_nameE";
            this.Client_nameE.ReadOnly = true;
            // 
            // Client_add
            // 
            this.Client_add.DataPropertyName = "Client_add";
            this.Client_add.HeaderText = "客户地址";
            this.Client_add.Name = "Client_add";
            this.Client_add.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheck,
            this.tsmiClientInfo,
            this.tsmiAddOrder,
            this.tsmiOrderList,
            this.tsmiLinkmanList,
            this.tsmiClientFollow,
            this.tsmiContract,
            this.tsmiEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 202);
            // 
            // tsmiCheck
            // 
            this.tsmiCheck.Name = "tsmiCheck";
            this.tsmiCheck.Size = new System.Drawing.Size(152, 22);
            this.tsmiCheck.Text = "选定";
            this.tsmiCheck.Click += new System.EventHandler(this.tsmiCheck_Click);
            // 
            // tsmiClientInfo
            // 
            this.tsmiClientInfo.Name = "tsmiClientInfo";
            this.tsmiClientInfo.Size = new System.Drawing.Size(152, 22);
            this.tsmiClientInfo.Text = "查看详细";
            this.tsmiClientInfo.Click += new System.EventHandler(this.tsmiClientInfo_Click);
            // 
            // tsmiAddOrder
            // 
            this.tsmiAddOrder.Name = "tsmiAddOrder";
            this.tsmiAddOrder.Size = new System.Drawing.Size(152, 22);
            this.tsmiAddOrder.Text = "添加订单";
            this.tsmiAddOrder.Click += new System.EventHandler(this.tsmiAddOrder_Click);
            // 
            // tsmiOrderList
            // 
            this.tsmiOrderList.Name = "tsmiOrderList";
            this.tsmiOrderList.Size = new System.Drawing.Size(152, 22);
            this.tsmiOrderList.Text = "订单列表";
            this.tsmiOrderList.Click += new System.EventHandler(this.tsmiOrderList_Click);
            // 
            // tsmiLinkmanList
            // 
            this.tsmiLinkmanList.Name = "tsmiLinkmanList";
            this.tsmiLinkmanList.Size = new System.Drawing.Size(152, 22);
            this.tsmiLinkmanList.Text = "联系人列表";
            this.tsmiLinkmanList.Click += new System.EventHandler(this.tsmiLinkmanList_Click);
            // 
            // tsmiClientFollow
            // 
            this.tsmiClientFollow.Name = "tsmiClientFollow";
            this.tsmiClientFollow.Size = new System.Drawing.Size(152, 22);
            this.tsmiClientFollow.Text = "跟进日程";
            this.tsmiClientFollow.Click += new System.EventHandler(this.tsmiClientFollow_Click);
            // 
            // tsmiContract
            // 
            this.tsmiContract.Name = "tsmiContract";
            this.tsmiContract.Size = new System.Drawing.Size(152, 22);
            this.tsmiContract.Text = "合同信息";
            this.tsmiContract.Click += new System.EventHandler(this.tsmiContract_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(817, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Size = new System.Drawing.Size(896, 410);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucCusromerSearch2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 180);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // ucCusromerSearch2
            // 
            this.ucCusromerSearch2.Location = new System.Drawing.Point(11, 3);
            this.ucCusromerSearch2.Name = "ucCusromerSearch2";
            this.ucCusromerSearch2.Size = new System.Drawing.Size(603, 145);
            this.ucCusromerSearch2.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(509, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmishow});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmishow
            // 
            this.tsmishow.Name = "tsmishow";
            this.tsmishow.Padding = new System.Windows.Forms.Padding(0);
            this.tsmishow.Size = new System.Drawing.Size(889, 21);
            this.tsmishow.Text = "显示/隐藏查询界面";
            this.tsmishow.Click += new System.EventHandler(this.tsmishow_Click);
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
            this.tableAdapterManager1.linkmanTableAdapter = null;
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
            // humanresourcesDataSet1
            // 
            this.humanresourcesDataSet1.DataSetName = "humanresourcesDataSet";
            this.humanresourcesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(152, 22);
            this.tsmiEdit.Text = "修改";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // FrmCusromerSearchSemple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 410);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCusromerSearchSemple";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "客户查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheck;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmishow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_nameE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_add;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrderList;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.clientTableAdapter clientTableAdapter1;
        private UcCusromerSearch ucCusromerSearch2;
        private System.Windows.Forms.ToolStripMenuItem tsmiLinkmanList;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientFollow;
        private System.Windows.Forms.ToolStripMenuItem tsmiContract;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
    }
}