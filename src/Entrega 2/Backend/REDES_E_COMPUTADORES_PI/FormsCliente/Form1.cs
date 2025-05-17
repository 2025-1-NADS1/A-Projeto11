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

            cbx_1.DropDownStyle = ComboBoxStyle.DropDownList;

            cbx_1.Items.Clear();
            cbx_1.Items.Add("Selecione...");
            cbx_1.Items.Add("Sala");
            cbx_1.Items.Add("Cozinha");
            cbx_1.Items.Add("Quarto de casal");
            cbx_1.Items.Add("Quarto das crian�as");
            cbx_1.SelectedIndex = 0;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string comodoSelecionado = cbx_1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(comodoSelecionado) && comodoSelecionado != "Selecione...")
            {
                string horario = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Informa��es hardcode para cada c�modo
                string arCondicionado = "";
                string sensorMovimento = "";

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

                txtResposta.Text += $"Conectado - {horario} - {comodoSelecionado}\r\n";
                txtResposta.Text += $"{arCondicionado}\r\n";
                txtResposta.Text += $"{sensorMovimento}\r\n";
                txtResposta.Text += "------------------------------\r\n";
            }
            else
            {
                MessageBox.Show("Por favor, selecione um c�modo antes de enviar.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResposta.Clear();
        }

        private void cbx_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Deixe vazio
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {
            // Deixe vazio
        }
    }
}