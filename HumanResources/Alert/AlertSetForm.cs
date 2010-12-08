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
    public partial class AlertSetForm : Form
    {
        public AlertSetForm()
        {
            InitializeComponent();
        }

        private void AlertSetForm_Load(object sender, EventArgs e)
        {
            this.tableAdapterManager1.alert_configTableAdapter.FillByAll(this.humanresourcesDataSet1.alert_config);
            foreach (humanresourcesDataSet.alert_configRow item2 in this.humanresourcesDataSet1.alert_config)
            {
                textBox3.Text = item2.AC_DTime.ToString();
                textBox4.Text = item2.AC_STime.ToString();
                textBox5.Text = item2.AC_MTime.ToString();
                if (item2.AC_Title == 1) checkBox1.Checked = true;
                if (item2.AC_Info == 1) checkBox2.Checked = true;
                if (item2.AC_Close == 1) checkBox3.Checked = true;
                if (item2.AC_Out == 1) checkBox4.Checked = true;
                if (item2.AC_MouseS == 1) checkBox5.Checked = true;
                if (item2.AC_MouseA == 1) checkBox6.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "500";
            textBox4.Text = "3000";
            textBox5.Text = "500";
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager1.alert_configTableAdapter.FillByAll(this.humanresourcesDataSet1.alert_config);
            foreach (humanresourcesDataSet.alert_configRow item2 in this.humanresourcesDataSet1.alert_config)
            {
                item2.AC_DTime = Convert.ToInt32(textBox3.Text);
                item2.AC_STime = Convert.ToInt32(textBox4.Text);
                item2.AC_MTime = Convert.ToInt32(textBox5.Text);
                if (checkBox1.Checked == true) item2.AC_Title = 1; else item2.AC_Title = 0;
                if (checkBox2.Checked == true) item2.AC_Info = 1; else item2.AC_Info = 0;
                if (checkBox3.Checked == true) item2.AC_Close = 1; else item2.AC_Close = 0;
                if (checkBox4.Checked == true) item2.AC_Out = 1; else item2.AC_Out = 0;
                if (checkBox5.Checked == true) item2.AC_MouseS = 1; else item2.AC_MouseS = 0;
                if (checkBox6.Checked == true) item2.AC_MouseA = 1; else item2.AC_MouseA = 0;
            }
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            MessageBox.Show("修改成功");
            this.Close();
        }
    }
}
