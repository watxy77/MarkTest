using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Base
{
    public partial class FrmCheckBoxList : Form
    {
        Control bbb;
        public FrmCheckBoxList()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                CheckBox a = new CheckBox();
                a.Text = "aaaaaaaa" + i;
                this.flowLayoutPanel1.Controls.Add(a);
            }
        }
        public FrmCheckBoxList(Control aaa)
        {
            bbb = aaa;
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                CheckBox a = new CheckBox();
                a.Text = "aaaaaaaa" + i;
                this.flowLayoutPanel1.Controls.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bbb.Text = "1111111";
            this.Close();
            
        }
    }
}
