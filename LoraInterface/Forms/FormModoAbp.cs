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
using System.Threading;
using LoraInterface.CustomControls;
using System.Security.Cryptography.X509Certificates;

namespace LoraInterface.Forms
{

    public partial class FormModoAbp : Form
    {
        //Serial Port
        public SerialPort serialPort = new SerialPort();

        //Tornando os controles do form e o forms acessíveis em outros forms.
        public static FormModoAbp formInstance;
        public CTextBox acessoDeviceAddress;
        public CTextBox acessoAppskey;
        public CTextBox acessoNwkskey;
        public CTextBox acessoDeveui;
        public CComboBox acessoClasse;
        public CToggle acessoToggleModoConfirmacao;
        public CComboBox acessoNumTentativas;

        public FormModoAbp()
        {
            InitializeComponent();

            //serialPort
            serialPort.DataReceived += SerialPort_DataReceived;

            //Inicializando portas COM
            for (int i = 0; i <= 50; i++)
            {
                comboBoxCOM.Items.Add("COM" + i.ToString());
            }
            comboBoxCOM.SelectedIndex = 0;

            //Inicializando número de retentativas ComboBox.
            for (int i = 0; i <= 7; i++)
            {
                numeroRetentativasComboBox.Items.Add(i.ToString());
            }
            numeroRetentativasComboBox.SelectedIndex = 0;

            //Inicializando porta AT+SEND ComboBox
            for (int i = 1; i <= 233; i++)
            {
                atSendPortaComboBox.Items.Add(i.ToString());
            }
            atSendPortaComboBox.SelectedIndex = 7;

            //Definindo classes de conexão
            classeComboBox.Items.Add("A");
            classeComboBox.Items.Add("B");
            classeComboBox.Items.Add("C");
            classeComboBox.SelectedIndex = 0;

            //Definindo colapso de abas
            modoDeConfirmacaoGroup.Height = 40;

            //Tornando o form e controles visíveis para outros forms
            formInstance = this;
            acessoDeviceAddress = deviceAddressTextBox;
            acessoAppskey = appskeyTextBox;
            acessoNwkskey = nwkskeyTextBox;
            acessoDeveui = deviceEuiTextBox;
            acessoClasse = classeComboBox;
            acessoToggleModoConfirmacao = modoConfirmacaoToggle;
            acessoNumTentativas = numeroRetentativasComboBox;

            //Iniciando classes de multicast.
            multicastClasseComboBox.Items.Add("B");
            multicastClasseComboBox.Items.Add("C");
            multicastClasseComboBox.SelectedIndex = 0;

        }

