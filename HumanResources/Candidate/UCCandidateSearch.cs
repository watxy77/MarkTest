using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Candidate
{
    public partial class UCCandidateSearch : UserControl
    {
        public UCCandidateSearch()
        {
            InitializeComponent();
            this.dateTimePicker2.Enabled = checkBox2.Checked;
            this.dateTimePicker4.Enabled = checkBox2.Checked;
            this.dateTimePicker1.Enabled = checkBox1.Checked;
            this.dateTimePicker3.Enabled = checkBox1.Checked;
            this.cboCandidate_marriage.SelectedItem = "不限";
            List<humanresourcesDataSet.nationalityRow> nationalityList = this.tableAdapterManager1.nationalityTableAdapter.GetData().ToList();
            foreach (humanresourcesDataSet.nationalityRow item in nationalityList)
            {
                this.cboNationality.Items.Add(item);
            }
            this.cboNationality.DisplayMember = "Nationality_name";
            this.cboNationality.ValueMember = "Nationality_ID";
            List<humanresourcesDataSet.mingzRow> mingzList = this.tableAdapterManager1.mingzTableAdapter.GetData().ToList();
            foreach (humanresourcesDataSet.mingzRow item in mingzList)
            {
                this.cboMinz.Items.Add(item);
            }
            this.cboMinz.DisplayMember = "Mingz_name";
            this.cboMinz.ValueMember = "Mingz_id";
            List<humanresourcesDataSet.cityRow> cityList = this.tableAdapterManager1.cityTableAdapter.GetData().ToList();
            foreach (humanresourcesDataSet.cityRow item in cityList)
            {
                this.cboCity1.Items.Add(item);
                this.cboCity2.Items.Add(item);
            }
            this.cboCity1.DisplayMember = "City_name";
            this.cboCity1.ValueMember = "City_id";
            this.cboCity2.DisplayMember = "City_name";
            this.cboCity2.ValueMember = "City_id";
        }
        public List<humanresourcesDataSet.vw_resume_candidateRow> SearchCandidate()
        {
            List<humanresourcesDataSet.vw_resume_candidateRow> dt = new List<humanresourcesDataSet.vw_resume_candidateRow>();
            dt = this.vw_resume_candidateTableAdapter1.GetDataBySearch("%" + this.txtCandidate_name.Text + "%", "%" + this.txtOther.Text + "%", "%" + this.txtpapersN.Text + "%", "%" + this.txtEMail.Text + "%", "%" + this.txtRegister.Text + "%", "%" + this.txtMobile.Text + "%").ToList();
            dt = rbtnSexBoth.Checked ? dt : dt.Where(d => (d.Candidate_sex == 1) == this.rbtnMale.Checked).ToList();
            dt = this.cboNationality.SelectedItem == null ? dt : dt.Where(d => d.Nationality_id == (cboNationality.SelectedItem as humanresourcesDataSet.nationalityRow).Nationality_id).ToList();
            dt = this.cboMinz.SelectedItem == null ? dt : dt.Where(d => d.Mingz_id == (cboMinz.SelectedItem as humanresourcesDataSet.mingzRow).Mingz_id).ToList();
            dt = !this.checkBox1.Checked?dt: dt.Where(d => d.Candidate_birthday.Date >= this.dateTimePicker1.Value.Date && d.Candidate_birthday.Date <= this.dateTimePicker3.Value.Date).ToList();
            dt = this.cboCandidate_marriage.SelectedIndex <= 0 ? dt : dt.Where(d => d.Candidate_marriage == this.cboCandidate_marriage.SelectedItem as string).ToList();
            dt = this.cboCity1.SelectedItem == null ? dt : dt.Where(d => d.City_id == (cboCity1.SelectedItem as humanresourcesDataSet.cityRow).City_id).ToList();
            dt = this.cboCity2.SelectedItem == null ? dt : dt.Where(d => d.City_id == (cboCity2.SelectedItem as humanresourcesDataSet.cityRow).City_id).ToList();
            if (this.checkBox2.Checked)
            {
                List<int> id = new List<int>();
                foreach (humanresourcesDataSet.vw_resume_candidateRow item in dt)
                {
                    humanresourcesDataSet.work_experienceRow w = this.tableAdapterManager1.work_experienceTableAdapter.GetFirstDataByResumeID(item.Resume_id).SingleOrDefault();
                    if (w != null)
                    {
                        if (w.WE_DateS.Date < this.dateTimePicker2.Value.Date || w.WE_DateS.Date > this.dateTimePicker4.Value.Date )
                        {
                            id.Add(item.Resume_id);
                        }
                    }
                    else
                    {
                        id.Add(item.Resume_id);
                    }
                }
                foreach (int item in id)
                {
                    dt.Remove(dt.Single(d => d.Resume_id == item));
                } 
            }
            if (!string.IsNullOrEmpty(this.textBox5.Text) || !string.IsNullOrEmpty(this.textBox4.Text))
            {
                List<int> id = new List<int>();
                foreach (humanresourcesDataSet.vw_resume_candidateRow item in dt)
                {
                    humanresourcesDataSet.work_experienceRow w = this.tableAdapterManager1.work_experienceTableAdapter.GetLastDataByResumeID(item.Resume_id).SingleOrDefault();
                    if (w != null)
                    {
                        if (!w.WE_name.Contains(this.textBox5.Text.Trim()) || !w.WE_position.Contains(this.textBox4.Text.Trim()))
                        {
                            id.Add(item.Resume_id);
                        }
                    }
                    else
                    {
                        id.Add(item.Resume_id);
                    }
                }
                foreach (int item in id)
                {
                    dt.Remove(dt.Single(d => d.Resume_id == item));
                } 
            }
            return dt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = checkBox1.Checked;
            this.dateTimePicker3.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker2.Enabled = checkBox2.Checked;
            this.dateTimePicker4.Enabled = checkBox2.Checked;
        }
    }
}
