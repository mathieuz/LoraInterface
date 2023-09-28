using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LoraInterface.Forms;
using FontAwesome.Sharp;
using LoraInterface.CustomControls;
using System.IO.Ports;
using System.IO;

namespace LoraInterface
{
    public partial class MainForm : Form
    {
        private Form formAtual;

        public static MainForm formInstance;
        public RichTextBox console;
        public IconButton acessoModoAbp;
        public IconButton acessoModoOtaa;
        public SerialPort serialPort = new SerialPort();
        public int modoSelecionado = 0;

        public MainForm()
        {

            InitializeComponent();

            //Iniciando janela selecionada no modo ABP.
            modoAbpButton.IconColor = Color.FromArgb(65, 65, 65);
            modoAbpButton.BackColor = Color.WhiteSmoke;
            modoAbpButton.ForeColor = Color.FromArgb(65, 65, 65);

            modoAbpButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            modoAbpButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;

            abrirForm(new FormModoAbp());

            //Iniciando console fechado.
            ColapsarConsole();

            //Tornando o acesso ao console e demais controles públicos/visíveis para outros forms.
            formInstance = this;
            console = consolePanel;
            acessoModoAbp = modoAbpButton;
            acessoModoOtaa = modoOtaaButton;
            
        }

        //Permitir movimentação de janela quando os controles estão desativados.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void topBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Aerosnap
        protected override void WndProc(ref Message m)
        {
            const int WH_NCCALCSIZE = 0x0083;

            if (m.Msg == WH_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            base.WndProc(ref m);
        }

        //Ajusta o Padding do form quando maximizado ou não.
        private void Form1_Resize(object sender, EventArgs e)
        {
            ajustarTelaFullScreen();
        }

        private void ajustarTelaFullScreen()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 8);
                break;

