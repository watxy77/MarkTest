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
    public partial class FrmPwdChange : Form
    {
        public FrmPwdChange()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                humanresourcesDataSet.usersRow u = ((MDIFrmParent)MdiParent).LoginUser;
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                throw new Exception("请输入原密码");
            }
            else if(u.User_pwd != this.textBox1.Text)
            {
                throw new Exception("原密码错误");
            }
            else if (string.IsNullOrEmpty(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox3.Text))
            {
                throw new Exception("请输入新密码");
            }
            else if (this.textBox2.Text != this.textBox3.Text)
            {
                throw new Exception("两次输入密码不一致");
            }
            else
            {
                u.User_pwd = this.textBox2.Text;

                if (this.tableAdapterManager1.usersTableAdapter.Update(u) > 0) 
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
            }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
    }
}
