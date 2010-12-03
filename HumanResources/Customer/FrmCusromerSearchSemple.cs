using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Order;

namespace HumanResources.Customer
{
    public partial class FrmCusromerSearchSemple : Form
    {
        Control EventCtr = null;
        public FrmCusromerSearchSemple()
        {
            InitializeComponent();
            this.tsmiCheck.Visible = false;
            this.panel1.BringToFront();
            this.dataGridView1.AutoGenerateColumns = false;
            this.tableAdapterManager1.clientTableAdapter.Fill(this.humanresourcesDataSet1.client);
            this.dataGridView1.DataSource = this.humanresourcesDataSet1.client;
        }
        public FrmCusromerSearchSemple(Control eventCtr)
        {
            InitializeComponent();
            this.panel1.BringToFront();
            this.dataGridView1.AutoGenerateColumns = false;
            this.EventCtr = eventCtr;
            this.tableAdapterManager1.clientTableAdapter.Fill(this.humanresourcesDataSet1.client);
            this.dataGridView1.DataSource = this.humanresourcesDataSet1.client;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = ucCusromerSearch2.SearchClient(this.humanresourcesDataSet1.client.ToList());
            this.panel1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmishow_Click(object sender, EventArgs e)
        {
            
            this.panel1.Visible = !this.panel1.Visible;
        }

        private void tsmiClientInfo_Click(object sender, EventArgs e)
        {
            FrmCusromerInfo fui = new FrmCusromerInfo(((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow).Client_id);
            fui.MdiParent = this.MdiParent;
            fui.Show();
        }

        private void tsmiCheck_Click(object sender, EventArgs e)
        {
            if (EventCtr != null)
            {
                humanresourcesDataSet.clientRow checkClient = (this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow;
                if (string.IsNullOrEmpty(checkClient.Client_name))
                {
                    EventCtr.Text = checkClient.Client_nameE;
                }
                else
                {
                    EventCtr.Text = checkClient.Client_name;
                }
                EventCtr.Tag = checkClient.Client_id;
                this.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {

                    if (EventCtr != null)
                    {
                        humanresourcesDataSet.clientRow checkClient = (this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow;
                        if (string.IsNullOrEmpty(checkClient.Client_name))
                        {
                            EventCtr.Text = checkClient.Client_nameE;
                        }
                        else
                        {
                            EventCtr.Text = checkClient.Client_name;
                        }
                        EventCtr.Tag = checkClient.Client_id;
                        this.Close();
                    }
                
                else
                {
                    FrmCusromerInfo fui = new FrmCusromerInfo(((this.dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow).Client_id);
                    fui.MdiParent = this.MdiParent;
                    fui.Show();
                }
            }
            
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void tsmiAddOrder_Click(object sender, EventArgs e)
        {
            FrmOrderInfoAdd foa = new FrmOrderInfoAdd((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow);
            foa.MdiParent = this.MdiParent;
            foa.Show();
        }

        private void tsmiOrderList_Click(object sender, EventArgs e)
        {
            int clientid = ((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow).Client_id;
            if (clientid > 0)
            {
                FrmOrderListSimple fols = new FrmOrderListSimple(clientid);
                fols.MdiParent = this.MdiParent;
                fols.Show();
            }
            
        }

        private void tsmiLinkmanList_Click(object sender, EventArgs e)
        {
            int clientid = ((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow).Client_id;
            if (clientid > 0)
            {
                FrmLinkmanList fols = new FrmLinkmanList(clientid);
                fols.MdiParent = this.MdiParent;
                fols.Show();
            }
        }

        private void tsmiClientFollow_Click(object sender, EventArgs e)
        {
            int clientid = ((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow).Client_id;
            if (clientid > 0)
            {
                FrmClientFllowList fols = new FrmClientFllowList(clientid);
                fols.MdiParent = this.MdiParent;
                fols.Show();
            }
        }

        private void tsmiContract_Click(object sender, EventArgs e)
        {
            int clientid = ((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow).Client_id;
            if (clientid > 0)
            {
                FrmContractList fols = new FrmContractList(clientid);
                fols.MdiParent = this.MdiParent;
                fols.Show();
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int clientid = ((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.clientRow).Client_id;
            if (clientid > 0)
            {
                FrmCustomerInfoAdd fols = new FrmCustomerInfoAdd(clientid);
                fols.MdiParent = this.MdiParent;
                fols.Show();
            }
        }
    }
}
