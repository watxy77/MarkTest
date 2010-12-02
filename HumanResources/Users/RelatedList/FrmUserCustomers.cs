using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Customer;

namespace HumanResources.Users.RelatedList
{
    public partial class FrmUserCustomers : Form
    {
        humanresourcesDataSet.usersRow OwnerUser = null;
        public FrmUserCustomers(int userid)
        {
            InitializeComponent();
            OwnerUser = this.tableAdapterManager1.usersTableAdapter.GetDataByUser_id(userid).SingleOrDefault();
            this.Text += "(" + OwnerUser.User_realName + ")";
            this.dataGridView1.AutoGenerateColumns = false;
            this.tableAdapterManager1.clientTableAdapter.FillByUser_id(this.humanresourcesDataSet1.client, userid);
            this.dataGridView1.DataSource = this.humanresourcesDataSet1.client;
                        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiClientInfo_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row.GetType() == typeof(humanresourcesDataSet.clientRow))
            {
                FrmCusromerInfo fui = new FrmCusromerInfo(((dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow).Client_id);
                fui.MdiParent = this.MdiParent;
                fui.Show();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem.GetType() == typeof(humanresourcesDataSet.clientRow))
            {
                FrmCusromerInfo fui = new FrmCusromerInfo((dataGridView1.Rows[e.RowIndex].DataBoundItem as humanresourcesDataSet.clientRow).Client_id);
                fui.MdiParent = this.MdiParent;
                fui.Show();
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
