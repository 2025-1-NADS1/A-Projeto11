using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace FormsCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configura o ComboBox para não permitir digitação manual
            cbx_1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Limpa e adiciona os cômodos no ComboBox
            cbx_1.Items.Clear();
            cbx_1.Items.Add("Selecione...");
            cbx_1.Items.Add("Sala");
            cbx_1.Items.Add("Cozinha");
            cbx_1.Items.Add("Quarto de casal");
            cbx_1.Items.Add("Quarto das crianças");
            cbx_1.SelectedIndex = 0;  // Seleciona o primeiro item por padrão
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Obtém o cômodo selecionado pelo usuário
            string comodoSelecionado = cbx_1.SelectedItem?.ToString();

            // Verifica se um cômodo válido foi selecionado
            if (!string.IsNullOrEmpty(comodoSelecionado) && comodoSelecionado != "Selecione...")
            {
                // Obtém o horário atual formatado
                string horario = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Variáveis para armazenar o status dos dispositivos
                string arCondicionado = "";
                string sensorMovimento = "";

                // Define as informações específicas para cada cômodo
                switch (comodoSelecionado)
                {
                    case "Sala":
                        arCondicionado = "Ar-condicionado: ligado";
                        sensorMovimento = "Sensor de movimento: alguém na sala";
                        break;
                    case "Cozinha":
                        arCondicionado = "Ar-condicionado: desligado";
                        sensorMovimento = "Sensor de movimento: ninguém na cozinha";
                        break;
                    case "Quarto de casal":
                        arCondicionado = "Ar-condicionado: ligado";
                        sensorMovimento = "Sensor de movimento: alguém no quarto de casal";
                        break;
                    case "Quarto das crianças":
                        arCondicionado = "Ar-condicionado: desligado";
                        sensorMovimento = "Sensor de movimento: ninguém no quarto das crianças";
                        break;
                    default:
                        arCondicionado = "Ar-condicionado: desconhecido";
                        sensorMovimento = "Sensor de movimento: desconhecido";
                        break;
                }

                // Adiciona as informações no campo de resposta
                txtResposta.Text += $"Conectado - {horario} - {comodoSelecionado}\r\n";
                txtResposta.Text += $"{arCondicionado}\r\n";
                txtResposta.Text += $"{sensorMovimento}\r\n";
                txtResposta.Text += "------------------------------\r\n";
            }
            else
            {
                // Exibe mensagem de erro se nenhum cômodo foi selecionado
                MessageBox.Show("Por favor, selecione um cômodo antes de enviar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa o conteúdo da caixa de texto
            txtResposta.Clear();
        }

        private void cbx_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento de mudança de seleção no ComboBox
            // Deixado vazio intencionalmente
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudança de texto na caixa de resposta
            // Deixado vazio intencionalmente
        }
    }
}