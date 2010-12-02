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
    public partial class FrmAnalysisOfCustomerDevelopment : Form
    {
        public FrmAnalysisOfCustomerDevelopment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAnalysisOfCustomerDevelopment_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[]{"客户信息增加量","",""});
            dataGridView1.Rows.Add(new object[] { "客户拜访数量", "", "" });
            dataGridView1.Rows.Add(new object[] { "客户服务调查报告CSS", "", "" });
            dataGridView2.Rows.Add(new object[] { "客户信息增加量", "", "", "" });
            dataGridView2.Rows.Add(new object[] { "客户拜访数量", "", "", "" });
            dataGridView2.Rows.Add(new object[] { "客户服务调查报告CSS", "", "", "" });
            dataGridView3.Rows.Add(new object[] { "客户信息增加量", "", "", "" });
            dataGridView3.Rows.Add(new object[] { "客户拜访数量", "", "", "" });
            dataGridView3.Rows.Add(new object[] { "客户服务调查报告CSS", "", "", "" });
            dataGridView5.Rows.Add(new object[] { "新订单增加量", "", "" });
            dataGridView5.Rows.Add(new object[] { "积极的订单", "", "" });
            dataGridView5.Rows.Add(new object[] { "暂停的订单", "", "" });
            dataGridView5.Rows.Add(new object[] { "客户取消的订单", "", "" });
            dataGridView5.Rows.Add(new object[] { "标尺取消的订单", "", "" });
            dataGridView5.Rows.Add(new object[] { "失败的订单", "", "" });
            dataGridView5.Rows.Add(new object[] { "成功的订单", "", "" });
            dataGridView5.Rows.Add(new object[] { "将要上班的订单", "", "" });
            dataGridView6.Rows.Add(new object[] { "新订单增加量", "", "", "" });
            dataGridView6.Rows.Add(new object[] { "积极的订单", "", "", "" });
            dataGridView6.Rows.Add(new object[] { "暂停的订单", "", "", "" });
            dataGridView6.Rows.Add(new object[] { "客户取消的订单", "", "", "" });
            dataGridView6.Rows.Add(new object[] { "标尺取消的订单", "", "", "" });
            dataGridView6.Rows.Add(new object[] { "失败的订单", "", "", "" });
            dataGridView6.Rows.Add(new object[] { "成功的订单", "", "", "" });
            dataGridView6.Rows.Add(new object[] { "将要上班的订单", "", "", "" });
            dataGridView7.Rows.Add(new object[] { "新订单增加量", "", "", "" });
            dataGridView7.Rows.Add(new object[] { "积极的订单", "", "", "" });
            dataGridView7.Rows.Add(new object[] { "暂停的订单", "", "", "" });
            dataGridView7.Rows.Add(new object[] { "客户取消的订单", "", "", "" });
            dataGridView7.Rows.Add(new object[] { "标尺取消的订单", "", "", "" });
            dataGridView7.Rows.Add(new object[] { "失败的订单", "", "", "" });
            dataGridView7.Rows.Add(new object[] { "成功的订单", "", "", "" });
            dataGridView7.Rows.Add(new object[] { "将要上班的订单", "", "", "" });
            dataGridView9.Rows.Add(new object[] {"客户总数",""});
            dataGridView9.Rows.Add(new object[] { "现有客户", "" });
            dataGridView9.Rows.Add(new object[] { "新客户", "" });
            dataGridView9.Rows.Add(new object[] { "停止合作的客户", "" });
            dataGridView9.Rows.Add(new object[] { "未来客户", "" });
        }

       
    }
}
