using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDPClient
{
    public partial class frmUDPClient : Form
    {
        private Thread threadReceive; // 数据接收线程
        private UdpClient client; // UDP客户端
        private IPAddress ipTarget; // 目标IP
        private int nPortTarget; // 目标端口
        private int nPortLocal; // 本地端口
        private IPEndPoint target; // 目标端
        private IPAddressControlLib.IPAddressControl ipCtrTarget;
        private ASCIIEncoding encode;
        private bool bLinked; // 是否已连接
        private int nCountSend; // 发送计数
        private int nCountRecv; // 接收计数
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtPortLocal; 
        private TextBox txtPortTarget;
        private TextBox txtSend;
        private Button btnSend;
        private ListBox lbxRecv;
        private Button btnClearRecv;
        private GroupBox groupBox1;
        private TextBox txtCountSend;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txtCountRecv;
        private Label label3;
        private Label label7;
        private TextBox txtboxInterval;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private IContainer components;
        private CheckBox chkAutoSend;
        private CheckBox cbxHex;
        private Button btnLink;
        private bool bHex; // 十六进制显示

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUDPClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortTarget = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.ipCtrTarget = new IPAddressControlLib.IPAddressControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPortLocal = new System.Windows.Forms.TextBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.lbxRecv = new System.Windows.Forms.ListBox();
            this.btnClearRecv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxInterval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCountSend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxHex = new System.Windows.Forms.CheckBox();
            this.txtCountRecv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标端口";
            // 
            // txtPortTarget
            // 
            this.txtPortTarget.Location = new System.Drawing.Point(67, 94);
            this.txtPortTarget.Name = "txtPortTarget";
            this.txtPortTarget.Size = new System.Drawing.Size(73, 23);
            this.txtPortTarget.TabIndex = 1;
            this.txtPortTarget.Text = "2000";
            // 
            // txtSend
            // 
            this.txtSend.BackColor = System.Drawing.SystemColors.Window;
            this.txtSend.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSend.Location = new System.Drawing.Point(162, 58);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSend.Size = new System.Drawing.Size(540, 201);
            this.txtSend.TabIndex = 2;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(162, 25);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(82, 30);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送(&S)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ipCtrTarget
            // 
            this.ipCtrTarget.BackColor = System.Drawing.SystemColors.Window;
            this.ipCtrTarget.Location = new System.Drawing.Point(9, 58);
            this.ipCtrTarget.MinimumSize = new System.Drawing.Size(131, 23);
            this.ipCtrTarget.Name = "ipCtrTarget";
            this.ipCtrTarget.ReadOnly = false;
            this.ipCtrTarget.Size = new System.Drawing.Size(131, 23);
            this.ipCtrTarget.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "本地端口";
            // 
            // txtPortLocal
            // 
            this.txtPortLocal.Location = new System.Drawing.Point(68, 130);
            this.txtPortLocal.Name = "txtPortLocal";
            this.txtPortLocal.Size = new System.Drawing.Size(72, 23);
            this.txtPortLocal.TabIndex = 2;
            this.txtPortLocal.Text = "2718";
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(67, 168);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(73, 30);
            this.btnLink.TabIndex = 3;
            this.btnLink.Text = "连接(&L)";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // lbxRecv
            // 
            this.lbxRecv.FormattingEnabled = true;
            this.lbxRecv.HorizontalScrollbar = true;
            this.lbxRecv.ItemHeight = 17;
            this.lbxRecv.Location = new System.Drawing.Point(162, 26);
            this.lbxRecv.Name = "lbxRecv";
            this.lbxRecv.Size = new System.Drawing.Size(540, 157);
            this.lbxRecv.TabIndex = 14;
            // 
            // btnClearRecv
            // 
            this.btnClearRecv.Location = new System.Drawing.Point(68, 81);
            this.btnClearRecv.Name = "btnClearRecv";
            this.btnClearRecv.Size = new System.Drawing.Size(73, 30);
            this.btnClearRecv.TabIndex = 0;
            this.btnClearRecv.Text = "清空(&C)";
            this.btnClearRecv.UseVisualStyleBackColor = true;
            this.btnClearRecv.Click += new System.EventHandler(this.btnClearRecv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoSend);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtboxInterval);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtCountSend);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ipCtrTarget);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Controls.Add(this.txtPortTarget);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnLink);
            this.groupBox1.Controls.Add(this.txtPortLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 277);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送区";
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.Location = new System.Drawing.Point(281, 31);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(75, 21);
            this.chkAutoSend.TabIndex = 24;
            this.chkAutoSend.Text = "自动发送";
            this.chkAutoSend.UseVisualStyleBackColor = true;
            this.chkAutoSend.CheckedChanged += new System.EventHandler(this.chkAutoSend_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "ms";
            // 
            // txtboxInterval
            // 
            this.txtboxInterval.Location = new System.Drawing.Point(441, 29);
            this.txtboxInterval.Name = "txtboxInterval";
            this.txtboxInterval.Size = new System.Drawing.Size(52, 23);
            this.txtboxInterval.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "间隔时间";
            // 
            // txtCountSend
            // 
            this.txtCountSend.BackColor = System.Drawing.Color.White;
            this.txtCountSend.Location = new System.Drawing.Point(68, 228);
            this.txtCountSend.Name = "txtCountSend";
            this.txtCountSend.ReadOnly = true;
            this.txtCountSend.Size = new System.Drawing.Size(73, 23);
            this.txtCountSend.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "发送计数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxHex);
            this.groupBox2.Controls.Add(this.txtCountRecv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbxRecv);
            this.groupBox2.Controls.Add(this.btnClearRecv);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 198);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区";
            // 
            // cbxHex
            // 
            this.cbxHex.AutoSize = true;
            this.cbxHex.Location = new System.Drawing.Point(41, 147);
            this.cbxHex.Name = "cbxHex";
            this.cbxHex.Size = new System.Drawing.Size(99, 21);
            this.cbxHex.TabIndex = 21;
            this.cbxHex.Text = "十六进制显示";
            this.cbxHex.UseVisualStyleBackColor = true;
            this.cbxHex.CheckedChanged += new System.EventHandler(this.cbxHex_CheckedChanged);
            // 
            // txtCountRecv
            // 
            this.txtCountRecv.BackColor = System.Drawing.Color.White;
            this.txtCountRecv.Location = new System.Drawing.Point(68, 42);
            this.txtCountRecv.Name = "txtCountRecv";
            this.txtCountRecv.ReadOnly = true;
            this.txtCountRecv.Size = new System.Drawing.Size(73, 23);
            this.txtCountRecv.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "接收计数";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmUDPClient
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUDPClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP客户端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUDPClient_FormClosed);
            this.Load += new System.EventHandler(this.frmUDPClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        
        private void btnLink_Click(object sender, EventArgs e)
        {
            if (!bLinked)
            {
                try
                {
                    // 初始化UDP客户端
                    nPortLocal = int.Parse(txtPortLocal.Text);
                    client = new UdpClient(nPortLocal);

                    // 初始化目标端
                    ipTarget = IPAddress.Parse(ipCtrTarget.Text);
                    nPortTarget = int.Parse(txtPortTarget.Text);
                    target = new IPEndPoint(ipTarget, nPortTarget);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    client.Close();
                    return;
                }

                // 已连接
                btnLink.Text = "断开";
                bLinked = true;
                btnSend.Enabled = true;
                Console.Beep(2000, 500);
                
                // 开启数据接收线程
                if (threadReceive.ThreadState.ToString() == "Unstarted")
                {
                    threadReceive.Start();         
                }
            }
            else
            {
                // 关闭连接
                bLinked = false;
                client.Close();

                // 已断开
                btnLink.Text = "连接";
                btnSend.Enabled = false;
                Console.Beep(800, 500);
            }
        }

        private void Receive() // 数据接收的线程函数
        {
            while(bLinked)
            {
                try
                {
                    if (client.Available == 0)
                    {
                        continue;
                    }
                    byte[] recvData = client.Receive(ref target);
                    String strRecv = encode.GetString(recvData);

                    // 是否转换为十六进制显示
                    if (bHex)
                    {
                        char[] values = strRecv.ToCharArray();
                        strRecv = "";
                        foreach (char letter in values)
                        {
                            int value = Convert.ToInt32(letter);
                            string strHex = String.Format("{0:X}", value);
                            if (strHex.Length == 1)
                            {
                                strHex = string.Format("{0}{1}", "0", strHex);
                            }
                            strRecv += strHex;
                            strRecv += " ";
                        }
                    }

                    // 更新接收计数
                    if (strRecv != "")
                    {
                        nCountRecv += 1;
                        txtCountRecv.Text = nCountRecv.ToString();
                    }
                    lbxRecv.Items.Add(strRecv);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // 生成发送串
            string strSend = txtSend.Text;
            byte[] sendData = encode.GetBytes(strSend);

            // 发送字符串
            try
            {
                client.Send(sendData, sendData.Length, target);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // 发送计数加1
            nCountSend += 1;
            txtCountSend.Text = nCountSend.ToString();
        }

        public frmUDPClient()
        {
            InitializeComponent();
            encode = new ASCIIEncoding();
            bLinked = false;
            btnSend.Enabled = false;
            nCountSend = 0;
            nCountRecv = 0;
            threadReceive = new Thread(new ThreadStart(Receive));
        }

        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            if (bLinked && (txtSend.Text.Length!=0))
            {
                btnSend.Enabled = true;
                chkAutoSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
                chkAutoSend.Enabled = false;
            }
        }

        private void frmUDPClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 若已连接则先关闭
            if (bLinked)
            {
                try
                {
                    bLinked = false;
                    client.Close();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 生成发送串
            string strSend = txtSend.Text;
            byte[] sendData = encode.GetBytes(strSend);

            // 发送字符串
            try
            {
                client.Send(sendData, sendData.Length, target);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // 发送计数加1
            nCountSend += 1;
            txtCountSend.Text = nCountSend.ToString();
        }

        private void chkAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSend.Checked)
            {
                int nInterval = int.Parse(txtboxInterval.Text);
                if (nInterval < 1)
                {
                    MessageBox.Show("无效的定时间隔");
                    return;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = nInterval;
                    timer1.Start();
                }
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
        }

        private void frmUDPClient_Load(object sender, EventArgs e)
        {
            chkAutoSend.Enabled = false;
            txtboxInterval.Text = "1000";
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
