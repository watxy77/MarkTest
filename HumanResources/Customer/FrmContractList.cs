using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Customer
{
    public partial class FrmContractList : Form
    {
        int clientid = 0;
        public FrmContractList(int cid)
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            clientid = cid;
            humanresourcesDataSet.clientRow cr = this.tableAdapterManager1.clientTableAdapter.GetDataByClient_id(cid).SingleOrDefault();
            this.lblClientName.Text = string.IsNullOrEmpty(cr.Client_name) ? cr.Client_nameE : cr.Client_name;
            this.tableAdapterManager1.contractTableAdapter.FillByClient_id(this.humanresourcesDataSet1.contract, cid);
            dataGridView1.DataSource = this.humanresourcesDataSet1.contract;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = "";
                }
            }
            this.panel1.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.panel1.BringToFront();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                item.Cells[0].Value = ((item.DataBoundItem as DataRowView).Row as humanresourcesDataSet.contractRow).Contract_validS.ToLongDateString() + "-" + ((item.DataBoundItem as DataRowView).Row as humanresourcesDataSet.contractRow).Contract_validE.ToLongDateString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            humanresourcesDataSet.contractRow contract = this.humanresourcesDataSet1.contract.NewcontractRow();
            contract.Client_id = clientid;
            contract.Comment = txtContractComment.Text;
            contract.Contract_calculate = txtContract_calculate.Text;
            contract.Contract_guaranteeT = txtContract_guaranteeT.Text;
            contract.Contract_guaranteeD = txtContract_guaranteeD.Text;
            contract.Contract_number = txtContract_number.Text;
            contract.Contract_payment = txtContract_payment.Text;
            contract.Contract_rate = txtContract_rate.Text;
            contract.Contract_validE = Convert.ToDateTime(dtpContract_validE.Value.ToShortDateString());
            contract.Contract_validS = Convert.ToDateTime(dtpContract_validS.Value.ToShortDateString());
            this.humanresourcesDataSet1.contract.AddcontractRow(contract);
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            this.tableAdapterManager1.contractTableAdapter.FillByClient_id(this.humanresourcesDataSet1.contract, clientid);

        }
        void bind(humanresourcesDataSet.contractRow cr)
        {
            this.lblComment.Text = cr.Comment;
            this.lblContract_calculate.Text = cr.Contract_calculate;
            this.lblContract_guaranteeD .Text= cr.Contract_guaranteeD;
            this.lblContract_guaranteeT.Text = cr.Contract_guaranteeT;
            this.lblContract_number.Text = cr.Contract_number;
            this.lblContract_rate.Text = cr.Contract_rate;
            this.lblContract_validE.Text = cr.Contract_validE.ToLongDateString();
            this.lblContract_validS.Text = cr.Contract_validS.ToLongDateString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                bind((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.contractRow);
            }
            catch (Exception)
            {
                
                
            }
        }
    }
  
}
