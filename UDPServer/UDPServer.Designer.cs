namespace UDPServer
{
    partial class frmUDPServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUDPServer));
            this.label1 = new System.Windows.Forms.Label();
            this.lbxRecv = new System.Windows.Forms.ListBox();
            this.txtPortLocal = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBack = new System.Windows.Forms.TextBox();
            this.btnClearRecv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxHex = new System.Windows.Forms.CheckBox();
            this.txtCountRecv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCountBack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务端口";
            // 
            // lbxRecv
            // 
            this.lbxRecv.FormattingEnabled = true;
            this.lbxRecv.HorizontalScrollbar = true;
            this.lbxRecv.ItemHeight = 17;
            this.lbxRecv.Location = new System.Drawing.Point(186, 32);
            this.lbxRecv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxRecv.Name = "lbxRecv";
            this.lbxRecv.Size = new System.Drawing.Size(520, 225);
            this.lbxRecv.TabIndex = 3;
            // 
            // txtPortLocal
            // 
            this.txtPortLocal.Location = new System.Drawing.Point(11, 59);
            this.txtPortLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPortLocal.Name = "txtPortLocal";
            this.txtPortLocal.Size = new System.Drawing.Size(73, 23);
            this.txtPortLocal.TabIndex = 4;
            this.txtPortLocal.Text = "2000";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(92, 55);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(73, 30);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "创建(&T)";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(186, 22);
            this.txtBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBack.Multiline = true;
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(520, 162);
            this.txtBack.TabIndex = 8;
            // 
            // btnClearRecv
            // 
            this.btnClearRecv.Location = new System.Drawing.Point(92, 175);
            this.btnClearRecv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearRecv.Name = "btnClearRecv";
            this.btnClearRecv.Size = new System.Drawing.Size(73, 30);
            this.btnClearRecv.TabIndex = 10;
            this.btnClearRecv.Text = "清空(&C)";
            this.btnClearRecv.UseVisualStyleBackColor = true;
            this.btnClearRecv.Click += new System.EventHandler(this.btnClearRecv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxHex);
            this.groupBox1.Controls.Add(this.txtCountRecv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClearRecv);
            this.groupBox1.Controls.Add(this.txtPortLocal);
            this.groupBox1.Controls.Add(this.lbxRecv);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(726, 278);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收区";
            // 
            // cbxHex
            // 
            this.cbxHex.AutoSize = true;
            this.cbxHex.Location = new System.Drawing.Point(66, 222);
            this.cbxHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxHex.Name = "cbxHex";
            this.cbxHex.Size = new System.Drawing.Size(99, 21);
            this.cbxHex.TabIndex = 13;
            this.cbxHex.Text = "十六进制显示";
            this.cbxHex.UseVisualStyleBackColor = true;
            this.cbxHex.CheckedChanged += new System.EventHandler(this.cbxHex_CheckedChanged);
            // 
            // txtCountRecv
            // 
            this.txtCountRecv.BackColor = System.Drawing.Color.White;
            this.txtCountRecv.Location = new System.Drawing.Point(92, 129);
            this.txtCountRecv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCountRecv.Name = "txtCountRecv";
            this.txtCountRecv.ReadOnly = true;
            this.txtCountRecv.Size = new System.Drawing.Size(73, 23);
            this.txtCountRecv.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "接收计数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCountBack);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBack);
            this.groupBox2.Location = new System.Drawing.Point(15, 297);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(726, 197);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "返回区";
            // 
            // txtCountBack
            // 
            this.txtCountBack.BackColor = System.Drawing.Color.White;
            this.txtCountBack.Location = new System.Drawing.Point(92, 47);
            this.txtCountBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCountBack.Name = "txtCountBack";
            this.txtCountBack.ReadOnly = true;
            this.txtCountBack.Size = new System.Drawing.Size(73, 23);
            this.txtCountBack.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "返回计数";
            // 
            // frmUDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmUDPServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP服务端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUDPServer_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxRecv;
        private System.Windows.Forms.TextBox txtPortLocal;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBack;
        private System.Windows.Forms.Button btnClearRecv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCountRecv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCountBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxHex;
    }
}