        //Conexão com porta COM.
        private void conectarCOMButton_Click(object sender, EventArgs e)
        {
            string portSelecionado = comboBoxCOM.SelectedItem.ToString();

            if (conectarCOMButton.Text == "Conectar COM")
            {
                serialPort.BaudRate = 115200;
                serialPort.PortName = portSelecionado;

                MainForm.formInstance.modoSelecionado = 0;

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

                        //Altera estilo de controle.
                        conectarLoraButton.BackColor = Color.LimeGreen;

                        //Desabilita acesso das abas do menu lateral.
                        MainForm.formInstance.acessoAbrir.Enabled = false;
                        MainForm.formInstance.acessoModoAbp.Enabled = false;
                        MainForm.formInstance.acessoModoOtaa.Enabled = false;

                        MainForm.formInstance.acessoSideBar.Cursor = Cursors.No;

                        new CustomDialog("Sucesso!", $"Conectado em '{portSelecionado}' com sucesso.", Color.LimeGreen).ShowDialog();

                    }
                    catch (Exception err)
                    {
                        new CustomDialog("Erro!", $"Não foi possível se conectar na porta '{portSelecionado}':\n" + err.Message, Color.OrangeRed).ShowDialog();
                    }

                }

            } 
            else if (conectarCOMButton.Text == "Desconectar COM")
            {
                //Fecha conexão.
                serialPort.Close();

                //Habilita/desabilita os controles do form.
                conectarCOMButton.Text = "Conectar COM";
                comboBoxCOM.Enabled = true;
                chavesDeAtivacaoGroup.Enabled = false;
                configuracoesConexaoGroup.Enabled = false;
                comandosATGroup.Visible = false;

                //Altera estilo de controle.
                conectarLoraButton.BackColor = Color.Gainsboro;

                //Habilita acesso das abas do menu lateral.
                MainForm.formInstance.acessoAbrir.Enabled = true;
                MainForm.formInstance.acessoModoAbp.Enabled = true;
                MainForm.formInstance.acessoModoOtaa.Enabled = true;

                MainForm.formInstance.acessoSideBar.Cursor = Cursors.Default;

                new CustomDialog("Sucesso!", $"Desconectado com sucesso.", Color.LimeGreen).ShowDialog();

            }

        }

        //Verifica o estado Enabled dos botões para alteração de estilo.
        private void conectarLoraButton_EnabledChanged(object sender, EventArgs e)
        {
            if (conectarLoraButton.Enabled)
            {
                conectarLoraButton.BackColor = Color.LimeGreen;

            } 
            else
            {
                conectarLoraButton.BackColor = Color.Gainsboro;
            }
        }

        //Envia as chaves e configurações de conexão com o Lora.
        private void conectarLoraButton_Click(object sender, EventArgs e)
        {

            //Verifica se os campos das chaves estão preenchidos.
            if (deviceAddressTextBox.Texts.Length == deviceAddressTextBox.MaxLength && appskeyTextBox.Texts.Length == appskeyTextBox.MaxLength && nwkskeyTextBox.Texts.Length == nwkskeyTextBox.MaxLength && deviceEuiTextBox.Texts.Length == deviceEuiTextBox.MaxLength)
            {
                //Colapsa o console.
                if (!MainForm.formInstance.ColapsarConsole())
                {
                    MainForm.formInstance.ColapsarConsole();

                }

                //Envia as chaves e configurações de conexão.
                string deviceAddress = deviceAddressTextBox.Texts;
                string appskey = appskeyTextBox.Texts;
                string nwkskey = nwkskeyTextBox.Texts;
                string deviceEui = deviceEuiTextBox.Texts;
                string classe = classeComboBox.SelectedItem.ToString();
                string cfm = modoConfirmacaoToggle.Checked ? "1" : "0";
                string rety = numeroRetentativasComboBox.SelectedItem.ToString();

                serialPort.WriteLine("AT+NJM=0");
                serialPort.WriteLine($"AT+DEVADDR={deviceAddress}");
                serialPort.WriteLine($"AT+APPSKEY={appskey}");
                serialPort.WriteLine($"AT+NWKSKEY={nwkskey}");

                serialPort.BaseStream.Flush();
                Thread.Sleep(500);

                serialPort.WriteLine($"AT+DEVEUI={deviceEui}");
                serialPort.WriteLine($"AT+CLASS={classe}");
                serialPort.WriteLine($"AT+CFM={cfm}");
                serialPort.WriteLine($"AT+RETY={rety}");

                serialPort.BaseStream.Flush();
                Thread.Sleep(500);

                serialPort.WriteLine($"AT+BAND=6");

                serialPort.BaseStream.Flush();
                Thread.Sleep(300);

                //Habilita painel de comandos AT.
                comandosATGroup.Visible = true;

                //Exibe mensagem no console.
                MainForm.formInstance.console.AppendText("Conexão no Modo ABP bem-sucedida!" + Environment.NewLine);
            
            }
            else
            {
                new CustomDialog("Erro!", "Alguns dos campos não foram totalmente preenchidos.\nTente novamente.", Color.OrangeRed).ShowDialog();
            }
        }

        //Colapsa a aba de modo de confirmação.
        private void cToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (modoConfirmacaoToggle.Checked)
            {
                modoDeConfirmacaoGroup.Height = 100;
            }
            else
            {
                modoDeConfirmacaoGroup.Height = 40;
            }
        }


        //Comandos AT Modo ABP

        //Multicast - ADDMULC, LSTMULC e RMVMULC.
        private void adicionarGrupoMulticastButton_Click(object sender, EventArgs e)
        {
            string multicastClass = multicastClasseComboBox.SelectedItem.ToString();
            string multicastAddress = multicastAddressTextBox.Texts;
            string multicastNwkskey = multicastNwkskeyTextBox.Texts;
            string multicastAppskey = multicastAppskeyTextBox.Texts;

            string frequencia = "923300000";

            if (multicastAddress.Length == multicastAddressTextBox.MaxLength && multicastNwkskey.Length == multicastNwkskeyTextBox.MaxLength && multicastAppskey.Length == multicastNwkskeyTextBox.MaxLength)
            {
                if (!MainForm.formInstance.ColapsarConsole())
                {
                    MainForm.formInstance.ColapsarConsole();

                }

                serialPort.WriteLine($"AT+ADDMULC={multicastClass}:{multicastAddress}:{multicastNwkskey}:{multicastAppskey}:{frequencia}:8:0");
                
                MainForm.formInstance.console.AppendText($"AT+ADDMULC={multicastClass}:{multicastAddress}:{multicastNwkskey}:{multicastAppskey}:{frequencia}:8:0" + Environment.NewLine);
            }
            else
            {
                new CustomDialog("Erro!", $"Erro ao adicionar grupo de multicast.\nAlguns campos não foram totalmente preenchidos. Tente novamente.", Color.OrangeRed).ShowDialog();
            }

        }

        private void removerGrupoMulticastButton_Click(object sender, EventArgs e)
        {
            if (!MainForm.formInstance.ColapsarConsole())
            {
                MainForm.formInstance.ColapsarConsole();

            }

            string multicastAddress = multicastAddressRemoverTextBox.Texts;

            if (multicastAddress.Length == multicastAddressRemoverTextBox.MaxLength)
            {
                //Colapsa o console.
                if (!MainForm.formInstance.ColapsarConsole())
                {
                    MainForm.formInstance.ColapsarConsole();

                }

                serialPort.WriteLine($"AT+RMVMULC={multicastAddress}");

                MainForm.formInstance.console.AppendText($"AT+RMVMULC={multicastAddress}" + Environment.NewLine);
            }
            else
            {
                new CustomDialog("Erro!", $"O campo do Multicast Address está incompleto ou vazio.\nTente novamente.", Color.OrangeRed).ShowDialog();
            }
            
        }

        private void listarGruposMulticastButton_Click(object sender, EventArgs e)
        {
            if (!MainForm.formInstance.ColapsarConsole())
            {
                MainForm.formInstance.ColapsarConsole();

            }

            serialPort.WriteLine($"AT+LSTMULC=?");

            MainForm.formInstance.console.AppendText($"AT+LSTMULC=?" + Environment.NewLine);
        }

        //AT+SEND
        private void atSendButton_Click(object sender, EventArgs e)
        {
            if (!MainForm.formInstance.ColapsarConsole())
            {
                MainForm.formInstance.ColapsarConsole();

            }

            string textoHex = "";

            string texto = atSendTextoTextBox.Texts;
            string port = atSendPortaComboBox.SelectedItem.ToString();

            for (int i = 0; i < texto.Length; i++)
            {
                //Verifica se o caractere no índice está entre esse intervalo, que representa um conjunto de letras, números, símbolos, etc.
                //Não considera conjuntos de letras com acentuações.
                if (texto[i] >= 32 && texto[i] <= 126)
                {
                    byte digitoHex1 = (byte)((texto[i] & 0xf0) >> 4);
                    byte digitoHex2 = (byte)((texto[i] & 0x0f));

                    if (digitoHex1 >= 0 && digitoHex1 <= 9)
                    {
                        digitoHex1 = (byte)(digitoHex1 + 48);

                    }
                    else if (digitoHex1 >= 10 && digitoHex1 <= 15)
                    {
                        digitoHex1 = (byte)(digitoHex1 + 55);
                    }

                    if (digitoHex2 >= 0 && digitoHex2 <= 9)
                    {
                        digitoHex2 = (byte)(digitoHex2 + 48);

                    }
                    else if (digitoHex2 >= 10 && digitoHex2 <= 15)
                    {
                        digitoHex2 = (byte)(digitoHex2 + 55);
                    }

                    textoHex += (char) digitoHex1;
                    textoHex += (char) digitoHex2;
                }
            }

            MainForm.formInstance.console.AppendText($"AT+SEND={port}:{textoHex}" + Environment.NewLine);

            //Enviando o AT+SEND.
            try
            {
                serialPort.WriteLine($"AT+SEND={port}:{textoHex}");
            }
            catch (Exception ex)
            {
                MainForm.formInstance.console.AppendText(ex.Message + Environment.NewLine);
            }
        }

        //AT+BAT
        private void atBatButton_Click(object sender, EventArgs e)
        {
            if (!MainForm.formInstance.ColapsarConsole())
            {
                MainForm.formInstance.ColapsarConsole();

            }

            MainForm.formInstance.console.AppendText($"AT+BAT=?" + Environment.NewLine);

            try
            {
                serialPort.WriteLine($"AT+BAT=?");
            }
            catch (Exception ex)
            {
                MainForm.formInstance.console.AppendText(ex.Message + Environment.NewLine);
            }

        }

        //AT+SLEEP
        private void iconButton10_Click(object sender, EventArgs e)
        {

            //Atribuindo o valor de tempo de sleep. Se o campo estiver vazio, considera tempo igual a 0.
            string tempo = atSleepTempoTextBox.Texts.Length > 0 ? atSleepTempoTextBox.Texts : "0";

            //Compara se o valor da string pode ser convertido para um tipo numérico inteiro.
            if (int.TryParse(tempo, out _))
            {
                if (!MainForm.formInstance.ColapsarConsole())
                {
                    MainForm.formInstance.ColapsarConsole();

                }

                serialPort.WriteLine($"AT+SLEEP={tempo}");

                MainForm.formInstance.console.AppendText($"AT+SLEEP={tempo}" + Environment.NewLine);
            
            } else
            {
                new CustomDialog("Erro!", "O valor de tempo do modo sleep não é um valor numérico válido.", Color.OrangeRed).ShowDialog();

            }
        }


        //Evento assíncrono serial port: retorna dados da placa à partir do momento em que um comando
        //AT é enviado ou um programa upado está rodando e escrevendo algo.
        private static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string respostaPlaca = serialPort.ReadExisting();

            MainForm.formInstance.console.AppendText(respostaPlaca + Environment.NewLine);

            MainForm.formInstance.console.ScrollToCaret();

        }
    }
}
