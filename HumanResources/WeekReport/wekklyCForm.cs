using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Diagnostics;

namespace HumanResources.WeekReport
{
    
    public partial class wekklyCForm : Form
    {
        //private humanresourcesDataSet.usersDataTable wpol;
        private string date = DateTime.Now.ToLongDateString().ToString();
        private int week;
        private string templetFile = null;
        private string outputFile = null;
        private object missing = Missing.Value;
        private DateTime beforeTime;			//Excel启动之前时间
        private DateTime afterTime;				//Excel启动之后时间
        Excel.Application app;
        Excel.Workbook workBook;
        Excel.Worksheet workSheet;
        Excel.Range range;
        Excel.Range range1;
        Excel.Range range2;
        Excel.TextBox textBox;
        private int sheetCount = 1;			//WorkSheet数量
        private string sheetPrefixName = "页";	
        private int u_id;
        private string  user_realName;


        public wekklyCForm()
        {
            week = GetWeekOfCurrDate(DateTime.Now);
            InitializeComponent();

            //List<humanresourcesDataSet.usersRow> aaa = this.tableAdapterManager1.usersTableAdapter.GetDataByUser_id(1).ToList();
        }

       

       
        

       

        private void wekklyCForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            humanresourcesDataSet.usersRow u = ((MDIFrmParent)MdiParent).LoginUser;
            u_id = u.User_id;
            this.tableAdapterManager1.usersTableAdapter.FillByUser_id(this.humanresourcesDataSet1.users, u_id);
            user_realName = this.humanresourcesDataSet1.users.SingleOrDefault().User_realName;
            int user_superior_id = this.humanresourcesDataSet1.users.SingleOrDefault().User_superior_id;

            this.label1.Text = user_realName.ToString();
            label2.Text = DateTime.Now.ToLongDateString().ToString();
            label3.Text = week + "周";
           
            this.tableAdapterManager1.teamTableAdapter.FillByT_id(this.humanresourcesDataSet1.team, user_superior_id);

            if (this.humanresourcesDataSet1.team.SingleOrDefault().Team_Leader_ID == u_id)
            {
                this.groupBox2.Visible = true;
                this.tableAdapterManager1.usersTableAdapter.FillByUSID(this.humanresourcesDataSet1.users, user_superior_id);
                int i = 0;
                int j = 0;
                int k = 0;
                foreach (humanresourcesDataSet.usersRow item in this.humanresourcesDataSet1.users)
                {
                    if (this.tableAdapterManager1.wekkly_consultantTableAdapter.ScalarQueryPan(item.User_id, week) != null)
                    {
                        Button b = new Button();
                        b.Size = new Size(80, 30);
                        if (i % 6 == 0)
                        {
                            j = k * 90;
                            i = 0;
                            k++;
                        }
                            b.Location = new Point(25 + j, i * 35 + 20);
                        
                        b.Text = this.tableAdapterManager1.usersTableAdapter.GetDataByUser_id(item.User_id).SingleOrDefault().User_realName ;
                        b.MouseClick += new MouseEventHandler(b_MouseClick);
                        this.groupBox2.Controls.Add(b);
                        
                        i++;
                    }
                    
                }
                
            }
            else
            {
                this.groupBox2.Enabled = false;
                this.groupBox2.Text = "您不是" + this.humanresourcesDataSet1.team.SingleOrDefault().Team_Name + "组的组长，无权看其他组员的周报信息。";

            }
            
        }

        void b_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (this.tableAdapterManager1.wekkly_consultantTableAdapter.ScalarQueryPan(u_id, week) == null)
                {

                    templetFile = System.Environment.CurrentDirectory+@"\Template\wekkly-consultant.xlsx";
                    outputFile = System.Environment.CurrentDirectory + @"\Template\excel\consultant\" + DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + ".xlsx";
                    MessageBox.Show(templetFile + "   " + outputFile);
                    ExcelHelper(templetFile, outputFile, true);
                    humanresourcesDataSet.wekkly_consultantRow newwc = this.humanresourcesDataSet1.wekkly_consultant.Newwekkly_consultantRow();
                    newwc.user_id = u_id;
                    newwc.WC_cTime = DateTime.Now;
                    newwc.WC_month = DateTime.Now.Month;
                    newwc.WC_Path = outputFile;
                    newwc.WC_useN = Convert.ToDecimal(0.5);
                    newwc.WC_week = week;
                    workSheet.Cells[3, 5] = user_realName;
                    workSheet.Cells[4, 5] = week;
                    workSheet.Cells[5, 5] = DateTime.Now.Month;
                    workSheet.Cells[6, 5] = Convert.ToDecimal(0.5);
                    workSheet.Cells[7, 5] = " ";
                    this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 0);
                    int j = 0;

