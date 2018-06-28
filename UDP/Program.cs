using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            int buffer_size;
            byte[] t_data;
            const int port = 5000;
            string input;
            //string input2;
            int vv = new int();

            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("172.31.110.204"), port);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, port);
            EndPoint remoteEP = (EndPoint)sender;
            client.Bind(sender);


            while (true)
            {
                
                Console.Write("send data : ");
                input = Console.ReadLine();
                if (input == "exit")
                    break;
                    
                /*Console.Write("value : ");

                input2 = Console.ReadLine();
                if (input2 == "exit")
                    break;
                */
                //buffer_size = Convert.ToInt16(input);
                buffer_size = 2048;

                vv++;
                vv = vv % 6;

                t_data = new byte[buffer_size];
             
                for (int i = 0; i < buffer_size / 2; i = i + 2)
                {
                    byte[] dat = new byte[2];
                    //dat = BitConverter.GetBytes((short)System.Net.IPAddress.HostToNetworkOrder((short)Convert.ToInt16(vv)));
                    dat = BitConverter.GetBytes((short)System.Net.IPAddress.HostToNetworkOrder((short)Convert.ToInt16(vv)));
                    t_data[i] = dat[0];
                    t_data[i+1] = dat[1];
                }    
                //client.SendTo(t_data, buffer_size, SocketFlags.None, serverEP);
                Delay(100);
            }

            Console.WriteLine("Stopping client");
            client.Close();
        }
        

        static private byte[] HostToNetworkOrder(int word)
        {
            byte[] data = new Byte[2];
            byte[] dat = BitConverter.GetBytes((short)System.Net.IPAddress.HostToNetworkOrder((short)word));
            data[0] = dat[0];
            data[1] = dat[1];

            return data;
        }
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                //System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
    }
}
