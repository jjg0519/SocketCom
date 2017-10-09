using Niu.Com;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niu.Client
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private SocketCom socketCom = new SocketCom();
        private Socket socket = null;
        private void btnClientLink_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            var ip = txtServerIp.Text.Trim();
            ip = string.IsNullOrWhiteSpace(ip) ? "127.0.0.1" : ip;
            if (!int.TryParse(txtServerPort.Text.Trim(), out var port)) { port = 6222; }
            //连接服务器
            socket = socketCom.Connect(ip, port);
            this.ShowMsg($"连接{ip}:{port}...");

            //开启接受消息
            Task.Factory.StartNew((obj) =>
            {
                var receiveSocket = obj as Socket;
                socketCom.ReceiveAsync(receiveSocket, bb =>
                {
                    var recStr = Encoding.UTF8.GetString(bb);
                    this.ShowMsg(recStr);
                });
            }, socket);
        }

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            var content = txtWrite.Text.Trim();
            if (string.IsNullOrWhiteSpace(content)) { return; }
            if (socket == null) { MessageBox.Show("点击“连接”按钮，连接服务器"); return; }
            //if (!socketCom.IsConnect(socket)) { this.Connect(); }
            socketCom.SendAsync(socket, content);
            this.ShowMsg(content);
            txtWrite.Clear();
            txtWrite.Focus();
        }

        private void ShowMsg(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) { return; }
            this.BeginInvoke(new EventHandler(delegate
            {
                txtContent.AppendText(
                           string.Format("\r\n{0}：{1}",
                           DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                           content));
            }));
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            this.txtContent.Select(this.txtContent.TextLength, 0);//光标定位到文本最后
            this.txtContent.ScrollToCaret();//滚动到光标处
        }

        private void txtWrite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//判断回车键
            {
                btnSend_Click(sender, e);
            }
        }

        private void txtWrite_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//判断回车键
            {
                txtWrite.Clear();
            }
        }
    }
}
