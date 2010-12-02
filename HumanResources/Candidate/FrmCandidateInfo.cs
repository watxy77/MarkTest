using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Candidate
{
    public partial class FrmCandidateInfo : Form
    {
        public FrmCandidateInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //FrmCandidateAdd fca = new FrmCandidateAdd();
            //fca.Show();
        }

        private void btnRecommendedHistory_Click(object sender, EventArgs e)
        {
            //FrmRecommendedHistory frh = new FrmRecommendedHistory();
            //frh.Show();
        }

        private void btnUploadResume_Click(object sender, EventArgs e)
        {
            ofdSelectResume.ShowDialog();
        }

        private void ofdSelectResume_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show(((OpenFileDialog)sender).FileName);
        }
    }
}
