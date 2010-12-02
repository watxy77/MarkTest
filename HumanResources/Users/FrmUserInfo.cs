using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Users.RelatedList;

namespace HumanResources.Users
{
    public partial class FrmUserInfo : Form
    {
        humanresourcesDataSet.usersRow u = null;
        public FrmUserInfo(int userID)
        {
            InitializeComponent();
            this.u = this.tableAdapterManager1.usersTableAdapter.GetDataByUser_id(userID).SingleOrDefault();
            bind();
        }
        void bind()
        {
            if (u!=null)
            {
                this.lblComment.Text = u.Comment;
                this.lblCreation_time.Text = u.Creation_time.ToShortDateString();
                try
                {
                    this.lblRole.Text = this.tableAdapterManager1.rolesTableAdapter.GetDataByID(u.Role_ID).SingleOrDefault().Name;
                }
                catch (Exception)
                {
                    
                    this.lblRole.Text = "";
                }
                this.lblUser_id.Text = u.User_id.ToString();
                this.lblUser_name.Text = u.User_name;
                this.lblUser_number.Text = u.User_number;
                this.lblUser_realName.Text = u.User_realName;
                this.lblUser_superior_id.Text = u.User_superior_id.ToString() ;
                this.Text += "(" + u.User_realName + ")";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmUserCustomers fuc = new FrmUserCustomers(u.User_id);
            fuc.MdiParent = this.MdiParent;
            fuc.Show();

        }
    }
}
