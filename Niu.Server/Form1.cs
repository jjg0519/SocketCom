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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niu.Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private SocketCom socketCom = new SocketCom();
        private Socket socket = null;

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.skinButton1.Enabled = false;

                var ip = txtServerIp.Text.Trim();
                ip = string.IsNullOrWhiteSpace(ip) ? "127.0.0.1" : ip;
                if (!int.TryParse(txtPort.Text.Trim(), out var port)) { port = 6222; }

                var listenSocket = socketCom.Listen(ip, port);
                this.ShowMsg($"监听{ip}:{port}...");

                socketCom.AcceptAsync(listenSocket, b =>
                {
                    this.socket = b;
                    Task.Factory.StartNew((bb) =>
                    {
                        var receiceSocket = bb as Socket;
                        socketCom.ReceiveAsync(receiceSocket, bbb =>
                        {
                            var recStr = Encoding.UTF8.GetString(bbb);
                            this.ShowMsg(recStr);
                        });
                    }, b);

                    this.ShowMsg($"{b.RemoteEndPoint}连接成功...");
                });
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.skinButton1.Enabled = true;
            }
        }

        public void txtContent_TextChanged(object sender, EventArgs e)
        {

            this.txtContent.Select(this.txtContent.TextLength, 0);//光标定位到文本最后
            this.txtContent.ScrollToCaret();//滚动到光标处
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            var content = txtWrite.Text.Trim();
            if (string.IsNullOrWhiteSpace(content)) { return; }
            if (socket == null) { MessageBox.Show("暂无连接，请等待..."); return; }
            socketCom.SendAsync(socket, content);
            this.ShowMsg(content);
            txtWrite.Clear();
            txtWrite.Focus();
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
