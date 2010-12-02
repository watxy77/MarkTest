namespace HumanResources.Order
{
    partial class FrmOrderListSimple
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
            this.Order_Stime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_positionN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.vw_orderTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.vw_orderTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.clientTableAdapter1 = new HumanResources.humanresourcesDataSetTableAdapters.clientTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmirecommeded = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrderinfo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_Stime,
            this.Order_positionN});
            this.dataGridView1.Location = new System.Drawing.Point(14, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(286, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // Order_Stime
            // 
            this.Order_Stime.DataPropertyName = "Order_Stime";
            this.Order_Stime.HeaderText = "订单开始时间";
            this.Order_Stime.Name = "Order_Stime";
            this.Order_Stime.ReadOnly = true;
            // 
            // Order_positionN
            // 
            this.Order_positionN.DataPropertyName = "Order_positionN";
            this.Order_positionN.HeaderText = "职位名称";
            this.Order_positionN.Name = "Order_positionN";
            this.Order_positionN.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(225, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // vw_orderTableAdapter1
            // 
            this.vw_orderTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "客户名称:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(80, 9);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(41, 12);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "label1";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmirecommeded,
            this.tsmiOrderinfo});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // tsmirecommeded
            // 
            this.tsmirecommeded.Name = "tsmirecommeded";
            this.tsmirecommeded.Size = new System.Drawing.Size(152, 22);
            this.tsmirecommeded.Text = "推荐候选人";
            this.tsmirecommeded.Click += new System.EventHandler(this.tsmirecommeded_Click);
            // 
            // tsmiOrderinfo
            // 
            this.tsmiOrderinfo.Name = "tsmiOrderinfo";
            this.tsmiOrderinfo.Size = new System.Drawing.Size(152, 22);
            this.tsmiOrderinfo.Text = "查看详细";
            this.tsmiOrderinfo.Click += new System.EventHandler(this.tsmiOrderinfo_Click);
            // 
            // FrmOrderListSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 266);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOrderListSimple";
            this.Text = "订单列表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HumanResources.humanresourcesDataSetTableAdapters.vw_orderTableAdapter vw_orderTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Stime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_positionN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientName;
        private HumanResources.humanresourcesDataSetTableAdapters.clientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmirecommeded;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrderinfo;
    }
}