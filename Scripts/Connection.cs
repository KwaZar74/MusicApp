using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Scripts
{
    internal class Connection
    {
        public bool icConnect = false;
        TcpClient tcpClient = new TcpClient();
        public void connectTCP()
        {
            try
            {
                tcpClient.Connect("192.168.0.104", 12345);
                icConnect = true;
            }
            catch
            {

            }
        }

        public void sendTCP(string messedge)
        {
            //Шифрование
            //string encryptedstring = StringCipher.Encrypt(messedge, "qweqweqwe");

            NetworkStream stream = tcpClient.GetStream();
            var DATA = Encoding.UTF8.GetBytes(messedge);
            stream.Write(DATA);
        }
    }
}
