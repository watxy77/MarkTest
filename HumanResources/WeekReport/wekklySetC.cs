using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.WeekReport
{
    public partial class wekklySetC : Form
    {
        
        public wekklySetC()
        {
            InitializeComponent();
            
        }

        private void weeklyc_particularsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.weeklyc_particularsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);

        }

        private void wekklySet_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(0, 0);
                humanresourcesDataSet.usersRow u = ((MDIFrmParent)MdiParent).LoginUser;
                this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1 ,0);
                int i = 0;
                foreach (humanresourcesDataSet.weeklyc_particularsRow item in this.humanresourcesDataSet1.weeklyc_particulars)
                {
                    Label lab = new Label();
                    lab.Text = item.WCP_name;
                    lab.Size = new Size(150, 12);
                    lab.Location = new Point(25, i * 20 + 50);
                    this.groupBox1.Controls.Add(lab);

                    TextBox tb = new TextBox();
                    tb.Text = item.WCP_value.ToString();
                    tb.Size = new Size(65, 12);
                    tb.Location = new Point(177, i * 20 + 50);
                    tb.Name = "tx_" + i;
                    this.groupBox1.Controls.Add(tb);

                    TextBox tb1 = new TextBox();
                    tb1.Text = item.WCP_E;
                    tb1.Size = new Size(250, 12);
                    tb1.Location = new Point(272, i * 20 + 50);
                    tb1.Name = "tx1_" + i;
                    this.groupBox1.Controls.Add(tb1);

                    TextBox tb2 = new TextBox();
                    tb2.Text = item.WCP_S;
                    tb2.Size = new Size(89, 12);
                    tb2.Location = new Point(542, i * 20 + 50);
                    tb2.Name = "tx2_" + i;
                    this.groupBox1.Controls.Add(tb2);
                    i++;
                }

                this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 1);
                i = 0;
                foreach (humanresourcesDataSet.weeklyc_particularsRow item in this.humanresourcesDataSet1.weeklyc_particulars)
                {
                    Label lab = new Label();
                    lab.Text = item.WCP_name;
                    lab.Size = new Size(150, 12);
                    lab.Location = new Point(25, i * 20 + 20);
                    this.groupBox2.Controls.Add(lab);

                    TextBox tb = new TextBox();
                    tb.Text = item.WCP_value.ToString();
                    tb.Size = new Size(65, 12);
                    tb.Location = new Point(177, i * 20 + 20);
                    tb.Name = "ltx_" + i;
                    this.groupBox2.Controls.Add(tb);

                    TextBox tb1 = new TextBox();
                    tb1.Text = item.WCP_E;
                    tb1.Size = new Size(250, 12);
                    tb1.Location = new Point(272, i * 20 + 20);
                    tb1.Name = "ltx1_" + i;
                    this.groupBox2.Controls.Add(tb1);

                    TextBox tb2 = new TextBox();
                    tb2.Text = item.WCP_S;
                    tb2.Size = new Size(89, 12);
                    tb2.Location = new Point(542, i * 20 + 20);
                    tb2.Name = "ltx2_" + i;
                    this.groupBox2.Controls.Add(tb2);
                    i++;
                }

                this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 2);
                i = 0;
                foreach (humanresourcesDataSet.weeklyc_particularsRow item in this.humanresourcesDataSet1.weeklyc_particulars)
                {
                    Label lab = new Label();
                    lab.Text = item.WCP_name;
                    lab.Size = new Size(150, 12);
                    lab.Location = new Point(10, i * 20 + 20);
                    this.groupBox3.Controls.Add(lab);

                    TextBox tb = new TextBox();
                    tb.Text = item.WCP_value.ToString();
                    tb.Size = new Size(65, 12);
                    tb.Location = new Point(167, i * 20 + 20);
                    tb.Name = "lltx_" + i;
                    this.groupBox3.Controls.Add(tb);

                    TextBox tb1 = new TextBox();
                    tb1.Text = item.WCP_E;
                    tb1.Size = new Size(220, 12);
                    tb1.Location = new Point(240, i * 20 + 20);
                    tb1.Name = "lltx1_" + i;
                    this.groupBox3.Controls.Add(tb1);

                    TextBox tb2 = new TextBox();
                    tb2.Text = item.WCP_S;
                    tb2.Size = new Size(220, 12);
                    tb2.Location = new Point(465, i * 20 + 20);
                    tb2.Name = "lltx2_" + i;
                    this.groupBox3.Controls.Add(tb2);
                    i++;
                }
            }
            catch (Exception w) { MessageBox.Show(w.Message); }
           
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 0);
            int i = 0;
            foreach (humanresourcesDataSet.weeklyc_particularsRow item in this.humanresourcesDataSet1.weeklyc_particulars)
            {
                //MessageBox.Show(this.groupBox2.groupBox2.Find("tx_" + i.ToString(), false)[1].Text);
                item.WCP_value = this.groupBox1.Controls.Find("tx_" + i.ToString(), false)[0].Text;
                item.WCP_E = this.groupBox1.Controls.Find("tx1_" + i.ToString(), false)[0].Text;
                item.WCP_S = this.groupBox1.Controls.Find("tx2_" + i.ToString(), false)[0].Text;
                i++;
            }
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 1);
            i = 0;
            foreach (humanresourcesDataSet.weeklyc_particularsRow item in this.humanresourcesDataSet1.weeklyc_particulars)
            {
                // MessageBox.Show(this.Controls.Find("tx_" + i.ToString(), false)[0].Text);
                item.WCP_value =  this.groupBox2.Controls.Find("ltx_" + i.ToString(), false)[0].Text;
                item.WCP_E =  this.groupBox2.Controls.Find("ltx1_" + i.ToString(), false)[0].Text;
                item.WCP_S =  this.groupBox2.Controls.Find("ltx2_" + i.ToString(), false)[0].Text;
                i++;
            }
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 2);
            i = 0;
            foreach (humanresourcesDataSet.weeklyc_particularsRow item in this.humanresourcesDataSet1.weeklyc_particulars)
            {
                // MessageBox.Show(this.Controls.Find("tx_" + i.ToString(), false)[0].Text);
                item.WCP_value = this.groupBox3.Controls.Find("lltx_" + i.ToString(), false)[0].Text;
                item.WCP_E = this.groupBox3.Controls.Find("lltx1_" + i.ToString(), false)[0].Text;
                item.WCP_S = this.groupBox3.Controls.Find("lltx2_" + i.ToString(), false)[0].Text;
                i++;
            }


            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            MessageBox.Show("修改完成！");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
