using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Base;

namespace HumanResources.Customer
{
    public partial class UcCusromerSearch : UserControl
    {
        public UcCusromerSearch()
        {
            InitializeComponent();
            List<humanresourcesDataSet.cityRow> cityresourse = this.tableAdapterManager1.cityTableAdapter.GetData().ToList();
            this.cboCity.DataSource = cityresourse;
            this.cboCity.AutoCompleteCustomSource.AddRange(cityresourse.Select(c => c.City_name).ToArray());
            this.cboCity.DisplayMember = "City_name";
            List<humanresourcesDataSet.dimensionsRow> dimensionsresourse = this.tableAdapterManager1.dimensionsTableAdapter.GetData().ToList();
            this.cboDimensions.Items.AddRange(dimensionsresourse.ToArray());
            this.cboDimensions.DisplayMember = "Dimensions_name";
            List<humanresourcesDataSet.ownershipRow> ownershipresourse = this.tableAdapterManager1.ownershipTableAdapter.GetData().ToList();
            this.cboOwnership.Items.AddRange(ownershipresourse.ToArray());
            this.cboOwnership.DisplayMember = "Ownership_name";
            List<humanresourcesDataSet.clientpropertyRow> clientpropertyresourse = this.tableAdapterManager1.clientpropertyTableAdapter.GetData().ToList();
            this.cboclientproperty.Items.AddRange(clientpropertyresourse.ToArray());
            this.cboclientproperty.DisplayMember = "ClientProperty_name";
            this.cboCity.SelectedIndex = -1;
            this.cboClient_hierarchy.SelectedIndex = 0;
            this.cboClient_status.SelectedIndex = 0;
            this.cboclientproperty.SelectedIndex = 0;
            this.cboOwnership.SelectedIndex = 0;
            this.cboDimensions.SelectedIndex = 0;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCheckBoxList aa = new FrmCheckBoxList(this.llblTrade);
            aa.ShowDialog();
        }
        public List<humanresourcesDataSet.clientRow> SearchClient(List<humanresourcesDataSet.clientRow> OriginalClientList)
        {
            List<humanresourcesDataSet.clientRow> result = OriginalClientList;
            if (!string.IsNullOrEmpty(this.txtClientName.Text))
            {
               // result = result.Where(r => r.Client_name.Contains(this.txtClientName.Text) || r.Client_nameE.Contains(this.txtClientName.Text)).ToList() ;
                result.RemoveAll(r => !r.Client_name.Contains(this.txtClientName.Text) && !r.Client_nameE.Contains(this.txtClientName.Text));
            }
            if (Convert.ToInt32(this.llblTrade.Tag) > 0)
            {
                //result = result.Where(r => r.Trade_id == Convert.ToInt32(this.llblTrade.Tag)).ToList();
                result.RemoveAll(r => r.Trade_id != Convert.ToInt32(this.llblTrade.Tag));
            }
            if ((this.cboCity.SelectedItem  as humanresourcesDataSet.cityRow)!= null)
            {
                //result = result.Where(r => r.City_id == (this.cboCity.SelectedItem as humanresourcesDataSet.cityRow).City_id).ToList();
                result.RemoveAll(r => r.City_id != (this.cboCity.SelectedItem as humanresourcesDataSet.cityRow).City_id);
            }
            if (!this.radioButton3.Checked)
            {
                List<int> id = new List<int>();
                //result = result.Where(r => (this.tableAdapterManager1.contractTableAdapter.GetCurrentContractByClientId(r.Client_id).Count>0) == radioButton1.Checked).ToList();
                //result.RemoveAll(r => (this.tableAdapterManager1.contractTableAdapter.GetCurrentContractByClientId(r.Client_id).Count>0) != radioButton1.Checked);
                //result.RemoveAll(r => (this.tableAdapterManager1.contractTableAdapter.GetCurrentContractByClientId(r.Client_id).Count > 0) != radioButton1.Checked);
                foreach (humanresourcesDataSet.clientRow item in result)
                {
                    humanresourcesDataSet.contractRow c = this.tableAdapterManager1.contractTableAdapter.GetCurrentContractByClientId(item.Client_id).SingleOrDefault();
                    if (radioButton1.Checked)
                    {
                        if (c == null)
                        {
                            id.Add(item.Client_id);
                        }
                        else if (c.Contract_validE.Date > this.dtpContract_validE.Value.Date || c.Contract_validE.Date < this.dtpContract_validS.Value.Date)
                        {
                            id.Add(item.Client_id);
                        }
                        
                    }
                    else if(c!= null)
                    {
                        id.Add(item.Client_id);
                    }
                    
                }
                result.RemoveAll(r =>id.Contains( r.Client_id));
            }
            if (this.cboDimensions.SelectedIndex>0)
            {
                //result = result.Where(r => r.Dimensions_id == (this.cboDimensions.SelectedItem as humanresourcesDataSet.dimensionsRow).Dimensions_id).ToList();
                result.RemoveAll(r => r.Dimensions_id != (this.cboDimensions.SelectedItem as humanresourcesDataSet.dimensionsRow).Dimensions_id);
            }
            if (this.cboclientproperty.SelectedIndex > 0)
            {
                //result = result.Where(r => r.Client_Property == (this.cboclientproperty.SelectedItem as humanresourcesDataSet.clientpropertyRow).ClientProperty_id).ToList();
                result.RemoveAll(r => r.Client_Property != (this.cboclientproperty.SelectedItem as humanresourcesDataSet.clientpropertyRow).ClientProperty_id);
            }
            if (cboClient_status.SelectedIndex>0)
            {
                result.RemoveAll(r => r.Client_status != Convert.ToString(this.cboClient_status.SelectedItem));
            }
            if (cboOwnership.SelectedIndex > 0)
            {
                result.RemoveAll(r => r.Ownership_id != (this.cboOwnership.SelectedItem as humanresourcesDataSet.ownershipRow).Ownership_id);
            }
            if (cboClient_hierarchy.SelectedIndex > 0)
            {
                result.RemoveAll(r => r.Client_hierarchy != Convert.ToString(this.cboClient_hierarchy.SelectedItem));
            }
            if (!string.IsNullOrEmpty(this.txtLinkman.Text) || !string.IsNullOrEmpty(this.txtphone.Text))
            {
                List<int> Clientidlist = this.tableAdapterManager1.linkmanTableAdapter.GetDataByPhoneAndName("%" + this.txtphone.Text.Trim() + "%", "%" + this.txtLinkman.Text.Trim() + "%").Select(l => l.Client_id).ToList();
                //result = result.Where(r => Clientidlist.Contains(r.Client_id)).ToList();
                result.RemoveAll(r => !Clientidlist.Contains(r.Client_id));
            }
            return result;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpContract_validE.Enabled = this.radioButton1.Checked;
            this.dtpContract_validS.Enabled = this.radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpContract_validE.Enabled = this.radioButton1.Checked;
            this.dtpContract_validS.Enabled = this.radioButton1.Checked;
        }
        
    }
}
