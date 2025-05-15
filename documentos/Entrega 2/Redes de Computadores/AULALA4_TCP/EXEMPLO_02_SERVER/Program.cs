using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXEMPLO_02_SERVER
{
    class Program
    {
        /* GET TIME
         * GET TIME LONDON
           GET DATE 
           SET SUMMERTIME {TRUE|FALSE}
           */
        static TcpListener tcpServer;
        static string myIP;
        static bool fim;
        static bool summerTime;
        static void Main(string[] args)
        {
            fim = false;
            summerTime = false;
            myIP = "127.0.0.1";
            tcpServer = new TcpListener(IPAddress.Parse(myIP), 30000);
            tcpServer.Start();
            Thread threadServer = new Thread(() => serverListener());
            threadServer.Start();
            //TcpClient client = new TcpClient();
            //client.Connect(myIP, 80);
            Console.WriteLine("Pressione [ENTER] para terninar...");
            Console.ReadLine();
            fim = true;
        }

        public static void serverListener()
        {
            while (!fim)
            {
                TcpClient client = tcpServer.AcceptTcpClient();
                Thread thread = new Thread(() => responseMessage(client));
                thread.Start();
            }

        }

        public static void responseMessage(TcpClient client)
        {
            Console.WriteLine(client.Client.RemoteEndPoint);
            String msg = receiveTCPMessage(client);
            Console.WriteLine(msg);
            msg = parseMsg(msg);
            sendTCPMessage(client, msg);
        }

        private static string parseMsg(string msg)
        {
            String[] parse = msg.Split(' ');
            String resposta = "Comando Desconhecido!!";

            if (parse[0] == "GET")

            {
                if (parse[1] == "TIME")
                {
                    DateTime dt = DateTime.Now;
                    if (parse.Length == 2)
                    {
                        if (summerTime) dt=dt.AddHours(1);

                        resposta = dt.ToShortTimeString();
                    }
                    else if (parse[2] == "LONDON")
                    {
                        
                        dt = dt.AddHours(4);
                        resposta = dt.ToShortTimeString();
                    }
                }
                if (parse[1] == "DATE")
                {
                    resposta = DateTime.Now.ToShortDateString();
                }
            }
            else 
            if (parse[0] == "SET") 
            {
                if (parse[1] == "SUMMERTIME")
                {
                    summerTime = (parse[2] == "TRUE");
                }
            }
            return resposta;
        }
    
        public static string receiveTCPMessage(TcpClient tcpClient)
        {
            string TCPMsg = "";
            int i;

            NetworkStream stream = tcpClient.GetStream();
            string ip = tcpClient.Client.RemoteEndPoint.ToString();
            ip = ip.Substring(0, ip.IndexOf(':'));

            Byte[] byteMsg = new Byte[tcpClient.ReceiveBufferSize];
            //TCPMsg = ip + " falou:>>";
            int tentativa = 0;
            while (!stream.DataAvailable && tentativa < 10)
            {
                Thread.Sleep(50);
                tentativa++;
            }

            while (stream.DataAvailable)
            {
                i = stream.Read(byteMsg, 0, byteMsg.Length);
                TCPMsg = TCPMsg + System.Text.Encoding.ASCII.GetString(byteMsg, 0, i);
            }

            return TCPMsg;
        }

        public static void sendTCPMessage(TcpClient tcpClient, String msg)
        {

            NetworkStream stream = tcpClient.GetStream();
            Byte[] byteMsg = System.Text.Encoding.UTF8.GetBytes(msg);
            if (stream.CanWrite)
            {
                stream.Write(byteMsg, 0, byteMsg.Length);
                stream.Flush();
            }
            else
            {
                throw new Exception("Problema de Comunicação!!!.");
            }

            tcpClient.Close();
        }

    }


}
