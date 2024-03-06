using LoraInterface.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoraInterface.Forms
{
    public partial class FormConfigurarIos : Form
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

            //Desabilita opção de salvar.
            try
            {
                MainForm.formInstance.acessoSalvar.Enabled = false;
            
            } catch {}
            
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

                        //Desabilita acesso das abas do menu lateral.
                        MainForm.formInstance.acessoAbrir.Enabled = false;
                        MainForm.formInstance.acessoModoAbp.Enabled = false;
                        MainForm.formInstance.acessoModoOtaa.Enabled = false;
                        MainForm.formInstance.acessoConfigurarIos.Enabled = false;

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

                MainForm.formInstance.acessoSideBar.Cursor = Cursors.Default;

                new CustomDialog("Sucesso!", $"Desconectado com sucesso.", Color.LimeGreen).ShowDialog();

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adicionarGrupoMulticastButton_Click(object sender, EventArgs e)
        {

        }
    }
}
