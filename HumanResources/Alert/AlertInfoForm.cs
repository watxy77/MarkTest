using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Alert
{
    public partial class AlertInfoForm : Form{
    //{
        private int u_id;
        public AlertInfoForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                humanresourcesDataSet.alert_infoRow newwAI = this.humanresourcesDataSet1.alert_info.Newalert_infoRow();
                newwAI.User_id = u_id;
                newwAI.AI_Theme = textBox1.Text;
                newwAI.AI_Add = textBox2.Text;
                newwAI.AI_Content = textBox3.Text;
                newwAI.AI_STime = this.dtpOrder_officeT.Value.Date;
                newwAI.AI_ETime = this.dateTimePicker4.Value.Date;
                newwAI.AI_Level = this.comboBox1.SelectedIndex;
                newwAI.AI_ATime = this.dateTimePicker3.Value.Date;
                newwAI.AI_CTime = DateTime.Now;
                this.humanresourcesDataSet1.alert_info.Addalert_infoRow(newwAI);
                this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);

                MessageBox.Show("添加成功");

            }
            catch (Exception ww) {

                MessageBox.Show(ww.Message);
            }
           
            //this.Close();
        }

        private void AlertInfoForm_Load(object sender, EventArgs e)
        {
            humanresourcesDataSet.usersRow u = ((MDIFrmParent)MdiParent).LoginUser;
            u_id = u.User_id;
            this.Location = new Point(0, 0);
            this.comboBox1.Items.Add("重要");
            this.comboBox1.Items.Add("一般");
            this.comboBox1.Items.Add("低级");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
