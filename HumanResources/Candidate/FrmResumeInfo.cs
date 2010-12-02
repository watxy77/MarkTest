using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Candidate
{
    public partial class FrmResumeInfo : Form
    {
        humanresourcesDataSet.resumeRow bindResume = null;
        humanresourcesDataSet.candidateRow bindCandidate = null;

        public FrmResumeInfo(int resumeid)
        {
            InitializeComponent();
            this.tableAdapterManager1.resumeTableAdapter.FillByResume_id(this. humanresourcesDataSet1.resume, resumeid);
            bindResume = this.humanresourcesDataSet1.resume.SingleOrDefault() ;
            
        }

        private void FrmResumeInfo_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView3.AutoGenerateColumns = false;
            
            Bind();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Bind()
        {
            this.tableAdapterManager1.candidateTableAdapter.FillByCandidate_id(this.humanresourcesDataSet1.candidate, bindResume.Candidate_id);
            bindCandidate = this.humanresourcesDataSet1.candidate.SingleOrDefault();
            this.lblCandidate_name.Text = bindCandidate.Candidate_name;
            this.lblCandidate_sex.Text = bindCandidate.Candidate_sex == 1 ? "男" : "女";
            this.lblCandidate_birthday.Text = bindCandidate.Candidate_birthday.ToShortDateString();
            try
            {
                this.lblMingz_id.Text = this.tableAdapterManager1.mingzTableAdapter.GetDataByMingz_id(bindCandidate.Mingz_id).SingleOrDefault().Mingz_name;
            }
            catch (Exception)
            {

                this.lblMingz_id.Text = "";
            }
            try
            {
                this.lblNationality_id.Text = this.tableAdapterManager1.nationalityTableAdapter.GetDataByNationality_id(bindCandidate.Nationality_id).SingleOrDefault().Nationality_name;
            }
            catch (Exception)
            {
                this.lblNationality_id.Text = "";
            }
            this.lblCandidate_marriage.Text = bindCandidate.Candidate_marriage;
            this.lblCandidate_papersT.Text = bindCandidate.Candidate_papersT;
            this.lblCandidate_papersN.Text = bindCandidate.Candidate_papersN;
            this.lblregistered.Text = bindCandidate.registered;
            this.lblCandidate_method1.Text = bindCandidate.Candidate_method1;
            this.lblCandidate_method2.Text = bindCandidate.Candidate_method2;
            this.lblCandidate_telephone.Text = bindCandidate.Candidate_telephone;
            this.lblCandidate_Email.Text = bindCandidate.Candidate_Email;
            this.lblUser_id.Text = this.tableAdapterManager1.usersTableAdapter.GetDataByUser_id(bindCandidate.User_id).SingleOrDefault().User_realName;
            this.lblincumbency_mode.Text = bindCandidate.incumbency_mode;   
                    this.lblResume_language.Text = bindResume.Resume_language + "简历";

            if (bindResume.City_id <= 0)
            {
                this.lblCity_id.Text = "未知";
                this.lblCity_id1.Text = "未知";
            }
            else
            {
                this.lblCity_id.Text = this.tableAdapterManager1.cityTableAdapter.GetDataByCity_id(bindResume.City_id).SingleOrDefault().City_name;
                this.lblCity_id1.Text = this.tableAdapterManager1.cityTableAdapter.GetDataByCity_id(bindResume.City_id1).SingleOrDefault().City_name;
            }
            List<humanresourcesDataSet.jobsdetailRow> jdl = getJobsDetailByIDArr(bindResume.JobsDetail_idArr);
            List<humanresourcesDataSet.tradeRow> tl = getTradeByIDArr(bindResume.Trade_IDArr);
            if (jdl.Count > 0)
            {
                this.lblJobsDetail_idArr.Text = string.Join(",", jdl.Select(j => j.JobsDetail_name).ToArray());
               
            }
            if (tl.Count > 0)
            {
                this.lblTrade_IDArr.Text = string.Join(",", tl.Select(j => j.Trade_name).ToArray());

            }
            this.lblExperience.Text = bindResume.Experience.ToString() +"年";
            this.lblResume_annual.Text = bindResume.Resume_annual.ToString() +"元";
            this.lblResume_expectation.Text = bindResume.Resume_expectation.ToString() + "元";
            this.lblResume_overseas.Text = bindResume.Resume_overseas;
            this.lblResume_evaluate.Text = bindResume.Resume_evaluate;
            this.lblComment.Text = bindResume.Comment;
            this.tableAdapterManager1.educationTableAdapter.FillByResume_id(this.humanresourcesDataSet1.education,bindResume.Resume_id);
            this.dataGridView1.DataSource = this.humanresourcesDataSet1.education;
            this.tableAdapterManager1.work_experienceTableAdapter.FillByResume_id(this.humanresourcesDataSet1.work_experience, bindResume.Resume_id);
            this.dataGridView3.DataSource = this.humanresourcesDataSet1.work_experience;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                humanresourcesDataSet.educationRow ed = (item.DataBoundItem as DataRowView).Row as humanresourcesDataSet.educationRow;
                item.Cells[0].Value = ed.Education_DateS.ToShortDateString() + "-" + ed.Education_DateE.ToShortDateString();
                item.Cells[3].Value = this.tableAdapterManager1.degreeTableAdapter.GetDataByDegree_ID(ed.degree_id).SingleOrDefault().Degree_Name;
            }
        }

        private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView3.Rows)
            {
                humanresourcesDataSet.work_experienceRow ed = (item.DataBoundItem as DataRowView).Row as humanresourcesDataSet.work_experienceRow;
                item.Cells[0].Value = ed.WE_DateS.ToShortDateString() + "-" + ed.WE_DateE.ToShortDateString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmResumeAdd fca = new FrmResumeAdd(bindResume.Resume_id);
            fca.MdiParent = this.MdiParent;
            fca.Show();
            this.Close();
        }
        List<humanresourcesDataSet.tradeRow> getTradeByIDArr(string idArr)
        {
            List<humanresourcesDataSet.tradeRow> tempTL = new List<humanresourcesDataSet.tradeRow>();
            string[] idarr = idArr.Split(',');
            foreach (string item in idarr)
            {
                try
                {
                    tempTL.Add(this.tableAdapterManager1.tradeTableAdapter.GetDataByTrade_id(Convert.ToInt32(item)).SingleOrDefault());
                }
                catch (Exception)
                {

                    continue;
                }
            }
            return tempTL;
        }
        List<humanresourcesDataSet.jobsdetailRow>  getJobsDetailByIDArr(string idArr)
        {
            List<humanresourcesDataSet.jobsdetailRow> tempJL = new List<humanresourcesDataSet.jobsdetailRow>();
            string[] idarr = idArr.Split(',');
            foreach (string item in idarr)
            {
                try
                {
                    tempJL.Add(this.tableAdapterManager1.jobsdetailTableAdapter.GetDataByJobsDetail_id(Convert.ToInt32(item)).SingleOrDefault());
                }
                catch (Exception)
                {

                    continue;
                }
            }
            return tempJL;
        }

    }
}
