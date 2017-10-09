namespace Niu.Client
{
    partial class form1
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtServerIp = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtServerPort = new CCWin.SkinControl.SkinTextBox();
            this.btnClientLink = new CCWin.SkinControl.SkinButton();
            this.btnSend = new CCWin.SkinControl.SkinButton();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(12, 27);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(55, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "连接ip：";
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
            this.txtServerIp.Location = new System.Drawing.Point(63, 18);
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
            this.txtServerIp.Size = new System.Drawing.Size(118, 28);
            // 
            // 
            // 
            this.txtServerIp.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerIp.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerIp.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtServerIp.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtServerIp.SkinTxt.Name = "BaseText";
            this.txtServerIp.SkinTxt.Size = new System.Drawing.Size(108, 18);
            this.txtServerIp.SkinTxt.TabIndex = 0;
            this.txtServerIp.SkinTxt.Text = "172.16.21.8";
            this.txtServerIp.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServerIp.SkinTxt.WaterText = "";
            this.txtServerIp.TabIndex = 1;
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
            this.skinLabel2.Location = new System.Drawing.Point(194, 28);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "端口：";
            // 
            // txtServerPort
            // 
            this.txtServerPort.BackColor = System.Drawing.Color.Transparent;
            this.txtServerPort.DownBack = null;
            this.txtServerPort.Icon = null;
            this.txtServerPort.IconIsButton = false;
            this.txtServerPort.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtServerPort.IsPasswordChat = '\0';
            this.txtServerPort.IsSystemPasswordChar = false;
            this.txtServerPort.Lines = new string[] {
        "6222"};
            this.txtServerPort.Location = new System.Drawing.Point(234, 16);
            this.txtServerPort.Margin = new System.Windows.Forms.Padding(0);
            this.txtServerPort.MaxLength = 32767;
            this.txtServerPort.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtServerPort.MouseBack = null;
            this.txtServerPort.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtServerPort.Multiline = false;
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.NormlBack = null;
            this.txtServerPort.Padding = new System.Windows.Forms.Padding(5);
            this.txtServerPort.ReadOnly = false;
            this.txtServerPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerPort.Size = new System.Drawing.Size(59, 28);
            // 
            // 
            // 
            this.txtServerPort.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerPort.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerPort.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtServerPort.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtServerPort.SkinTxt.Name = "BaseText";
            this.txtServerPort.SkinTxt.Size = new System.Drawing.Size(49, 18);
            this.txtServerPort.SkinTxt.TabIndex = 0;
            this.txtServerPort.SkinTxt.Text = "6222";
            this.txtServerPort.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServerPort.SkinTxt.WaterText = "";
            this.txtServerPort.TabIndex = 3;
            this.txtServerPort.Text = "6222";
            this.txtServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServerPort.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServerPort.WaterText = "";
            this.txtServerPort.WordWrap = true;
            // 
            // btnClientLink
            // 
            this.btnClientLink.BackColor = System.Drawing.Color.Transparent;
            this.btnClientLink.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClientLink.DownBack = null;
            this.btnClientLink.Location = new System.Drawing.Point(308, 23);
            this.btnClientLink.MouseBack = null;
            this.btnClientLink.Name = "btnClientLink";
            this.btnClientLink.NormlBack = null;
            this.btnClientLink.Size = new System.Drawing.Size(75, 23);
            this.btnClientLink.TabIndex = 4;
            this.btnClientLink.Text = "连接";
            this.btnClientLink.UseVisualStyleBackColor = false;
            this.btnClientLink.Click += new System.EventHandler(this.btnClientLink_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSend.DownBack = null;
            this.btnSend.Location = new System.Drawing.Point(467, 236);
            this.btnSend.MouseBack = null;
            this.btnSend.Name = "btnSend";
            this.btnSend.NormlBack = null;
            this.btnSend.Size = new System.Drawing.Size(60, 56);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.Location = new System.Drawing.Point(15, 48);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(512, 185);
            this.txtContent.TabIndex = 8;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(15, 236);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(446, 56);
            this.txtWrite.TabIndex = 9;
            this.txtWrite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWrite_KeyDown);
            this.txtWrite.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWrite_KeyUp);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 304);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClientLink);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.skinLabel1);
            this.Name = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtServerIp;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox txtServerPort;
        private CCWin.SkinControl.SkinButton btnClientLink;
        private CCWin.SkinControl.SkinButton btnSend;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtWrite;
    }
}

