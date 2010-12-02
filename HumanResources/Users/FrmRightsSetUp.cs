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
    public partial class FrmRightsSetUp : Form
    {

       
        public FrmRightsSetUp()
        {
            InitializeComponent();

            this.tableAdapterManager1.rightsTableAdapter.Fill(this.humanresourcesDataSet1.rights);
            this.tableAdapterManager1.rolesTableAdapter.Fill(this.humanresourcesDataSet1.roles);
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = this.humanresourcesDataSet1.roles;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.ValueMember = "ID";
        }
        private void getRoleRights()
        {
            humanresourcesDataSet.rolesRow r = listBox1.SelectedItem == null ? null : (listBox1.SelectedItem as DataRowView).Row as humanresourcesDataSet.rolesRow;
            if (r!= null)
            {
                string[] roleRightsArr = r.Rights == null?null: r.Rights.Split(',');
                foreach (humanresourcesDataSet.rightsRow item in this.humanresourcesDataSet1.rights)
                {
                    if (roleRightsArr.Contains(item.Right_ID.ToString()))
                    {
                        listBox2.Items.Add(item);
                    }
                    else
                    {
                        listBox3.Items.Add(item);
                    }
                }
                listBox2.DisplayMember = "Right_Name";
                listBox2.ValueMember = "Right_ID";
                listBox2.SelectedIndex = listBox2.Items.Count>=1?0:-1;
                listBox3.DisplayMember = "Right_Name";
                listBox3.ValueMember = "Right_ID";
                listBox3.SelectedIndex = listBox3.Items.Count >= 1 ? 0 : -1;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            getRoleRights();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.Items.Count > 0)
                {
                    humanresourcesDataSet.rightsRow r = listBox3.SelectedItem as humanresourcesDataSet.rightsRow;
                    listBox3.Items.Remove(r);
                    listBox2.Items.Add(r);
                    listBox3.SelectedIndex = listBox3.Items.Count >= 1 ? 0 : -1;
                    listBox2.SelectedIndex = listBox2.Items.Count >= 1 ? 0 : -1;
                }
            }
            catch (Exception)
            {
                listBox3.SelectedIndex = listBox3.Items.Count >= 1 ? 0 : -1;
            }
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.Items.Count > 0)
                {
                    humanresourcesDataSet.rightsRow r = listBox2.SelectedItem as humanresourcesDataSet.rightsRow;
                    listBox2.Items.Remove(r);
                    listBox3.Items.Add(r);
                    listBox3.SelectedIndex = listBox3.Items.Count >= 1 ? 0 : -1;
                    listBox2.SelectedIndex = listBox2.Items.Count >= 1 ? 0 : -1;
                }
            }
            catch (Exception)
            {
                listBox2.SelectedIndex = listBox2.Items.Count >= 1 ? 0 : -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            humanresourcesDataSet.rolesRow r = (listBox1.SelectedItem as DataRowView).Row as humanresourcesDataSet.rolesRow;
            if (r != null)
            {
                string rights = "";
                foreach (humanresourcesDataSet.rightsRow item in listBox2.Items)
                {
                    rights += item.Right_ID;
                    rights += ",";
                }
                if (rights[rights.Length - 1] == ',')
                {
                    rights = rights.Remove(rights.Length - 1);
                }
                r.Rights = rights;
                if (this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1)>0)
                {
                    MessageBox.Show("保存成功!");
                }
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            humanresourcesDataSet.rolesRow r = this.humanresourcesDataSet1.roles.NewrolesRow();
            r.Name = this.txtRoleName.Text.Trim();
            this.humanresourcesDataSet1.roles.AddrolesRow(r);
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = this.humanresourcesDataSet1.roles;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.ValueMember = "ID";
        }
    }
}
