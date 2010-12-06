using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Customer;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using HumanResources.Order;
using System.Reflection;
using HumanResources.Candidate;


using HumanResources.Users;
using HumanResources.WeekReport;

namespace HumanResources
{
    public partial class MDIFrmParent : Form
    {
        public string skinName = "";
        public humanresourcesDataSet.usersRow LoginUser = null;
        public MDIFrmParent()
        {
            InitializeComponent();
            //if (File.Exists(System.Environment.CurrentDirectory + "\\skin.dat"))
            //{
            //    FileStream fileStream1 = new FileStream(System.Environment.CurrentDirectory + "\\skin.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
            //    BinaryFormatter b1 = new BinaryFormatter();
            //    skinName = b1.Deserialize(fileStream1) as String;
            //    if (skinName == "")
            //    {
            //        this.skinEngine1.Dispose();
            //    }
            //    else
            //    {
            //        this.skinEngine1.SkinFile = skinName;
            //    }

            //    fileStream1.Close();
            //}
            //else
            //{
            //    this.skinEngine1.Dispose();
            //}


            
        }
        public MDIFrmParent(humanresourcesDataSet.usersRow u)
        {
            InitializeComponent();
            this.LoginUser = u;
            this.Text += "(当前用户:" +u.User_realName + ")";
        }
        private void 客户信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerInfoAdd childForm = new FrmCustomerInfoAdd(this);
            childForm.MdiParent = this;
            childForm.Show();
            childForm.BringToFront();
            childForm.Show(); 


        }

        private void 订单信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderInfoAdd childForm = new FrmOrderInfoAdd();
            childForm.MdiParent = this;
            childForm.Show();
            childForm.BringToFront();
        }

        private void MDIFrmParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void MDIFrmParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void tsmiResumeAdd_Click(object sender, EventArgs e)
        {
            FrmResumeAdd fra = new FrmResumeAdd();
            fra.MdiParent = this;
            fra.Show();
            fra.BringToFront();
        }

        private void tsmiCandidateSearch_Click(object sender, EventArgs e)
        {
            FrmCandidateSearchSemple frcss = new FrmCandidateSearchSemple();
            frcss.MdiParent = this;
            frcss.Show();
            frcss.BringToFront();
        }
        private void tsmiUsersList_Click(object sender, EventArgs e)
        {
            FrmUserSearch fus = new FrmUserSearch();
            fus.MdiParent = this;
            fus.Show();
            fus.BringToFront();
        }

        private void tsmiRightsSetup_Click(object sender, EventArgs e)
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

        private void tsmiPWDChange_Click(object sender, EventArgs e)
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

        private void tsmiUserSetup_Click(object sender, EventArgs e)
        {
            FrmUserAdd fua = new FrmUserAdd(this.LoginUser.User_id);
            fua.MdiParent = this;
            fua.Show();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiClientList_Click(object sender, EventArgs e)
        {
            FrmCusromerSearchSemple fua = new FrmCusromerSearchSemple();
            fua.MdiParent = this;
            fua.Show();
        }

        private void tsmiOrderSearch_Click(object sender, EventArgs e)
        {
            FrmOrderSearch fos = new FrmOrderSearch();
            fos.MdiParent = this;
            fos.Show();
        }

        private void tsmiTeamManager_Click(object sender, EventArgs e)
        {
            FrmTeamManager fos = new FrmTeamManager();
            fos.MdiParent = this;
            fos.Show();
        }

        private void 顾问周报ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wekklyCForm wcf = new wekklyCForm();
            wcf.MdiParent = this;
            wcf.Show(); 
        }

        private void 助理周报ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wekklyAForm wcf = new wekklyAForm();
            wcf.MdiParent = this;
            wcf.Show(); 
        }

        private void 助理周报设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wekklySetA aa = new wekklySetA();
            aa.MdiParent = this;
            aa.Show();
        }

        private void 顾问周报设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wekklySetC aa = new wekklySetC();
            aa.MdiParent = this;
            aa.Show();
        }
    }
}
