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
    public partial class FrmResumeList : Form
    {
        humanresourcesDataSet.candidateRow c = null;
        public FrmResumeList(int Candidate_id)
        {
            InitializeComponent();
            this.tableAdapterManager1.candidateTableAdapter.FillByCandidate_id(this.humanresourcesDataSet1.candidate, Candidate_id);
            c = this.humanresourcesDataSet1.candidate.SingleOrDefault();
            this.dataGridView1.AutoGenerateColumns = false;
            this.lblCandidate_name.Text = c.Candidate_name;
            this.tableAdapterManager1.resumeTableAdapter.FillByCandidate_id(this.humanresourcesDataSet1.resume, c.Candidate_id);
            this.dataGridView1.DataSource = this.humanresourcesDataSet1.resume;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy年MM月dd日";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmResumeInfo fri = new FrmResumeInfo(((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.resumeRow).Resume_id);
                fri.MdiParent = this.MdiParent;
                fri.Show();
            }
        }

    }
}
