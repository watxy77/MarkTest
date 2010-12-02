namespace HumanResources.Invoice
{
    partial class FrmInvoiceAdd
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
            System.Windows.Forms.Label invoice_guaranteeLabel;
            System.Windows.Forms.Label invoice_paymentTypeLabel;
            System.Windows.Forms.Label invoice_moneyLabel;
            System.Windows.Forms.Label invoice_paymentTLabel;
            System.Windows.Forms.Label invoice_endTLabel;
            System.Windows.Forms.Label Invoice_costLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label71;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.dtpInvoice_endT = new System.Windows.Forms.DateTimePicker();
            this.nudInvoice_cost = new System.Windows.Forms.NumericUpDown();
            this.nudInvoice_guarantee = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.nudInvoice_money = new System.Windows.Forms.NumericUpDown();
            this.nudInvoice_paymentT = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.humanresourcesDataSet = new HumanResources.humanresourcesDataSet();
            this.invoiceTableAdapter = new HumanResources.humanresourcesDataSetTableAdapters.invoiceTableAdapter();
            this.tableAdapterManager = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.dtpInvoice_WorkDate = new System.Windows.Forms.DateTimePicker();
            invoice_guaranteeLabel = new System.Windows.Forms.Label();
            invoice_paymentTypeLabel = new System.Windows.Forms.Label();
            invoice_moneyLabel = new System.Windows.Forms.Label();
            invoice_paymentTLabel = new System.Windows.Forms.Label();
            invoice_endTLabel = new System.Windows.Forms.Label();
            Invoice_costLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label71 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoice_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoice_guarantee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoice_money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoice_paymentT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice_guaranteeLabel
            // 
            invoice_guaranteeLabel.AutoSize = true;
            invoice_guaranteeLabel.Location = new System.Drawing.Point(19, 53);
            invoice_guaranteeLabel.Name = "invoice_guaranteeLabel";
            invoice_guaranteeLabel.Size = new System.Drawing.Size(47, 12);
            invoice_guaranteeLabel.TabIndex = 3;
            invoice_guaranteeLabel.Text = "担保期:";
            // 
            // invoice_paymentTypeLabel
            // 
            invoice_paymentTypeLabel.AutoSize = true;
            invoice_paymentTypeLabel.Location = new System.Drawing.Point(257, 79);
            invoice_paymentTypeLabel.Name = "invoice_paymentTypeLabel";
            invoice_paymentTypeLabel.Size = new System.Drawing.Size(53, 12);
            invoice_paymentTypeLabel.TabIndex = 5;
            invoice_paymentTypeLabel.Text = "付款期数";
            // 
            // invoice_moneyLabel
            // 
            invoice_moneyLabel.AutoSize = true;
            invoice_moneyLabel.Location = new System.Drawing.Point(257, 27);
            invoice_moneyLabel.Name = "invoice_moneyLabel";
            invoice_moneyLabel.Size = new System.Drawing.Size(59, 12);
            invoice_moneyLabel.TabIndex = 7;
            invoice_moneyLabel.Text = "开票金额:";
            // 
            // invoice_paymentTLabel
            // 
            invoice_paymentTLabel.AutoSize = true;
            invoice_paymentTLabel.Location = new System.Drawing.Point(257, 53);
            invoice_paymentTLabel.Name = "invoice_paymentTLabel";
            invoice_paymentTLabel.Size = new System.Drawing.Size(71, 12);
            invoice_paymentTLabel.TabIndex = 9;
            invoice_paymentTLabel.Text = "约定付款期:";
            // 
            // invoice_endTLabel
            // 
            invoice_endTLabel.AutoSize = true;
            invoice_endTLabel.Location = new System.Drawing.Point(19, 79);
            invoice_endTLabel.Name = "invoice_endTLabel";
            invoice_endTLabel.Size = new System.Drawing.Size(83, 12);
            invoice_endTLabel.TabIndex = 11;
            invoice_endTLabel.Text = "付款截止日期:";
            // 
            // Invoice_costLabel
            // 
            Invoice_costLabel.AutoSize = true;
            Invoice_costLabel.Location = new System.Drawing.Point(19, 27);
            Invoice_costLabel.Name = "Invoice_costLabel";
            Invoice_costLabel.Size = new System.Drawing.Size(83, 12);
            Invoice_costLabel.TabIndex = 1;
            Invoice_costLabel.Text = "总服务费金额:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(234, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 12);
            label1.TabIndex = 1;
            label1.Text = "元";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(234, 53);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 12);
            label2.TabIndex = 1;
            label2.Text = "月";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(389, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(17, 12);
            label3.TabIndex = 1;
            label3.Text = "期";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(472, 27);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(17, 12);
            label4.TabIndex = 1;
            label4.Text = "元";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(472, 53);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(17, 12);
            label5.TabIndex = 1;
            label5.Text = "天";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(223, 11);
            label6.Margin = new System.Windows.Forms.Padding(0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(17, 12);
            label6.TabIndex = 1;
            label6.Text = "天";
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new System.Drawing.Point(8, 11);
            label71.Margin = new System.Windows.Forms.Padding(0);
            label71.Name = "label71";
            label71.Size = new System.Drawing.Size(59, 12);
            label71.TabIndex = 9;
            label71.Text = "每期天数:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(19, 102);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(71, 12);
            label7.TabIndex = 11;
            label7.Text = "有无预付款:";
            // 
            // dtpInvoice_endT
            // 
            this.dtpInvoice_endT.Location = new System.Drawing.Point(108, 75);
            this.dtpInvoice_endT.Name = "dtpInvoice_endT";
            this.dtpInvoice_endT.Size = new System.Drawing.Size(143, 21);
            this.dtpInvoice_endT.TabIndex = 12;
            // 
            // nudInvoice_cost
            // 
            this.nudInvoice_cost.DecimalPlaces = 2;
            this.nudInvoice_cost.Location = new System.Drawing.Point(108, 23);
            this.nudInvoice_cost.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudInvoice_cost.Name = "nudInvoice_cost";
            this.nudInvoice_cost.Size = new System.Drawing.Size(120, 21);
            this.nudInvoice_cost.TabIndex = 13;
            this.nudInvoice_cost.ThousandsSeparator = true;
            // 
            // nudInvoice_guarantee
            // 
            this.nudInvoice_guarantee.Location = new System.Drawing.Point(108, 49);
            this.nudInvoice_guarantee.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudInvoice_guarantee.Name = "nudInvoice_guarantee";
            this.nudInvoice_guarantee.Size = new System.Drawing.Size(120, 21);
            this.nudInvoice_guarantee.TabIndex = 13;
            this.nudInvoice_guarantee.ThousandsSeparator = true;
            this.nudInvoice_guarantee.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(346, 75);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(37, 21);
            this.numericUpDown3.TabIndex = 13;
            this.numericUpDown3.ThousandsSeparator = true;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // nudInvoice_money
            // 
            this.nudInvoice_money.DecimalPlaces = 2;
            this.nudInvoice_money.Location = new System.Drawing.Point(346, 23);
            this.nudInvoice_money.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudInvoice_money.Name = "nudInvoice_money";
            this.nudInvoice_money.Size = new System.Drawing.Size(120, 21);
            this.nudInvoice_money.TabIndex = 13;
            this.nudInvoice_money.ThousandsSeparator = true;
            // 
            // nudInvoice_paymentT
            // 
            this.nudInvoice_paymentT.Location = new System.Drawing.Point(346, 49);
            this.nudInvoice_paymentT.Name = "nudInvoice_paymentT";
            this.nudInvoice_paymentT.Size = new System.Drawing.Size(120, 21);
            this.nudInvoice_paymentT.TabIndex = 13;
            this.nudInvoice_paymentT.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(451, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(97, 7);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown6.TabIndex = 13;
            this.numericUpDown6.ThousandsSeparator = true;
            this.numericUpDown6.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(label71);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.numericUpDown6);
            this.panel1.Location = new System.Drawing.Point(249, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 28);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(108, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.Text = "有";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(156, 100);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "无";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(Invoice_costLabel);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(invoice_guaranteeLabel);
            this.groupBox1.Controls.Add(this.nudInvoice_paymentT);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.nudInvoice_guarantee);
            this.groupBox1.Controls.Add(invoice_paymentTypeLabel);
            this.groupBox1.Controls.Add(this.nudInvoice_money);
            this.groupBox1.Controls.Add(invoice_moneyLabel);
            this.groupBox1.Controls.Add(this.nudInvoice_cost);
            this.groupBox1.Controls.Add(invoice_paymentTLabel);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(this.dtpInvoice_WorkDate);
            this.groupBox1.Controls.Add(this.dtpInvoice_endT);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(invoice_endTLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 149);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发票信息";
            // 
            // humanresourcesDataSet
            // 
            this.humanresourcesDataSet.DataSetName = "humanresourcesDataSet";
            this.humanresourcesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.candidateTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.client_followTableAdapter = null;
            this.tableAdapterManager.clientpropertyTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contractTableAdapter = null;
            this.tableAdapterManager.degreeTableAdapter = null;
            this.tableAdapterManager.dimensionsTableAdapter = null;
            this.tableAdapterManager.educationTableAdapter = null;
            this.tableAdapterManager.employeesnumberTableAdapter = null;
            this.tableAdapterManager.evaluateTableAdapter = null;
            this.tableAdapterManager.invoicestateTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.jobsdetailTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.linkmanTableAdapter = null;
            this.tableAdapterManager.mingzTableAdapter = null;
            this.tableAdapterManager.nationalityTableAdapter = null;
            this.tableAdapterManager.operationmodelTableAdapter = null;
            this.tableAdapterManager.order_stateTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.ownershipTableAdapter = null;
            this.tableAdapterManager.personnelTableAdapter = null;
            this.tableAdapterManager.provinceTableAdapter = null;
            this.tableAdapterManager.recommended_state_remarkTableAdapter = null;
            this.tableAdapterManager.recommended_stateTableAdapter = null;
            this.tableAdapterManager.recommendedTableAdapter = null;
            this.tableAdapterManager.recruitment_quantityTableAdapter = null;
            this.tableAdapterManager.recruitmentTableAdapter = null;
            this.tableAdapterManager.resumeTableAdapter = null;
            this.tableAdapterManager.rightsTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.tradeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.weeklyc_detailsTableAdapter = null;
            this.tableAdapterManager.weeklyc_particularsTableAdapter = null;
            this.tableAdapterManager.wekkly_consultantTableAdapter = null;
            this.tableAdapterManager.work_experienceTableAdapter = null;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(19, 125);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(59, 12);
            label8.TabIndex = 11;
            label8.Text = "上班日期:";
            // 
            // dtpInvoice_WorkDate
            // 
            this.dtpInvoice_WorkDate.Location = new System.Drawing.Point(108, 121);
            this.dtpInvoice_WorkDate.Name = "dtpInvoice_WorkDate";
            this.dtpInvoice_WorkDate.Size = new System.Drawing.Size(143, 21);
            this.dtpInvoice_WorkDate.TabIndex = 12;
            // 
            // FrmInvoiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoiceAdd";
            this.Text = "发票信息添加";
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoice_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoice_guarantee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoice_money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoice_paymentT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private humanresourcesDataSet humanresourcesDataSet;
        private HumanResources.humanresourcesDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dtpInvoice_endT;
        private System.Windows.Forms.NumericUpDown nudInvoice_cost;
        private System.Windows.Forms.NumericUpDown nudInvoice_guarantee;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown nudInvoice_money;
        private System.Windows.Forms.NumericUpDown nudInvoice_paymentT;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpInvoice_WorkDate;
    }
}