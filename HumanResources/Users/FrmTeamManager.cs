using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources.Users
{
    public partial class FrmTeamManager : Form
    {
        public FrmTeamManager()
        {
            InitializeComponent();
            this.tableAdapterManager1.teamTableAdapter.Fill(this.humanresourcesDataSet1.team);
            this.tableAdapterManager1.usersTableAdapter.Fill(this.humanresourcesDataSet1.users);
        }

        private void TeamListBind()
        {

            this.listBox1.DataSource = this.humanresourcesDataSet1.team ;
            this.listBox1.DisplayMember = "Team_Name";
            this.listBox1.ValueMember = "Team_ID";
        }
        private void UserListBind(int checkTeamid)
        {
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();
            foreach (humanresourcesDataSet.usersRow item in this.humanresourcesDataSet1.users)
            {
                if (item.User_superior_id == checkTeamid)
                {
                    this.listBox2.Items.Add(item);
                }
                else if (item.User_superior_id == 0)
                {
                    this.listBox3.Items.Add(item);
                }
            }
           this.listBox2.DisplayMember = "User_realName";
            this.listBox2.ValueMember = "User_id";
            this.listBox3.DisplayMember = "User_realName";
            this.listBox3.ValueMember = "User_id";
        }
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtTeamName.Text))
            {
                MessageBox.Show("请输入团队名称");
            }
            else
            {
                this.tableAdapterManager1.teamTableAdapter.Insert(this.txtTeamName.Text.Trim(), 0);
                this.tableAdapterManager1.teamTableAdapter.Fill(this.humanresourcesDataSet1.team);
                this.listBox1.SelectedValue = Convert.ToInt32(this.tableAdapterManager1.teamTableAdapter.Adapter.InsertCommand.LastInsertedId);
            }
            
        }

        private void tsmiDelTeam_Click(object sender, EventArgs e)
        {
            foreach (humanresourcesDataSet.usersRow item in this.humanresourcesDataSet1.users)
            {
                if (item.User_superior_id == ((this.listBox1.SelectedItem as DataRowView).Row as humanresourcesDataSet.teamRow).Team_Id)
                {
                    item.User_superior_id = 0;
                }
            }
            try
            {
                 (this.listBox1.SelectedItem as DataRowView).Delete();
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            }
            catch (Exception)
            {
                
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                humanresourcesDataSet.teamRow checkTeam = ((this.listBox1.SelectedItem as DataRowView).Row as humanresourcesDataSet.teamRow);
                UserListBind(checkTeam.Team_Id);
                if (checkTeam.Team_Leader_ID == 0)
                {
                    this.lblLeaderName.Text = "无";
                }
                else
                {
                    this.lblLeaderName.Text = this.humanresourcesDataSet1.users.Single(u => u.User_id == checkTeam.Team_Leader_ID).User_realName;
                }
            }
            catch (Exception)
            {
                

            }
        }

        private void FrmTeamManager_Load(object sender, EventArgs e)
        {
            TeamListBind();
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                humanresourcesDataSet.usersRow checku = (this.listBox2.SelectedItem as humanresourcesDataSet.usersRow);
                //this.listBox3.Items.Add(this.listBox2.SelectedItem);
                //this.listBox2.Items.Remove(this.listBox2.SelectedItem);
               
                humanresourcesDataSet.teamRow checkt= humanresourcesDataSet1.team.Single(t=>t.Team_Id == checku.User_superior_id);
               if (checkt.Team_Leader_ID == checku.User_id)
               {
                   checkt.Team_Leader_ID = 0;
                   this.lblLeaderName.Text = "无";
               }
               checku.User_superior_id = 0;
               UserListBind(checkt.Team_Id);
                this.listBox2.SelectedIndex = this.listBox2.Items.Count > 0 ? 0 : -1;
                this.listBox3.SelectedIndex = this.listBox3.Items.Count - 1;
               
            }
            
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex >= 0)
            {
                (this.listBox3.SelectedItem as humanresourcesDataSet.usersRow).User_superior_id = ((this.listBox1.SelectedItem as DataRowView).Row as humanresourcesDataSet.teamRow).Team_Id;
                this.listBox2.Items.Add(this.listBox3.SelectedItem);
                this.listBox3.Items.Remove(this.listBox3.SelectedItem);
                this.listBox3.SelectedIndex = this.listBox3.Items.Count > 0 ? 0 : -1;
                this.listBox2.SelectedIndex = this.listBox2.Items.Count - 1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
            MessageBox.Show("保存成功");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex >=0)
            {
                humanresourcesDataSet.usersRow checku = (this.listBox2.SelectedItem as humanresourcesDataSet.usersRow);
                ((this.listBox1.SelectedItem as DataRowView).Row as humanresourcesDataSet.teamRow).Team_Leader_ID = checku.User_id;
                this.lblLeaderName.Text = checku.User_realName;
                this.listBox2.SelectedItem = checku;
            }
        }

    }
}
