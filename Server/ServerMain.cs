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

        private void ���ò���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set TSet = new Set();
            TSet.ShowDialog();
        }

       
        /// <summary>
        /// ���XML�ļ��еĶ˿ں�
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
            catch { return 6600; }//Ĭ����6600
        }

        //������Ҫ�õ�����
        private IPEndPoint ServerInfo;//��ŷ�������IP�Ͷ˿���Ϣ
        private Socket ServerSocket;//��������е�SOCKET
        private Thread ServerThread;//��������е��߳�
        private Socket[] ClientSocket;//Ϊ�ͻ��˽�����SOCKET����
        private int ClientNumb;//��ſͻ�������
        private byte[] MsgBuffer;//�����Ϣ����

        private void CmdStar_Click(object sender, EventArgs e)
        {
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ServerInfo=new IPEndPoint(IPAddress.Any,this.GetPort());
            ServerSocket.Bind(ServerInfo);//��SOCKET�ӿں�IP�˿ڰ�
            ServerSocket.Listen(10);//��ʼ���������ҹ�����Ϊ10

            ClientSocket = new Socket[65535];//Ϊ�ͻ����ṩ���Ӹ���
            MsgBuffer = new byte[65535];//��Ϣ���ݴ�С
            ClientNumb = 0;//������0��ʼͳ��

            ServerThread = new Thread(RecieveAccept);//�����ܿͻ������ӵķ���ί�и��߳�
            ServerThread.Start();//�߳̿�ʼ����

            CheckForIllegalCrossThreadCalls = false;//������Դ����̵߳ĵ���

            this.CmdStar.Enabled = false;
            this.CmdStop.Enabled = true;
            this.StateMsg.Text = "������������..."+"  ���ж˿ڣ�"+this.GetPort().ToString();
            this.ClientList.Items.Add("������ " + DateTime.Now.ToString() + " ��ʼ����.");
        }
        
        //���ܿͻ������ӵķ���
        private void RecieveAccept()
        {
            while (true)
            {
                ClientSocket[ClientNumb] = ServerSocket.Accept();
                ClientSocket[ClientNumb].BeginReceive(MsgBuffer, 0, MsgBuffer.Length, 0, new AsyncCallback(RecieveCallBack),ClientSocket[ClientNumb]);
                this.ClientList.Items.Add(ClientSocket[ClientNumb].RemoteEndPoint.ToString()+" �ɹ����ӷ�����.");
                ClientNumb++;
            }
        }

        //�ط����ݸ��ͻ���
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
            ServerThread.Abort();//�߳���ֹ
            ServerSocket.Close();//�ر�SOCKET

            this.CmdStar.Enabled = true;
            this.CmdStop.Enabled = false;
            this.StateMsg.Text = "�ȴ�����...";
            this.ClientList.Items.Add("������ " + DateTime.Now.ToString() + " ֹͣ����.");
        }
    }
}