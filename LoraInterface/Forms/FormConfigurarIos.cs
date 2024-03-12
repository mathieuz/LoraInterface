using LoraInterface.Classes;
using LoraInterface.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LoraInterface.Forms
{
    public partial class FormConfigurarIos : Form
    {
        //Serial Port
        public SerialPort serialPort = new SerialPort();

        //Tornando os controles do form e o forms acessíveis em outros forms.
        public static FormConfigurarIos formInstance;

        //Lista de comboboxes dos IOs e comboboxes das zonas.
        List<CComboBox> iosComboboxList = new List<CComboBox>();
        List<CTextBox> zonasTextboxList = new List<CTextBox>();

        public FormConfigurarIos()
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

            //Inicializando comboboxes dos IOs.
            iosComboboxList.Add(pa15ModoCombobox);
            iosComboboxList.Add(pa15ZonaCombobox);

            iosComboboxList.Add(pa1ModoCombobox);
            iosComboboxList.Add(pa1ZonaCombobox);

            iosComboboxList.Add(pa8ModoCombobox);
            iosComboboxList.Add(pa8ZonaCombobox);

            iosComboboxList.Add(pa9ModoCombobox);
            iosComboboxList.Add(pa9ZonaCombobox);

            iosComboboxList.Add(pa0ModoCombobox);
            iosComboboxList.Add(pa0ZonaCombobox);

            iosComboboxList.Add(pb5ModoCombobox);
            iosComboboxList.Add(pb5ZonaCombobox);

            iosComboboxList.Add(pb4ModoCombobox);
            iosComboboxList.Add(pb4ZonaCombobox);

            iosComboboxList.Add(pb3ModoCombobox);
            iosComboboxList.Add(pb3ZonaCombobox);

            iosComboboxList.Add(pa2ModoCombobox);
            iosComboboxList.Add(pa2ZonaCombobox);

            iosComboboxList.Add(pb12ModoCombobox);
            iosComboboxList.Add(pb12ZonaCombobox);

            foreach (CComboBox ioCombobox in iosComboboxList)
            {
                ioCombobox.SelectedIndex = 0;
            }

            //Inicializando comboboxes dos valores de zona.
            zonasTextboxList.Add(zona0Textbox);
            zonasTextboxList.Add(zona1Textbox);
            zonasTextboxList.Add(zona2Textbox);
            zonasTextboxList.Add(zona3Textbox);
            zonasTextboxList.Add(zona4Textbox);


            //Tornando o form e controles visíveis para outros forms
            formInstance = this;

        }

        //Conexão com porta COM.
        private void conectarCOMButton_Click(object sender, EventArgs e)
        {
            string portSelecionado = comboBoxCOM.SelectedItem.ToString();

            if (conectarCOMButton.Text == "Conectar COM")
            {
                serialPort.BaudRate = 115200;
                serialPort.PortName = portSelecionado;

                MainForm.formInstance.modoSelecionado = 2;

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

                        //Desabilita acesso das abas do menu lateral.
                        MainForm.formInstance.acessoAbrir.Enabled = false;
                        MainForm.formInstance.acessoModoAbp.Enabled = false;
                        MainForm.formInstance.acessoModoOtaa.Enabled = false;
                        MainForm.formInstance.acessoConfigurarIos.Enabled = false;

                        //Habilita o grupo de IOs
                        configurarIosPanel.Visible = true;
                        configurarTempoZonasPanel.Visible = true;

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

                //Habilita acesso das abas do menu lateral.
                MainForm.formInstance.acessoAbrir.Enabled = true;
                MainForm.formInstance.acessoModoAbp.Enabled = true;
                MainForm.formInstance.acessoModoOtaa.Enabled = true;
                MainForm.formInstance.acessoConfigurarIos.Enabled = true;

                //Desabilita o grupo de IOs
                configurarIosPanel.Visible = false;
                configurarTempoZonasPanel.Visible = false;

                MainForm.formInstance.acessoSideBar.Cursor = Cursors.Default;

                new CustomDialog("Sucesso!", $"Desconectado com sucesso.", Color.LimeGreen).ShowDialog();

            }
        }

        //Envia as configurações dos IOs na memória flash do device.
        private void enviarConfiguracoesButton_Click(object sender, EventArgs e)
        {
            //Verifica se os campos dos valores das zonas são valores numéricos.
            foreach (CTextBox zona in zonasTextboxList)
            {
                if (!int.TryParse(zona.Texts, out _))
                {
                    new CustomDialog("Erro!", "Um ou mais campos de tempo das zonas não foram informados ou preenchidos corretamente. Preencha-os com valores numéricos válidos e tente novamente.", Color.OrangeRed).ShowDialog();
                    return;

                } else {

                    if (int.Parse(zona.Texts) > 65535)
                    {
                        new CustomDialog("Erro!", "Foi informado um valor maior que 65535 para um ou mais campos de tempo das zonas. Corrija-os e tente novamente.", Color.OrangeRed).ShowDialog();
                        return;
                    }

                    if (int.Parse(zona.Texts) < 0)
                    {
                        new CustomDialog("Erro!", "Foi informado um valor negativo para um ou mais campos de tempo das zonas. Corrija-os e tente novamente.", Color.OrangeRed).ShowDialog();
                        return;
                    }
                }
            }

            //Buffer de bytes das configurações dos IOs.
            byte[] iosConfig = new byte[30];

            //Populando os 10 primeiros endereços da flash com os modos das IOs.
            uint indexCount = 0;

            for (int i = 0; i < 20; i += 2)
            {
                byte config = (byte)(iosComboboxList[i]).SelectedIndex;
                iosConfig[indexCount] = config;
                indexCount++;
            }

            //Populando os próximos 10 endereços da flash com as zonas das IOs.
            indexCount = 10;

            for (int i = 1; i < 20; i += 2)
            {
                byte config = (byte)(iosComboboxList[i]).SelectedIndex;
                iosConfig[indexCount] = config;
                indexCount++;
            }

            indexCount = 20;

            //Populando os últimos 10 endereços da flash com os valores de cada zona.
            for (int i = 0; i < 5; i++)
            {
                byte hexHigh = (byte)(ushort.Parse(zonasTextboxList[i].Texts) >> 8);
                byte hexLow = (byte)(ushort.Parse(zonasTextboxList[i].Texts) & 0x00FF);

                iosConfig[indexCount] = hexHigh;
                indexCount++;
                iosConfig[indexCount] = hexLow;
                indexCount++;
            }

            //O buffer das configurações de IO a ser enviado junto com CRC.
            byte[] iosConfigBuffer = new byte[32];

            iosConfig.CopyTo(iosConfigBuffer, 0);
            iosConfigBuffer[30] = CRC16.CalcAndGetHigh(iosConfig);
            iosConfigBuffer[31] = CRC16.CalcAndGetLow(iosConfig);

            string res = "";
            for (int i = 0; i < iosConfigBuffer.Length; i++)
            {
                if (iosConfigBuffer[i] >= 0 && iosConfigBuffer[i] <= 15)
                {
                    res += "0";
                }

                res += iosConfigBuffer[i].ToString("X");
            }

            MainForm.formInstance.console.AppendText("Enviado na serial:" + Environment.NewLine);
            MainForm.formInstance.console.AppendText(res + Environment.NewLine);
            
            //Colapsa o console.
            if (!MainForm.formInstance.ColapsarConsole())
            {
                MainForm.formInstance.ColapsarConsole();
            }

            //Enviando as configurações na serial.
            serialPort.Write(iosConfigBuffer, 0, iosConfigBuffer.Length);
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
