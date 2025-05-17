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

            // Configura o ComboBox para n�o permitir digita��o manual
            cbx_1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Limpa e adiciona os c�modos no ComboBox
            cbx_1.Items.Clear();
            cbx_1.Items.Add("Selecione...");
            cbx_1.Items.Add("Sala");
            cbx_1.Items.Add("Cozinha");
            cbx_1.Items.Add("Quarto de casal");
            cbx_1.Items.Add("Quarto das crian�as");
            cbx_1.SelectedIndex = 0;  // Seleciona o primeiro item por padr�o
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Obt�m o c�modo selecionado pelo usu�rio
            string comodoSelecionado = cbx_1.SelectedItem?.ToString();

            // Verifica se um c�modo v�lido foi selecionado
            if (!string.IsNullOrEmpty(comodoSelecionado) && comodoSelecionado != "Selecione...")
            {
                // Obt�m o hor�rio atual formatado
                string horario = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Vari�veis para armazenar o status dos dispositivos
                string arCondicionado = "";
                string sensorMovimento = "";

                // Define as informa��es espec�ficas para cada c�modo
                switch (comodoSelecionado)
                {
                    case "Sala":
                        arCondicionado = "Ar-condicionado: ligado";
                        sensorMovimento = "Sensor de movimento: algu�m na sala";
                        break;
                    case "Cozinha":
                        arCondicionado = "Ar-condicionado: desligado";
                        sensorMovimento = "Sensor de movimento: ningu�m na cozinha";
                        break;
                    case "Quarto de casal":
                        arCondicionado = "Ar-condicionado: ligado";
                        sensorMovimento = "Sensor de movimento: algu�m no quarto de casal";
                        break;
                    case "Quarto das crian�as":
                        arCondicionado = "Ar-condicionado: desligado";
                        sensorMovimento = "Sensor de movimento: ningu�m no quarto das crian�as";
                        break;
                    default:
                        arCondicionado = "Ar-condicionado: desconhecido";
                        sensorMovimento = "Sensor de movimento: desconhecido";
                        break;
                }

                // Adiciona as informa��es no campo de resposta
                txtResposta.Text += $"Conectado - {horario} - {comodoSelecionado}\r\n";
                txtResposta.Text += $"{arCondicionado}\r\n";
                txtResposta.Text += $"{sensorMovimento}\r\n";
                txtResposta.Text += "------------------------------\r\n";
            }
            else
            {
                // Exibe mensagem de erro se nenhum c�modo foi selecionado
                MessageBox.Show("Por favor, selecione um c�modo antes de enviar.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa o conte�do da caixa de texto
            txtResposta.Clear();
        }

        private void cbx_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento de mudan�a de sele��o no ComboBox
            // Deixado vazio intencionalmente
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudan�a de texto na caixa de resposta
            // Deixado vazio intencionalmente
        }
    }
}