                    foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                    {
                        int number = 0;
                        int a = 0;
                        int b = 0;

                        foreach (string item1 in item2.WCP_S.Split(new char[] { ',' }))
                        {
                            if (number > 0)
                            {
                                b = Convert.ToInt32(item1);
                            }
                            else
                            {
                                a = Convert.ToInt32(item1);
                            }
                            number++;
                        }
                        j++;
                        workSheet.Cells[a, b] = item2.WCP_value;

                    }

                    this.humanresourcesDataSet1.wekkly_consultant.Addwekkly_consultantRow(newwc);
                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);

                    this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 1);
                    j = 0;
                    foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                    {
                        int i = 0;
                        humanresourcesDataSet.weeklyc_detailsRow newwd = this.humanresourcesDataSet1.weeklyc_details.Newweeklyc_detailsRow();
                        newwd.WCD_Targets = Convert.ToInt32(item2.WCP_value);
                        newwd.WCD_Time = DateTime.Now;
                        newwd.WCD_Week = week;
                        newwd.WC_id = Convert.ToInt32(this.tableAdapterManager1.wekkly_consultantTableAdapter.Adapter.InsertCommand.LastInsertedId);
                        newwd.WCP_id = item2.WCP_id;
                        this.humanresourcesDataSet1.weeklyc_details.Addweeklyc_detailsRow(newwd);
                        int number = 0;
                        int a = 0;
                        int b = 0;
                        foreach (string item3 in item2.WCP_S.Split(new char[] { '|' }))
                        {
                            
                            foreach (string item1 in item3.Split(new char[] { ',' }))
                            {
                                if (number > 0)
                                {
                                    b = Convert.ToInt32(item1);
                                }
                                else
                                {
                                    a = Convert.ToInt32(item1);
                                }
                                number++;
                                
                            }
                            if (i == 0)
                            {
                                workSheet.Cells[a, b] = item2.WCP_value;
                            }
                            else {
                                workSheet.Cells[a, b] = 0;
                            
                            }
                            

                            i++;
                        }
                        
                        j++;
                       
                    }

                    this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 2);
                    j = 0;
                    string[] aa = GetDateByWeek(week.ToString());
                    foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                    {
                        int i = 0;
                        humanresourcesDataSet.weeklyc_detailsRow newwd = this.humanresourcesDataSet1.weeklyc_details.Newweeklyc_detailsRow();
                        newwd.WCD_Targets = Convert.ToInt32(item2.WCP_value);
                        newwd.WCD_Time = DateTime.Now;
                        newwd.WCD_Week = week;
                        newwd.WC_id = Convert.ToInt32(this.tableAdapterManager1.wekkly_consultantTableAdapter.Adapter.InsertCommand.LastInsertedId);
                        newwd.WCP_id = item2.WCP_id;
                        this.humanresourcesDataSet1.weeklyc_details.Addweeklyc_detailsRow(newwd);
                        int number = 0;
                        int a = 0;
                        int b = 0;
                        foreach (string item3 in item2.WCP_S.Split(new char[] { '|' }))
                        {
                            foreach (string item1 in item3.Split(new char[] { ',' }))
                            {
                                if (number > 0)
                                {
                                    b = Convert.ToInt32(item1);
                                }
                                else
                                {
                                    a = Convert.ToInt32(item1);
                                }
                                number++;

                            }
                            if (j == 0)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 1; }
                                else if (i == 2) { workSheet.Cells[a, b] = 2; }
                                else if (i == 3) { workSheet.Cells[a, b] = 3; }
                                else if (i == 4) { workSheet.Cells[a, b] = 4; }
                                else if (i == 5) { workSheet.Cells[a, b] = 5; }
                               
                                
                            }
                            else if(j == 1){

                                if (this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryT1_T2(u_id, aa[0].ToString(), aa[4] ,3) != null)
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[0] ,3); }
                                    else if (i == 2) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[1], 3); }
                                    else if (i == 3) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[2], 3); }
                                    else if (i == 4) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[3], 3); }
                                    else if (i == 5) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[4], 3); }
                                }
                                else {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 5) { workSheet.Cells[a, b] = 0; }
                                }
                                
                                
                            }
                            else if (j == 2)
                            {
                                if (this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryT1_T2(u_id, aa[0].ToString(), aa[4], 4) != null)
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[0], 4); }
                                    else if (i == 2) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[1], 4); }
                                    else if (i == 3) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[2], 4); }
                                    else if (i == 4) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[3], 4); }
                                    else if (i == 5) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[4], 4); }
                                }
                                else
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 5) { workSheet.Cells[a, b] = 0; }
                                }
                               
                            }
                            else if (j == 3)
                            {
                                if (this.tableAdapterManager1.ordersTableAdapter.ScalarQueryT1_T2(u_id, aa[0].ToString(), aa[4]) != null)
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[0]); }
                                    else if (i == 2) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[1]); }
                                    else if (i == 3) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[2]); }
                                    else if (i == 4) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[3]); }
                                    else if (i == 5) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[4]); }
                                }
                                else {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 5) { workSheet.Cells[a, b] = 0; }
                                }
                               
                                
                            }
                            else if (j == 4)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }
                               
                            }
                            else if (j == 5)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }
                             
                            }
                            else if (j == 6)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }

                            }
                            else if (j == 7)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }

                            }
                           
                            i++;
                        }

                        j++;
                    }
                    
                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                    workBook.BeforeClose += new Microsoft.Office.Interop.Excel.WorkbookEvents_BeforeCloseEventHandler(workBook_BeforeClose);
                }
                else {
                    this.tableAdapterManager1.wekkly_consultantTableAdapter.FillByu_id_week(this.humanresourcesDataSet1.wekkly_consultant, u_id, week);
                    ExcelHelperOpen(this.humanresourcesDataSet1.wekkly_consultant.SingleOrDefault().WC_Path, true);

                    this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 1);
                    int j = 0;
                    foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                    {
                        int i = 0;
                      
                        int number = 0;
                        int a = 0;
                        int b = 0;
                        foreach (string item3 in item2.WCP_S.Split(new char[] { '|' }))
                        {

                            foreach (string item1 in item3.Split(new char[] { ',' }))
                            {
                                if (number > 0)
                                {
                                    b = Convert.ToInt32(item1);
                                }
                                else
                                {
                                    a = Convert.ToInt32(item1);
                                }
                                number++;

                            }
                            if (i == 0)
                            {
                                workSheet.Cells[a, b] = item2.WCP_value;
                            }
                            else
                            {
                                workSheet.Cells[a, b] = 0;

                            }


                            i++;
                        }

                        j++;

                    }
                    this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 2);
                    j = 0;
                    string[] aa = GetDateByWeek(week.ToString());
                    foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                    {
                        int i = 0;
                        int number = 0;
                        int a = 0;
                        int b = 0;
                        foreach (string item3 in item2.WCP_S.Split(new char[] { '|' }))
                        {
                            foreach (string item1 in item3.Split(new char[] { ',' }))
                            {
                                if (number > 0)
                                {
                                    b = Convert.ToInt32(item1);
                                }
                                else
                                {
                                    a = Convert.ToInt32(item1);
                                }
                                number++;

                            }
                            if (j == 0)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }


                            }
                            else if (j == 1)
                            {

                                if (this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryT1_T2(u_id, aa[0].ToString(), aa[4], 3) != null)
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[0], 3); }
                                    else if (i == 2) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[1], 3); }
                                    else if (i == 3) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[2], 3); }
                                    else if (i == 4) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[3], 3); }
                                    else if (i == 5) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[4], 3); }
                                }
                                else
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 5) { workSheet.Cells[a, b] = 0; }
                                }


                            }
                            else if (j == 2)
                            {
                                if (this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryT1_T2(u_id, aa[0].ToString(), aa[4], 4) != null)
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[0], 4); }
                                    else if (i == 2) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[1], 4); }
                                    else if (i == 3) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[2], 4); }
                                    else if (i == 4) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[3], 4); }
                                    else if (i == 5) { workSheet.Cells[a, b] = this.tableAdapterManager1.recommended_state_remarkTableAdapter.ScalarQueryTime(u_id, aa[4], 4); }
                                }
                                else
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 5) { workSheet.Cells[a, b] = 0; }
                                }

                            }
                            else if (j == 3)
                            {
                                if (this.tableAdapterManager1.ordersTableAdapter.ScalarQueryT1_T2(u_id, aa[0].ToString(), aa[4]) != null)
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[0]); }
                                    else if (i == 2) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[1]); }
                                    else if (i == 3) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[2]); }
                                    else if (i == 4) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[3]); }
                                    else if (i == 5) { workSheet.Cells[a, b] = this.tableAdapterManager1.ordersTableAdapter.ScalarQueryTime(u_id, aa[4]); }
                                }
                                else
                                {
                                    if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                    else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                    else if (i == 5) { workSheet.Cells[a, b] = 0; }
                                }
                                

                            }
                            else if (j == 4)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }

                            }
                            else if (j == 5)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }

                            }
                            else if (j == 6)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }

                            }
                            else if (j == 7)
                            {
                                if (i == 0) { workSheet.Cells[a, b] = item2.WCP_value; }
                                else if (i == 1) { workSheet.Cells[a, b] = 0; }
                                else if (i == 2) { workSheet.Cells[a, b] = 0; }
                                else if (i == 3) { workSheet.Cells[a, b] = 0; }
                                else if (i == 4) { workSheet.Cells[a, b] = 0; }
                                else if (i == 5) { workSheet.Cells[a, b] = 0; }

                            }

                            i++;
                        }

                        j++;
                    }
                   
                    workBook.BeforeClose += new Microsoft.Office.Interop.Excel.WorkbookEvents_BeforeCloseEventHandler(workBook_BeforeClose);
                }
                
            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.Message);
            }
        }

        void workBook_BeforeClose(ref bool Cancel)
        {
            try
            {
                
                
                this.tableAdapterManager1.wekkly_consultantTableAdapter.FillByu_id_week(this.humanresourcesDataSet1.wekkly_consultant, u_id, week);


                this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 0);

                List<string> str = new List<string>();
                foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                {
                    foreach (string item1 in item2.WCP_E.Split(new char[] { ',' }))
                    {
                        str.Add(item1);

                    }

                }

                foreach (humanresourcesDataSet.wekkly_consultantRow item2 in this.humanresourcesDataSet1.wekkly_consultant)
                {
                    item2.WC_Milestone1 = workSheet.get_Range(str[0], missing).Value2.ToString();
                    item2.WC_Milestone2 = workSheet.get_Range(str[1], missing).Value2.ToString();
                    item2.WC_Milestone3 = workSheet.get_Range(str[2], missing).Value2.ToString();
                    item2.WC_Thing1 = workSheet.get_Range(str[3], missing).Value2.ToString();
                    item2.WC_Thing2 = workSheet.get_Range(str[3], missing).Value2.ToString();
                    item2.WC_Thing3 = workSheet.get_Range(str[3], missing).Value2.ToString();

                }
                this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);

                this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 1);

                foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                {
                    this.tableAdapterManager1.weeklyc_detailsTableAdapter.FillBywp(this.humanresourcesDataSet1.weeklyc_details, this.humanresourcesDataSet1.wekkly_consultant.SingleOrDefault().WC_id, item2.WCP_id);


                    str.Clear();
                    foreach (string item1 in item2.WCP_E.Split(new char[] { ',' }))
                    {
                        str.Add(item1);

                    }

                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_Tot = Convert.ToInt32(workSheet.get_Range(str[0], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_Var = Convert.ToInt32(workSheet.get_Range(str[1], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAM = Convert.ToInt32(workSheet.get_Range(str[2], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAT = Convert.ToInt32(workSheet.get_Range(str[3], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAW = Convert.ToInt32(workSheet.get_Range(str[4], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DATH = Convert.ToInt32(workSheet.get_Range(str[5], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAF = Convert.ToInt32(workSheet.get_Range(str[6], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAS = Convert.ToInt32(workSheet.get_Range(str[7], missing).Value2.ToString());

                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                }

                this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 1, 2);

                foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                {
                    this.tableAdapterManager1.weeklyc_detailsTableAdapter.FillBywp(this.humanresourcesDataSet1.weeklyc_details, this.humanresourcesDataSet1.wekkly_consultant.SingleOrDefault().WC_id, item2.WCP_id);


                    str.Clear();
                    foreach (string item1 in item2.WCP_E.Split(new char[] { ',' }))
                    {
                        str.Add(item1);

                    }
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_Tot = Convert.ToInt32(workSheet.get_Range(str[0], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_Var = Convert.ToInt32(workSheet.get_Range(str[1], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAM = Convert.ToInt32(workSheet.get_Range(str[2], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAT = Convert.ToInt32(workSheet.get_Range(str[3], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAW = Convert.ToInt32(workSheet.get_Range(str[4], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DATH = Convert.ToInt32(workSheet.get_Range(str[5], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAF = Convert.ToInt32(workSheet.get_Range(str[6], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklyc_details.SingleOrDefault().WCD_DAS = Convert.ToInt32(workSheet.get_Range(str[7], missing).Value2.ToString());

                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                }


            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
            finally
            {

                Dispose1();
            }
            
           
        }

        public void ExcelHelper(string templetFilePath, string outputFilePath, Boolean visible)
		{
			if(templetFilePath == null)
				throw new Exception("Excel模板文件路径不能为空！");

			if(outputFilePath == null)
				throw new Exception("输出Excel文件路径不能为空！");

			if(!File.Exists(templetFilePath))
				throw new Exception("指定路径的Excel模板文件不存在！");

			this.templetFile = templetFilePath;
            this.outputFile = outputFilePath;
            File.Copy(templetFile, outputFile, true);
			//创建一个Application对象并使其可见
			beforeTime = DateTime.Now;
			app = new Excel.ApplicationClass();
            app.Visible = visible;
			afterTime = DateTime.Now;

			//打开模板文件，得到WorkBook对象
            workBook = app.Workbooks.Open(outputFile, missing, missing, missing, missing,
                missing,missing,missing,missing,missing, missing, missing, missing, missing, missing);

			//得到WorkSheet对象
			workSheet = (Excel.Worksheet)workBook.Sheets.get_Item(1);

		}
        public void ExcelHelperOpen(string templetFilePath, Boolean visible)
        {
            if (templetFilePath == null)
                throw new Exception("Excel模板文件路径不能为空！");

            //创建一个Application对象并使其可见
            beforeTime = DateTime.Now;
            app = new Excel.ApplicationClass();
            app.Visible = visible;
            afterTime = DateTime.Now;

            //打开模板文件，得到WorkBook对象
            workBook = app.Workbooks.Open(templetFilePath, missing, missing, missing, missing,
                missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);

            //得到WorkSheet对象
            workSheet = (Excel.Worksheet)workBook.Sheets.get_Item(1);

        }


        private void Dispose1() 
        {
            workBook.Save();
            //workBook.Close(null, null, null);
            //app.Workbooks.Close();
            app.Quit();

            if (range != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(range);
                range = null;
            }
            if (range1 != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(range1);
                range1 = null;
            }
            if (range2 != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(range2);
                range2 = null;
            }
            if (textBox != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(textBox);
                textBox = null;
            }
            if (workSheet != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
                workSheet = null;
            }
            if (workBook != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBook);
                workBook = null;
            }
            if (app != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
            }

            GC.Collect();

            this.KillExcelProcess();

        }
        
        //end Dispose
        /// <summary>
        /// 结束Excel进程
        /// </summary>
        public void KillExcelProcess()
        {
            Process[] myProcesses;
            DateTime startTime;
            myProcesses = Process.GetProcessesByName("Excel");

            //得不到Excel进程ID，暂时只能判断进程启动时间
            foreach (Process myProcess in myProcesses)
            {
                startTime = myProcess.StartTime;

                if (startTime > beforeTime && startTime < afterTime)
                {
                    myProcess.Kill();
                }
            }
        }
        private int GetWeekOfCurrDate(DateTime p_Time)
        {
            DateTime _Year = new DateTime(p_Time.Year, 1, 1);
            int _StarWeek = (int)_Year.DayOfWeek;
            int _Days = p_Time.DayOfYear + _StarWeek;
            if (_Days < 7) return 1;
            int _Value = (_Days / 7);
            if (_Days % 7 != 0) _Value++;
            return _Value;
        }

        public string[] GetDateByWeek(string WeekCount)
        {
            string Time1="";
            string Time2 = "";
            string Time3 = "";
            string Time4 = "";
            string Time5="";

           
            int weeknow = Convert.ToInt32(System.DateTime.Now.DayOfWeek);
            int dayM = (-1) * weeknow + 1;
            int dayT = 2 - weeknow;
            int dayW = 3 - weeknow;
            int dayTH = 4 - weeknow;
            int dayF = 5 - weeknow;
           
            //星期一
            Time1 = System.DateTime.Now.AddDays(dayM).ToString("yyyy-MM-dd");
            //星期二
            Time2 = System.DateTime.Now.AddDays(dayT).ToString("yyyy-MM-dd");
            //星期三
            Time3 = System.DateTime.Now.AddDays(dayW).ToString("yyyy-MM-dd");
            //星期四
            Time4 = System.DateTime.Now.AddDays(dayTH).ToString("yyyy-MM-dd");
            //星期五
            Time5 = System.DateTime.Now.AddDays(dayF).ToString("yyyy-MM-dd");

            string[] Time = { Time1, Time2, Time3, Time4, Time5 };
            return Time;
        }  

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        
       
      
    }
}
