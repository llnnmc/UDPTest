namespace UDPTest
{
    partial class UDPTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDPTest));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUdpServer = new System.Windows.Forms.ToolStripButton();
            this.tsbUdpClient = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUdpServer,
            this.tsbUdpClient});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbUdpServer
            // 
            this.tsbUdpServer.Image = ((System.Drawing.Image)(resources.GetObject("tsbUdpServer.Image")));
            this.tsbUdpServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUdpServer.Name = "tsbUdpServer";
            this.tsbUdpServer.Size = new System.Drawing.Size(98, 24);
            this.tsbUdpServer.Text = "UDP Server";
            this.tsbUdpServer.Click += new System.EventHandler(this.tsbUdpServer_Click);
            // 
            // tsbUdpClient
            // 
            this.tsbUdpClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbUdpClient.Image")));
            this.tsbUdpClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUdpClient.Name = "tsbUdpClient";
            this.tsbUdpClient.Size = new System.Drawing.Size(93, 24);
            this.tsbUdpClient.Text = "UDP Client";
            this.tsbUdpClient.Click += new System.EventHandler(this.tsbUdpClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UDPTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UDPTest";
            this.Text = "UDP Test";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUdpServer;
        private System.Windows.Forms.ToolStripButton tsbUdpClient;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

