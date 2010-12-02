namespace HumanResources.Customer
{
    partial class UcCusromerSearch
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpContract_validS = new System.Windows.Forms.DateTimePicker();
            this.dtpContract_validE = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLinkman = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.llblTrade = new System.Windows.Forms.LinkLabel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.cboClient_hierarchy = new System.Windows.Forms.ComboBox();
            this.cboclientproperty = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboDimensions = new System.Windows.Forms.ComboBox();
            this.cboOwnership = new System.Windows.Forms.ComboBox();
            this.cboClient_status = new System.Windows.Forms.ComboBox();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.cityTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.cityTableAdapter();
            this.clientpropertyTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.clientpropertyTableAdapter();
            this.contractTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.contractTableAdapter();
            this.dimensionsTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.dimensionsTableAdapter();
            this.linkmanTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.linkmanTableAdapter();
            this.ownershipTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.ownershipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(73, 7);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(129, 21);
            this.txtClientName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "行业";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(454, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "地区";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "企业性质";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "企业规模";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Location = new System.Drawing.Point(247, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "信用状况";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "是否签约";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "合同有效期";
            // 
            // dtpContract_validS
            // 
            this.dtpContract_validS.Location = new System.Drawing.Point(74, 60);
            this.dtpContract_validS.Name = "dtpContract_validS";
            this.dtpContract_validS.Size = new System.Drawing.Size(128, 21);
            this.dtpContract_validS.TabIndex = 7;
            // 
            // dtpContract_validE
            // 
            this.dtpContract_validE.Location = new System.Drawing.Point(73, 87);
            this.dtpContract_validE.Name = "dtpContract_validE";
            this.dtpContract_validE.Size = new System.Drawing.Size(128, 21);
            this.dtpContract_validE.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "至";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(425, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "合作状态";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "所有制性质";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "联系人";
            // 
            // txtLinkman
            // 
            this.txtLinkman.Location = new System.Drawing.Point(73, 114);
            this.txtLinkman.Name = "txtLinkman";
            this.txtLinkman.Size = new System.Drawing.Size(128, 21);
            this.txtLinkman.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(218, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "电话";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(289, 113);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(223, 21);
            this.txtphone.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(425, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "重要级别";
            // 
            // llblTrade
            // 
            this.llblTrade.AutoSize = true;
            this.llblTrade.Location = new System.Drawing.Point(289, 11);
            this.llblTrade.Name = "llblTrade";
            this.llblTrade.Size = new System.Drawing.Size(41, 12);
            this.llblTrade.TabIndex = 2;
            this.llblTrade.TabStop = true;
            this.llblTrade.Tag = "0";
            this.llblTrade.Text = "无条件";
            this.llblTrade.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(126, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "是";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "否";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(73, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "不限";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // cboClient_hierarchy
            // 
            this.cboClient_hierarchy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClient_hierarchy.FormattingEnabled = true;
            this.cboClient_hierarchy.Items.AddRange(new object[] {
            "不限",
            "A",
            "B",
            "C",
            "D"});
            this.cboClient_hierarchy.Location = new System.Drawing.Point(486, 88);
            this.cboClient_hierarchy.Name = "cboClient_hierarchy";
            this.cboClient_hierarchy.Size = new System.Drawing.Size(108, 20);
            this.cboClient_hierarchy.TabIndex = 9;
            // 
            // cboclientproperty
            // 
            this.cboclientproperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclientproperty.FormattingEnabled = true;
            this.cboclientproperty.Items.AddRange(new object[] {
            "不限"});
            this.cboclientproperty.Location = new System.Drawing.Point(486, 30);
            this.cboclientproperty.Name = "cboclientproperty";
            this.cboclientproperty.Size = new System.Drawing.Size(108, 20);
            this.cboclientproperty.TabIndex = 9;
            // 
            // cboCity
            // 
            this.cboCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(486, 8);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(108, 20);
            this.cboCity.TabIndex = 9;
            // 
            // cboDimensions
            // 
            this.cboDimensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDimensions.FormattingEnabled = true;
            this.cboDimensions.Items.AddRange(new object[] {
            "不限"});
            this.cboDimensions.Location = new System.Drawing.Point(289, 34);
            this.cboDimensions.Name = "cboDimensions";
            this.cboDimensions.Size = new System.Drawing.Size(108, 20);
            this.cboDimensions.TabIndex = 9;
            // 
            // cboOwnership
            // 
            this.cboOwnership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOwnership.FormattingEnabled = true;
            this.cboOwnership.Items.AddRange(new object[] {
            "不限"});
            this.cboOwnership.Location = new System.Drawing.Point(289, 83);
            this.cboOwnership.Name = "cboOwnership";
            this.cboOwnership.Size = new System.Drawing.Size(108, 20);
            this.cboOwnership.TabIndex = 9;
            // 
            // cboClient_status
            // 
            this.cboClient_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClient_status.FormattingEnabled = true;
            this.cboClient_status.Items.AddRange(new object[] {
            "不限",
            "新客户",
            "现在客户",
            "过去客户"});
            this.cboClient_status.Location = new System.Drawing.Point(486, 60);
            this.cboClient_status.Name = "cboClient_status";
            this.cboClient_status.Size = new System.Drawing.Size(108, 20);
            this.cboClient_status.TabIndex = 9;
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
            this.tableAdapterManager1.clientpropertyTableAdapter = this.clientpropertyTableAdapter1;
            this.tableAdapterManager1.clientTableAdapter = null;
            this.tableAdapterManager1.contractTableAdapter = this.contractTableAdapter1;
            this.tableAdapterManager1.degreeTableAdapter = null;
            this.tableAdapterManager1.dimensionsTableAdapter = this.dimensionsTableAdapter1;
            this.tableAdapterManager1.educationTableAdapter = null;
            this.tableAdapterManager1.employeesnumberTableAdapter = null;
            this.tableAdapterManager1.evaluateTableAdapter = null;
            this.tableAdapterManager1.jobsdetailTableAdapter = null;
            this.tableAdapterManager1.jobsTableAdapter = null;
            this.tableAdapterManager1.linkmanTableAdapter = this.linkmanTableAdapter1;
            this.tableAdapterManager1.mingzTableAdapter = null;
            this.tableAdapterManager1.nationalityTableAdapter = null;
            this.tableAdapterManager1.operationmodelTableAdapter = null;
            this.tableAdapterManager1.order_stateTableAdapter = null;
            this.tableAdapterManager1.ordersTableAdapter = null;
            this.tableAdapterManager1.ownershipTableAdapter = this.ownershipTableAdapter1;
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
            this.tableAdapterManager1.usersTableAdapter = null;
            this.tableAdapterManager1.work_experienceTableAdapter = null;
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // clientpropertyTableAdapter1
            // 
            this.clientpropertyTableAdapter1.ClearBeforeFill = true;
            // 
            // contractTableAdapter1
            // 
            this.contractTableAdapter1.ClearBeforeFill = true;
            // 
            // dimensionsTableAdapter1
            // 
            this.dimensionsTableAdapter1.ClearBeforeFill = true;
            // 
            // linkmanTableAdapter1
            // 
            this.linkmanTableAdapter1.ClearBeforeFill = true;
            // 
            // ownershipTableAdapter1
            // 
            this.ownershipTableAdapter1.ClearBeforeFill = true;
            // 
            // UcCusromerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboClient_status);
            this.Controls.Add(this.cboOwnership);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.cboDimensions);
            this.Controls.Add(this.cboclientproperty);
            this.Controls.Add(this.cboClient_hierarchy);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.llblTrade);
            this.Controls.Add(this.dtpContract_validE);
            this.Controls.Add(this.dtpContract_validS);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtLinkman);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label1);
            this.Name = "UcCusromerSearch";
            this.Size = new System.Drawing.Size(606, 145);
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpContract_validS;
        private System.Windows.Forms.DateTimePicker dtpContract_validE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLinkman;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.LinkLabel llblTrade;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.contractTableAdapter contractTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.linkmanTableAdapter linkmanTableAdapter1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox cboClient_hierarchy;
        private System.Windows.Forms.ComboBox cboclientproperty;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ComboBox cboDimensions;
        private System.Windows.Forms.ComboBox cboOwnership;
        private HumanResources.humanresourcesDataSetTableAdapters.cityTableAdapter cityTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.ownershipTableAdapter ownershipTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.dimensionsTableAdapter dimensionsTableAdapter1;
        private System.Windows.Forms.ComboBox cboClient_status;
        private HumanResources.humanresourcesDataSetTableAdapters.clientpropertyTableAdapter clientpropertyTableAdapter1;
    }
}
