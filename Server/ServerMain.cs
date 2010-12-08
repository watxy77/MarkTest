using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;

namespace Server
{
    public partial class ServerMain : Form
    {
        public ServerMain()
        {
            InitializeComponent();
        }

        private void ServerMain_Load(object sender, EventArgs e)
        {
            this.CmdStar.Enabled = true;
            this.CmdStop.Enabled = false;
        }

        private void 配置参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set TSet = new Set();
            TSet.ShowDialog();
        }

       
        /// <summary>
        /// 获得XML文件中的端口号
        /// </summary>
        /// <returns></returns>
        private int GetPort()
        {
            try
            {
                XmlDocument TDoc = new XmlDocument();
                TDoc.Load("Settings.xml");
                string TPort = TDoc.GetElementsByTagName("ServerPort")[0].InnerXml;
                return Convert.ToInt32(TPort);

            }
            catch { return 6600; }//默认是6600
        }

        //声明将要用到的类
        private IPEndPoint ServerInfo;//存放服务器的IP和端口信息
        private Socket ServerSocket;//服务端运行的SOCKET
        private Thread ServerThread;//服务端运行的线程
        private Socket[] ClientSocket;//为客户端建立的SOCKET连接
        private int ClientNumb;//存放客户端数量
        private byte[] MsgBuffer;//存放消息数据

        private void CmdStar_Click(object sender, EventArgs e)
        {
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ServerInfo=new IPEndPoint(IPAddress.Any,this.GetPort());
            ServerSocket.Bind(ServerInfo);//将SOCKET接口和IP端口绑定
            ServerSocket.Listen(10);//开始监听，并且挂起数为10

            ClientSocket = new Socket[65535];//为客户端提供连接个数
            MsgBuffer = new byte[65535];//消息数据大小
            ClientNumb = 0;//数量从0开始统计

            ServerThread = new Thread(RecieveAccept);//将接受客户端连接的方法委托给线程
            ServerThread.Start();//线程开始运行

            CheckForIllegalCrossThreadCalls = false;//不捕获对错误线程的调用

            this.CmdStar.Enabled = false;
            this.CmdStop.Enabled = true;
            this.StateMsg.Text = "服务正在运行..."+"  运行端口："+this.GetPort().ToString();
            this.ClientList.Items.Add("服务于 " + DateTime.Now.ToString() + " 开始运行.");
        }
        
        //接受客户端连接的方法
        private void RecieveAccept()
        {
            while (true)
            {
                ClientSocket[ClientNumb] = ServerSocket.Accept();
                ClientSocket[ClientNumb].BeginReceive(MsgBuffer, 0, MsgBuffer.Length, 0, new AsyncCallback(RecieveCallBack),ClientSocket[ClientNumb]);
                this.ClientList.Items.Add(ClientSocket[ClientNumb].RemoteEndPoint.ToString()+" 成功连接服务器.");
                ClientNumb++;
            }
        }

        //回发数据给客户端
        private void RecieveCallBack(IAsyncResult AR)
        {
            try
            {
                Socket RSocket = (Socket)AR.AsyncState;
                int REnd = RSocket.EndReceive(AR);
                for (int i = 0; i < ClientNumb; i++)
                {
                    if (ClientSocket[i].Connected)
                    {
                        ClientSocket[i].Send(MsgBuffer, 0, REnd,0);
                    }
                    RSocket.BeginReceive(MsgBuffer, 0, MsgBuffer.Length, 0, new AsyncCallback(RecieveCallBack), RSocket);
                }
            }
            catch { }
        }

        private void CmdStop_Click(object sender, EventArgs e)
        {
            ServerThread.Abort();//线程终止
            ServerSocket.Close();//关闭SOCKET

            this.CmdStar.Enabled = true;
            this.CmdStop.Enabled = false;
            this.StateMsg.Text = "等待运行...";
            this.ClientList.Items.Add("服务于 " + DateTime.Now.ToString() + " 停止运行.");
        }
    }
}