namespace Niu.Server
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtPort = new CCWin.SkinControl.SkinTextBox();
            this.txtServerIp = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.btnSend = new CCWin.SkinControl.SkinButton();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(325, 19);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 0;
            this.skinButton1.Text = "监听";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(205, 25);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "监听端口：";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.Transparent;
            this.txtPort.DownBack = null;
            this.txtPort.Icon = null;
            this.txtPort.IconIsButton = false;
            this.txtPort.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPort.IsPasswordChat = '\0';
            this.txtPort.IsSystemPasswordChar = false;
            this.txtPort.Lines = new string[] {
        "6222"};
            this.txtPort.Location = new System.Drawing.Point(269, 14);
            this.txtPort.Margin = new System.Windows.Forms.Padding(0);
            this.txtPort.MaxLength = 32767;
            this.txtPort.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPort.MouseBack = null;
            this.txtPort.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.NormlBack = null;
            this.txtPort.Padding = new System.Windows.Forms.Padding(5);
            this.txtPort.ReadOnly = false;
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.Size = new System.Drawing.Size(53, 28);
            // 
            // 
            // 
            this.txtPort.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPort.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPort.SkinTxt.Name = "BaseText";
            this.txtPort.SkinTxt.Size = new System.Drawing.Size(43, 18);
            this.txtPort.SkinTxt.TabIndex = 0;
            this.txtPort.SkinTxt.Text = "6222";
            this.txtPort.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPort.SkinTxt.WaterText = "";
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "6222";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPort.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPort.WaterText = "";
            this.txtPort.WordWrap = true;
            // 
            // txtServerIp
            // 
            this.txtServerIp.BackColor = System.Drawing.Color.Transparent;
            this.txtServerIp.DownBack = null;
            this.txtServerIp.Icon = null;
            this.txtServerIp.IconIsButton = false;
            this.txtServerIp.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtServerIp.IsPasswordChat = '\0';
            this.txtServerIp.IsSystemPasswordChar = false;
            this.txtServerIp.Lines = new string[] {
        "172.16.21.8"};
            this.txtServerIp.Location = new System.Drawing.Point(63, 14);
            this.txtServerIp.Margin = new System.Windows.Forms.Padding(0);
            this.txtServerIp.MaxLength = 32767;
            this.txtServerIp.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtServerIp.MouseBack = null;
            this.txtServerIp.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtServerIp.Multiline = false;
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.NormlBack = null;
            this.txtServerIp.Padding = new System.Windows.Forms.Padding(5);
            this.txtServerIp.ReadOnly = false;
            this.txtServerIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerIp.Size = new System.Drawing.Size(139, 28);
            // 
            // 
            // 
            this.txtServerIp.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerIp.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerIp.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtServerIp.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtServerIp.SkinTxt.Name = "BaseText";
            this.txtServerIp.SkinTxt.Size = new System.Drawing.Size(129, 18);
            this.txtServerIp.SkinTxt.TabIndex = 0;
            this.txtServerIp.SkinTxt.Text = "172.16.21.8";
            this.txtServerIp.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServerIp.SkinTxt.WaterText = "";
            this.txtServerIp.TabIndex = 5;
            this.txtServerIp.Text = "172.16.21.8";
            this.txtServerIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServerIp.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServerIp.WaterText = "";
            this.txtServerIp.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(12, 25);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(55, 17);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "监听ip：";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSend.DownBack = null;
            this.btnSend.Location = new System.Drawing.Point(538, 250);
            this.btnSend.MouseBack = null;
            this.btnSend.Name = "btnSend";
            this.btnSend.NormlBack = null;
            this.btnSend.Size = new System.Drawing.Size(62, 64);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.Location = new System.Drawing.Point(15, 46);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(585, 198);
            this.txtContent.TabIndex = 8;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(15, 251);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(517, 63);
            this.txtWrite.TabIndex = 9;
            this.txtWrite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWrite_KeyDown);
            this.txtWrite.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWrite_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 326);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtPort;
        private CCWin.SkinControl.SkinTextBox txtServerIp;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton btnSend;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtWrite;
    }
}

