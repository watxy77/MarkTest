using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Customer;

using HumanResources.Dictionary;

namespace HumanResources.Order
{
    public partial class FrmOrderInfoAdd : Form
    {
        humanresourcesDataSet.ordersRow EditOrder = null;
        humanresourcesDataSet.usersRow BelongUser = null;
        
        public FrmOrderInfoAdd()
        {
            InitializeComponent();
            ContralDataBind();
        }
        public FrmOrderInfoAdd(humanresourcesDataSet.clientRow cl)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(cl.Client_name))
                {
                    this.llblClient.Text = cl.Client_nameE;
                }
                else
                {
                    this.llblClient.Text = cl.Client_name;
                }
            llblClient.Tag = cl.Client_id;
            ContralDataBind();
        }
        public FrmOrderInfoAdd(int orderid)
        {
            InitializeComponent();
            ContralDataBind();
            this.tableAdapterManager1.ordersTableAdapter.FillByOrder_id(this.humanresourcesDataSet1.orders, orderid);
            EditOrder = this.humanresourcesDataSet1.orders.SingleOrDefault();
            bind();
        }

        private void FrmOrderInfoAdd_Load(object sender, EventArgs e)
        {
            if (EditOrder == null)
            {
                BelongUser = ((MDIFrmParent)MdiParent).LoginUser;
                this.lblUser.Text = BelongUser.User_realName;
            }
        }
        private void ContralDataBind()
        {
            cboCity.DataSource = this.tableAdapterManager1.cityTableAdapter.GetData();
            cboCity.DisplayMember = "City_name";
            cboCity.ValueMember = "City_Id";
            cboDegree_id.DataSource = this.tableAdapterManager1.degreeTableAdapter.GetData();
            cboDegree_id.DisplayMember = "Degree_name";
            cboDegree_id.ValueMember = "Degree_id";
            cboOrder_indirectN1.DataSource = this.tableAdapterManager1.nationalityTableAdapter.GetData();
            cboOrder_indirectN1.DisplayMember = "Nationality_name";
            cboOrder_indirectN1.ValueMember = "Nationality_id";
            cboOrder_reportN1.DataSource = this.tableAdapterManager1.nationalityTableAdapter.GetData();
            cboOrder_reportN1.DisplayMember = "Nationality_name";
            cboOrder_reportN1.ValueMember = "Nationality_id";
            foreach (TabPage item in tabControl1.TabPages)
            {
                foreach (Control ctr in item.Controls)
                {
                    if (ctr.GetType().Equals(typeof(ComboBox)))
                    {
                        ((ComboBox)ctr).SelectedIndex = -1;
                    }
                }
            }
        }
        private void bind()
        {
            this.cboCity.SelectedValue = EditOrder.City_id;
            humanresourcesDataSet.clientRow tempClient = this.tableAdapterManager1.clientTableAdapter.GetDataByClient_id(EditOrder.Client_id).SingleOrDefault();
            this.llblClient.Tag = tempClient.Client_id;
            this.llblClient.Text = string.IsNullOrEmpty(tempClient.Client_name) ? tempClient.Client_nameE : tempClient.Client_name;
            this.txtClient_Selling1.Text = EditOrder.Client_Selling1;
            this.txtClient_Selling2.Text = EditOrder.Client_Selling2;
            this.txtClient_Selling3.Text = EditOrder.Client_Selling3;
            this.txtClient_Selling4.Text = EditOrder.Client_Selling4;
            this.txtClient_Selling5.Text = EditOrder.Client_Selling5;
            this.cboDegree_id.SelectedValue = EditOrder.Degree_id;
            this.txtEducation_major.Text = EditOrder.Education_major;
            this.txtEvaluate_Staff1.Text = EditOrder.Evaluate_Staff1;
            this.txtEvaluate_Staff2.Text = EditOrder.Evaluate_Staff2;
            this.txtEvaluate_Staff3.Text = EditOrder.Evaluate_Staff3;
            this.txtEvaluate_Staff4.Text = EditOrder.Evaluate_Staff4;
            this.nudExperience.Value = EditOrder.Experience;
            this.txtForeignLanguage.Text = EditOrder.ForeignLanguage;
            humanresourcesDataSet.jobsdetailRow tempJobsDetail = this.tableAdapterManager1.jobsdetailTableAdapter.GetDataByJobsDetail_id(EditOrder.JobsDetailID).SingleOrDefault();
            this.llblJobsDetail.Tag = tempJobsDetail.JobsDetail_id;
            this.llblJobsDetail.Text = tempJobsDetail.JobsDetail_name;
            this.cboOrder_allopatry.SelectedIndex = EditOrder.Order_allopatry?0:1;
            this.cboOrder_candidate.SelectedIndex = EditOrder.Order_candidate;
            this.txtOrder_candidateC.Text = EditOrder.Order_candidateC;
            this.txtOrder_company.Text = EditOrder.Order_company;
            this.txtOrder_compendium.Text = EditOrder.Order_compendium;
            this.cboOrder_condition.SelectedIndex = EditOrder.Order_condition;
            this.txtOrder_decision.Text = EditOrder.Order_decision;
            this.txtOrder_equivalentN.Text = EditOrder.Order_equivalentN;
            this.txtOrder_equivalentP.Text = EditOrder.Order_equivalentP;
            this.txtOrder_headcount.Text = EditOrder.Order_headcount.ToString();
            this.txtOrder_indirectN.Text = EditOrder.Order_indirectN;
            this.cboOrder_indirectN1.SelectedValue = EditOrder.Order_indirectN1;
            this.txtOrder_indirectS.Text = EditOrder.Order_indirectS;
            this.txtOrder_instrument.Text = EditOrder.Order_instrument;
            this.txtOrder_Interview1.Text = EditOrder.Order_Interview1;
            this.txtOrder_Interview2.Text = EditOrder.Order_Interview2;
            this.txtOrder_Interview3.Text = EditOrder.Order_Interview3;
            this.txtOrder_Interview4.Text = EditOrder.Order_Interview4;
            this.txtOrder_InterviewADD.Text = EditOrder.Order_InterviewADD;
            this.dtpOrder_InterviewT.Value = EditOrder.Order_InterviewT;
            this.nudOrder_joinN.Value = EditOrder.Order_joinN;
            this.txtOrder_Language.Text = EditOrder.Order_Language;
            this.txtOrder_languageL.Text = EditOrder.Order_languageL;
            this.txtOrder_manageS.Text = EditOrder.Order_manageS;
            this.dtpOrder_officeT.Value = EditOrder.Order_officeT;
            this.txtOrder_Pdescribe.Text = EditOrder.Order_Pdescribe;
            this.txtOrder_positionN.Text = EditOrder.Order_positionN;
            this.cboOrder_positionType.SelectedItem = EditOrder.Order_positionType;
            this.cboOrder_preference.SelectedIndex = EditOrder.Order_preference;
            this.txtOrder_promotion.Text = EditOrder.Order_promotion;
            this.txtOrder_reportN.Text = EditOrder.Order_reportN;
            this.cboOrder_reportN1.SelectedValue = EditOrder.Order_reportN1;
            this.nudOrder_salary.Value = EditOrder.Order_salary;
            this.txtOrder_salaryS.Text = EditOrder.Order_salaryS;
            this.txtOrder_share.Text = EditOrder.Order_share;
            this.dtpOrder_Stime.Value = EditOrder.Order_Stime;
            this.txtOrder_subordinateN.Text = EditOrder.Order_subordinateN.ToString();
            this.txtOrder_turnover.Text = EditOrder.Order_turnover.ToString();
            this.cboOrder_written.SelectedIndex = EditOrder.Order_written?1:0;
            this.txtPosition_Challenge1.Text = EditOrder.Position_Challenge1;
            this.txtPosition_Challenge2.Text = EditOrder.Position_Challenge2;
            this.txtPosition_Challenge3.Text = EditOrder.Position_Challenge3;
            this.txtPosition_Challenge4.Text = EditOrder.Position_Challenge4;
            this.txtPosition_Challenge5.Text = EditOrder.Position_Challenge5;
            this.txtPosition_Difficulty1.Text = EditOrder.Position_Difficulty1;
            this.txtPosition_Difficulty2.Text = EditOrder.Position_Difficulty2;
            this.txtPosition_Difficulty3.Text = EditOrder.Position_Difficulty3;
            this.txtPosition_Difficulty4.Text = EditOrder.Position_Difficulty4;
            this.txtPosition_Difficulty5.Text = EditOrder.Position_Difficulty5;
            this.txtPosition_Duty1.Text = EditOrder.Position_Duty1;
            this.txtPosition_Duty2.Text = EditOrder.Position_Duty2;
            this.txtPosition_Duty3.Text = EditOrder.Position_Duty3;
            this.txtPosition_Duty4.Text = EditOrder.Position_Duty4;
            this.txtPosition_Duty5.Text = EditOrder.Position_Duty5;
            this.txtPosition_Duty6.Text = EditOrder.Position_Duty6;
            this.txtPosition_Selling1.Text = EditOrder.Position_Selling1;
            this.txtPosition_Selling2.Text = EditOrder.Position_Selling2;
            this.txtPosition_Selling3.Text = EditOrder.Position_Selling3;
            this.txtPosition_Selling4.Text = EditOrder.Position_Selling4;
            this.txtPosition_Selling5.Text = EditOrder.Position_Selling5;
            this.cboRecruitment.SelectedValue = EditOrder.Recruitment_id;
            humanresourcesDataSet.tradeRow tempTrade =this.tableAdapterManager1.tradeTableAdapter.GetDataByTrade_id(EditOrder.Trade_ID).SingleOrDefault();
            this.llblTrade_ID.Tag = tempTrade.Trade_id;
            this.llblTrade_ID.Text = tempTrade.Trade_name;
            this.lblUser.Text = this.tableAdapterManager1.usersTableAdapter.GetDataByUser_id(EditOrder.User_id).SingleOrDefault().User_realName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Save();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Save()
        {
            if (this.llblClient.Tag.ToString() == "0")
            {
                throw new Exception("请选择客户");
            }
            if (string.IsNullOrEmpty(this.txtOrderNO.Text))
            {
                throw new Exception("请填写订单号");
            }
            else
            {
                int count = Convert.ToInt32(tableAdapterManager1.ordersTableAdapter.IsOrderNOExists(this.txtOrderNO.Text.Trim()));
                if (count>0)
                {
                    throw new Exception("订单号已存在.请重新填写");
                }
                
            }
            if (EditOrder == null)
            {

                EditOrder = this.humanresourcesDataSet1.orders.NewordersRow();
                EditOrder.Order_CreateTime = DateTime.Now;
            }
            EditOrder.City_id = Convert.ToInt32(this.cboCity.SelectedValue);
            EditOrder.Client_id = Convert.ToInt32(this.llblClient.Tag);
            EditOrder.Client_Selling1 = this.txtClient_Selling1.Text;
            EditOrder.Client_Selling2 = this.txtClient_Selling2.Text;
            EditOrder.Client_Selling3 = this.txtClient_Selling3.Text;
            EditOrder.Client_Selling4 = this.txtClient_Selling4.Text;
            EditOrder.Client_Selling5 = this.txtClient_Selling5.Text;
            EditOrder.Degree_id = Convert.ToInt32(this.cboDegree_id.SelectedValue);
            EditOrder.Education_major = this.txtEducation_major.Text;
            EditOrder.Evaluate_Staff1 = this.txtEvaluate_Staff1.Text;
            EditOrder.Evaluate_Staff2 = this.txtEvaluate_Staff2.Text;
            EditOrder.Evaluate_Staff3 = this.txtEvaluate_Staff3.Text;
            EditOrder.Evaluate_Staff4 = this.txtEvaluate_Staff4.Text;
            EditOrder.Experience = Convert.ToInt32(this.nudExperience.Value);
            EditOrder.ForeignLanguage = this.txtForeignLanguage.Text;
            EditOrder.JobsDetailID = Convert.ToInt32(this.llblJobsDetail.Tag);
            EditOrder.Order_allopatry = this.cboOrder_allopatry.SelectedIndex == 0;
            EditOrder.Order_candidate = this.cboOrder_candidate.SelectedIndex;
            EditOrder.Order_candidateC = this.txtOrder_candidateC.Text;
            EditOrder.Order_company = this.txtOrder_company.Text;
            EditOrder.Order_compendium = this.txtOrder_compendium.Text;
            EditOrder.Order_condition = this.cboOrder_condition.SelectedIndex;
            EditOrder.Order_decision = this.txtOrder_decision.Text;
            EditOrder.Order_equivalentN = this.txtOrder_equivalentN.Text;
            EditOrder.Order_equivalentP = this.txtOrder_equivalentP.Text;
            try
            {
                EditOrder.Order_headcount = Convert.ToInt32(this.txtOrder_headcount.Text);
            }
            catch (Exception)
            {

                EditOrder.Order_headcount = 0;
            }
            EditOrder.Order_indirectN = this.txtOrder_indirectN.Text;
            EditOrder.Order_indirectN1 = Convert.ToInt32(this.cboOrder_indirectN1.SelectedValue);
            EditOrder.Order_indirectS = this.txtOrder_indirectS.Text;
            EditOrder.Order_instrument = this.txtOrder_instrument.Text;
            EditOrder.Order_Interview1 = this.txtOrder_Interview1.Text;
            EditOrder.Order_Interview2 = this.txtOrder_Interview2.Text;
            EditOrder.Order_Interview3 = this.txtOrder_Interview3.Text;
            EditOrder.Order_Interview4 = this.txtOrder_Interview4.Text;
            EditOrder.Order_InterviewADD = this.txtOrder_InterviewADD.Text;
            EditOrder.Order_InterviewT = this.dtpOrder_InterviewT.Value;
            EditOrder.Order_joinN = Convert.ToInt32(this.nudOrder_joinN.Value);
            EditOrder.Order_Language = this.txtOrder_Language.Text;
            EditOrder.Order_languageL = this.txtOrder_languageL.Text;
            EditOrder.Order_manageS = this.txtOrder_manageS.Text;
            EditOrder.Order_officeT = this.dtpOrder_officeT.Value.Date;
            EditOrder.Order_Pdescribe = this.txtOrder_Pdescribe.Text;
            EditOrder.Order_positionN = this.txtOrder_positionN.Text;
            EditOrder.Order_positionType = this.cboOrder_positionType.SelectedItem as string;
            EditOrder.Order_preference = this.cboOrder_preference.SelectedIndex;
            EditOrder.Order_promotion = this.txtOrder_promotion.Text;
            EditOrder.Order_reportN = this.txtOrder_reportN.Text;
            EditOrder.Order_reportN1 = Convert.ToInt32(this.cboOrder_reportN1.SelectedValue);
            EditOrder.Order_salary = Convert.ToInt32(this.nudOrder_salary.Value);
            EditOrder.Order_salaryS = this.txtOrder_salaryS.Text;
            EditOrder.Order_share = this.txtOrder_share.Text;
            EditOrder.Order_Stime = this.dtpOrder_Stime.Value.Date;
            try
            {
                EditOrder.Order_subordinateN = Convert.ToInt32(this.txtOrder_subordinateN.Text);
            }
            catch (Exception)
            {

                EditOrder.Order_subordinateN = 0;
            }
            try
            {
                EditOrder.Order_turnover = Convert.ToDecimal(this.txtOrder_turnover.Text);
            }
            catch (Exception)
            {

                EditOrder.Order_turnover = 0;
            }
            EditOrder.Order_written = this.cboOrder_written.SelectedIndex==1;
            EditOrder.Position_Challenge1 = this.txtPosition_Challenge1.Text;
            EditOrder.Position_Challenge2 = this.txtPosition_Challenge2.Text;
            EditOrder.Position_Challenge3 = this.txtPosition_Challenge3.Text;
            EditOrder.Position_Challenge4 = this.txtPosition_Challenge4.Text;
            EditOrder.Position_Challenge5 = this.txtPosition_Challenge5.Text;
            EditOrder.Position_Difficulty1 = this.txtPosition_Difficulty1.Text;
            EditOrder.Position_Difficulty2 = this.txtPosition_Difficulty2.Text;
            EditOrder.Position_Difficulty3 = this.txtPosition_Difficulty3.Text;
            EditOrder.Position_Difficulty4 = this.txtPosition_Difficulty4.Text;
            EditOrder.Position_Difficulty5 = this.txtPosition_Difficulty5.Text;
            EditOrder.Position_Duty1 = this.txtPosition_Duty1.Text;
            EditOrder.Position_Duty2 = this.txtPosition_Duty2.Text;
            EditOrder.Position_Duty3 = this.txtPosition_Duty3.Text;
            EditOrder.Position_Duty4 = this.txtPosition_Duty4.Text;
            EditOrder.Position_Duty5 = this.txtPosition_Duty5.Text;
            EditOrder.Position_Duty6 = this.txtPosition_Duty6.Text;
            EditOrder.Position_Selling1 = this.txtPosition_Selling1.Text;
            EditOrder.Position_Selling2 = this.txtPosition_Selling2.Text;
            EditOrder.Position_Selling3 = this.txtPosition_Selling3.Text;
            EditOrder.Position_Selling4 = this.txtPosition_Selling4.Text;
            EditOrder.Position_Selling5 = this.txtPosition_Selling5.Text;
            EditOrder.Recruitment_id = Convert.ToInt32(this.cboRecruitment.SelectedValue);
            EditOrder.Trade_ID = Convert.ToInt32(this.llblTrade_ID.Tag);
            EditOrder.User_id = EditOrder.User_id > 0 ? EditOrder.User_id : BelongUser.User_id;
            if (EditOrder.Order_id > 0)
            {
                this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            }
            else
            {
                this.humanresourcesDataSet1.orders.AddordersRow(EditOrder);
                this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                EditOrder = this.tableAdapterManager1.ordersTableAdapter.GetDataByOrder_id(Convert.ToInt32(this.tableAdapterManager1.ordersTableAdapter.Adapter.InsertCommand.LastInsertedId)).SingleOrDefault();
                
            }
            this.panel1.Show();
            this.tabControl1.Enabled = false;
        }

        private void llblClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCusromerSearchSemple FrmselectCusromer = new FrmCusromerSearchSemple(this.llblClient);
            FrmselectCusromer.ShowDialog();
        }

        private void llblTrade_ID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmTradeSelect fts = new FrmTradeSelect(this.llblTrade_ID);
            fts.ShowDialog();
        }

        private void llblJobsDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmJobsSelect fjs = new FrmJobsSelect(this.llblJobsDetail);
            fjs.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOrderInfo foi = new FrmOrderInfo(EditOrder.Order_id);
            foi.MdiParent = this.MdiParent;
            foi.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRecommended drc = new  FrmRecommended(EditOrder.Order_id);
            drc.MdiParent = this.MdiParent;
            drc.Show();
            this.Close();
        }

    }
}
