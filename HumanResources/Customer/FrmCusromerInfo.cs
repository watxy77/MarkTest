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
    public partial class FrmCusromerInfo : Form
    {
        humanresourcesDataSet.clientRow BindClient;
        public FrmCusromerInfo(int Clientid)
        {
            InitializeComponent();
            BindClient = this.tableAdapterManager1.clientTableAdapter.GetDataByClient_id(Clientid).SingleOrDefault();
            bind();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void bind()
        {
            lblUserName.Text = this.tableAdapterManager1.usersTableAdapter.GetDataByUser_id(BindClient.User_id).SingleOrDefault().User_realName;
            lblClient_name.Text = BindClient.Client_name;
            lblClient_nameE.Text = BindClient.Client_nameE;
            try
            {
                lblClient_Property.Text = this.tableAdapterManager1.clientpropertyTableAdapter.GetDataByClientProperty_id(BindClient.Client_Property).SingleOrDefault().ClientProperty_name;
            }
            catch (Exception)
            {

                lblClient_Property.Text = "";
            }
            lblClient_URL.Text = BindClient.Client_URL;
            lblClient_add.Text = BindClient.Client_add;
            lblClient_postcode.Text = BindClient.Client_postcode;
            lblClient_product.Text = BindClient.Client_product;
            lblClient_targetMarket.Text = BindClient.Client_targetMarket;
            try
            {
                lblTrade.Text = this.tableAdapterManager1.tradeTableAdapter.GetDataByTrade_id(BindClient.Trade_id).SingleOrDefault().Trade_name;
            }
            catch (Exception)
            {

                lblTrade.Text = "";
            }
            try
            {
                lblProvince.Text = this.tableAdapterManager1.provinceTableAdapter.GetDataByProvince_id(BindClient.Province_id).SingleOrDefault().Province_name;
            }
            catch (Exception)
            {
                
                lblProvince.Text = "";
            }
            try
            {
                lblCity.Text = this.tableAdapterManager1.cityTableAdapter.GetDataByCity_id(BindClient.City_id).SingleOrDefault().City_name;
            }
            catch (Exception)
            {
                
                lblCity.Text = "";
            }
            lblClient_typical.Text = BindClient.Client_typical;
            try
            {
                lblOwnership.Text = this.tableAdapterManager1.ownershipTableAdapter.GetDataByOwnership_id(BindClient.Ownership_id).SingleOrDefault().Ownership_name;
            }
            catch (Exception)
            {
                
                lblOwnership.Text = "";
            }
            try
            {
                lblOperationModel.Text = this.tableAdapterManager1.operationmodelTableAdapter.GetDataByOperationModel_id(BindClient.OperationModel_id).SingleOrDefault().OperationModel_name;
            }
            catch (Exception)
            {
                
                lblOperationModel.Text = "";
            }
            lblClient_summary.Text = BindClient.Client_summary;
            try
            {
                lblDimensions.Text = this.tableAdapterManager1.dimensionsTableAdapter.GetDataByDimensions_id(BindClient.Dimensions_id).SingleOrDefault().Dimensions_name;
            }
            catch (Exception)
            {
                
                lblDimensions.Text = "";
            }
            try
            {
                lblEmployeesNumber.Text =  this.tableAdapterManager1.employeesnumberTableAdapter.GetDataByEmployeesNumber_id(BindClient.EmployeesNumber_id).SingleOrDefault().EmployeesNumber_name;
            }
            catch (Exception)
            {
                
                lblEmployeesNumber.Text = "";
            }
            lblClient_sales.Text = BindClient.Client_sales.ToString();
            lblClient_structure.Text = BindClient.Client_structure;
            lblClient_development.Text = BindClient.Client_development;
            lblClient_challenge.Text = BindClient.Client_challenge;
            lblClient_turnover.Text = BindClient.Client_turnover;
            lblClient_Intermediate.Text = BindClient.Client_Intermediate;
            lblClient_primary.Text = BindClient.Client_primary;
            lblClient_Join.Text = BindClient.Client_Join;
            lblClient_difficulty.Text = BindClient.Client_difficulty;
            lblClient_cooperation.Text = BindClient.Client_cooperation? "是" : "否";
            lblClient_cooperationN.Text = BindClient.Client_cooperationN;
            lblClient_recruitment.Text = BindClient.Client_recruitment;
            lblClient_cooperationA.Text = BindClient.Client_cooperationA;
            lblClient_staff.Text = BindClient.Client_staff;
            lblClient_income1.Text  = BindClient.Client_income1;
            lblClient_income2.Text = BindClient.Client_income2;
            lblClient_challenge1.Text = BindClient.Client_challenge1;
            lblClient_challenge2.Text = BindClient.Client_challenge2;
            lblClient_interviewing.Text = BindClient.Client_interviewing;
            lblClient_way.Text = BindClient.Client_way;
            lblClient_period.Text = BindClient.Client_period;
            lblClient_welfare.Text = BindClient.Client_welfare;
            lblClient_increase.Text = BindClient.Client_increase;
            lblClient_range.Text = BindClient.Client_range;
            lblClient_reputation.Text = BindClient.Client_reputation;
            lblClient_hierarchy.Text = BindClient.Client_hierarchy;
            lblClient_status.Text = BindClient.Client_status;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmCustomerInfoAdd fcia = new FrmCustomerInfoAdd(BindClient.Client_id);
            fcia.MdiParent = this.MdiParent;
            fcia.Show();
            this.Close();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            if (BindClient.Client_id > 0)
            {
                FrmClientFllowList fols = new FrmClientFllowList(BindClient.Client_id);
                fols.MdiParent = this.MdiParent;
                fols.Show();
            }
        }

        private void btnLinkman_Click(object sender, EventArgs e)
        {
            if (BindClient.Client_id > 0)
            {
                FrmLinkmanList fols = new FrmLinkmanList(BindClient.Client_id);
                fols.MdiParent = this.MdiParent;
                fols.Show();
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            if (BindClient.Client_id > 0)
            {
                FrmContractList fols = new FrmContractList(BindClient.Client_id);
                fols.MdiParent = this.MdiParent;
                fols.Show();
            }
        }


    }
}
