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
    public partial class FrmClientFllowList : Form
    {
        int clientid = 0;
        public FrmClientFllowList(int cid)
        {
            InitializeComponent();
            this.dataGridView2.AutoGenerateColumns = false;
            clientid = cid;
            humanresourcesDataSet.clientRow cr = this.tableAdapterManager1.clientTableAdapter.GetDataByClient_id(cid).SingleOrDefault();
            this.lblClientName.Text =string.IsNullOrEmpty(cr.Client_name)?cr.Client_nameE:cr.Client_name;
            this.tableAdapterManager1.client_followTableAdapter.FillByClient_id(this.humanresourcesDataSet1.client_follow, cid);
            dataGridView2.DataSource = this.humanresourcesDataSet1.client_follow;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCF_target.Text))
                {
                    throw new Exception("请填写跟进目标");
                }
                humanresourcesDataSet.client_followRow newl = this.humanresourcesDataSet1.client_follow.Newclient_followRow();
                newl.Comment = this.txtCFComment.Text;
                newl.CF_target = this.txtCF_target.Text;
                newl.CF_time = Convert.ToDateTime(this.dtpCF_time.Value.ToShortDateString());
                newl.Client_id = 0;
                newl.User_id = ((MDIFrmParent)MdiParent).LoginUser.User_id;
                this.humanresourcesDataSet1.client_follow.Addclient_followRow(newl);
                this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                foreach (Control item in this.panel1.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        item.Text = "";
                    }
                }
                this.panel1.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddClientFllow_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }
    }
}
