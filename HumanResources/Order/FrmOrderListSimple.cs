using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Order
{
    public partial class FrmOrderListSimple : Form
    {
        public FrmOrderListSimple(int ClientID)
        {
            InitializeComponent();
            DataRow dr = clientTableAdapter1.GetDataByClient_id(ClientID).Rows[0];
            this.lblClientName.Text = string.IsNullOrEmpty(Convert.ToString(dr["Client_name"])) ? Convert.ToString(dr["Client_name"]) : Convert.ToString(dr["Client_nameE"]);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = vw_orderTableAdapter1.GetDataByClient_id(ClientID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiOrderinfo_Click(object sender, EventArgs e)
        {
            FrmOrderInfo foi = new FrmOrderInfo(Convert.ToInt32((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView)["Order_ID"]));
            foi.MdiParent = this.MdiParent;
            foi.Show();
        }

        private void tsmirecommeded_Click(object sender, EventArgs e)
        {
            FrmRecommended frc = new FrmRecommended(Convert.ToInt32((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView)["Order_ID"]));
            frc.MdiParent = this.MdiParent;
            frc.Show();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                this.dataGridView1.ClearSelection();
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmOrderInfo foi = new FrmOrderInfo(Convert.ToInt32((this.dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView)["Order_ID"]));
            foi.MdiParent = this.MdiParent;
            foi.Show();
        }
    }
}
