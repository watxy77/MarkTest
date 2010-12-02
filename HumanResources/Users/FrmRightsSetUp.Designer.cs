namespace HumanResources.Users
{
    partial class FrmRightsSetUp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnIN = new System.Windows.Forms.Button();
            this.btnOUT = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.usersTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter();
            this.rightsTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.rightsTableAdapter();
            this.rolesTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.rolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 172);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(172, 36);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 232);
            this.listBox2.TabIndex = 0;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(339, 36);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 232);
            this.listBox3.TabIndex = 0;
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(298, 118);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(35, 23);
            this.btnIN.TabIndex = 1;
            this.btnIN.Text = "←";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(298, 147);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(35, 23);
            this.btnOUT.TabIndex = 1;
            this.btnOUT.Text = "→";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(384, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(57, 245);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(75, 23);
            this.btnAddRole.TabIndex = 2;
            this.btnAddRole.Text = "添加角色";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "角色列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "已有权限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "所有权限";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(32, 218);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(100, 21);
            this.txtRoleName.TabIndex = 4;
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
            this.tableAdapterManager1.jobsdetailTableAdapter = null;
            this.tableAdapterManager1.jobsTableAdapter = null;
            this.tableAdapterManager1.linkmanTableAdapter = null;
            this.tableAdapterManager1.mingzTableAdapter = null;
            this.tableAdapterManager1.nationalityTableAdapter = null;
            this.tableAdapterManager1.operationmodelTableAdapter = null;
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
            this.tableAdapterManager1.rightsTableAdapter = this.rightsTableAdapter1;
            this.tableAdapterManager1.rolesTableAdapter = this.rolesTableAdapter1;
            this.tableAdapterManager1.tradeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = this.usersTableAdapter1;
            this.tableAdapterManager1.work_experienceTableAdapter = null;
            // 
            // humanresourcesDataSet1
            // 
            this.humanresourcesDataSet1.DataSetName = "humanresourcesDataSet";
            this.humanresourcesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // rightsTableAdapter1
            // 
            this.rightsTableAdapter1.ClearBeforeFill = true;
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmRightsSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 306);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOUT);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRightsSetUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "权限设置";
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoleName;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.rightsTableAdapter rightsTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.rolesTableAdapter rolesTableAdapter1;
        private HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
    }
}