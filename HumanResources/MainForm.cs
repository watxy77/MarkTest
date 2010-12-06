using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HumanResources.Order;
using HumanResources.Candidate;
using HumanResources.Customer;
using HumanResources.Users;
using HumanResources.WeekReport;

namespace HumanResources
{
    public partial class MainForm : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public string skinName = "";
        public humanresourcesDataSet.usersRow LoginUser = null;

        public MainForm(humanresourcesDataSet.usersRow u)
        {
            InitializeComponent();
            this.LoginUser = u;
            
            //this.lb_status.Text += "(当前用户:" + u.User_realName + ")";
            this.Text += "(当前用户:" + u.User_realName + ")";
 
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRelogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnPwd_Click(object sender, EventArgs e)
        {
            bool FormIsExists = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "FrmPwdChange")
                {
                    FormIsExists = true;
                    item.Focus();
                }
            }
            if (!FormIsExists)
            {
                FrmPwdChange fpc = new FrmPwdChange();
                fpc.MdiParent = this;
                fpc.Show();
                fpc.BringToFront();
            }
        }

        private void btnRightSet_Click(object sender, EventArgs e)
        {
            bool FormIsExists = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "FrmRightsSetUp")
                {
                    FormIsExists = true;
                    item.Focus();
                    break;
                }
            }
            if (!FormIsExists)
            {
                FrmRightsSetUp frs = new FrmRightsSetUp();
                frs.MdiParent = this;
                frs.Show();
                frs.BringToFront();
            }
            
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            FrmTeamManager fos = new FrmTeamManager();
            fos.MdiParent = this;
            fos.Show();
        }

        private void btnUserSet_Click(object sender, EventArgs e)
        {
            FrmUserAdd fua = new FrmUserAdd(this.LoginUser.User_id);
            fua.MdiParent = this;
            fua.Show();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            FrmUserSearch fus = new FrmUserSearch();
            fus.MdiParent = this;
            fus.Show();
            fus.BringToFront();
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            //关闭当前在容器中打开的窗体或面板
        }

        

  
      
    }
}
