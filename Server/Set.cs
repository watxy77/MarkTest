using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Xml;

namespace Server
{
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
        }

        private void Set_Load(object sender, EventArgs e)
        {
            this.GetAllIP();
            this.GetPort();
        }

        private void GetAllIP()
        {

        }

        private void GetPort()
        {
            try
            {
                XmlDocument TDoc = new XmlDocument();
                TDoc.Load("Settings.xml");
                string TPort = TDoc.GetElementsByTagName("ServerPort")[0].InnerXml;
                this.Port.Text = TPort;

            }
            catch { }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument TDoc = new XmlDocument();
                TDoc.Load("Settings.xml");

                XmlElement Root = TDoc.DocumentElement;
                XmlElement newElem = TDoc.CreateElement("ServerPort");
                newElem.InnerXml = this.Port.Text;

                Root.ReplaceChild(newElem, Root.LastChild);

                TDoc.Save("Settings.xml");

                MessageBox.Show("参数保存成功！");
                this.Close();
            }
            catch
            {
                MessageBox.Show("参数写入XML文件不成功！");
            }

        }
    }
}