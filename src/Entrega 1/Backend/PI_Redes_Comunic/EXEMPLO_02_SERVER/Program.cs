using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace EXEMPLO_02_SERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpListener servidor = new TcpListener(IPAddress.Any, 80);
                servidor.Start();
                Console.WriteLine("Servidor TCP iniciado na porta 80");
                Console.WriteLine("Aguardando conexões...");

                while (true)
                {
                    TcpClient cliente = servidor.AcceptTcpClient();
                    Console.WriteLine($"Cliente conectado: {((IPEndPoint)cliente.Client.RemoteEndPoint).Address}");

                    NetworkStream stream = cliente.GetStream();
                    byte[] buffer = new byte[cliente.ReceiveBufferSize];
                    
                    // Lê a mensagem do cliente
                    int bytesLidos = stream.Read(buffer, 0, buffer.Length);
                    string mensagemRecebida = Encoding.UTF8.GetString(buffer, 0, bytesLidos);
                    Console.WriteLine($"Mensagem recebida: {mensagemRecebida}");

                    // Envia resposta para o cliente
                    string resposta = $"Servidor recebeu: {mensagemRecebida}";
                    byte[] dadosResposta = Encoding.UTF8.GetBytes(resposta);
                    stream.Write(dadosResposta, 0, dadosResposta.Length);

                    cliente.Close();
                    Console.WriteLine("Cliente desconectado\n");
                }
            }
            catch (SocketException se)
            {
                Console.WriteLine($"Erro de socket: {se.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}