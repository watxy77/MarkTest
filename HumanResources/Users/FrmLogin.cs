using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace HumanResources.Users
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtLoginName.Text))
            {
                MessageBox.Show("请输入用户名!");
            }
            else if (string.IsNullOrEmpty(this.txtLoginPWD.Text))
            {
                MessageBox.Show("请输入密码!");
            }
            else
            {


                try
                {
                    this.tableAdapterManager1.usersTableAdapter.FillByUser_name(this.humanresourcesDataSet1.users,this.txtLoginName.Text.Trim());
                    if (this.humanresourcesDataSet1.users.Count == 0)
	                {
                		 throw new Exception("用户不存在!");
	                }
                    humanresourcesDataSet.usersRow u = this.humanresourcesDataSet1.users.SingleOrDefault();

                    if (u.User_pwd == this.txtLoginPWD.Text)
                    {
                        MDIFrmParent mfp = new MDIFrmParent(u);
                        mfp.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("密码错误!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("登录失败:" + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
