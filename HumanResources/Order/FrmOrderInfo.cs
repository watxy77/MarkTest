using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Candidate;

namespace HumanResources.Order
{
    public partial class FrmOrderInfo : Form
    {
        humanresourcesDataSet.vw_orderDataTable OrderTable = new humanresourcesDataSet.vw_orderDataTable();
        public FrmOrderInfo(int BindOrder_id)
        {
            InitializeComponent();
            this.vw_orderTableAdapter1.FillByOrderID(OrderTable,BindOrder_id);
            bind();
        }

        private void bind()
        {
            if (OrderTable.Rows.Count > 0)
            {
                DataRow dr = OrderTable.Rows[0];
                this.lblClient_Name.Text = Convert.ToString(dr["Client_Name"]);
                this.llbl_Userrealname.Text = Convert.ToString(dr["user_realName"]);
                this.llbl_Userrealname.Click += new EventHandler(llbl_Userrealname_Click);
                this.lblOrder_Stime.Text = Convert.ToDateTime(dr["Order_Stime"]).ToLongDateString();
                this.lblcity.Text = Convert.ToString(dr["city_name"]);
                this.lblOrder_joinN.Text = Convert.ToString(dr["Order_joinN"]);
                this.lblOrder_positionType.Text = Convert.ToString(dr["Order_positionType"]);
                this.lblOrder_positionN.Text = Convert.ToString(dr["Order_positionN"]);
                this.lblOrder_salary.Text = Convert.ToString(dr["Order_salary"]);
                this.lblOrder_salaryS.Text = Convert.ToString(dr["Order_salaryS"]);
                this.lblOrder_officeT.Text = Convert.ToDateTime(dr["Order_officeT"]).ToLongDateString();
                this.lbldegree_name.Text = Convert.ToString(dr["degree_name"]);
                this.lblOrder_Language.Text = Convert.ToString(dr["Order_Language"]);
                this.lblOrder_languageL.Text = Convert.ToString(dr["Order_languageL"]);
                this.lblForeignLanguage.Text = Convert.ToString(dr["ForeignLanguage"]);
                this.lblOrder_compendium.Text = Convert.ToString(dr["Order_compendium"]);
                this.lblOrder_reportN.Text = Convert.ToString(dr["Order_reportN"]);
                this.lblOrder_reportN1name.Text = Convert.ToString(dr["Order_reportN1name"]);
                this.lblOrder_manageS.Text = Convert.ToString(dr["Order_manageS"]);
                this.lblOrder_indirectN.Text = Convert.ToString(dr["Order_indirectN"]);
                this.lblOrder_indirectN1name.Text = Convert.ToString(dr["Order_indirectN1name"]);
                this.lblOrder_indirectS.Text = Convert.ToString(dr["Order_indirectS"]);
                this.lblOrder_subordinateN.Text = Convert.ToString(dr["Order_subordinateN"]);
                this.lblOrder_equivalentN.Text = Convert.ToString(dr["Order_equivalentN"]);
                this.lblOrder_equivalentP.Text = Convert.ToString(dr["Order_equivalentP"]);
                this.lblOrder_turnover.Text = Convert.ToString(dr["Order_turnover"]);
                this.lblOrder_headcount.Text = Convert.ToString(dr["Order_headcount"]);
                this.lblOrder_share.Text = Convert.ToString(dr["Order_share"]);
                this.lblOrder_candidate.Text = Convert.ToBoolean(dr["Order_candidate"]) ? "是" : "否";
                this.lblOrder_candidateC.Text = Convert.ToString(dr["Order_candidateC"]);
                this.lbljobsdetail_name.Text = Convert.ToString(dr["jobsdetail_name"]);
                this.lbltrade_name.Text = Convert.ToString(dr["trade_name"]);
                this.lblExperience.Text = Convert.ToString(dr["Experience"]);
                this.lblEducation_major.Text = Convert.ToString(dr["Education_major"]);
                this.lblOrder_instrument.Text = Convert.ToString(dr["Order_instrument"]);
                this.lblOrder_allopatry.Text = Convert.ToBoolean(dr["Order_allopatry"]) ? "是" : "否";
                this.lblOrder_preference.Text = Convert.ToBoolean(dr["Order_preference"]) ? Convert.ToString(dr["Order_company"]) : "否";
                this.lblOrder_promotion.Text = Convert.ToString(dr["Order_promotion"]);
                this.lblOrder_Interview1.Text = Convert.ToString(dr["Order_Interview1"]);
                this.lblOrder_Interview2.Text = Convert.ToString(dr["Order_Interview2"]);
                this.lblOrder_Interview3.Text = Convert.ToString(dr["Order_Interview3"]);
                this.lblOrder_Interview4.Text = Convert.ToString(dr["Order_Interview4"]);
                this.lblOrder_written.Text = Convert.ToBoolean(dr["Order_written"]) ? "是" : "否";
                this.lblOrder_InterviewT.Text = Convert.ToDateTime(dr["Order_InterviewT"]).ToLongDateString();
                this.lblOrder_decision.Text = Convert.ToString(dr["Order_decision"]);
                this.lblOrder_condition.Text = Convert.ToBoolean(dr["Order_condition"]) ? "是" : "否";
                this.lblOrder_InterviewADD.Text = Convert.ToString(dr["Order_InterviewADD"]);
                this.lblOrder_Pdescribe.Text = Convert.ToString(dr["Order_Pdescribe"]);
                this.lblPosition_Duty1.Text = Convert.ToString(dr["Position_Duty1"]);
                this.lblPosition_Duty2.Text = Convert.ToString(dr["Position_Duty2"]);
                this.lblPosition_Duty3.Text = Convert.ToString(dr["Position_Duty3"]);
                this.lblPosition_Duty4.Text = Convert.ToString(dr["Position_Duty4"]);
                this.lblPosition_Duty5.Text = Convert.ToString(dr["Position_Duty5"]);
                this.lblPosition_Duty6.Text = Convert.ToString(dr["Position_Duty6"]);
                this.lblRecruitment_name.Text = Convert.ToString(dr["Recruitment_name"]);
                this.lblEvaluate_Staff1.Text = Convert.ToString(dr["Evaluate_Staff1"]);
                this.lblEvaluate_Staff2.Text = Convert.ToString(dr["Evaluate_Staff2"]);
                this.lblEvaluate_Staff3.Text = Convert.ToString(dr["Evaluate_Staff3"]);
                this.lblEvaluate_Staff4.Text = Convert.ToString(dr["Evaluate_Staff4"]);
                this.lblClient_Selling1.Text = Convert.ToString(dr["Client_Selling1"]);
                this.lblClient_Selling2.Text = Convert.ToString(dr["Client_Selling2"]);
                this.lblClient_Selling3.Text = Convert.ToString(dr["Client_Selling3"]);
                this.lblClient_Selling4.Text = Convert.ToString(dr["Client_Selling4"]);
                this.lblClient_Selling5.Text = Convert.ToString(dr["Client_Selling5"]);
                this.lblPosition_Selling1.Text = Convert.ToString(dr["Position_Selling1"]);
                this.lblPosition_Selling2.Text = Convert.ToString(dr["Position_Selling2"]);
                this.lblPosition_Selling3.Text = Convert.ToString(dr["Position_Selling3"]);
                this.lblPosition_Selling4.Text = Convert.ToString(dr["Position_Selling4"]);
                this.lblPosition_Selling5.Text = Convert.ToString(dr["Position_Selling5"]);
                this.lblPosition_Difficulty1.Text = Convert.ToString(dr["Position_Difficulty1"]);
                this.lblPosition_Difficulty2.Text = Convert.ToString(dr["Position_Difficulty2"]);
                this.lblPosition_Difficulty3.Text = Convert.ToString(dr["Position_Difficulty3"]);
                this.lblPosition_Difficulty4.Text = Convert.ToString(dr["Position_Difficulty4"]);
                this.lblPosition_Difficulty5.Text = Convert.ToString(dr["Position_Difficulty5"]);
                this.lblPosition_Challenge1.Text = Convert.ToString(dr["Position_Challenge1"]);
                this.lblPosition_Challenge2.Text = Convert.ToString(dr["Position_Challenge2"]);
                this.lblPosition_Challenge3.Text = Convert.ToString(dr["Position_Challenge3"]);
                this.lblPosition_Challenge4.Text = Convert.ToString(dr["Position_Challenge4"]);
                this.lblPosition_Challenge5.Text = Convert.ToString(dr["Position_Challenge5"]);
            }
            else
            {
                this.Close();
            }
            
        }

        void llbl_Userrealname_Click(object sender, EventArgs e)
        {
            Users.FrmUserInfo fui = new HumanResources.Users.FrmUserInfo(Convert.ToInt32(OrderTable.Rows[0]["User_ID"]));
            fui.MdiParent = this.MdiParent;
            fui.Show();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            FrmRecommended frc = new FrmRecommended(Convert.ToInt32(OrderTable.Rows[0]["Order_id"]));
            frc.MdiParent = this.MdiParent;
            frc.Show();
        }

    }
}
