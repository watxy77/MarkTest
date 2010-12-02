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
    public partial class FrmCustomerInfoAdd : Form
    {
        bool isEdit = false;
        Form before = null;
        humanresourcesDataSet.linkmanDataTable ldt = new humanresourcesDataSet.linkmanDataTable();
        humanresourcesDataSet.client_followDataTable cfdt = new humanresourcesDataSet.client_followDataTable();
        public FrmCustomerInfoAdd()
        {
            InitializeComponent();
        }
        public FrmCustomerInfoAdd(Form beforeForm)
        {
            before = beforeForm;
            InitializeComponent();
            MDIFrmParent parent = (MDIFrmParent)ParentForm;
        }
        public FrmCustomerInfoAdd(int rid)
        {
            InitializeComponent();
            this.tableAdapterManager1.clientTableAdapter.FillByClient_id(this.humanresourcesDataSet1.client, rid);

        }
        private void FrmCustomerInfoAdd_Load(object sender, EventArgs e)
        {

            this.lblUserName.Text = ((MDIFrmParent)this.MdiParent).LoginUser.User_realName;
            this.lblUserName.Tag = ((MDIFrmParent)this.MdiParent).LoginUser.User_id;
            cboClient_Property.DataSource = this.tableAdapterManager1.clientpropertyTableAdapter.GetData();
            cboClient_Property.DisplayMember = "ClientProperty_name";
            cboClient_Property.ValueMember = "ClientProperty_Id";
            cboOwnership.DataSource = this.tableAdapterManager1.ownershipTableAdapter.GetData();
            cboOwnership.DisplayMember = "Ownership_name";
            cboOwnership.ValueMember = "Ownership_Id";
            cboTrade.DataSource = this.tableAdapterManager1.tradeTableAdapter.GetData();
            cboTrade.DisplayMember = "Trade_name";
            cboTrade.ValueMember = "Trade_id";
            cboProvince.DataSource = this.tableAdapterManager1.provinceTableAdapter.GetData();
            cboProvince.DisplayMember = "Province_name";
            cboProvince.ValueMember = "Province_Id";
            cboOperationModel.DataSource = this.tableAdapterManager1.operationmodelTableAdapter.GetData();
            cboOperationModel.DisplayMember = "OperationModel_name";
            cboOperationModel.ValueMember = "OperationModel_Id";
            cboDimensions.DataSource = this.tableAdapterManager1.dimensionsTableAdapter.GetData();
            cboDimensions.DisplayMember = "Dimensions_name";
            cboDimensions.ValueMember = "Dimensions_Id";
            cboEmployeesNumber.DataSource = this.tableAdapterManager1.employeesnumberTableAdapter.GetData();
            cboEmployeesNumber.DisplayMember = "EmployeesNumber_name";
            cboEmployeesNumber.ValueMember = "EmployeesNumber_Id";
            bind();
            foreach (TabPage item in this.tabControl1.Controls)
            {
                foreach (Control control in item.Controls)
                {
                    control.TextChanged += new EventHandler(onEdit);
                }
            }
        }
        void bind()
        {
            if (this.humanresourcesDataSet1.client.Count > 0)
            {
                humanresourcesDataSet.clientRow c = this.humanresourcesDataSet1.client.SingleOrDefault();
                this.txtClient_add.Text = c.Client_add;
                this.txtClient_challenge.Text = c.Client_challenge;
                this.txtClient_challenge1.Text = c.Client_challenge1;
                this.txtClient_challenge2.Text = c.Client_challenge2;
                this.rbnClient_cooperationYes.Checked = c.Client_cooperation;
                this.txtClient_cooperationA.Text = c.Client_cooperationA;
                this.txtClient_cooperationN.Text = c.Client_cooperationN;
                this.txtClient_development.Text = c.Client_development;
                this.txtClient_difficulty.Text = c.Client_difficulty;
                this.cboClient_hierarchy.SelectedText = c.Client_hierarchy;
                this.txtClient_income1.Text = c.Client_income1;
                this.txtClient_income2.Text = c.Client_income2;
                this.txtClient_increase.Text = c.Client_increase;
                this.txtClient_Intermediate.Text = c.Client_Intermediate;
                this.txtClient_interviewing.Text = c.Client_interviewing;
                this.txtClient_Join.Text = c.Client_Join;
                this.txtClient_name.Text = c.Client_name;
                this.txtClient_nameE.Text = c.Client_nameE;
                this.txtClient_period.Text = c.Client_period;
                this.txtClient_postcode.Text = c.Client_postcode;
                this.txtClient_primary.Text = c.Client_primary;
                this.txtClient_product.Text = c.Client_product;
                this.cboClient_Property.SelectedValue = c.Client_Property;
                this.txtClient_range.Text = c.Client_range;
                this.txtClient_recruitment.Text = c.Client_recruitment;
                this.cboClient_reputation.SelectedText = c.Client_reputation;
                this.nudClient_sales.Value = c.Client_sales;
                this.txtClient_staff.Text = c.Client_staff;
                this.cboClient_status.SelectedText = c.Client_status;
                this.txtClient_structure.Text = c.Client_structure;
                this.txtClient_summary.Text = c.Client_summary;
                this.txtClient_targetMarket.Text = c.Client_targetMarket;
                this.txtClient_turnover.Text = c.Client_turnover;
                this.txtClient_typical.Text = c.Client_typical;
                this.txtClient_URL.Text = c.Client_URL;
                this.txtClient_way.Text = c.Client_way;
                this.txtClient_welfare.Text = c.Client_welfare;
                this.cboDimensions.SelectedValue = c.Dimensions_id;
                this.cboEmployeesNumber.SelectedValue = c.EmployeesNumber_id;
                this.cboOperationModel.SelectedValue = c.OperationModel_id;
                this.cboOwnership.SelectedValue = c.Ownership_id;
                this.cboProvince.SelectedValue = c.Province_id;
                this.cboTrade.SelectedValue = c.Trade_id;
                this.lblUserName.Text = this.tableAdapterManager1.usersTableAdapter.GetDataByUser_id(c.User_id).SingleOrDefault().User_realName;
                this.tableAdapterManager1.recruitment_quantityTableAdapter.FillByClientIDAndYear(this.humanresourcesDataSet1.recruitment_quantity, c.Client_id, DateTime.Now.Year.ToString());
                if (this.humanresourcesDataSet1.recruitment_quantity.Count > 0)
                {
                    this.txtRQ_LyearT.Text = this.humanresourcesDataSet1.recruitment_quantity.SingleOrDefault().RQ_LyearT;
                    this.txtRQ_Lyear.Text = this.humanresourcesDataSet1.recruitment_quantity.SingleOrDefault().RQ_Lyear;
                    this.txtRQ_futureT.Text = this.humanresourcesDataSet1.recruitment_quantity.SingleOrDefault().RQ_futureT;
                    this.txtRQ_future.Text = this.humanresourcesDataSet1.recruitment_quantity.SingleOrDefault().RQ_future;
                }

            }
        }
        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboProvince.SelectedValue) > 0)
            {
                cboCity.DataSource = this.tableAdapterManager1.cityTableAdapter.GetDataByProvince_id(Convert.ToInt32(cboProvince.SelectedValue));
                cboCity.DisplayMember = "City_name";
                cboCity.ValueMember = "City_Id";
            }
        }
        private void onEdit(object sender, EventArgs e)
        {
            isEdit = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                if (MessageBox.Show("输入的信息还未保存,确定要退出?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.txtClient_name.Text) && string.IsNullOrEmpty(this.txtClient_nameE.Text))
                {
                    throw new Exception("中英文客户名称至少填写一个");
                }
                humanresourcesDataSet.clientRow c = null;
                if (this.humanresourcesDataSet1.client.Count > 0)
                {
                    c = humanresourcesDataSet1.client.SingleOrDefault();
                }
                else
                {
                    c = this.humanresourcesDataSet1.client.NewclientRow();
                }

                c.Client_add = this.txtClient_add.Text;
                c.Client_challenge = this.txtClient_challenge.Text;
                c.Client_challenge1 = this.txtClient_challenge1.Text;
                c.Client_challenge2 = this.txtClient_challenge2.Text;
                c.Client_cooperation = this.rbnClient_cooperationYes.Checked;
                c.Client_cooperationA = this.txtClient_cooperationA.Text;
                c.Client_cooperationN = this.txtClient_cooperationN.Text;
                c.Client_development = this.txtClient_development.Text;
                c.Client_difficulty = this.txtClient_difficulty.Text;
                c.Client_establishT = DateTime.Now;
                c.Client_hierarchy = this.cboClient_hierarchy.SelectedText;
                c.Client_income1 = this.txtClient_income1.Text;
                c.Client_income2 = this.txtClient_income2.Text;
                c.Client_increase = this.txtClient_increase.Text;
                c.Client_Intermediate = this.txtClient_Intermediate.Text;
                c.Client_interviewing = this.txtClient_interviewing.Text;
                c.Client_Join = this.txtClient_Join.Text;
                c.Client_name = this.txtClient_name.Text;
                c.Client_nameE = this.txtClient_nameE.Text;
                c.Client_period = this.txtClient_period.Text;
                c.Client_postcode = this.txtClient_postcode.Text;
                c.Client_primary = this.txtClient_primary.Text;
                c.Client_product = this.txtClient_product.Text;
                c.Client_Property = Convert.ToInt32(this.cboClient_Property.SelectedValue);
                c.Client_range = this.txtClient_range.Text;
                c.Client_recruitment = this.txtClient_recruitment.Text;
                c.Client_reputation = this.cboClient_reputation.SelectedText;
                c.Client_sales = this.nudClient_sales.Value;
                c.Client_staff = this.txtClient_staff.Text;
                c.Client_status = this.cboClient_status.SelectedText;
                c.Client_structure = this.txtClient_structure.Text;
                c.Client_summary = this.txtClient_summary.Text;
                c.Client_targetMarket = this.txtClient_targetMarket.Text;
                c.Client_turnover = this.txtClient_turnover.Text;
                c.Client_typical = this.txtClient_typical.Text;
                c.Client_URL = this.txtClient_URL.Text;
                c.Client_way = this.txtClient_way.Text;
                c.Client_welfare = this.txtClient_welfare.Text;
                c.Dimensions_id = Convert.ToInt32(this.cboDimensions.SelectedValue);
                c.City_id = Convert.ToInt32(this.cboCity.SelectedValue);
                c.EmployeesNumber_id = Convert.ToInt32(this.cboEmployeesNumber.SelectedValue);
                c.OperationModel_id = Convert.ToInt32(this.cboOperationModel.SelectedValue);
                c.Ownership_id = Convert.ToInt32(this.cboOwnership.SelectedValue);
                c.Province_id = Convert.ToInt32(this.cboProvince.SelectedValue);
                c.Trade_id = Convert.ToInt32(this.cboTrade.SelectedValue);
                c.User_id = Convert.ToInt32(this.lblUserName.Tag);
                if (c.Client_id <= 0)
                {
                    this.humanresourcesDataSet1.client.AddclientRow(c);
                }
                this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);

                int clientid = c.Client_id <= 0 ? Convert.ToInt32(this.tableAdapterManager1.clientTableAdapter.Adapter.InsertCommand.LastInsertedId) : c.Client_id;
                if (clientid > 0)
                {
                    humanresourcesDataSet.recruitment_quantityRow rq = null;
                    if (humanresourcesDataSet1.recruitment_quantity.Count == 0)
                    {
                        rq = this.humanresourcesDataSet1.recruitment_quantity.Newrecruitment_quantityRow();
                    }
                    else
                    {
                        rq = this.humanresourcesDataSet1.recruitment_quantity.SingleOrDefault();
                    }
                    rq.Client_id = clientid;
                    rq.RQ_future = this.txtRQ_future.Text.Trim();
                    rq.RQ_futureT = this.txtRQ_futureT.Text.Trim();
                    rq.RQ_Lyear = txtRQ_Lyear.Text.Trim();
                    rq.RQ_LyearT = txtRQ_LyearT.Text.Trim();
                    rq.RQ_Year = DateTime.Now.Year.ToString();

                    if (humanresourcesDataSet1.recruitment_quantity.Count == 0)
                    {
                        this.humanresourcesDataSet1.recruitment_quantity.Addrecruitment_quantityRow(rq);
                    }
                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                    MessageBox.Show("保存成功!");
                    isEdit = false;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



    }
}
