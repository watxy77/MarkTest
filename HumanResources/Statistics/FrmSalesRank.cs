using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Statistics
{
    public partial class FrmSalesRank : Form
    {
        public FrmSalesRank(bool isTeam)
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add(new object[]{isTeam?"顾问":"团队","总计","","","","","","","","","","","","","",""});
        }
        void bind()
        { 
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
