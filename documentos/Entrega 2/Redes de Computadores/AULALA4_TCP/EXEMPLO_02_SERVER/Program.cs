using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace EXEMPLO_02_SERVER
{
    class Program
    {
        /* GET TIME
         * GET TIME LONDON
           GET DATE 
           SET SUMMERTIME {TRUE|FALSE}
           */
        static TcpListener tcpServer;      // Servidor TCP
        static string myIP;                // IP do servidor
        static bool fim;                   // Controla término
        static bool summerTime;            // Horário de verão

        static void Main(string[] args)
        {
            fim = false;
            summerTime = false;
            myIP = "127.0.0.1";            // Localhost
            tcpServer = new TcpListener(IPAddress.Parse(myIP), 30000);
            tcpServer.Start();             // Inicia servidor

            Thread threadServer = new Thread(() => serverListener());
            threadServer.Start();          // Inicia escuta

            Console.WriteLine("Pressione [ENTER] para terminar...");
            Console.ReadLine();
            fim = true;                    // Encerra servidor
        }

        public static void serverListener()
        {
            while (!fim)                   // Loop até encerrar
            {
                TcpClient client = tcpServer.AcceptTcpClient();  // Aceita cliente
                Thread thread = new Thread(() => responseMessage(client));
                thread.Start();            // Nova thread para cliente
            }
        }

        public static void responseMessage(TcpClient client)
        {
            Console.WriteLine(client.Client.RemoteEndPoint);  // Mostra cliente
            String msg = receiveTCPMessage(client);           // Recebe mensagem
            Console.WriteLine(msg);                           // Exibe mensagem
            msg = parseMsg(msg);                              // Processa comando
            sendTCPMessage(client, msg);                      // Envia resposta
        }

        private static string parseMsg(string msg)
        {
            String[] parse = msg.Split(' ');                  // Divide comando
            String resposta = "Comando Desconhecido!!";       // Resposta padrão

            if (parse[0] == "GET")                            // Comando GET
            {
                if (parse[1] == "TIME")                       // GET TIME
                {
                    DateTime dt = DateTime.Now;
                    if (parse.Length == 2)                    // Apenas GET TIME
                    {
                        if (summerTime) dt = dt.AddHours(1);    // Ajusta verão
                        resposta = dt.ToShortTimeString();    // Retorna hora
                    }
                    else if (parse[2] == "LONDON")            // GET TIME LONDON
                    {
                        dt = dt.AddHours(4);                  // Hora Londres
                        resposta = dt.ToShortTimeString();    // Retorna hora
                    }
                }
                if (parse[1] == "DATE")                       // GET DATE
                {
                    resposta = DateTime.Now.ToShortDateString();  // Retorna data
                }
            }
            else if (parse[0] == "SET")                       // Comando SET
            {
                if (parse[1] == "SUMMERTIME")                 // SET SUMMERTIME
                {
                    summerTime = (parse[2] == "TRUE");        // Define verão
                }
            }
            return resposta;                                  // Retorna resposta
        }

        public static string receiveTCPMessage(TcpClient tcpClient)
        {
            string TCPMsg = "";
            int i;

            NetworkStream stream = tcpClient.GetStream();     // Obtém stream
            Byte[] byteMsg = new Byte[tcpClient.ReceiveBufferSize];

            int tentativa = 0;
            while (!stream.DataAvailable && tentativa < 10)   // Espera dados
            {
                Thread.Sleep(50);
                tentativa++;
            }

            while (stream.DataAvailable)                      // Lê dados
            {
                i = stream.Read(byteMsg, 0, byteMsg.Length);
                TCPMsg = TCPMsg + System.Text.Encoding.ASCII.GetString(byteMsg, 0, i);
            }

            return TCPMsg;                                    // Retorna mensagem
        }

        public static void sendTCPMessage(TcpClient tcpClient, String msg)
        {
            NetworkStream stream = tcpClient.GetStream();     // Obtém stream
            Byte[] byteMsg = System.Text.Encoding.UTF8.GetBytes(msg);

            if (stream.CanWrite)                              // Pode escrever?
            {
                stream.Write(byteMsg, 0, byteMsg.Length);     // Envia dados
                stream.Flush();                               // Limpa buffer
            }
            else
            {
                throw new Exception("Problema de Comunicação!!!.");
            }

            tcpClient.Close();                                // Fecha conexão
        }
    }
}