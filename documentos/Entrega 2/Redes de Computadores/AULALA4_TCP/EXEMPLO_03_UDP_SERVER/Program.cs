using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace EXEMPLO_03_UDP_SERVER
{
    class Program
    {
        static int porta = 9000;
        static void Main(string[] args)
        {
            UdpClient udpOuvidor;
            IPEndPoint IPOuvidor;
            Byte[] bytes; ;
            String Msg = null;
            udpOuvidor = new UdpClient(porta);
            udpOuvidor.EnableBroadcast = true;
            IPOuvidor = new IPEndPoint(IPAddress.Parse("192.168.0.255"), porta);
            while (true)
            {
                Console.WriteLine("Ouvindo...");
                
                bytes = udpOuvidor.Receive(ref IPOuvidor);
                Msg = Encoding.UTF8.GetString(bytes);
                Console.WriteLine(Msg);

            }
        }
    }
}
