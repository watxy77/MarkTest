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
    public partial class FrmState_remark : Form
    {
       public string ms1 = "";
       public string ms2 = "";
        public FrmState_remark(int type,object obj)
        {
            InitializeComponent();
            this.lblCandidateNameInRP.Text = (obj as DataGridViewRow).Cells["Candidate_id_Name"].Value.ToString();
            switch (type)
            {
                case 1:
                    this.textBox1.Height = 55;
                    this.textBox2.Visible = true;
                    this.label13.Text = "优势";
                    this.label14.Visible = true;
                    
                    break;
                case 2:
                    this.textBox1.Height = 116;
                    this.textBox2.Visible = false;
                    this.label13.Text = "备注";
                    this.label14.Visible = false;
                    this.lblState.Text = (obj as DataGridViewRow).Cells["recommended_state"].Value.ToString();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ms1 = this.textBox1.Text;
            ms2 = this.textBox2.Text;
            this.Close();
        }
    }
}
