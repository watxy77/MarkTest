namespace HumanResources.Customer
{
    partial class FrmContractList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txtContractComment = new System.Windows.Forms.TextBox();
            this.txtContract_guaranteeT = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.txtContract_payment = new System.Windows.Forms.TextBox();
            this.txtContract_number = new System.Windows.Forms.TextBox();
            this.txtContract_rate = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.lblContractComment = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtContract_guaranteeD = new System.Windows.Forms.TextBox();
            this.dtpContract_validS = new System.Windows.Forms.DateTimePicker();
            this.label44 = new System.Windows.Forms.Label();
            this.dtpContract_validE = new System.Windows.Forms.DateTimePicker();
            this.txtContract_calculate = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblContract_guaranteeD = new System.Windows.Forms.Label();
            this.lblContract_validS = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblContract_calculate = new System.Windows.Forms.Label();
            this.lblContract_guaranteeT = new System.Windows.Forms.Label();
            this.lblContract_rate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblContract_validE = new System.Windows.Forms.Label();
            this.lblContract_number = new System.Windows.Forms.Label();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.clientTableAdapter();
            this.contractTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.contractTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label48);
            this.panel1.Controls.Add(this.label47);
            this.panel1.Controls.Add(this.txtContractComment);
            this.panel1.Controls.Add(this.txtContract_guaranteeT);
            this.panel1.Controls.Add(this.label69);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.txtContract_payment);
            this.panel1.Controls.Add(this.txtContract_number);
            this.panel1.Controls.Add(this.txtContract_rate);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.lblContractComment);
            this.panel1.Controls.Add(this.label52);
            this.panel1.Controls.Add(this.txtContract_guaranteeD);
            this.panel1.Controls.Add(this.dtpContract_validS);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.dtpContract_validE);
            this.panel1.Controls.Add(this.txtContract_calculate);
            this.panel1.Controls.Add(this.label51);
            this.panel1.Location = new System.Drawing.Point(175, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 223);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(240, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(15, 14);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(59, 12);
            this.label48.TabIndex = 11;
            this.label48.Text = "合同编号:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(219, 39);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(23, 12);
            this.label47.TabIndex = 12;
            this.label47.Text = "至:";
            // 
            // txtContractComment
            // 
            this.txtContractComment.Location = new System.Drawing.Point(87, 136);
            this.txtContractComment.Multiline = true;
            this.txtContractComment.Name = "txtContractComment";
            this.txtContractComment.Size = new System.Drawing.Size(309, 52);
            this.txtContractComment.TabIndex = 19;
            // 
            // txtContract_guaranteeT
            // 
            this.txtContract_guaranteeT.Location = new System.Drawing.Point(296, 106);
            this.txtContract_guaranteeT.Name = "txtContract_guaranteeT";
            this.txtContract_guaranteeT.Size = new System.Drawing.Size(100, 21);
            this.txtContract_guaranteeT.TabIndex = 17;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(231, 62);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(59, 12);
            this.label69.TabIndex = 10;
            this.label69.Text = "付款周期:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(15, 61);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(35, 12);
            this.label49.TabIndex = 9;
            this.label49.Text = "费率:";
            // 
            // txtContract_payment
            // 
            this.txtContract_payment.Location = new System.Drawing.Point(296, 58);
            this.txtContract_payment.Name = "txtContract_payment";
            this.txtContract_payment.Size = new System.Drawing.Size(100, 21);
            this.txtContract_payment.TabIndex = 21;
            // 
            // txtContract_number
            // 
            this.txtContract_number.Location = new System.Drawing.Point(87, 11);
            this.txtContract_number.Name = "txtContract_number";
            this.txtContract_number.Size = new System.Drawing.Size(100, 21);
            this.txtContract_number.TabIndex = 18;
            // 
            // txtContract_rate
            // 
            this.txtContract_rate.Location = new System.Drawing.Point(87, 59);
            this.txtContract_rate.Name = "txtContract_rate";
            this.txtContract_rate.Size = new System.Drawing.Size(100, 21);
            this.txtContract_rate.TabIndex = 16;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(15, 86);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(59, 12);
            this.label50.TabIndex = 4;
            this.label50.Text = "计算公式:";
            // 
            // lblContractComment
            // 
            this.lblContractComment.AutoSize = true;
            this.lblContractComment.Location = new System.Drawing.Point(15, 139);
            this.lblContractComment.Name = "lblContractComment";
            this.lblContractComment.Size = new System.Drawing.Size(35, 12);
            this.lblContractComment.TabIndex = 6;
            this.lblContractComment.Text = "备注:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(231, 110);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(59, 12);
            this.label52.TabIndex = 8;
            this.label52.Text = "担保责任:";
            // 
            // txtContract_guaranteeD
            // 
            this.txtContract_guaranteeD.Location = new System.Drawing.Point(87, 107);
            this.txtContract_guaranteeD.Name = "txtContract_guaranteeD";
            this.txtContract_guaranteeD.Size = new System.Drawing.Size(100, 21);
            this.txtContract_guaranteeD.TabIndex = 20;
            // 
            // dtpContract_validS
            // 
            this.dtpContract_validS.Location = new System.Drawing.Point(87, 35);
            this.dtpContract_validS.Name = "dtpContract_validS";
            this.dtpContract_validS.Size = new System.Drawing.Size(123, 21);
            this.dtpContract_validS.TabIndex = 14;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(15, 38);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(71, 12);
            this.label44.TabIndex = 7;
            this.label44.Text = "合同有效期:";
            // 
            // dtpContract_validE
            // 
            this.dtpContract_validE.Location = new System.Drawing.Point(248, 35);
            this.dtpContract_validE.Name = "dtpContract_validE";
            this.dtpContract_validE.Size = new System.Drawing.Size(148, 21);
            this.dtpContract_validE.TabIndex = 13;
            // 
            // txtContract_calculate
            // 
            this.txtContract_calculate.Location = new System.Drawing.Point(87, 83);
            this.txtContract_calculate.Name = "txtContract_calculate";
            this.txtContract_calculate.Size = new System.Drawing.Size(100, 21);
            this.txtContract_calculate.TabIndex = 15;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(15, 110);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(47, 12);
            this.label51.TabIndex = 5;
            this.label51.Text = "担保期:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(9, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(160, 269);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(432, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加合同";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(513, 275);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(77, 9);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(0, 12);
            this.lblClientName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "客户名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "合同编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "至:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "付款周期:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "费率:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "计算公式:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "备注:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "担保责任:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "合同有效期:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "担保期:";
            // 
            // lblContract_guaranteeD
            // 
            this.lblContract_guaranteeD.AutoSize = true;
            this.lblContract_guaranteeD.Location = new System.Drawing.Point(414, 125);
            this.lblContract_guaranteeD.Name = "lblContract_guaranteeD";
            this.lblContract_guaranteeD.Size = new System.Drawing.Size(59, 12);
            this.lblContract_guaranteeD.TabIndex = 27;
            this.lblContract_guaranteeD.Text = "担保责任:";
            // 
            // lblContract_validS
            // 
            this.lblContract_validS.AutoSize = true;
            this.lblContract_validS.Location = new System.Drawing.Point(260, 53);
            this.lblContract_validS.Name = "lblContract_validS";
            this.lblContract_validS.Size = new System.Drawing.Size(71, 12);
            this.lblContract_validS.TabIndex = 26;
            this.lblContract_validS.Text = "合同有效期:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(260, 154);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(35, 12);
            this.lblComment.TabIndex = 25;
            this.lblComment.Text = "备注:";
            // 
            // lblContract_calculate
            // 
            this.lblContract_calculate.AutoSize = true;
            this.lblContract_calculate.Location = new System.Drawing.Point(260, 101);
            this.lblContract_calculate.Name = "lblContract_calculate";
            this.lblContract_calculate.Size = new System.Drawing.Size(59, 12);
            this.lblContract_calculate.TabIndex = 23;
            this.lblContract_calculate.Text = "计算公式:";
            // 
            // lblContract_guaranteeT
            // 
            this.lblContract_guaranteeT.AutoSize = true;
            this.lblContract_guaranteeT.Location = new System.Drawing.Point(260, 125);
            this.lblContract_guaranteeT.Name = "lblContract_guaranteeT";
            this.lblContract_guaranteeT.Size = new System.Drawing.Size(47, 12);
            this.lblContract_guaranteeT.TabIndex = 24;
            this.lblContract_guaranteeT.Text = "担保期:";
            // 
            // lblContract_rate
            // 
            this.lblContract_rate.AutoSize = true;
            this.lblContract_rate.Location = new System.Drawing.Point(260, 76);
            this.lblContract_rate.Name = "lblContract_rate";
            this.lblContract_rate.Size = new System.Drawing.Size(35, 12);
            this.lblContract_rate.TabIndex = 28;
            this.lblContract_rate.Text = "费率:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(414, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 29;
            this.label17.Text = "付款周期:";
            // 
            // lblContract_validE
            // 
            this.lblContract_validE.AutoSize = true;
            this.lblContract_validE.Location = new System.Drawing.Point(378, 53);
            this.lblContract_validE.Name = "lblContract_validE";
            this.lblContract_validE.Size = new System.Drawing.Size(23, 12);
            this.lblContract_validE.TabIndex = 31;
            this.lblContract_validE.Text = "至:";
            // 
            // lblContract_number
            // 
            this.lblContract_number.AutoSize = true;
            this.lblContract_number.Location = new System.Drawing.Point(260, 29);
            this.lblContract_number.Name = "lblContract_number";
            this.lblContract_number.Size = new System.Drawing.Size(59, 12);
            this.lblContract_number.TabIndex = 30;
            this.lblContract_number.Text = "合同编号:";
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
            this.tableAdapterManager1.contractTableAdapter = this.contractTableAdapter1;
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
            // contractTableAdapter1
            // 
            this.contractTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 310);
            this.Controls.Add(this.lblContract_number);
            this.Controls.Add(this.lblContract_validE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblContract_rate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblContract_guaranteeT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblContract_calculate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblContract_validS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblContract_guaranteeD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "FrmContractList";
            this.Text = "合同信息";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtContractComment;
        private System.Windows.Forms.TextBox txtContract_guaranteeT;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtContract_payment;
        private System.Windows.Forms.TextBox txtContract_number;
        private System.Windows.Forms.TextBox txtContract_rate;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label lblContractComment;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtContract_guaranteeD;
        private System.Windows.Forms.DateTimePicker dtpContract_validS;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.DateTimePicker dtpContract_validE;
        private System.Windows.Forms.TextBox txtContract_calculate;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label1;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.clientTableAdapter clientTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.contractTableAdapter contractTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblContract_guaranteeD;
        private System.Windows.Forms.Label lblContract_validS;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblContract_calculate;
        private System.Windows.Forms.Label lblContract_guaranteeT;
        private System.Windows.Forms.Label lblContract_rate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblContract_validE;
        private System.Windows.Forms.Label lblContract_number;
    }
}