using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Niu.Com
{
    public class SocketCom
    {
        public Socket Listen(string ip, int port, int nListen = 10)
        {
            Socket socket = null;
            try
            {
                var ipAddr = IPAddress.Parse(ip);
                var endPoint = new IPEndPoint(ipAddr, port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(endPoint);
                socket.Listen(nListen);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return socket;
        }

        public Socket Connect(string ip, int port)
        {
            Socket socket = null;
            try
            {
                var ipAddr = IPAddress.Parse(ip);
                var endPoint = new IPEndPoint(ipAddr, port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(endPoint);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return socket;
        }

        public void Close(Socket socket)
        {
            if (socket != null)
            {
                socket.Close();
                socket.Dispose();
                socket = null;
            }
        }

        public bool IsConnect(Socket socket)
        {
            return socket.Connected;// && socket.Poll(1000, SelectMode.SelectRead);
        }

        /// <summary>
        /// 接受链接
        /// </summary>
        public void AcceptAsync(Socket socket, Action<Socket> action)
        {
            socket.BeginAccept(new AsyncCallback((result) =>
            {
                var accept_socket = socket.EndAccept(result);
                action(accept_socket);
            }), null);
        }

        //接受信息
        public void ReceiveAsync(Socket socket, Action<byte[]> action, int readByte = 1024)
        {
            var bb = new byte[readByte];
            socket.BeginReceive(bb, 0, bb.Length, SocketFlags.None,
                new AsyncCallback((result) =>
                {
                    if (!socket.Connected)
                    {
                        this.Close(socket); return;
                    }
                    try
                    {
                        var nReceive = socket.EndReceive(result);
                    }
                    catch (Exception ex) { }
                    action(bb);
                    this.ReceiveAsync(socket, action, readByte);
                }),
                socket);
        }

        //发送信息
        public void SendAsync(Socket socket, string content, int writeByte = 1024)
        {
            var sendb = Encoding.UTF8.GetBytes(content);
            socket.BeginSend(sendb, 0, sendb.Length, SocketFlags.None,
                new AsyncCallback((result) =>
                {
                    if (!socket.Connected)
                    {
                        this.Close(socket); return;
                    }
                    try
                    {
                        var nSend = socket.EndSend(result);
                    }
                    catch (Exception) { }
                }),
                socket);
        }

        //获取本机IP   
        public string GetMyIp()
        {
            var _myHostIP = Dns.GetHostEntry(Dns.GetHostName()).
                             AddressList.FirstOrDefault<IPAddress>(a => a.AddressFamily.ToString().Equals("InterNetwork")).ToString();
            return _myHostIP;
        }

        //获取可用端口
        public int GetMyPort()
        {
            return 5666;
        }
    }
}
