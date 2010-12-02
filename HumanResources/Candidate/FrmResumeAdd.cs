using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Dictionary;
using HumanResources.humanresourcesDataSetTableAdapters;

namespace HumanResources.Candidate
{
    public partial class FrmResumeAdd : Form
    {

        humanresourcesDataSet.resumeRow Editresume = null;
        humanresourcesDataSet.candidateRow EditCandidate = null;
       public List<humanresourcesDataSet.jobsdetailRow> tempJL = new List<humanresourcesDataSet.jobsdetailRow>();
       public List<humanresourcesDataSet.tradeRow> tempTL = new  List<humanresourcesDataSet.tradeRow>();
        public FrmResumeAdd()
        {
            InitializeComponent();
            ContralInit();
            
        } 
        public FrmResumeAdd(int resumeid)
        {
            InitializeComponent();
            this.tableAdapterManager1.resumeTableAdapter.FillByResume_id(this.humanresourcesDataSet1.resume,resumeid);
            Editresume = this.humanresourcesDataSet1.resume.SingleOrDefault();
            this.tableAdapterManager1.candidateTableAdapter.FillByCandidate_id(this.humanresourcesDataSet1.candidate,Editresume.Candidate_id);
            EditCandidate = this.humanresourcesDataSet1.candidate.SingleOrDefault();
            this.tableAdapterManager1.educationTableAdapter.FillByResume_id(this.humanresourcesDataSet1.education, resumeid);
            this.tableAdapterManager1.work_experienceTableAdapter.FillByResume_id(this.humanresourcesDataSet1.work_experience, resumeid);
            ContralInit();
            bind(false);

        }
        public FrmResumeAdd(int CandidateID, bool isnewResume)
        {
            InitializeComponent();
            this.tableAdapterManager1.candidateTableAdapter.FillByCandidate_id(this.humanresourcesDataSet1.candidate, CandidateID);
            EditCandidate = this.humanresourcesDataSet1.candidate.SingleOrDefault();
            ContralInit();
            bind(true);

        }
        private void bind(bool isnewResume)
        {
            this.txtCandidate_name.Text = EditCandidate.Candidate_name;
            this.rbtnCandidate_sexM.Checked = (EditCandidate.Candidate_sex == 1);
            this.rbtnCandidate_sexF.Checked = !(EditCandidate.Candidate_sex == 1);
            this.dtpCandidate_birthday.Value = EditCandidate.Candidate_birthday;
            this.cboMingz.SelectedValue = EditCandidate.Mingz_id;
            this.cboNationality.SelectedValue = EditCandidate.Nationality_id;
            this.cboCandidate_marriage.SelectedItem = EditCandidate.Candidate_marriage;
            this.cboCandidate_papersT.SelectedItem = EditCandidate.Candidate_papersT;
            this.txtCandidate_papersN.Text = EditCandidate.Candidate_papersN;
            this.txtCandidate_method1.Text = EditCandidate.Candidate_method1;
            this.txtCandidate_method2.Text = EditCandidate.Candidate_method2;
            this.txtCandidate_Email.Text = EditCandidate.Candidate_Email;
            this.txtCandidate_telephone.Text = EditCandidate.Candidate_telephone;
            this.cboUser.SelectedValue = EditCandidate.User_id;
            this.cboincumbency_mode.SelectedItem = EditCandidate.incumbency_mode;
            this.txtComment.Text = EditCandidate.Comment;
            this.txtregistered.Text = EditCandidate.registered;
            
            if (!isnewResume)
            {
                this.cboResume_language.SelectedItem = Editresume.Resume_language;
                this.txtResume_overseas.Text = Editresume.Resume_overseas;
                this.cboCity.SelectedValue = Editresume.City_id;
                this.cboCityWant.SelectedValue = Editresume.City_id1;
                this.nudExperience.Value = Editresume.Experience;
                getTradeByIDArr(Editresume.Trade_IDArr);
                this.listBox3.DataSource = null;
                this.listBox3.DataSource = tempTL;
                listBox3.DisplayMember = "Trade_name";
                listBox3.ValueMember = "Trade_id";
                getJobsDetailByIDArr(Editresume.JobsDetail_idArr);
                this.listBox4.DataSource = null;
                this.listBox4.DataSource = tempJL;
                this.nudResume_annual.Value = Editresume.Resume_annual;
                this.nudResume_expectation.Value = Editresume.Resume_expectation;
                this.txtResume_evaluate.Text = Editresume.Resume_evaluate;
                this.dgvEducation.DataSource = this.humanresourcesDataSet1.education;
                this.dgvwork_experience.DataSource = this.humanresourcesDataSet1.work_experience;
            }
           
        }
        private void ContralInit()
        {
            this.dgvEducation.AutoGenerateColumns = false;
            this.dgvwork_experience.AutoGenerateColumns = false;
            cboMingz.DataSource = this.tableAdapterManager1.mingzTableAdapter.GetData() ;
            cboMingz.DisplayMember = "Mingz_name";
            cboMingz.ValueMember = "Mingz_id";
            cboNationality.DataSource = this.tableAdapterManager1.nationalityTableAdapter.GetData();
            cboNationality.DisplayMember = "Nationality_name";
            cboNationality.ValueMember = "Nationality_id";
            cboUser.DataSource = this.tableAdapterManager1.usersTableAdapter.GetData();
            cboUser.DisplayMember = "User_realName";
            cboUser.ValueMember = "User_id";
            cboCity.DataSource = this.tableAdapterManager1.cityTableAdapter.GetData();
            cboCity.DisplayMember = "City_name";
            cboCity.ValueMember = "City_Id";
            cboCityWant.DataSource = this.tableAdapterManager1.cityTableAdapter.GetData();
            cboCityWant.DisplayMember = "City_name";
            cboCityWant.ValueMember = "City_Id";
            cboDegree.DataSource = this.tableAdapterManager1.degreeTableAdapter.GetData();
            cboDegree.DisplayMember = "Degree_name";
            cboDegree.ValueMember = "Degree_id";
            this.cboCandidate_marriage.SelectedIndex = 0;
            this.cboCandidate_papersT.SelectedIndex = 0;
            this.cboCity.SelectedIndex = 0;
            this.cboCityWant.SelectedIndex = 0;
            this.cboDegree.SelectedIndex = 0;
            this.cboincumbency_mode.SelectedIndex = 0;
            this.cboMingz.SelectedIndex = 0;
            this.cboNationality.SelectedIndex = 0;
            this.cboResume_language.SelectedIndex = 0;
            this.cboUser.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCandidate_name.Text))
                {
                    throw new Exception("候选人姓名必须填写!");
                }
                if (EditCandidate == null)
                {
                    EditCandidate = this.humanresourcesDataSet1.candidate.NewcandidateRow();
                    EditCandidate.Candidate_name = this.txtCandidate_name.Text;
                }
                EditCandidate.Candidate_birthday = Convert.ToDateTime(this.dtpCandidate_birthday.Value.ToShortDateString());
                EditCandidate.Candidate_Email = this.txtCandidate_Email.Text;
                EditCandidate.Candidate_marriage = this.cboCandidate_marriage.SelectedItem as string;
                EditCandidate.Candidate_method1 = this.txtCandidate_method1.Text;
                EditCandidate.Candidate_method2 = this.txtCandidate_method2.Text;
                EditCandidate.Candidate_papersN = this.txtCandidate_papersN.Text;
                EditCandidate.Candidate_papersT = this.cboCandidate_papersT.SelectedItem as string;
                EditCandidate.Candidate_sex = this.rbtnCandidate_sexM.Checked ? 1 : 0;
                EditCandidate.Candidate_telephone = this.txtCandidate_telephone.Text.Trim();
                EditCandidate.Comment = this.txtComment.Text;
                EditCandidate.incumbency_mode = this.cboincumbency_mode.SelectedItem as string;
                EditCandidate.Mingz_id =this.cboMingz.SelectedValue==null?0: Convert.ToInt32(this.cboMingz.SelectedValue);
                EditCandidate.Nationality_id =this.cboNationality.SelectedValue == null?0: Convert.ToInt32(this.cboNationality.SelectedValue);
                EditCandidate.recommend_mode = "未推荐";
                EditCandidate.registered = this.txtregistered.Text;
                EditCandidate.User_id =this.cboUser.SelectedValue==null?0: Convert.ToInt32(this.cboUser.SelectedValue);
                int newID = 0;
                if (EditCandidate.Candidate_id > 0)
                {
                    newID = EditCandidate.Candidate_id;
                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                }
                else
                {
                    this.humanresourcesDataSet1.candidate.AddcandidateRow(EditCandidate);
                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                    newID = Convert.ToInt32(this.tableAdapterManager1.candidateTableAdapter.Adapter.InsertCommand.LastInsertedId);
                }
                if (newID > 0)
                {
                    if (Editresume == null)
                    {

                        Editresume = this.humanresourcesDataSet1.resume.NewresumeRow();
                    }
                    Editresume.Candidate_id = newID;
                    Editresume.Resume_ShowName = this.txtCandidate_name.Text;
                    Editresume.City_id = Convert.ToInt32(this.cboCity.SelectedValue);
                    Editresume.City_id1 = Convert.ToInt32(this.cboCityWant.SelectedValue);
                    Editresume.Experience = Convert.ToInt32(this.nudExperience.Value);
                    Editresume.Resume_annual = this.nudResume_annual.Value;
                    Editresume.Resume_expectation = this.nudResume_expectation.Value;
                    Editresume.Resume_evaluate = this.txtResume_evaluate.Text;
                    Editresume.Resume_language = this.cboResume_language.SelectedItem as string;
                    Editresume.Resume_overseas = this.txtResume_overseas.Text;
                    string JArr = "";
                    foreach (humanresourcesDataSet.jobsdetailRow item in tempJL)
                    {
                        JArr += item.JobsDetail_id+ ",";
                    }
                    Editresume.JobsDetail_idArr = JArr;
                    string TArr = "";
                    foreach (humanresourcesDataSet.tradeRow item in tempTL)
                    {
                        TArr += item.Trade_id + ",";
                    }
                    Editresume.Trade_IDArr = TArr;
                    Editresume.update_time = DateTime.Now;
                    int rusumeId = 0;
                    if (Editresume.Resume_id > 0)
                    {
                        rusumeId = Editresume.Resume_id;
                        this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);

                    }
                    else
                    {
                        this.humanresourcesDataSet1.resume.AddresumeRow(Editresume);
                        this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                        rusumeId = Convert.ToInt32(this.tableAdapterManager1.resumeTableAdapter.Adapter.InsertCommand.LastInsertedId);
                    }
                    foreach (humanresourcesDataSet.educationRow item in this.humanresourcesDataSet1.education)
                    {
                        item.Resume_id = item.Resume_id == 0 ? rusumeId : item.Resume_id;
                    }
                    foreach (humanresourcesDataSet.work_experienceRow item in this.humanresourcesDataSet1.work_experience)
                    {
                        item.Resume_id = item.Resume_id == 0 ? rusumeId : item.Resume_id;
                    }
                    if (!string.IsNullOrEmpty(this.txtEvaluate_value.Text) && !string.IsNullOrEmpty(this.txtEvaluate_Comment.Text))
                    {
                        this.humanresourcesDataSet1.evaluate.AddevaluateRow(this.txtEvaluate_value.Text,rusumeId,this.txtEvaluate_Comment.Text,EditCandidate.User_id);
                    }
                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                    MessageBox.Show("保存成功!");
                    FrmResumeInfo fri = new FrmResumeInfo(rusumeId);
                    fri.MdiParent = this.MdiParent;
                    fri.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnTradeAdd_Click(object sender, EventArgs e)
        {
            FrmTradeSelect fts = new FrmTradeSelect(tempTL);
            fts.ShowDialog();
            this.listBox3.DataSource = null;
            this.listBox3.DataSource = tempTL;
            listBox3.DisplayMember = "Trade_name";
            listBox3.ValueMember = "Trade_id";
        }

