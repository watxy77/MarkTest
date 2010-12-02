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
    public partial class FrmLinkmanList : Form
    {
        int clientid = 0;
        public FrmLinkmanList(int cid)
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            clientid = cid;
            humanresourcesDataSet.clientRow cr = this.tableAdapterManager1.clientTableAdapter.GetDataByClient_id(cid).SingleOrDefault();
            this.lblClientName.Text = string.IsNullOrEmpty(cr.Client_name) ? cr.Client_nameE : cr.Client_name;
            this.tableAdapterManager1.linkmanTableAdapter.FillByClient_id(this.humanresourcesDataSet1.linkman, cid);
            dataGridView1.DataSource = this.humanresourcesDataSet1.linkman;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtLinkman_name.Text) && string.IsNullOrEmpty(this.txtLinkman_nameE.Text))
                {
                    throw new Exception("中文姓名和英文姓名至少填写一项");
                }
                humanresourcesDataSet.linkmanRow newl = this.humanresourcesDataSet1.linkman.NewlinkmanRow();
                newl.Client_id = clientid;
                newl.Comment = this.txtLinkman_Comment.Text;
                newl.Linkman_add = this.txtLinkman_add.Text;
                newl.LinkMan_Email = this.txtLinkMan_Email.Text;
                newl.Linkman_fax = this.txtLinkman_fax.Text;
                newl.Linkman_mobileP = this.txtLinkman_mobileP.Text;
                newl.Linkman_name = this.txtLinkman_name.Text;
                newl.Linkman_nameE = this.txtLinkman_nameE.Text;
                newl.Linkman_phone = this.txtLinkman_phone.Text;
                newl.Linkman_position = this.txtLinkman_position.Text;

                this.humanresourcesDataSet1.linkman.AddlinkmanRow(newl);
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

        private void btnAddLinkman_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }
    }
}