                case FormWindowState.Normal:
                    this.Padding = new Padding(0, 0, 0, 0);    
                break;
            }
        }

        //Eventos do custom control box (fechar, maximizar, minimizar)
        private void fecharJanelaButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizarJanelaButton_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    this.WindowState = FormWindowState.Maximized;
                break;

                case FormWindowState.Maximized:
                    this.WindowState = FormWindowState.Normal;
                    this.Size = new Size(1064, 667);
                break;
            }
        }

        private void minimizarJanelaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Evento do menu lateral.
        private void menuButton_Click(object sender, EventArgs e)
        {
            ColapsarMenu();
        }

        private void ColapsarMenu()
        {
            if (this.sideBarPanel.Width == 180)
            {
                foreach (Button menuButton in sideBarPanel.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                }

                this.sideBarPanel.Width = 40;

            } else
            {

                foreach (Button menuButton in sideBarPanel.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                }

                this.sideBarPanel.Width = 180;
            }

            this.Refresh();
        }

        //Função que chama os forms correspondente às abas de navegação
        private void abrirForm(Form form)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }

            formAtual = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            desktopPanel.Controls.Add(form);
            desktopPanel.Tag = form;

            form.BringToFront();
            form.Show();

        }

        //Eventos de clique nos botões do menu lateral.
        private void salvarButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "*.txt";
            saveFile.RestoreDirectory = true;
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.DefaultExt = "txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string deviceAddress;
                string appskey;
                string nwkskey;
                string deveui;
                string classe;
                string numTentativas;

                string appkey;
                string autoJoin;
                string numTentativasJoin;
                string intervaloTentativasJoin;

                if (formAtual.Name.Contains("Abp"))
                {
                    deviceAddress = FormModoAbp.formInstance.acessoDeviceAddress.Texts;
                    appskey = FormModoAbp.formInstance.acessoAppskey.Texts;
                    nwkskey = FormModoAbp.formInstance.acessoNwkskey.Texts;
                    deveui = FormModoAbp.formInstance.acessoDeveui.Texts;
                    classe = FormModoAbp.formInstance.acessoClasse.SelectedItem.ToString();
                    numTentativas = FormModoAbp.formInstance.acessoNumTentativas.SelectedItem.ToString();

                    File.WriteAllText(saveFile.FileName, $"Arquivo Salvo 28/09/2023 Modo ABP\n" +
                                                         $"{deviceAddress}\n" +
                                                         $"{appskey}\n" +
                                                         $"{nwkskey}\n" +
                                                         $"{deveui}\n" +
                                                         $"{classe}\n" +
                                                         $"{numTentativas}");

                }
                else if (formAtual.Name.Contains("Otaa"))
                {
                    appkey = FormModoOtaa.formInstance.acessoAppkey.Texts;
                    deveui = FormModoOtaa.formInstance.acessoDeveui.Texts;
                    classe = FormModoOtaa.formInstance.acessoClasse.Texts;
                    numTentativas = FormModoOtaa.formInstance.acessoNumTentativas.SelectedItem.ToString();
                    autoJoin = FormModoOtaa.formInstance.acessoAutoJoin.SelectedItem.ToString();
                    numTentativasJoin = FormModoOtaa.formInstance.acessoNumTentativasJoin.SelectedItem.ToString();
                    intervaloTentativasJoin = FormModoOtaa.formInstance.acessoIntervaloTentativasJoin.SelectedItem.ToString();

                    File.WriteAllText(saveFile.FileName, $"Arquivo Salvo 28/09/2023 Modo OTAA\n" +
                                                         $"Appkey: {appkey}\n" +
                                                         $"Deveui: {deveui}\n" +
                                                         $"Classe: {classe}\n" +
                                                         $"numTentativas: {numTentativas}\n" +
                                                         $"autoJoin: {autoJoin}\n" +
                                                         $"numTentativasJoin: {numTentativasJoin}\n" +
                                                         $"intervaloTentativasJoin: {intervaloTentativasJoin}");

                }

                new CustomDialog("Arquivo salvo com sucesso.").ShowDialog();
            }

        }

        private void modoAbpButton_Click(object sender, EventArgs e)
        {
            abrirForm(new FormModoAbp());

            modoAbpButton.IconColor = Color.FromArgb(65, 65, 65);
            modoAbpButton.BackColor = Color.WhiteSmoke;
            modoAbpButton.ForeColor = Color.FromArgb(65, 65, 65);

            modoAbpButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            modoAbpButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;

            modoOtaaButton.IconColor = Color.WhiteSmoke;
            modoOtaaButton.BackColor = Color.FromArgb(253, 189, 19);
            modoOtaaButton.ForeColor = Color.WhiteSmoke;

            modoOtaaButton.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            modoOtaaButton.FlatAppearance.MouseOverBackColor = Color.Goldenrod;

        }

        private void modoOtaaButton_Click(object sender, EventArgs e)
        {
            abrirForm(new FormModoOtaa());

            modoOtaaButton.IconColor = Color.FromArgb(65, 65, 65);
            modoOtaaButton.BackColor = Color.WhiteSmoke;
            modoOtaaButton.ForeColor = Color.FromArgb(65, 65, 65);

            modoOtaaButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            modoOtaaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;

            modoAbpButton.IconColor = Color.WhiteSmoke;
            modoAbpButton.BackColor = Color.FromArgb(253, 189, 19);
            modoAbpButton.ForeColor = Color.WhiteSmoke;

            modoAbpButton.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            modoAbpButton.FlatAppearance.MouseOverBackColor = Color.Goldenrod;

        }

        public bool ColapsarConsole() {
            if (panel5.Height == 0)
            {
                panel5.Height += 250;
                return true;
            }
            else
            {
                panel5.Height -= 250;
                return false;
            }
        }

        private void consoleButton_Click(object sender, EventArgs e)
        {
            ColapsarConsole();
        }

        //Evita bugs visuais no forms principal quando é detectado ou não o focus na janela.
        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void enviarConsole_Click(object sender, EventArgs e)
        {
            string cmdConsole = consoleCmdTextBox.Texts;

            if (!(string.IsNullOrEmpty(cmdConsole)))
            {
                if (modoSelecionado == 0)
                {
                    try
                    {
                        FormModoAbp.formInstance.serialPort.WriteLine(cmdConsole);

                    }
                    catch (Exception ex)
                    {
                        consolePanel.AppendText(ex.Message + Environment.NewLine);

                    }

                }
                else
                {
                    try
                    {
                        FormModoOtaa.formInstance.serialPort.WriteLine(cmdConsole);

                    }
                    catch (Exception ex)
                    {
                        consolePanel.AppendText(ex.Message + Environment.NewLine);

                    }

                }
            }
        }
    }
}
