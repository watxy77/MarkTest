﻿namespace HumanResources.WeekReport
{
    partial class wekklyCForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.ordersTableAdapter();
            this.recommended_state_remarkTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.recommended_state_remarkTableAdapter();
            this.teamTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.teamTableAdapter();
            this.usersTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter();
            this.weeklyc_detailsTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.weeklyc_detailsTableAdapter();
            this.weeklyc_particularsTableAdapter = new HumanResources.humanresourcesDataSetTableAdapters.weeklyc_particularsTableAdapter();
            this.wekkly_consultantTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.wekkly_consultantTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(203, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自己的周报";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(166, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 52);
            this.button6.TabIndex = 9;
            this.button6.Text = "关  闭";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 52);
            this.button5.TabIndex = 1;
            this.button5.Text = "填写周报详情";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "周报提交情况";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
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
            this.tableAdapterManager1.invoicestateTableAdapter = null;
            this.tableAdapterManager1.invoiceTableAdapter = null;
            this.tableAdapterManager1.jobsdetailTableAdapter = null;
            this.tableAdapterManager1.jobsTableAdapter = null;
            this.tableAdapterManager1.linkmanTableAdapter = null;
            this.tableAdapterManager1.mingzTableAdapter = null;
            this.tableAdapterManager1.nationalityTableAdapter = null;
            this.tableAdapterManager1.operationmodelTableAdapter = null;
            this.tableAdapterManager1.order_stateTableAdapter = null;
            this.tableAdapterManager1.ordersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager1.ownershipTableAdapter = null;
            this.tableAdapterManager1.personnelTableAdapter = null;
            this.tableAdapterManager1.provinceTableAdapter = null;
            this.tableAdapterManager1.recommended_state_remarkTableAdapter = this.recommended_state_remarkTableAdapter1;
            this.tableAdapterManager1.recommended_stateTableAdapter = null;
            this.tableAdapterManager1.recommendedTableAdapter = null;
            this.tableAdapterManager1.recruitment_quantityTableAdapter = null;
            this.tableAdapterManager1.recruitmentTableAdapter = null;
            this.tableAdapterManager1.resumeTableAdapter = null;
            this.tableAdapterManager1.rightsTableAdapter = null;
            this.tableAdapterManager1.rolesTableAdapter = null;
            this.tableAdapterManager1.teamTableAdapter = this.teamTableAdapter1;
            this.tableAdapterManager1.tradeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = this.usersTableAdapter1;
            this.tableAdapterManager1.weeklya_detailsTableAdapter = null;
            this.tableAdapterManager1.weeklya_orderTableAdapter = null;
            this.tableAdapterManager1.weeklyc_detailsTableAdapter = this.weeklyc_detailsTableAdapter1;
            this.tableAdapterManager1.weeklyc_particularsTableAdapter = this.weeklyc_particularsTableAdapter;
            this.tableAdapterManager1.wekkly_assistantTableAdapter = null;
            this.tableAdapterManager1.wekkly_consultantTableAdapter = this.wekkly_consultantTableAdapter1;
            this.tableAdapterManager1.work_experienceTableAdapter = null;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // recommended_state_remarkTableAdapter1
            // 
            this.recommended_state_remarkTableAdapter1.ClearBeforeFill = true;
            // 
            // teamTableAdapter1
            // 
            this.teamTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // weeklyc_detailsTableAdapter1
            // 
            this.weeklyc_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // weeklyc_particularsTableAdapter
            // 
            this.weeklyc_particularsTableAdapter.ClearBeforeFill = true;
            // 
            // wekkly_consultantTableAdapter1
            // 
            this.wekkly_consultantTableAdapter1.ClearBeforeFill = true;
            // 
            // wekklyCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "wekklyCForm";
            this.Text = "wekklyCForm";
            this.Load += new System.EventHandler(this.wekklyCForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private HumanResources.humanresourcesDataSetTableAdapters.wekkly_consultantTableAdapter wekkly_consultantTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.weeklyc_particularsTableAdapter weeklyc_particularsTableAdapter;
        private HumanResources.humanresourcesDataSetTableAdapters.weeklyc_detailsTableAdapter weeklyc_detailsTableAdapter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private HumanResources.humanresourcesDataSetTableAdapters.teamTableAdapter teamTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.recommended_state_remarkTableAdapter recommended_state_remarkTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.ordersTableAdapter ordersTableAdapter1;
    }
}