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
    public partial class FrmCandidateSearchSemple : Form
    {
        public object retrunobj = null;
        public FrmCandidateSearchSemple()
        {
            InitializeComponent();
            
            this.dataGridView1.AutoGenerateColumns = false;
            this.panel1.BringToFront();

                this.tsmicheck.Visible = false;
            
        }
        public FrmCandidateSearchSemple(bool isGetSingle)
        {
            InitializeComponent();
            if (isGetSingle)
            {
                this.tsmicheck.Visible = true;
            }
            this.dataGridView1.AutoGenerateColumns = false;
            this.panel1.BringToFront();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = !this.panel1.Visible;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = ucCandidateSearch1.SearchCandidate();
            this.panel1.Visible = false;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                 foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                item.Selected = false;
            }
            this.dataGridView1.Rows[e.RowIndex].Selected = true;
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void tsmicandidateInfo_Click(object sender, EventArgs e)
        {
            FrmResumeAdd frl = new FrmResumeAdd((this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.vw_resume_candidateRow).Candidate_id, true);
            frl.MdiParent = this.MdiParent;
            frl.Show();
        }

        private void tsmiResumeList_Click(object sender, EventArgs e)
        {
            FrmResumeList frl = new FrmResumeList((this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.vw_resume_candidateRow).Candidate_id);
            frl.MdiParent = this.MdiParent;
            frl.Show();
        }


        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells["Candidate_birthday"].Value =DateTime.Now.Year - (item.DataBoundItem as humanresourcesDataSet.vw_resume_candidateRow).Candidate_birthday.Year;
                item.Cells["Candidate_sex"].Value = (item.DataBoundItem as humanresourcesDataSet.vw_resume_candidateRow).Candidate_sex == 1 ? "男" : "女";
            }
        }

        private void tsmicheck_Click(object sender, EventArgs e)
        {
            retrunobj = this.tableAdapterManager1.candidateTableAdapter.GetDataByCandidate_id((this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.vw_resume_candidateRow).Candidate_id).SingleOrDefault();
            this.Close();
        }

        private void tsmiHistory_Click(object sender, EventArgs e)
        {
            FrmRecommendedHistory frh = new FrmRecommendedHistory((this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.vw_resume_candidateRow).Candidate_id);
            frh.MdiParent = this.MdiParent;
            frh.Show();
        }
    }
}
