namespace HumanResources.Order
{
    partial class FrmRecommended
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblclient_name = new System.Windows.Forms.Label();
            this.lblOrder_positionN = new System.Windows.Forms.Label();
            this.lblOrder_Stime = new System.Windows.Forms.Label();
            this.lbluser_realname = new System.Windows.Forms.Label();
            this.btnCandidateInsert = new System.Windows.Forms.Button();
            this.btnDelCandidate = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Recommended_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Candidate_id_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Candidate_id_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommended_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiChangeState = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recommended_stateDataGridView = new System.Windows.Forms.DataGridView();
            this.Recommended_State_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangeStateCancel = new System.Windows.Forms.Button();
            this.btnChangeStateSure = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCandidateNameInCSP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vw_orderTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.vw_orderTableAdapter();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.candidateTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.candidateTableAdapter();
            this.recommended_state_remarkTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.recommended_state_remarkTableAdapter();
            this.recommended_stateTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.recommended_stateTableAdapter();
            this.recommendedTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.recommendedTableAdapter();
            this.usersTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter();
            this.btnUp = new System.Windows.Forms.Button();
            this.tsmiFace = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recommended_stateDataGridView)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "职位名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "订单开始时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "所属顾问:";
            // 
            // lblclient_name
            // 
            this.lblclient_name.AutoSize = true;
            this.lblclient_name.Location = new System.Drawing.Point(68, 9);
            this.lblclient_name.Name = "lblclient_name";
            this.lblclient_name.Size = new System.Drawing.Size(29, 12);
            this.lblclient_name.TabIndex = 0;
            this.lblclient_name.Text = "数据";
            // 
            // lblOrder_positionN
            // 
            this.lblOrder_positionN.AutoSize = true;
            this.lblOrder_positionN.Location = new System.Drawing.Point(202, 9);
            this.lblOrder_positionN.Name = "lblOrder_positionN";
            this.lblOrder_positionN.Size = new System.Drawing.Size(29, 12);
            this.lblOrder_positionN.TabIndex = 0;
            this.lblOrder_positionN.Text = "数据";
            // 
            // lblOrder_Stime
            // 
            this.lblOrder_Stime.AutoSize = true;
            this.lblOrder_Stime.Location = new System.Drawing.Point(359, 9);
            this.lblOrder_Stime.Name = "lblOrder_Stime";
            this.lblOrder_Stime.Size = new System.Drawing.Size(29, 12);
            this.lblOrder_Stime.TabIndex = 0;
            this.lblOrder_Stime.Text = "数据";
            // 
            // lbluser_realname
            // 
            this.lbluser_realname.AutoSize = true;
            this.lbluser_realname.Location = new System.Drawing.Point(527, 9);
            this.lbluser_realname.Name = "lbluser_realname";
            this.lbluser_realname.Size = new System.Drawing.Size(29, 12);
            this.lbluser_realname.TabIndex = 0;
            this.lbluser_realname.Text = "数据";
            // 
            // btnCandidateInsert
            // 
            this.btnCandidateInsert.Location = new System.Drawing.Point(554, 114);
            this.btnCandidateInsert.Name = "btnCandidateInsert";
            this.btnCandidateInsert.Size = new System.Drawing.Size(30, 30);
            this.btnCandidateInsert.TabIndex = 5;
            this.btnCandidateInsert.Text = "＋";
            this.btnCandidateInsert.UseVisualStyleBackColor = true;
            this.btnCandidateInsert.Click += new System.EventHandler(this.btnCandidateInsert_Click);
            // 
            // btnDelCandidate
            // 
            this.btnDelCandidate.Enabled = false;
            this.btnDelCandidate.Location = new System.Drawing.Point(554, 150);
            this.btnDelCandidate.Name = "btnDelCandidate";
            this.btnDelCandidate.Size = new System.Drawing.Size(30, 30);
            this.btnDelCandidate.TabIndex = 6;
            this.btnDelCandidate.Text = "×";
            this.btnDelCandidate.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(554, 78);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 30);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Recommended_Order,
            this.Candidate_id_Name,
            this.Candidate_id_Phone,
            this.recommended_state});
            this.dataGridView1.Location = new System.Drawing.Point(14, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(534, 184);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Recommended_Order
            // 
            this.Recommended_Order.DataPropertyName = "Recommended_Order";
            this.Recommended_Order.HeaderText = "序号";
            this.Recommended_Order.Name = "Recommended_Order";
            this.Recommended_Order.ReadOnly = true;
            // 
            // Candidate_id_Name
            // 
            this.Candidate_id_Name.HeaderText = "姓名";
            this.Candidate_id_Name.Name = "Candidate_id_Name";
            this.Candidate_id_Name.ReadOnly = true;
            // 
            // Candidate_id_Phone
            // 
            this.Candidate_id_Phone.HeaderText = "电话";
            this.Candidate_id_Phone.Name = "Candidate_id_Phone";
            this.Candidate_id_Phone.ReadOnly = true;
            // 
            // recommended_state
            // 
            this.recommended_state.HeaderText = "状态";
            this.recommended_state.Name = "recommended_state";
            this.recommended_state.ReadOnly = true;
            this.recommended_state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recommended_state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangeState,
            this.tsmiFace});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmiChangeState
            // 
            this.tsmiChangeState.Name = "tsmiChangeState";
            this.tsmiChangeState.Size = new System.Drawing.Size(152, 22);
            this.tsmiChangeState.Text = "更改状态";
            this.tsmiChangeState.Click += new System.EventHandler(this.tsmiChangeState_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(509, 231);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "订单详情";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(428, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.recommended_stateDataGridView);
            this.panel2.Controls.Add(this.btnChangeStateCancel);
            this.panel2.Controls.Add(this.btnChangeStateSure);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(167, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 178);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // recommended_stateDataGridView
            // 
            this.recommended_stateDataGridView.AllowUserToAddRows = false;
            this.recommended_stateDataGridView.AllowUserToDeleteRows = false;
            this.recommended_stateDataGridView.AllowUserToResizeColumns = false;
            this.recommended_stateDataGridView.AllowUserToResizeRows = false;
            this.recommended_stateDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recommended_stateDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.recommended_stateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recommended_stateDataGridView.ColumnHeadersVisible = false;
            this.recommended_stateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Recommended_State_Name});
            this.recommended_stateDataGridView.Location = new System.Drawing.Point(12, 25);
            this.recommended_stateDataGridView.MultiSelect = false;
            this.recommended_stateDataGridView.Name = "recommended_stateDataGridView";
            this.recommended_stateDataGridView.ReadOnly = true;
            this.recommended_stateDataGridView.RowHeadersVisible = false;
            this.recommended_stateDataGridView.RowTemplate.Height = 23;
            this.recommended_stateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recommended_stateDataGridView.Size = new System.Drawing.Size(171, 113);
            this.recommended_stateDataGridView.TabIndex = 3;
            // 
            // Recommended_State_Name
            // 
            this.Recommended_State_Name.DataPropertyName = "Recommended_State_Name";
            this.Recommended_State_Name.HeaderText = "Recommended_State_Name";
            this.Recommended_State_Name.Name = "Recommended_State_Name";
            this.Recommended_State_Name.ReadOnly = true;
            // 
            // btnChangeStateCancel
            // 
            this.btnChangeStateCancel.Location = new System.Drawing.Point(103, 144);
            this.btnChangeStateCancel.Name = "btnChangeStateCancel";
            this.btnChangeStateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnChangeStateCancel.TabIndex = 2;
            this.btnChangeStateCancel.Text = "取消";
            this.btnChangeStateCancel.UseVisualStyleBackColor = true;
            this.btnChangeStateCancel.Click += new System.EventHandler(this.btnChangeStateCancel_Click);
            // 
            // btnChangeStateSure
            // 
            this.btnChangeStateSure.Location = new System.Drawing.Point(22, 144);
            this.btnChangeStateSure.Name = "btnChangeStateSure";
            this.btnChangeStateSure.Size = new System.Drawing.Size(75, 23);
            this.btnChangeStateSure.TabIndex = 2;
            this.btnChangeStateSure.Text = "确定";
            this.btnChangeStateSure.UseVisualStyleBackColor = true;
            this.btnChangeStateSure.Click += new System.EventHandler(this.btnChangeStateSure_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.lblCandidateNameInCSP);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(171, 12);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "将候选人";
            // 
            // lblCandidateNameInCSP
            // 
            this.lblCandidateNameInCSP.AutoSize = true;
            this.lblCandidateNameInCSP.ForeColor = System.Drawing.Color.Red;
            this.lblCandidateNameInCSP.Location = new System.Drawing.Point(53, 0);
            this.lblCandidateNameInCSP.Margin = new System.Windows.Forms.Padding(0);
            this.lblCandidateNameInCSP.Name = "lblCandidateNameInCSP";
            this.lblCandidateNameInCSP.Size = new System.Drawing.Size(53, 12);
            this.lblCandidateNameInCSP.TabIndex = 0;
            this.lblCandidateNameInCSP.Text = "{候选人}";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "状态更改为";
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
            this.tableAdapterManager1.candidateTableAdapter = this.candidateTableAdapter1;
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
            this.tableAdapterManager1.recommended_state_remarkTableAdapter = this.recommended_state_remarkTableAdapter1;
            this.tableAdapterManager1.recommended_stateTableAdapter = this.recommended_stateTableAdapter1;
            this.tableAdapterManager1.recommendedTableAdapter = this.recommendedTableAdapter1;
            this.tableAdapterManager1.recruitment_quantityTableAdapter = null;
            this.tableAdapterManager1.recruitmentTableAdapter = null;
            this.tableAdapterManager1.resumeTableAdapter = null;
            this.tableAdapterManager1.rightsTableAdapter = null;
            this.tableAdapterManager1.rolesTableAdapter = null;
            this.tableAdapterManager1.teamTableAdapter = null;
            this.tableAdapterManager1.tradeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = this.usersTableAdapter1;
            this.tableAdapterManager1.weeklyc_detailsTableAdapter = null;
            this.tableAdapterManager1.weeklyc_particularsTableAdapter = null;
            this.tableAdapterManager1.wekkly_consultantTableAdapter = null;
            this.tableAdapterManager1.work_experienceTableAdapter = null;
            // 
            // candidateTableAdapter1
            // 
            this.candidateTableAdapter1.ClearBeforeFill = true;
            // 
            // recommended_state_remarkTableAdapter1
            // 
            this.recommended_state_remarkTableAdapter1.ClearBeforeFill = true;
            // 
            // recommended_stateTableAdapter1
            // 
            this.recommended_stateTableAdapter1.ClearBeforeFill = true;
            // 
            // recommendedTableAdapter1
            // 
            this.recommendedTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(554, 41);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 30);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // tsmiFace
            // 
            this.tsmiFace.Name = "tsmiFace";
            this.tsmiFace.Size = new System.Drawing.Size(152, 22);
            this.tsmiFace.Text = "添加面试信息";
            this.tsmiFace.Click += new System.EventHandler(this.tsmiFace_Click);
            // 
            // FrmRecommended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 274);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnCandidateInsert);
            this.Controls.Add(this.lbluser_realname);
            this.Controls.Add(this.btnDelCandidate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOrder_Stime);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOrder_positionN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblclient_name);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecommended";
            this.Text = "推荐候选人";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recommended_stateDataGridView)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HumanResources.humanresourcesDataSetTableAdapters.vw_orderTableAdapter vw_orderTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblclient_name;
        private System.Windows.Forms.Label lblOrder_positionN;
        private System.Windows.Forms.Label lblOrder_Stime;
        private System.Windows.Forms.Label lbluser_realname;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnCandidateInsert;
        private System.Windows.Forms.Button btnDelCandidate;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recommended_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidate_id_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidate_id_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommended_state;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChangeStateCancel;
        private System.Windows.Forms.Button btnChangeStateSure;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCandidateNameInCSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeState;
        private System.Windows.Forms.DataGridView recommended_stateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recommended_State_Name;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.recommended_state_remarkTableAdapter recommended_state_remarkTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.recommended_stateTableAdapter recommended_stateTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.recommendedTableAdapter recommendedTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.candidateTableAdapter candidateTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFace;
    }
}