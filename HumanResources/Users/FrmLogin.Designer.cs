﻿namespace HumanResources.Users
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginPWD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager();
            this.humanresourcesDataSet1 = new HumanResources.humanresourcesDataSet();
            this.usersTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(401, 131);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(136, 21);
            this.txtLoginName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(336, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // txtLoginPWD
            // 
            this.txtLoginPWD.Location = new System.Drawing.Point(401, 167);
            this.txtLoginPWD.Name = "txtLoginPWD";
            this.txtLoginPWD.PasswordChar = '●';
            this.txtLoginPWD.Size = new System.Drawing.Size(136, 21);
            this.txtLoginPWD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(348, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HumanResources.Properties.Resources.viewfilefda;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.CausesValidation = false;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 109);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("方正舒体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(162, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "标尺人力资源管理系统";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(381, 206);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(462, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.tableAdapterManager1.rightsTableAdapter = null;
            this.tableAdapterManager1.rolesTableAdapter = null;
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
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HumanResources.Properties.Resources.loginbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(591, 252);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoginPWD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            ((System.ComponentModel.ISupportInitialize)(this.humanresourcesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginPWD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private HumanResources.humanresourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private humanresourcesDataSet humanresourcesDataSet1;
        private HumanResources.humanresourcesDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
    }
}