using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CustomUIControls;

namespace HumanResources.Alert
{
    public partial class AlertSet1Form : Form
    {

        TaskbarNotifier taskbarNotifier1;
        TaskbarNotifier taskbarNotifier2;
        TaskbarNotifier taskbarNotifier3;

        public AlertSet1Form()
        {
            InitializeComponent();

            taskbarNotifier1 = new TaskbarNotifier();
            taskbarNotifier1.SetBackgroundBitmap(new Bitmap(GetType(), "skin.bmp"), Color.FromArgb(255, 0, 255));
            taskbarNotifier1.SetCloseBitmap(new Bitmap(GetType(), "close.bmp"), Color.FromArgb(255, 0, 255), new Point(127, 8));
            taskbarNotifier1.TitleRectangle = new Rectangle(40, 9, 70, 25);
            taskbarNotifier1.ContentRectangle = new Rectangle(8, 41, 133, 68);
            taskbarNotifier1.TitleClick += new EventHandler(TitleClick);
            taskbarNotifier1.ContentClick += new EventHandler(ContentClick);
            taskbarNotifier1.CloseClick += new EventHandler(CloseClick);
            
            taskbarNotifier2 = new TaskbarNotifier();
            taskbarNotifier2.SetBackgroundBitmap(new Bitmap(GetType(), "skin2.bmp"), Color.FromArgb(255, 0, 255));
            taskbarNotifier2.SetCloseBitmap(new Bitmap(GetType(), "close2.bmp"), Color.FromArgb(255, 0, 255), new Point(300, 74));
            taskbarNotifier2.TitleRectangle = new Rectangle(123, 80, 176, 16);
            taskbarNotifier2.ContentRectangle = new Rectangle(116, 97, 197, 22);
            taskbarNotifier2.TitleClick += new EventHandler(TitleClick);
            taskbarNotifier2.ContentClick += new EventHandler(ContentClick);
            taskbarNotifier2.CloseClick += new EventHandler(CloseClick);

            // Added Rev 002
            taskbarNotifier3 = new TaskbarNotifier();
            taskbarNotifier3.SetBackgroundBitmap(new Bitmap(GetType(), "skin3.bmp"), Color.FromArgb(255, 0, 255));
            taskbarNotifier3.SetCloseBitmap(new Bitmap(GetType(), "close.bmp"), Color.FromArgb(255, 0, 255), new Point(280, 57));
            taskbarNotifier3.TitleRectangle = new Rectangle(150, 57, 125, 28);
            taskbarNotifier3.ContentRectangle = new Rectangle(75, 92, 215, 55);
            taskbarNotifier3.TitleClick += new EventHandler(TitleClick);
            taskbarNotifier3.ContentClick += new EventHandler(ContentClick);
            taskbarNotifier3.CloseClick += new EventHandler(CloseClick);
             
        }


        void CloseClick(object obj, EventArgs ea)
        {
            MessageBox.Show("关闭按钮被点击");
        }

        void TitleClick(object obj, EventArgs ea)
        {
            MessageBox.Show("标题被点击");
            AlertInfoForm aa = new AlertInfoForm();
            aa.MdiParent = this.MdiParent;
            aa.Show();
        }

        void ContentClick(object obj, EventArgs ea)
        {
            MessageBox.Show("内容被点击");
        }

        static bool IsNumeric(string str)
        {
            if (str == null || str.Length == 0)
                return false;
            foreach (char c in str)
            {
                if (!Char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入标题和内容文字");
                return;
            }
            if (!IsNumeric(textBox3.Text) || !IsNumeric(textBox4.Text) || !IsNumeric(textBox5.Text))
            {
                MessageBox.Show("请输入延迟时间（以毫秒计）");
                return;
            }

            taskbarNotifier1.CloseClickable = checkBox3.Checked;
            taskbarNotifier1.TitleClickable = checkBox1.Checked;
            taskbarNotifier1.ContentClickable = checkBox2.Checked;

            taskbarNotifier1.EnableSelectionRectangle = checkBox4.Checked;
            taskbarNotifier1.KeepVisibleOnMousOver = checkBox5.Checked;	// Added Rev 002
            taskbarNotifier1.ReShowOnMouseOver = checkBox6.Checked;			// Added Rev 002
            taskbarNotifier1.Show(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入标题和内容文字");
                return;
            }
            if (!IsNumeric(textBox3.Text) || !IsNumeric(textBox4.Text) || !IsNumeric(textBox5.Text))
            {
                MessageBox.Show("请输入延迟时间（以毫秒计）");
                return;
            }

            taskbarNotifier2.CloseClickable = checkBox3.Checked;
            taskbarNotifier2.TitleClickable = checkBox1.Checked;
            taskbarNotifier2.ContentClickable = checkBox2.Checked;
            taskbarNotifier2.EnableSelectionRectangle = checkBox4.Checked;
            taskbarNotifier2.KeepVisibleOnMousOver = checkBox5.Checked;	// Added Rev 002
            taskbarNotifier2.ReShowOnMouseOver = checkBox6.Checked;			// Added Rev 002
            taskbarNotifier2.Show(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入标题和内容文字");
                return;
            }
            if (!IsNumeric(textBox3.Text) || !IsNumeric(textBox4.Text) || !IsNumeric(textBox5.Text))
            {
                MessageBox.Show("请输入延迟时间（以毫秒计）");
                return;
            }

            taskbarNotifier3.CloseClickable = checkBox3.Checked;
            taskbarNotifier3.TitleClickable = checkBox1.Checked;
            taskbarNotifier3.ContentClickable = checkBox2.Checked;
            taskbarNotifier3.EnableSelectionRectangle = checkBox4.Checked;
            taskbarNotifier3.KeepVisibleOnMousOver = checkBox5.Checked;	// Added Rev 002
            taskbarNotifier3.ReShowOnMouseOver = checkBox6.Checked;			// Added Rev 002
            taskbarNotifier3.Show(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}