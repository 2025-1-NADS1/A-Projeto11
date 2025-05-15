using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EXEMPLO_03_UDP_CLIENT
{
    class Program
    {
        static int porta = 9000;
        static private void enviarJogadaUDP(String msg)
        {
            UdpClient clienteUDP = new UdpClient();
            UTF8Encoding encoder = new UTF8Encoding();
            byte[] send = encoder.GetBytes(msg);

            clienteUDP.EnableBroadcast = true;
            // clienteUDP.Send(send, send.Length, new IPEndPoint(IPAddress.Broadcast, porta));
            clienteUDP.Send(send, send.Length, new IPEndPoint(IPAddress.Parse("192.168.0.255"), porta));
            clienteUDP.Close();
        }

        static void Main(string[] args)
        {
            string msg = "";
            while (msg.ToUpper() != "FIM")
            {
                Console.WriteLine("Entre com a MSG:");
                msg = Console.ReadLine();
                enviarJogadaUDP(msg);
            }
        }
    }
}
