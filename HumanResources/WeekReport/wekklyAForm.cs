using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Diagnostics;
using System.IO;
namespace HumanResources.WeekReport
{
    public partial class wekklyAForm : Form
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
        private string user_realName;
        private string time;
        public wekklyAForm()
        {
            InitializeComponent();
        }

        private void wekklyAForm_Load(object sender, EventArgs e)
        {
            week = GetWeekOfCurrDate(DateTime.Now);
            this.Location = new Point(0, 0);
            humanresourcesDataSet.usersRow u = ((MDIFrmParent)MdiParent).LoginUser;
            u_id = u.User_id;
            this.tableAdapterManager1.usersTableAdapter.FillByUser_id(this.humanresourcesDataSet1.users, u_id);
            user_realName = this.humanresourcesDataSet1.users.SingleOrDefault().User_realName;
            //time = this.humanresourcesDataSet1.users.SingleOrDefault().
            this.label1.Text = user_realName.ToString();
            label2.Text = DateTime.Now.ToLongDateString().ToString();
            label3.Text = week + "周";
        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tableAdapterManager1.wekkly_assistantTableAdapter.ScalarQuerypan(u_id, week) == null)
                {

                    templetFile = System.Environment.CurrentDirectory + @"\Template\weekly-assistant.xlsx";
                    outputFile = System.Environment.CurrentDirectory + @"\Template\excel\assistant\" + DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + ".xlsx";
                    ExcelHelper(templetFile, outputFile, true);
                    humanresourcesDataSet.wekkly_assistantRow newa = this.humanresourcesDataSet1.wekkly_assistant.Newwekkly_assistantRow();
                   
                    newa.User_id = u_id;
                    newa.WA_week = week;
                    newa.WA_month = DateTime.Now.Month;
                    //newa.WA_useName = workSheet.get_Range("O16", missing).Value2.ToString();
                    //newa.WA_joinT = workSheet.get_Range("O13", missing).Value2.ToString();
                   
                    newa.WA_cTime = DateTime.Now;
                    newa.WA_path = outputFile;
                    newa.WA_CC = workSheet.get_Range("O4", missing).Value2.ToString();
                    newa.WA_CV = workSheet.get_Range("O5", missing).Value2.ToString();
                    newa.WA_BI = workSheet.get_Range("O6", missing).Value2.ToString();
                    newa.WA_ROS = workSheet.get_Range("O7", missing).Value2.ToString();
                    newa.WA_SP = workSheet.get_Range("O8", missing).Value2.ToString();
                    newa.WA_SUM = workSheet.get_Range("O9", missing).Value2.ToString();

                    workSheet.Cells[12, 15] = user_realName;
                    //workSheet.Cells[13, 15] = ;
                    workSheet.Cells[14, 15] = week;
                    workSheet.Cells[15, 15] = DateTime.Now.Month;
                    //workSheet.Cells[16, 15] = ;
                    int j = 0;
                    this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 2, 0);
                   
                    this.humanresourcesDataSet1.wekkly_assistant.Addwekkly_assistantRow(newa);
                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);


                    this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 2, 1);
                   // j = 0;
                    foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                    {
                        humanresourcesDataSet.weeklya_detailsRow newwa = this.humanresourcesDataSet1.weeklya_details.Newweeklya_detailsRow();
                        newwa.WAD_Targets = Convert.ToInt32(item2.WCP_value);
                        newwa.WAD_Time = DateTime.Now;
                        newwa.WAD_Week = week.ToString();
                        newwa.WA_id = Convert.ToInt32(this.tableAdapterManager1.wekkly_assistantTableAdapter.Adapter.InsertCommand.LastInsertedId);
                        newwa.WCP_id = item2.WCP_id;
                       
                        this.humanresourcesDataSet1.weeklya_details.Addweeklya_detailsRow(newwa);
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
                    this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);
                    workBook.BeforeClose += new Microsoft.Office.Interop.Excel.WorkbookEvents_BeforeCloseEventHandler(workBook_BeforeClose);
                }
                else
                {
                    this.tableAdapterManager1.wekkly_assistantTableAdapter.FillByUW(this.humanresourcesDataSet1.wekkly_assistant, u_id, week);
                    ExcelHelperOpen(this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_path, true);
                    this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 2, 1);
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
                this.tableAdapterManager1.wekkly_assistantTableAdapter.FillByUW(this.humanresourcesDataSet1.wekkly_assistant, u_id, week);
                this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 2, 0);
                List<string> str = new List<string>();
                foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                {
                    foreach (string item1 in item2.WCP_E.Split(new char[] { ',' }))
                    {
                        str.Add(item1);

                    }

                }

                foreach (humanresourcesDataSet.wekkly_assistantRow item2 in this.humanresourcesDataSet1.wekkly_assistant)
                {
                    item2.WA_OrderNum = workSheet.get_Range(str[0], missing).Value2.ToString();
                    item2.WA_OfferNum = workSheet.get_Range(str[1], missing).Value2.ToString();
                }
              
                this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_CC = workSheet.get_Range("O4", missing).Value2.ToString();
                this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_CV = workSheet.get_Range("O5", missing).Value2.ToString();
                this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_BI = workSheet.get_Range("O6", missing).Value2.ToString();
                this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_ROS = workSheet.get_Range("O7", missing).Value2.ToString();
                this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_SP = workSheet.get_Range("O8", missing).Value2.ToString();
                this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_SUM = workSheet.get_Range("O9", missing).Value2.ToString();
                //this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_useName = workSheet.get_Range("O16", missing).Value2.ToString();
                //this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_joinT = workSheet.get_Range("O13", missing).Value2.ToString();
                this.tableAdapterManager1.UpdateAll(this.humanresourcesDataSet1);

                this.tableAdapterManager1.weeklyc_particularsTableAdapter.FillBytype_uf(this.humanresourcesDataSet1.weeklyc_particulars, 2, 1);
                foreach (humanresourcesDataSet.weeklyc_particularsRow item2 in this.humanresourcesDataSet1.weeklyc_particulars)
                {
                    this.tableAdapterManager1.weeklya_detailsTableAdapter.FillBywp(this.humanresourcesDataSet1.weeklya_details, this.humanresourcesDataSet1.wekkly_assistant.SingleOrDefault().WA_id, item2.WCP_id);


                    str.Clear();
                    foreach (string item1 in item2.WCP_E.Split(new char[] { ',' }))
                    {
                        str.Add(item1);

                    }
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_Targets = Convert.ToInt32(workSheet.get_Range(str[0], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_Tot = Convert.ToInt32(workSheet.get_Range(str[1], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_Var = Convert.ToInt32(workSheet.get_Range(str[2], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_DAM = Convert.ToInt32(workSheet.get_Range(str[3], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_DAT = Convert.ToInt32(workSheet.get_Range(str[4], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_DAW = Convert.ToInt32(workSheet.get_Range(str[5], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_DATH = Convert.ToInt32(workSheet.get_Range(str[6], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_DAF = Convert.ToInt32(workSheet.get_Range(str[7], missing).Value2.ToString());
                    this.humanresourcesDataSet1.weeklya_details.SingleOrDefault().WAD_DAS = Convert.ToInt32(workSheet.get_Range(str[8], missing).Value2.ToString());

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
            if (templetFilePath == null)
                throw new Exception("Excel模板文件路径不能为空！");

            if (outputFilePath == null)
                throw new Exception("输出Excel文件路径不能为空！");

            if (!File.Exists(templetFilePath))
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
                missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);

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

       
    }
}
