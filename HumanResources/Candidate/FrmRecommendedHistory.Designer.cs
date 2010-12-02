namespace HumanResources.Candidate
{
    partial class FrmRecommendedHistory
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
            this.Order_positionN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recommended_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advantages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recommended_State_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClientInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.订单信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推荐过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.candidateTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.candidateTableAdapter();
            this.vw_recommendedTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.vw_recommendedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client_name,
            this.Order_positionN,
            this.Recommended_Time,
            this.Advantages,
            this.Inferior,
            this.Recommended_State_Name});
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(525, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // Client_name
            // 
            this.Client_name.DataPropertyName = "Client_name";
            this.Client_name.HeaderText = "客户名称";
            this.Client_name.Name = "Client_name";
            this.Client_name.ReadOnly = true;
            // 
            // Order_positionN
            // 
            this.Order_positionN.DataPropertyName = "Order_positionN";
            this.Order_positionN.HeaderText = "职位名称";
            this.Order_positionN.Name = "Order_positionN";
            this.Order_positionN.ReadOnly = true;
            // 
            // Recommended_Time
            // 
            this.Recommended_Time.DataPropertyName = "Recommended_Time";
            this.Recommended_Time.HeaderText = "推荐时间";
            this.Recommended_Time.Name = "Recommended_Time";
            this.Recommended_Time.ReadOnly = true;
            // 
            // Advantages
            // 
            this.Advantages.DataPropertyName = "Advantages";
            this.Advantages.HeaderText = "优势";
            this.Advantages.Name = "Advantages";
            this.Advantages.ReadOnly = true;
            // 
            // Inferior
            // 
            this.Inferior.DataPropertyName = "Inferior";
            this.Inferior.HeaderText = "劣势";
            this.Inferior.Name = "Inferior";
            this.Inferior.ReadOnly = true;
            // 
            // Recommended_State_Name
            // 
            this.Recommended_State_Name.DataPropertyName = "Recommended_State_Name";
            this.Recommended_State_Name.HeaderText = "推荐状态";
            this.Recommended_State_Name.Name = "Recommended_State_Name";
            this.Recommended_State_Name.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(462, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "候选人名:";
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = true;
            this.lblCandidateName.Location = new System.Drawing.Point(78, 11);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(0, 12);
            this.lblCandidateName.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientInfo,
            this.订单信息ToolStripMenuItem,
            this.推荐过程ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // tsmiClientInfo
            // 
            this.tsmiClientInfo.Name = "tsmiClientInfo";
            this.tsmiClientInfo.Size = new System.Drawing.Size(124, 22);
            this.tsmiClientInfo.Text = "客户信息";
            this.tsmiClientInfo.Click += new System.EventHandler(this.tsmiClientInfo_Click);
            // 
            // 订单信息ToolStripMenuItem
            // 
            this.订单信息ToolStripMenuItem.Name = "订单信息ToolStripMenuItem";
            this.订单信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.订单信息ToolStripMenuItem.Text = "订单信息";
            // 
            // 推荐过程ToolStripMenuItem
            // 
            this.推荐过程ToolStripMenuItem.Name = "推荐过程ToolStripMenuItem";
            this.推荐过程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.推荐过程ToolStripMenuItem.Text = "推荐过程";
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
            // vw_recommendedTableAdapter1
            // 
            this.vw_recommendedTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmRecommendedHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 269);
            this.Controls.Add(this.lblCandidateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRecommendedHistory";
            this.Text = "推荐历史";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_positionN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recommended_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advantages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recommended_State_Name;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.vw_recommendedTableAdapter vw_recommendedTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.candidateTableAdapter candidateTableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientInfo;
        private System.Windows.Forms.ToolStripMenuItem 订单信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推荐过程ToolStripMenuItem;
    }
}