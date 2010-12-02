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
    public partial class FrmInvoiceAdd : Form
    {
        int rid = 0;
        public FrmInvoiceAdd(int recommandedid)
        {
            InitializeComponent();
            this.rid = recommandedid;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.panel1.Visible = (this.numericUpDown3.Value > 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= this.numericUpDown3.Value; i++)
            {
                if (this.numericUpDown3.Value == 1)
                {
                    humanresourcesDataSet.invoiceRow newr = this.humanresourcesDataSet.invoice.NewinvoiceRow();
                    newr.Invoice_Bmoney = 0;
                    newr.Invoice_BmoneyType = 0;
                    newr.Invoice_BmoneyT = DateTime.MinValue;
                    newr.Invoice_cost = this.nudInvoice_cost.Value;
                    newr.Invoice_delayD = 0;
                    newr.Invoice_endT = this.dtpInvoice_endT.Value;
                    newr.Invoice_guarantee = Convert.ToInt32(this.nudInvoice_guarantee.Value);
                    newr.Invoice_money = this.nudInvoice_money.Value;
                    newr.Invoice_number = "";
                    newr.Invoice_paymentT = Convert.ToInt32(this.nudInvoice_paymentT.Value);
                    newr.Invoice_paymentType = "全款";
                    newr.Invoice_startT = DateTime.MinValue;
                    newr.Invoice_State = 1;
                    newr.Invoice_WorkDate = this.dtpInvoice_WorkDate.Value.Date;
                    newr.Recommended_id = rid;
                    this.humanresourcesDataSet.invoice.AddinvoiceRow(newr);
                }
                else
                {
                    //N期款
                }
            }
            this.tableAdapterManager.UpdateAll(this.humanresourcesDataSet);
        }
    }
}
