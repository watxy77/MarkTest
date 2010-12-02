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
    public partial class FrmUserSearch : Form
    {
       public List<humanresourcesDataSet.usersRow> sourse = null;
        public FrmUserSearch()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.tableAdapterManager1.usersTableAdapter.Fill(this.humanresourcesDataSet1.users);
            sourse = this.humanresourcesDataSet1.users.ToList();
            this.dataGridView1.DataSource = sourse;
            cboRole.Items.Add("不限");
            this.tableAdapterManager1.rolesTableAdapter.Fill(this.humanresourcesDataSet1.roles);
            foreach (humanresourcesDataSet.rolesRow item in this.humanresourcesDataSet1.roles)
            {
                cboRole.Items.Add(item);

            }
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "ID";
            
            cboRole.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
        private void tsmiUserInfo_Click(object sender, EventArgs e)
        {
            FrmUserInfo fui = new FrmUserInfo(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            fui.MdiParent = this.MdiParent;
            fui.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmUserInfo fui = new FrmUserInfo((dataGridView1.Rows[e.RowIndex].DataBoundItem as humanresourcesDataSet.usersRow).User_id);
                fui.MdiParent = this.MdiParent;
                fui.Show();
            }
        }
        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            FrmUserAdd fua = new FrmUserAdd();
            fua.listForm = this;
            fua.MdiParent = this.MdiParent;
            fua.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Serach();
        }
        public void Serach()
        {
            List <humanresourcesDataSet.usersRow> ul = sourse;
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                ul = ul.Where(u => u.User_realName.Contains(txtName.Text.Trim())).ToList();
            }
            if (cboRole.SelectedItem != null && cboRole.SelectedItem.GetType() == typeof(humanresourcesDataSet.rolesRow))
            {
                ul = ul.Where(u => u.Role_ID.ToString() == ((humanresourcesDataSet.rolesRow)cboRole.SelectedItem).ID.ToString()).ToList();
            }
            if (!string.IsNullOrEmpty(this.txtWorkNO.Text))
            {
                ul = ul.Where(u => u.User_number.Contains(this.txtWorkNO.Text.Trim())).ToList();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ul;
            
        }

        private void tsmiUserEdit_Click(object sender, EventArgs e)
        {
            FrmUserAdd fua = new FrmUserAdd((dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.usersRow).User_id);
            fua.MdiParent = this.MdiParent;
            fua.listForm = this;
            fua.Show();
        }

        private void tsmiClientList_Click(object sender, EventArgs e)
        {
            FrmUserCustomers fuc = new FrmUserCustomers((dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.usersRow).User_id);
            fuc.MdiParent = this.MdiParent;
            fuc.Show();
        }

    }
}
