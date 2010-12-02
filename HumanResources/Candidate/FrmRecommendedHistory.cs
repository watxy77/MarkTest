using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResources.Customer;

namespace HumanResources.Candidate
{
    public partial class FrmRecommendedHistory : Form
    {
        humanresourcesDataSet.vw_recommendedDataTable dt = null;
        public FrmRecommendedHistory(int CandidateID)
        {
            InitializeComponent();
            dt = vw_recommendedTableAdapter1.GetDataByCandidate_id(CandidateID);
            this.dataGridView1.AutoGenerateColumns = false;
            this.lblCandidateName.Text = this.tableAdapterManager1.candidateTableAdapter.GetDataByCandidate_id(CandidateID).SingleOrDefault().Candidate_name;
            this.dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                this.dataGridView1.ClearSelection();
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void tsmiClientInfo_Click(object sender, EventArgs e)
        {
            FrmCusromerInfo fci = new FrmCusromerInfo(((this.dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row as humanresourcesDataSet.vw_recommendedRow).Client_id);
            fci.MdiParent = this.MdiParent;
            fci.Show();
        }

    }
}
