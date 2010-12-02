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
    public partial class FrmTradeSelect : Form
    {
        bool isSingle = false;
        Control EventCtr = null;
        List<humanresourcesDataSet.tradeRow> tempTL = null;
        public FrmTradeSelect(List<humanresourcesDataSet.tradeRow> temp)
        {
            InitializeComponent();
            tempTL = temp;
            int[] checklist = temp.Select(t=>t.Trade_id).ToArray();
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    if (checklist.Contains(Convert.ToInt32(item.Tag)))
                    {
                        ((CheckBox)item).Checked = true;
                    }
                }
            }
        }
        public FrmTradeSelect(Control eventCtr)
        {
            InitializeComponent();
            isSingle = true;
            this.EventCtr = eventCtr;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)item).CheckedChanged += new EventHandler(FrmTradeSelect_CheckedChanged);
                }
            }
        }

        void FrmTradeSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {


                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)item).Checked && !item.Equals(sender))
                        {
                            MessageBox.Show("只能选择一项");
                            ((CheckBox)sender).Checked = false;
                        }
                    }
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)item).Checked = false;
                }
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (isSingle)
            {
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)item).Checked)
                        {
                            EventCtr.Text = this.tableAdapterManager1.tradeTableAdapter.GetDataByTrade_id(Convert.ToInt32(item.Tag)).SingleOrDefault().Trade_name;
                            EventCtr.Tag = item.Tag;
                        }
                    }
                }
            }
            else
            {
                tempTL.Clear();
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)item).Checked)
                        {
                            tempTL.Add(this.tableAdapterManager1.tradeTableAdapter.GetDataByTrade_id(Convert.ToInt32(item.Tag)).SingleOrDefault());
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
