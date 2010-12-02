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
    public partial class FrmUserAdd : Form
    {
        humanresourcesDataSet.usersRow bindUser = null;
        public FrmUserSearch listForm;
        public FrmUserAdd()
        {
            InitializeComponent();
            this.txtPWD.Text = "8888";
            this.tableAdapterManager1.rolesTableAdapter.Fill(this.humanresourcesDataSet1.roles);
            this.cboRole.DataSource = null;
            this.cboRole.DataSource = this.humanresourcesDataSet1.roles;
            this.cboRole.DisplayMember = "Name";
            this.cboRole.ValueMember = "ID";

        }
        public FrmUserAdd(int uid)
        {
            InitializeComponent();
            this.txtPWD.Enabled = false;
            this.tableAdapterManager1.usersTableAdapter.FillByUser_id(this.humanresourcesDataSet1.users,uid);
            this.bindUser = this.humanresourcesDataSet1.users.SingleOrDefault() ;
            this.cboRole.DataSource = null;
            this.cboRole.DataSource = this.humanresourcesDataSet1.roles;
            this.cboRole.DisplayMember = "Name";
            this.cboRole.ValueMember = "ID";

            this.Text = "用户编辑("+ this.bindUser.User_realName +")";
            this.txtComent.Text = this.bindUser.Comment;
            this.txtGroup.Text = this.bindUser.User_superior_id.ToString();
            this.txtLoginName.Text = this.bindUser.User_name;
            this.txtName.Text = this.bindUser.User_realName;
            this.txtPWD.Text = this.bindUser.User_pwd;
            this.txtWorkNO.Text = this.bindUser.User_number;
            this.cboRole.SelectedValue = this.bindUser.Role_ID;
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLoginName.Text))
                {
                    throw new Exception("登录名不能为空!");
                }
                else if (string.IsNullOrEmpty(txtName.Text))
                {
                    throw new Exception("姓名不能为空!");
                }
                else if (string.IsNullOrEmpty(txtPWD.Text))
                {
                    throw new Exception("初始密码不能为空!");
                }
                else
                {
                    if (this.bindUser == null)
                    {
                        humanresourcesDataSet.usersRow u = this.humanresourcesDataSet1.users.NewusersRow();
                        u.Comment = this.txtComent.Text;
                        u.Creation_time = DateTime.Now;
                        u.Role_ID =Convert.ToInt32(cboRole.SelectedValue);
                        u.User_name = this.txtLoginName.Text;
                        u.User_number = this.txtWorkNO.Text;
                        u.User_pwd = this.txtPWD.Text;
                        u.User_realName = this.txtName.Text;
                        u.User_superior_id = Convert.ToInt32(this.txtGroup.Text);
                        
                        Save(u);
                    }
                    else
                    {
                        this.bindUser.Comment = this.txtComent.Text;
                        this.bindUser.Creation_time = DateTime.Now;
                        this.bindUser.Role_ID = Convert.ToInt32(cboRole.SelectedValue);
                        this.bindUser.User_name = this.txtLoginName.Text;
                        this.bindUser.User_number = this.txtWorkNO.Text;
                        this.bindUser.User_pwd = this.txtPWD.Text;
                        this.bindUser.User_realName = this.txtName.Text;
                        this.bindUser.User_superior_id = Convert.ToInt32(this.txtGroup.Text);
                        Edit();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Save(humanresourcesDataSet.usersRow u)
        {
            this.humanresourcesDataSet1.users.AddusersRow(u);
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            int id =Convert.ToInt32( this.tableAdapterManager1.usersTableAdapter.Adapter.InsertCommand.LastInsertedId);
            if (id>0)
            {
                u.User_id = id;
                MessageBox.Show("添加成功");
                if (listForm!= null && listForm.sourse != null)
                {
                    listForm.sourse.Add(u);
                    listForm.Serach();   
                }
                this.Close();
            }
        }
        void Edit()
        {
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);

                MessageBox.Show("修改成功");
                if (listForm != null&&listForm.sourse != null)
                {
                    foreach (humanresourcesDataSet.usersRow item in listForm.sourse)
                    {
                        if (item.User_id == bindUser.User_id)
                        {
                            item.User_name = bindUser.User_name;
                            item.User_number = bindUser.User_number;
                            item.User_pwd = bindUser.User_pwd;
                            item.User_realName = bindUser.User_realName;
                            item.User_superior_id = bindUser.User_superior_id;
                            
                        }
                    }
                    listForm.Serach();
                }
                this.Close();
            
        }
    }
}
