using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Analysis
{
    public partial class FrmContactsAndResume : Form
    {
        public FrmContactsAndResume()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmContactsAndResume_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(new object[] { "简历数量", "", "" });
            this.dataGridView1.Rows.Add(new object[] { "通讯录名单数量", "", "" });
            this.dataGridView2.Rows.Add(new object[] { "简历数量", "", "" ,""});
            this.dataGridView2.Rows.Add(new object[] { "简历通讯录名单数量数量", "", "","" });
            this.dataGridView3.Rows.Add(new object[] { "简历数量", "", "", "" });
            this.dataGridView3.Rows.Add(new object[] { "简历通讯录名单数量数量", "", "", "" });
        }
    }
}
