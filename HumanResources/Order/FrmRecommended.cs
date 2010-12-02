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
    public partial class FrmRecommended : Form
    {

        int SuccessId = 0;
        int order_id = 0;
        DataTable dt = null;
        List<humanresourcesDataSet.recommendedRow> clist = new List<humanresourcesDataSet.recommendedRow>();
        List<object[]> remarklist = new List<object[]>(); 
        public FrmRecommended(int orderid)
        {
            InitializeComponent();
            
            order_id = orderid;
            this.dataGridView1.AutoGenerateColumns = false;
            this.recommended_stateDataGridView.AutoGenerateColumns = false;
            this.recommended_stateDataGridView.DataSource =this.tableAdapterManager1.recommended_stateTableAdapter.GetData();
            dt = vw_orderTableAdapter1.GetDataByOrderID(orderid);
            if (dt.Rows.Count > 0)
            {
                bind(dt.Rows[0]);
            }
        }
        void bind(DataRow dr)
        {
            this.lblclient_name.Text = Convert.ToString(dr["client_name"]);
            this.lblOrder_positionN.Text = Convert.ToString(dr["Order_positionN"]);
            this.lblOrder_Stime.Text = Convert.ToDateTime(dr["Order_Stime"]).ToLongDateString();
            this.lbluser_realname.Text = Convert.ToString(dr["user_realname"]);
            this.tableAdapterManager1.recommendedTableAdapter.FillByOrder_id(this.humanresourcesDataSet1.recommended,order_id);
            foreach (humanresourcesDataSet.recommendedRow item in this.humanresourcesDataSet1.recommended)
            {
                
                clist.Add(item);
            }
            this.dataGridView1.DataSource = clist;
        }

        private void btnCandidateInsert_Click(object sender, EventArgs e)
        {
            FrmCandidateSearchSemple fcss = new FrmCandidateSearchSemple(true); 
            fcss.ShowDialog();
            humanresourcesDataSet.candidateRow can = fcss.retrunobj as humanresourcesDataSet.candidateRow;
            if (can != null)
            {
                if (clist.Where(r => r.Candidate_id == can.Candidate_id).Count() == 0)
                {
                    this.dataGridView1.DataSource = null;
                    humanresourcesDataSet.recommendedRow newr = this.humanresourcesDataSet1.recommended.NewrecommendedRow();
                    newr.Order_id = order_id;
                    newr.Candidate_id = can.Candidate_id;
                    newr.Recommended_State_ID = 1;
                    newr.Recommended_Order = this.clist.Count + 1;
                    newr.Users_ID = ((MDIFrmParent)MdiParent).LoginUser.User_id;
                    newr.Recommended_Time = DateTime.Now;
                    clist.Add(newr);
                    this.dataGridView1.DataSource = clist;
                    this.dataGridView1.ClearSelection();
                    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Selected = true;
                    FrmState_remark fsr = new FrmState_remark(1, this.dataGridView1.SelectedRows[0]);
                    fsr.lblState.Text =this.dataGridView1.SelectedRows[0].Cells["recommended_state"].Value.ToString();
                    //fsr.Location= new Point(this.Location.X+ (this.Width - fsr.Width)/2,this.Location.Y);
                    fsr.ShowDialog();
                    newr.Advantages = fsr.ms1;
                    newr.Inferior = fsr.ms2;
                    this.humanresourcesDataSet1.recommended.AddrecommendedRow(newr);
                }
                else
                {
                    MessageBox.Show("已有此候选人!");
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.btnUp.Enabled = (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows[0].Index > 0);
            this.btnDown.Enabled = (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows[0].Index < this.dataGridView1.Rows.Count - 1);
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                humanresourcesDataSet.candidateRow c = this.tableAdapterManager1.candidateTableAdapter.GetDataByCandidate_id(Convert.ToInt32((item.DataBoundItem as humanresourcesDataSet.recommendedRow).Candidate_id)).SingleOrDefault();
                item.Cells["Candidate_id_Name"].Value = c.Candidate_name;
                item.Cells["Candidate_id_Phone"].Value = c.Candidate_method1;
                item.Cells["recommended_state"].Value = this.tableAdapterManager1.recommended_stateTableAdapter.GetDataByRecommended_State_Id((item.DataBoundItem as humanresourcesDataSet.recommendedRow).Recommended_State_ID).SingleOrDefault()["Recommended_State_Name"];
        }
    }

        private void tsmiChangeState_Click(object sender, EventArgs e)
        {
            this.lblCandidateNameInCSP.Text = this.dataGridView1.SelectedRows[0].Cells["Candidate_id_Name"].Value.ToString();
            ChangePanelVisble(this.panel2,true);

        }
        void ChangePanelVisble(Panel panel,bool showorhide)
        {
            foreach (Control item in this.Controls)
            {
                if (!item.Equals(panel))
                {
                    item.Enabled = !showorhide;
                }
                else
                {
                    item.Visible = showorhide;
                }  
            }
        }

        private void btnChangeStateCancel_Click(object sender, EventArgs e)
        {
            ChangePanelVisble(this.panel2, false);

        }

        private void btnChangeStateSure_Click(object sender, EventArgs e)
        {
            ChangePanelVisble(this.panel2, false);
            if (Convert.ToInt32((this.recommended_stateDataGridView.SelectedRows[0].DataBoundItem as DataRowView)["Recommended_State_Id"]) != (this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.recommendedRow).Recommended_State_ID)
            {
                if (Convert.ToInt32((this.recommended_stateDataGridView.SelectedRows[0].DataBoundItem as DataRowView)["Recommended_State_Id"]) == 5)
                {
                    onCanSuccss((this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.recommendedRow).Candidate_id);
                }
                else
                {
                    FrmState_remark fsr = new FrmState_remark(2, this.dataGridView1.SelectedRows[0]);
                    fsr.lblState.Text = (this.recommended_stateDataGridView.SelectedRows[0].DataBoundItem as DataRowView)["Recommended_State_Name"].ToString();
                    fsr.ShowDialog();
                    int selectIndex = this.dataGridView1.SelectedRows[0].Index;
                    (this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.recommendedRow).Recommended_State_ID = Convert.ToInt32((this.recommended_stateDataGridView.SelectedRows[0].DataBoundItem as DataRowView)["Recommended_State_Id"]);
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = clist;
                    this.dataGridView1.Rows[selectIndex].Selected = true;
                    object[] ol = new object[4];
                    ol[0] = ((this.dataGridView1.SelectedRows[0].DataBoundItem ) as humanresourcesDataSet.recommendedRow).Candidate_id;
                    ol[1] = ((this.dataGridView1.SelectedRows[0].DataBoundItem ) as humanresourcesDataSet.recommendedRow).Recommended_State_ID;
                    ol[2] = fsr.ms1;
                    ol[3] = DateTime.Now;
                    remarklist.Add(ol);
                }

            }
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            this.tableAdapterManager1.recommendedTableAdapter.FillByOrder_id(this.humanresourcesDataSet1.recommended,order_id);
            foreach (humanresourcesDataSet.recommendedRow item in humanresourcesDataSet1.recommended)
            {
                foreach (object[] remark in remarklist)
                {
                    if (Convert.ToInt32(remark[0]) == item.Candidate_id)
                    {
                        humanresourcesDataSet.recommended_state_remarkRow newr = this.humanresourcesDataSet1.recommended_state_remark.Newrecommended_state_remarkRow();
                        newr.recommended_ID = item.Recommended_Id;
                        newr.recommended_state_ID = Convert.ToInt32(remark[1]);
                        newr.recommended_state_remark_content = Convert.ToString(remark[2]);
                        newr.recommended_state_remark_Time = Convert.ToDateTime(remark[3]);
                        newr.User_ID = ((MDIFrmParent)MdiParent).LoginUser.User_id;
                        this.humanresourcesDataSet1.recommended_state_remark.Addrecommended_state_remarkRow(newr);
                    }
                }
            }
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            MessageBox.Show("保存成功");
            if (SuccessId > 0)
            {
                Invoice.FrmInvoiceAdd fia = new HumanResources.Invoice.FrmInvoiceAdd(SuccessId);
                fia.ShowDialog();
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void onCanSuccss(int candidateid)
        {
            foreach (humanresourcesDataSet.recommendedRow item in clist)
            {
                if (item.Candidate_id == candidateid)
                {
                    SuccessId = item.Recommended_Id;
                }
                else
                {
                    item.Recommended_State_ID = 4;
                    FrmState_remark fsr = new FrmState_remark(2, this.dataGridView1.SelectedRows[0]);
                    fsr.lblState.Text = (this.recommended_stateDataGridView.SelectedRows[0].DataBoundItem as DataRowView)["Recommended_State_Name"].ToString();
                    fsr.ShowDialog();
                    object[] ol = new object[4];
                    ol[0] = item.Candidate_id;
                    ol[1] = 4;
                    ol[2] = fsr.ms1;
                    ol[3] = DateTime.Now;
                    remarklist.Add(ol);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.btnUp.Enabled = (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows[0].Index > 0);
            this.btnDown.Enabled = (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows[0].Index < this.dataGridView1.Rows.Count-1);
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.SelectedRows[0].Index;
            if (index > 0)
            {
                this.dataGridView1.DataSource = null;
                humanresourcesDataSet.recommendedRow a = this.humanresourcesDataSet1.recommended.NewrecommendedRow();
                a = clist[index - 1];
                clist[index - 1] = clist[index];
                clist[index] = a;
                clist[index].Recommended_Order = index + 1;
                clist[index - 1].Recommended_Order = index;
                this.dataGridView1.DataSource = clist;
                this.dataGridView1.Rows[index - 1].Selected = true;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.SelectedRows[0].Index;
            if (index < (dataGridView1.Rows.Count - 1))
            {
                this.dataGridView1.DataSource = null;
                humanresourcesDataSet.recommendedRow a = this.humanresourcesDataSet1.recommended.NewrecommendedRow();
                a = clist[index];
                clist[index] = clist[index + 1];
                clist[index + 1] = a;
                clist[index + 1].Recommended_Order = index + 2;
                clist[index].Recommended_Order = index + 1;
                this.dataGridView1.DataSource = clist;
                this.dataGridView1.Rows[index + 1].Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOrderInfo foi = new FrmOrderInfo(order_id);
            foi.MdiParent = this.MdiParent;
            foi.Show();
        }

        private void tsmiFace_Click(object sender, EventArgs e)
        {
            if (((this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.recommendedRow).Recommended_State_ID == 3))
            {


                FrmState_remark fsr = new FrmState_remark(2, this.dataGridView1.SelectedRows[0]);
                fsr.label7.Visible = false;
                fsr.label9.Visible = false;
                fsr.lblState.Text = "的面试信息";
                fsr.ShowDialog();
                object[] ol = new object[4];
                ol[0] = (this.dataGridView1.SelectedRows[0].DataBoundItem as humanresourcesDataSet.recommendedRow).Candidate_id;
                ol[1] = 3;
                ol[2] = fsr.ms1;
                ol[3] = DateTime.Now;
                remarklist.Add(ol);
            }
            else
            {
                MessageBox.Show("状态为\"顾问面试\"的候选人才能添加面试信息");
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.dataGridView1.ClearSelection();
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
        
    }
}