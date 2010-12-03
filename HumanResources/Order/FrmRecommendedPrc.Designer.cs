namespace HumanResources.Order
{
    partial class FrmRecommendedPrc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdvantages = new System.Windows.Forms.TextBox();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.lblRecommendedTime = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.candidateTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.candidateTableAdapter();
            this.vw_orderTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.vw_orderTableAdapter();
            this.vw_recommendedTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.vw_recommendedTableAdapter();
            this.vw_recommended_state_remarkTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.vw_recommended_state_remarkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "候选人名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "客户名称:";
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = true;
            this.lblCandidateName.Location = new System.Drawing.Point(77, 12);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(0, 12);
            this.lblCandidateName.TabIndex = 0;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(77, 36);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(0, 12);
            this.lblClientName.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(494, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "推荐时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "优势:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "劣势:";
            // 
            // txtAdvantages
            // 
            this.txtAdvantages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdvantages.Location = new System.Drawing.Point(15, 77);
            this.txtAdvantages.Multiline = true;
            this.txtAdvantages.Name = "txtAdvantages";
            this.txtAdvantages.ReadOnly = true;
            this.txtAdvantages.Size = new System.Drawing.Size(274, 74);
            this.txtAdvantages.TabIndex = 3;
            // 
            // txtInferior
            // 
            this.txtInferior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInferior.Location = new System.Drawing.Point(295, 76);
            this.txtInferior.Multiline = true;
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.ReadOnly = true;
            this.txtInferior.Size = new System.Drawing.Size(274, 74);
            this.txtInferior.TabIndex = 3;
            // 
            // lblRecommendedTime
            // 
            this.lblRecommendedTime.AutoSize = true;
            this.lblRecommendedTime.Location = new System.Drawing.Point(358, 12);
            this.lblRecommendedTime.Name = "lblRecommendedTime";
            this.lblRecommendedTime.Size = new System.Drawing.Size(0, 12);
            this.lblRecommendedTime.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(14, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(555, 197);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            // candidateTableAdapter1
            // 
            this.candidateTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_orderTableAdapter1
            // 
            this.vw_orderTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_recommendedTableAdapter1
            // 
            this.vw_recommendedTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_recommended_state_remarkTableAdapter1
            // 
            this.vw_recommended_state_remarkTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmRecommendedPrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 392);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.txtAdvantages);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRecommendedTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCandidateName);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecommendedPrc";
            this.Text = "推荐过程";
            this.Load += new System.EventHandler(this.FrmRecommendedPrc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.vw_orderTableAdapter vw_orderTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.candidateTableAdapter candidateTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdvantages;
        private System.Windows.Forms.TextBox txtInferior;
        private HumanResources.humanresourcesDataSetTableAdapters.vw_recommendedTableAdapter vw_recommendedTableAdapter1;
        private System.Windows.Forms.Label lblRecommendedTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private HumanResources.humanresourcesDataSetTableAdapters.vw_recommended_state_remarkTableAdapter vw_recommended_state_remarkTableAdapter1;
    }
}