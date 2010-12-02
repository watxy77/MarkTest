using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Customer;
using HumanResources.Users;
using HumanResources.Dictionary;

namespace HumanResources.Order
{
    public partial class FrmOrderSearch : Form
    {
        public FrmOrderSearch()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.panel1.BringToFront();
            ContralDataFill();
        }

        private void ContralDataFill()
        {
            List<humanresourcesDataSet.usersRow> userStatesourse = this.tableAdapterManager1.usersTableAdapter.GetData().ToList();
            this.cbouser.Items.Add("不限");
            foreach (humanresourcesDataSet.usersRow item in userStatesourse)
            {
                this.cbouser.Items.Add(item);
            }
            cbouser.DisplayMember = "User_realName";
            cbouser.ValueMember = "User_id";
            List<humanresourcesDataSet.order_stateRow> orderStatesourse = this.tableAdapterManager1.order_stateTableAdapter.GetData().ToList();
            this.cboOrderState.Items.Add("不限");
            foreach (humanresourcesDataSet.order_stateRow item in orderStatesourse)
            {
                this.cboOrderState.Items.Add(item);
            }
            cboOrderState.DisplayMember = "Order_State_Name";
            cboOrderState.ValueMember = "Order_State_Id";
            List<humanresourcesDataSet.cityRow> citysourse = this.tableAdapterManager1.cityTableAdapter.GetData().ToList();
            this.cboCity.AutoCompleteCustomSource.AddRange(citysourse.Select(c => c.City_name).ToArray());
            foreach (humanresourcesDataSet.cityRow item in citysourse)
            {
                this.cboCity.Items.Add(item);
            }
            cboCity.DisplayMember = "City_name";
            cboCity.ValueMember = "City_id";
        }

        private void tsmiSearchPanelVisible_Click(object sender, EventArgs e)
        {
            this.panel1.BringToFront();
            this.panel1.Visible = !this.panel1.Visible;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            List<humanresourcesDataSet.vw_orderRow> temp = vw_orderTableAdapter1.GetDataBySearch(this.dtpOrder_StimeS.Value, this.dtpOrder_StimeE.Value, "%" + this.txtClient_Name.Text + "%", "%" + this.txtPositionN.Text + "%").ToList();
            try
            {
                int u = (this.cbouser.SelectedItem as humanresourcesDataSet.usersRow).User_id;
                if(u>0)
	            {
                    temp = temp.Where(t => t.User_id == u).ToList();
	            }
                
            }
            catch (Exception)
            {
            }
            try
            {
                int u =(this.cboOrderState.SelectedItem as humanresourcesDataSet.order_stateRow).Order_State_Id;
                if (u > 0)
                {
                    temp = temp.Where(t => t.Order_State_ID == u).ToList();
                }

            }
            catch (Exception)
            {
            }
            try
            {
                int u = Convert.ToInt32(this.llblJobsDetail.Tag);
                if (u > 0)
                {
                    temp = temp.Where(t => t.JobsDetailID == u).ToList();
                }

            }
            catch (Exception)
            {
            }
            try
            {
                int u = (this.cboCity.SelectedItem as humanresourcesDataSet.cityRow).City_id;
                if (u > 0)
                {
                    temp = temp.Where(t => t.City_id == u).ToList();
                }

            }
            catch (Exception)
            {
            }
            this.dataGridView1.DataSource = temp ;
            this.panel1.Hide();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                FrmOrderInfo foi = new FrmOrderInfo((dataGridView1.SelectedRows[0].DataBoundItem  as humanresourcesDataSet.vw_orderRow).Order_id);
                foi.MdiParent = this.MdiParent;
                foi.Show();
            }
        }

        private void tsmiOrderInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FrmOrderInfo foi = new FrmOrderInfo((dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.vw_orderRow).Order_id);
                foi.MdiParent = this.MdiParent;
                foi.Show();
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                this.dataGridView1.ClearSelection();
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
            }
           
        }

        private void tsmiClientinfo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FrmCusromerInfo fci = new FrmCusromerInfo((dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.vw_orderRow).Client_id);
                fci.MdiParent = this.MdiParent;
                fci.Show();
            }
        }

        private void tsmiUserInfo_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.SelectedRows.Count > 0)
            {
                FrmUserInfo fui = new FrmUserInfo((dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.vw_orderRow).User_id);
                fui.MdiParent = this.MdiParent;
                fui.Show();
            }
        }

        private void tsmirecommended_Click(object sender, EventArgs e)
        {
            FrmRecommended frc = new FrmRecommended((dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.vw_orderRow).Order_id);
            frc.MdiParent = this.MdiParent;
            frc.Show();
        }

        private void llblJobsDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmJobsSelect fts = new FrmJobsSelect(this.llblJobsDetail);
            fts.ShowDialog();
        }


    }
}
