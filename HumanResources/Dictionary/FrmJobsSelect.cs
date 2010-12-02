using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Dictionary
{
    public partial class FrmJobsSelect : Form
    {
        Control EventCtr = null;
        bool isSingle = false;
        List<humanresourcesDataSet.jobsdetailRow> tempJL = null;
        public FrmJobsSelect(List<humanresourcesDataSet.jobsdetailRow> temp)
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            tempJL = temp;
            foreach (humanresourcesDataSet.jobsdetailRow item in tempJL)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.JobsDetail_name;
                cb.Tag = item;
                cb.Checked = true;
                cb.CheckedChanged += new EventHandler(cb_CheckedChanged);    
                this.flowLayoutPanel1.Controls.Add(cb);
            }
        }
        public FrmJobsSelect(Control eventCtr)
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            isSingle = true;
            this.EventCtr = eventCtr;
            tempJL = new List<humanresourcesDataSet.jobsdetailRow>();

            if (Convert.ToInt32(eventCtr.Tag)>0)
            {
                humanresourcesDataSet.jobsdetailRow item = this.tableAdapterManager1.jobsdetailTableAdapter.GetDataByJobsDetail_id(Convert.ToInt32(eventCtr.Tag)).SingleOrDefault();
                tempJL.Add(item);
                CheckBox cb = new CheckBox();
                cb.Text = item.JobsDetail_name;
                cb.Tag = item;
                cb.Checked = true;
                cb.CheckedChanged += new EventHandler(cb_CheckedChanged);
                this.flowLayoutPanel1.Controls.Add(cb);
            }
                
        }
        void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if(!cb.Checked)
            {
                this.flowLayoutPanel1.Controls.Remove(cb);
                tempJL.Remove(tempJL.Single(t => t.JobsDetail_id == (cb.Tag as humanresourcesDataSet.jobsdetailRow).JobsDetail_id));
            }
        }

        private void linkLabel_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource=null;
            List<humanresourcesDataSet.jobsdetailRow> jl = this.tableAdapterManager1.jobsdetailTableAdapter.GetDataByJobs_id(Convert.ToInt32(((Control)sender).Tag)).ToList();
            this.dataGridView1.DataSource = jl;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[0].Value = tempJL.Select(j => j.JobsDetail_id).Contains((item.DataBoundItem as humanresourcesDataSet.jobsdetailRow).JobsDetail_id);
                
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            this.tempJL.Clear();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[0].Value = false;
            }
            if (this.EventCtr != null)
            {
                EventCtr.Text = "请选择";
                EventCtr.Tag = 0;
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value))
            {
                if (isSingle)
                {
                    this.flowLayoutPanel1.Controls.Clear();
                    this.tempJL.Clear();
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        item.Cells[0].Value = false;
                    }
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
                }
                humanresourcesDataSet.jobsdetailRow j = dataGridView1.Rows[e.RowIndex].DataBoundItem as humanresourcesDataSet.jobsdetailRow;
                if (!tempJL.Select(t=>t.JobsDetail_id).Contains(j.JobsDetail_id))
                {
                    tempJL.Add(j);
                }
                CheckBox cb = new CheckBox();
                cb.Text = j.JobsDetail_name;
                cb.Tag = j;
                cb.Checked = true;
                cb.CheckedChanged += new EventHandler(cb_CheckedChanged);   
                this.flowLayoutPanel1.Controls.Add(cb);
                
            }
            else
            {
                humanresourcesDataSet.jobsdetailRow j = dataGridView1.Rows[e.RowIndex].DataBoundItem as humanresourcesDataSet.jobsdetailRow;
                if (tempJL.Select(t => t.JobsDetail_id).Contains(j.JobsDetail_id))
                {
                    tempJL.Remove(tempJL.Single(t=>t.JobsDetail_id==j.JobsDetail_id));
                }
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    if (item.GetType() == typeof(CheckBox))
                    {
                        if (((humanresourcesDataSet.jobsdetailRow)item.Tag).JobsDetail_id == j.JobsDetail_id)
                        {
                            flowLayoutPanel1.Controls.Remove(item);
                        }
                    }
                }
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (isSingle)
            {
                if (tempJL.Count > 0)
                {
                    EventCtr.Tag = tempJL[0].JobsDetail_id;
                    EventCtr.Text = tempJL[0].JobsDetail_name;
                }
            }
            this.Close();
        }
    }
}
