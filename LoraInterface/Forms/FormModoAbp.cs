using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using LoraInterface.Forms;

namespace LoraInterface.Forms
{
    public partial class FormModoAbp : Form
    {
        //Serial Port
        SerialPort serialPort = new SerialPort();

        public FormModoAbp()
        {
            InitializeComponent();

            //Inicializando portas COM
            for (int i = 0; i <= 50; i++)
            {
                comboBoxCOM.Items.Add("COM" + i.ToString());
            }

            comboBoxCOM.SelectedIndex = 0;

            //Definindo classes de conexão
            classeComboBox.Items.Add("A");
            classeComboBox.Items.Add("B");
            classeComboBox.Items.Add("C");
            classeComboBox.SelectedIndex = 0;


        }

        //Conexão com porta COM.
        private void conectarCOMButton_Click(object sender, EventArgs e)
        {
            string portSelecionado = comboBoxCOM.SelectedItem.ToString();

            if (conectarCOMButton.Text == "Conectar COM")
            {
                serialPort.BaudRate = 115200;
                serialPort.PortName = portSelecionado;

                //Verifica se a porta selecionada está disponível. Se sim, conecta.
                if (serialPort.IsOpen == false)
                {
                    try
                    {
                        //Tenta conexão no portName definido.
                        serialPort.Open();

                        //Habilita/desabilita os controles do form.
                        conectarCOMButton.Text = "Desconectar COM";
                        comboBoxCOM.Enabled = false;
                        chavesDeAtivacaoGroup.Enabled = true;
                        configuracoesConexaoGroup.Enabled = true;

                        //Desabilita acesso das abas do menu lateral.
                        MainForm.formInstance.acessoModoAbp.Enabled = false;
                        MainForm.formInstance.acessoModoOtaa.Enabled = false;

                        new CustomDialog($"Conectado em '{portSelecionado}' com sucesso.").ShowDialog();

                    }
                    catch (Exception err)
                    {
                        new CustomDialog($"Não foi possível se conectar na porta '{portSelecionado}':\n" + err.Message).ShowDialog();
                    }

                }

            } else if (conectarCOMButton.Text == "Desconectar COM")
            {
                serialPort.Close();

                //Habilita/desabilita os controles do form.
                conectarCOMButton.Text = "Conectar COM";
                comboBoxCOM.Enabled = true;
                chavesDeAtivacaoGroup.Enabled = false;
                configuracoesConexaoGroup.Enabled = false;

                //Habilita acesso das abas do menu lateral.
                MainForm.formInstance.acessoModoAbp.Enabled = true;
                MainForm.formInstance.acessoModoOtaa.Enabled = true;

                new CustomDialog($"Desconectado com sucesso.").ShowDialog();

            }

        }

        //Verifica o estado Enabled dos botões para alteração de estilo.
        private void conectarLoraButton_EnabledChanged(object sender, EventArgs e)
        {
            if (conectarLoraButton.Enabled)
            {
                conectarLoraButton.BackColor = Color.LimeGreen;

            } else
            {
                conectarLoraButton.BackColor = Color.Gainsboro;
            }
        }

        //Envia as chave e configurações de conexão com o Lora.
        private void conectarLoraButton_Click(object sender, EventArgs e)
        {
            string deviceAddress = deviceAddressTextBox.Texts;
            string appskey = appskeyTextBox.Texts;
            string nwkskey = nwkskeyTextBox.Texts;
            string deviceEui = deviceEuiTextBox.Texts;
            string classe = classeComboBox.SelectedItem.ToString();
            int bandRegion = 6;

            serialPort.WriteLine("AT+NJM=0");
            serialPort.WriteLine($"AT+DEVADDR={deviceAddress}");
            serialPort.WriteLine($"AT+APPSKEY={appskey}");
            serialPort.WriteLine($"AT+NWKSKEY={nwkskey}");
            /*
            serialPort.WriteLine($"AT+DEVEUI={deviceEui}");
            serialPort.WriteLine($"AT+CLASS={classe}");
            serialPort.WriteLine($"AT+BAND={bandRegion.ToString()}");
            */

            MainForm.formInstance.console.AppendText("Conexão no Modo ABP bem-sucedida." + Environment.NewLine);

            if (MainForm.formInstance.ColapsarConsole() == false)
            {
                MainForm.formInstance.ColapsarConsole();
            }
        }
    }
}
