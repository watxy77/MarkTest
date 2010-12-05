using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Order
{
    public partial class FrmRecommendedPrc : Form
    {
        humanresourcesDataSet.vw_recommendedRow vwrr = null;
        humanresourcesDataSet.vw_recommended_state_remarkDataTable vwrsrtb = new humanresourcesDataSet.vw_recommended_state_remarkDataTable();
        public FrmRecommendedPrc(int recommendedID)
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            vwrr = this.vw_recommendedTableAdapter1.GetDataByRecommended_Id(recommendedID).SingleOrDefault();
            vw_recommended_state_remarkTableAdapter1.FillByRecommended_ID(vwrsrtb,recommendedID);    
        }
        void bind()
        {
            if (vwrr != null)
            {
                this.lblCandidateName.Text = vwrr.Candidate_name;
                this.lblClientName.Text = string.IsNullOrEmpty(vwrr.Client_name) ? vwrr.Client_name : vwrr.Client_nameE;
                this.lblRecommendedTime.Text = vwrr.Recommended_Time.ToLongDateString();
                this.txtAdvantages.Text = vwrr.Advantages;
                this.txtInferior.Text = vwrr.Inferior;
                this.dataGridView1.DataSource = vwrsrtb;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                humanresourcesDataSet.vw_recommended_state_remarkRow i = (item.DataBoundItem as DataRowView).Row as humanresourcesDataSet.vw_recommended_state_remarkRow;
                item.Cells[0].Value = i.recommended_state_remark_Time.ToLongDateString() + "由" + i.User_realName + "更改状态为" + i.Recommended_State_Name;
                item.Cells[1].Value = i.recommended_state_remark_content;
            }
        }

        private void FrmRecommendedPrc_Load(object sender, EventArgs e)
        {
            bind();
        }

    }
}
