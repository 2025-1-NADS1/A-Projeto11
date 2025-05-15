using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;  //Biblioteca de Componentes de REDE
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXEMPLO_01
{
    class Program
    {
        static void Main(string[] args)
        {
           // String IPServer = "177.47.1.102";
            String Site= "www.fecap.br";
            String Pagina = "/";

            TcpClient client = new TcpClient();
            client.Connect(Site, 80);
            String msg = "GET "+Pagina+" HTTP/1.1\r\n";
            msg = msg + "Host:www.fecap.br\r\n\r\n";

            Byte[] dados = System.Text.Encoding.UTF8.GetBytes(msg);
            NetworkStream stream = client.GetStream();
            stream.Write(dados, 0, dados.Length);
            Byte[] dadosLidos = new Byte[client.ReceiveBufferSize];
            int tentativas = 0;
            while (!stream.DataAvailable && tentativas < 5) { tentativas++; Thread.Sleep(10); }
            int numBytes = stream.Read(dadosLidos, 0, dadosLidos.Length);
            String resposta = "";
           
            while (numBytes > 0)
            {
                tentativas = 0;
                resposta = resposta + System.Text.Encoding.UTF8.GetString(dadosLidos, 0, numBytes);
                numBytes = 0;
                tentativas = 0;
                while (!stream.DataAvailable && tentativas < 5) { tentativas++; Thread.Sleep(10); }
                if (stream.DataAvailable)
                {
                    numBytes = stream.Read(dadosLidos, 0, dadosLidos.Length);
                }
            }
            System.Console.Write(resposta);
            Console.ReadKey();

        }
    }
}
