using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UDPTest
{
    public partial class UDPTest : Form
    {
        public UDPTest()
        {
            InitializeComponent();
        }

        private void tsbUdpServer_Click(object sender, EventArgs e)
        {
            try
            {
                UDPServer.frmUDPServer frm_udpServer = new UDPServer.frmUDPServer();
                frm_udpServer.Show();
            }
            catch (Exception ex)
            {
                // 调用动态链接库时出错
                MessageBox.Show(ex.Message);
            }

        }

        private void tsbUdpClient_Click(object sender, EventArgs e)
        {
            try
            {
                UDPClient.frmUDPClient frm_udpClient = new UDPClient.frmUDPClient();
                frm_udpClient.Show();
            }
            catch (Exception ex)
            {
                // 调用动态链接库时出错
                MessageBox.Show(ex.Message);
            }

        }
    }
}