        private void btnJobsAdd_Click(object sender, EventArgs e)
        {
            FrmJobsSelect fts = new FrmJobsSelect(tempJL);
            fts.ShowDialog();
            this.listBox4.DataSource = null;
            this.listBox4.DataSource = tempJL;
        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            this.dgvEducation.DataSource = null;
            humanresourcesDataSet.educationRow ed = this.humanresourcesDataSet1.education.NeweducationRow();
            ed.degree_id = Convert.ToInt32(cboDegree.SelectedValue);
            ed.Education_DateE = Convert.ToDateTime(dtpEducation_DateE.Value.ToShortDateString());
            ed.Education_DateS = Convert.ToDateTime(dtpEducation_DateS.Value.ToShortDateString());
            ed.Education_major = this.txtEducation_major.Text;
            ed.Education_References = this.txtEducation_References.Text;
            ed.Education_References_Contect = this.txtEducation_References_Contect.Text;
            ed.Education_school = this.txtEducation_school.Text;
            ed.Resume_id = 0;
            this.humanresourcesDataSet1.education.AddeducationRow(ed);
            this.dgvEducation.DataSource = this.humanresourcesDataSet1.education;
        }


        private void btnWork_ExperienceAdd_Click(object sender, EventArgs e)
        {
            this.dgvwork_experience.DataSource = null;
            humanresourcesDataSet.work_experienceRow ed = this.humanresourcesDataSet1.work_experience.Newwork_experienceRow();
            ed.WE_achievement = this.txtWE_achievement.Text;
            ed.WE_DateE = Convert.ToDateTime(dtpWE_DateE.Value.ToShortDateString());
            ed.WE_DateS = Convert.ToDateTime(dtpWE_DateS.Value.ToShortDateString());
            ed.WE_leave = this.txtWE_leave.Text;
            ed.WE_name = this.txtWE_name.Text;
            ed.WE_place = this.txtWE_place.Text;
            ed.WE_position = this.txtWE_position.Text;
            ed.WE_responsibility = this.txtWE_responsibility.Text;
            ed.WE_target = this.txtWE_target.Text;
            ed.WE_id = 0;
            ed.Resume_id = 0;
            this.humanresourcesDataSet1.work_experience.Addwork_experienceRow(ed);
            this.dgvwork_experience.DataSource = this.humanresourcesDataSet1.work_experience;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvEducation_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dgvEducation.Rows)
            {
                humanresourcesDataSet.educationRow ed = item.DataBoundItem as humanresourcesDataSet.educationRow;
                item.Cells[0].Value = ed.Education_DateS.ToShortDateString() + "-" + ed.Education_DateE.ToShortDateString();
                item.Cells[1].Value = this.tableAdapterManager1.degreeTableAdapter.GetDataByDegree_ID(ed.degree_id).SingleOrDefault().Degree_Name;
            }
        }

        private void dgvwork_experience_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dgvwork_experience.Rows)
            {
                humanresourcesDataSet.work_experienceRow ed = item.DataBoundItem as humanresourcesDataSet.work_experienceRow;
                item.Cells[0].Value = ed.WE_DateS.ToShortDateString() + "-" + ed.WE_DateE.ToShortDateString();
            }
        }
        void getTradeByIDArr(string idArr)
        {
            foreach (char item in idArr)
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
        }
        void getJobsDetailByIDArr(string idArr)
        {
            foreach (char item in idArr)
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
        }

        
    }
}
