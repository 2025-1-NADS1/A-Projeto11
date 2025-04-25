using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace EXEMPLO_02_CLIENT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String IPServer = "127.0.0.1";
                int porta = 80;
                Console.WriteLine($"Iniciando testes de comunicação TCP com servidor {IPServer}:{porta}");

                // Teste 1: Conexão básica
                Console.WriteLine("\nTeste 1: Verificando conexão com servidor...");
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(IPServer, porta);
                    Console.WriteLine("Conexão estabelecida com sucesso!");

                    // Teste 2: Envio e recebimento de dados
                    Console.WriteLine("\nTeste 2: Testando troca de mensagens...");
                    String msg = "Mensagem de teste TCP";
                    Byte[] dados = Encoding.UTF8.GetBytes(msg);
                    NetworkStream stream = client.GetStream();

                    Console.WriteLine($"Enviando mensagem: {msg}");
                    stream.Write(dados, 0, dados.Length);

                    // Recebimento da resposta
                    Byte[] dadosLidos = new Byte[client.ReceiveBufferSize];
                    int tentativas = 0;
                    string resposta = "";

                    while (tentativas < 5)
                    {
                        if (stream.DataAvailable)
                        {
                            int bytesLidos = stream.Read(dadosLidos, 0, dadosLidos.Length);
                            resposta += Encoding.UTF8.GetString(dadosLidos, 0, bytesLidos);

                            if (!stream.DataAvailable)
                                break;
                        }
                        Thread.Sleep(100);
                        tentativas++;
                    }

                    if (string.IsNullOrEmpty(resposta))
                        Console.WriteLine("ERRO: Nenhuma resposta recebida do servidor.");
                    else
                        Console.WriteLine($"Resposta recebida: {resposta}");
                }
            }
            catch (SocketException se)
            {
                Console.WriteLine($"Erro de conexão: {se.Message}");
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