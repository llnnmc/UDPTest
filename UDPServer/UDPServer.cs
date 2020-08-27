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

namespace UDPServer
{
    public partial class frmUDPServer : Form
    {
        private UdpClient server; // UDP服务端
        private IPEndPoint target; // 目标端
        private int nPortLocal; // 本地端口
        private Thread threadServer; // 服务端线程
        private ASCIIEncoding encode;
        private int nCountRecv; // 接收计数
        private int nCountBack; // 返回计数
        private bool bCreated; // 服务端是否已创建
        private bool bHex; // 十六进制显示

        public frmUDPServer()
        {
            InitializeComponent();
            encode = new ASCIIEncoding();
            nCountRecv = 0;
            nCountBack = 0;
            bCreated = false;
            threadServer = new Thread(new ThreadStart(Run));
            bHex = false;
        }

        public void Run() // 服务端线程函数
        {         
            while(bCreated)
            {
                try
                {
                    // 接收数据
                    if (server.Available == 0)
                    {
                        continue;
                    }
                    byte[] recvData = server.Receive(ref target);
                    string strReceive = encode.GetString(recvData);

                    // 是否转换为十六进制显示
                    if (bHex)
                    {
                        char[] values = strReceive.ToCharArray();
                        strReceive = "";
                        foreach (char letter in values)
                        {
                            int value = Convert.ToInt32(letter);
                            string strHex = String.Format("{0:X}", value);
                            if (strHex.Length == 1)
                            {
                                strHex = string.Format("{0}{1}", "0", strHex);
                            }
                            strReceive += strHex;
                            strReceive += " ";
                        } 
                    }

                    // 更新接收计数
                    if (strReceive!="")
                    {
                        nCountRecv += 1;
                        txtCountRecv.Text = nCountRecv.ToString();
                    }

                    // 数据添加到列表框
                    lbxRecv.Items.Add(strReceive);

                    // 生成回执数据
                    String strSend = txtBack.Text;

                    // 发送回执
                    if (strSend!="")
                    {
                        // 返回数据
                        byte[] sendData = encode.GetBytes(strSend);
                        server.Send(sendData, sendData.Length, target);
                      
                        // 更新返回计数
                        nCountBack += 1;
                        txtCountBack.Text = nCountBack.ToString();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // 初始化UDP服务端
                nPortLocal = int.Parse(txtPortLocal.Text);
                server = new UdpClient(nPortLocal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // 已创建
            btnCreate.Text = "已创建";
            btnCreate.Enabled = false;
            txtPortLocal.Enabled = false;
            bCreated = true;
            Console.Beep(2000, 500);

            // 开启服务端线程
            threadServer.Start();
        }

        private void frmUDPServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 若已连接则先关闭
            if (bCreated)
            {
                try
                {
                    bCreated = false;
                    server.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnClearRecv_Click(object sender, EventArgs e)
        {
            lbxRecv.Items.Clear();
            nCountRecv = 0;
            txtCountRecv.Text = nCountRecv.ToString();
        }
        
        private void cbxHex_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHex.Checked)
            {
                bHex = true;
            }
            else
            {
                bHex = false;
            }
        }
    }
}
