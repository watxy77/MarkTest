using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Invoice
{
    public partial class FrmTransactionDetails : Form
    {
        List<humanresourcesDataSet.vw_invoiceRow> datasourse = null;
        public FrmTransactionDetails()
        {
            InitializeComponent();
        }

        private void FrmTransactionDetails_Load(object sender, EventArgs e)
        {
            this.dateTimePicker2.Value = DateTime.Now;
            this.dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            datasourse = this.vw_invoiceTableAdapter1.GetDataByInvoice_startT(this.dateTimePicker1.Value.Date,this.dateTimePicker2.Value.Date).ToList();
            if (this.radioButton1.Checked)
            {
                this.dataGridView1.DataSource = datasourse;
            }
            else
            {

                this.dataGridView1.DataSource = datasourse.Where(t => (t.Invoice_BmoneyType.ToString() == "1") == this.radioButton2.Checked);

            }
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells["ID"].Value = item.Index + 1;
                item.Cells["Column2"].Value = string.IsNullOrEmpty((item.DataBoundItem as humanresourcesDataSet.vw_invoiceRow).Client_name) ? (item.DataBoundItem as humanresourcesDataSet.vw_invoiceRow).Client_name : (item.DataBoundItem as humanresourcesDataSet.vw_invoiceRow).Client_nameE;
                if ((item.DataBoundItem as humanresourcesDataSet.vw_invoiceRow).Invoice_BmoneyType.ToString() == "1" )
                {
                    item.Cells["Column14"].Value = "是";
                }
                else
                {
                    item.Cells["Column14"].Value = "否";
                    item.Cells["Column16"].Value = null;
                    item.Cells["Column17"].Value = null;
                    item.Cells["Column18"].Value = null;
                }
                
            }
        }
    }
}
