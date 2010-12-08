namespace Server
{
    partial class ServerMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.CmdStar = new System.Windows.Forms.Button();
            this.CmdStop = new System.Windows.Forms.Button();
            this.StateMsg = new System.Windows.Forms.Label();
            this.SysMsg = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统菜单ToolStripMenuItem
            // 
            this.系统菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置参数ToolStripMenuItem});
            this.系统菜单ToolStripMenuItem.Name = "系统菜单ToolStripMenuItem";
            this.系统菜单ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统菜单ToolStripMenuItem.Text = "系统菜单";
            // 
            // 配置参数ToolStripMenuItem
            // 
            this.配置参数ToolStripMenuItem.Name = "配置参数ToolStripMenuItem";
            this.配置参数ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.配置参数ToolStripMenuItem.Text = "配置参数";
            this.配置参数ToolStripMenuItem.Click += new System.EventHandler(this.配置参数ToolStripMenuItem_Click);
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 12;
            this.ClientList.Location = new System.Drawing.Point(12, 27);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(268, 100);
            this.ClientList.TabIndex = 1;
            // 
            // CmdStar
            // 
            this.CmdStar.Location = new System.Drawing.Point(39, 133);
            this.CmdStar.Name = "CmdStar";
            this.CmdStar.Size = new System.Drawing.Size(75, 23);
            this.CmdStar.TabIndex = 2;
            this.CmdStar.Text = "启动服务";
            this.CmdStar.UseVisualStyleBackColor = true;
            this.CmdStar.Click += new System.EventHandler(this.CmdStar_Click);
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(175, 133);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(75, 23);
            this.CmdStop.TabIndex = 3;
            this.CmdStop.Text = "停止服务";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // StateMsg
            // 
            this.StateMsg.AutoSize = true;
            this.StateMsg.Location = new System.Drawing.Point(3, 251);
            this.StateMsg.Name = "StateMsg";
            this.StateMsg.Size = new System.Drawing.Size(71, 12);
            this.StateMsg.TabIndex = 4;
            this.StateMsg.Text = "等待运行...";
            // 
            // SysMsg
            // 
            this.SysMsg.Location = new System.Drawing.Point(12, 162);
            this.SysMsg.Multiline = true;
            this.SysMsg.Name = "SysMsg";
            this.SysMsg.Size = new System.Drawing.Size(268, 86);
            this.SysMsg.TabIndex = 5;
            // 
            // ServerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.SysMsg);
            this.Controls.Add(this.StateMsg);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.CmdStar);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ServerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器程序";
            this.Load += new System.EventHandler(this.ServerMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置参数ToolStripMenuItem;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.Button CmdStar;
        private System.Windows.Forms.Button CmdStop;
        private System.Windows.Forms.Label StateMsg;
        private System.Windows.Forms.TextBox SysMsg;
    }
}