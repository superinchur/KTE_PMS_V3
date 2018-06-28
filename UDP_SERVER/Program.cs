using System;
using System.Net;
using System.Net.Sockets;
using System.Text;



namespace UDP_SERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 5000;
            string strIP = "172.31.110.33";

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress ip = IPAddress.Parse(strIP);
            IPEndPoint endPoint = new IPEndPoint(ip, port);

            socket.Bind(endPoint);

            //데이터 받기
            byte[] rBuffer = new byte[1024];

            while (true)
            {
                int length = socket.Receive(rBuffer, 0, rBuffer.Length, SocketFlags.None);
                Console.WriteLine(rBuffer.Length);
                //디코딩
                //string result = Encoding.UTF8.GetString(rBuffer);

                for (int i = 0; i < rBuffer.Length; i++)
                {
                    Console.Write(rBuffer[i] + " " );
                }
                
                Console.WriteLine("");
            }
            
        }
    }
}
