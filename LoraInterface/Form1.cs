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
        public IconButton acessoAbrir;
        public IconButton acessoModoAbp;
        public IconButton acessoModoOtaa;
        public SerialPort serialPort = new SerialPort();
        public FlowLayoutPanel acessoSideBar;
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

            //Colapsando guias.
            ColapsarConsole();
            ColapsarMenu();

            //Tornando o acesso ao console e demais controles públicos/visíveis para outros forms.
            formInstance = this;
            console = consolePanel;
            acessoAbrir = abrirButton;
            acessoModoAbp = modoAbpButton;
            acessoModoOtaa = modoOtaaButton;
            acessoSideBar = sideBarPanel;
            
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

        /*
        protected override void WndProc(ref Message m)
        {
            const int WH_NCCALCSIZE = 0x0083;

            if (m.Msg == WH_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            base.WndProc(ref m);
        }
        */

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
                    this.Padding = new Padding(0, 0, 0, 0);
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

            if (form.Name.Contains("Abp"))
            {

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
            else if (form.Name.Contains("Otaa"))
            {

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

        }

        //Eventos de clique nos botões do menu lateral.
        private void salvarButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = formAtual.Name.Contains("Abp") ? "config-abp.txt" : "config-otaa.txt";
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

                    File.WriteAllText(saveFile.FileName, $"ABP\n" +
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
                    autoJoin = FormModoOtaa.formInstance.acessoAutoJoin.SelectedIndex.ToString();
                    numTentativasJoin = FormModoOtaa.formInstance.acessoNumTentativasJoin.SelectedItem.ToString();
                    intervaloTentativasJoin = FormModoOtaa.formInstance.acessoIntervaloTentativasJoin.SelectedItem.ToString();

                    File.WriteAllText(saveFile.FileName, $"OTAA\n" +
                                                         $"{appkey}\n" +
                                                         $"{deveui}\n" +
                                                         $"{classe}\n" +
                                                         $"{numTentativas}\n" +
                                                         $"{autoJoin}\n" +
                                                         $"{numTentativasJoin}\n" +
                                                         $"{intervaloTentativasJoin}");

                }

                new CustomDialog("Sucesso!", "Arquivo salvo com sucesso.", Color.LimeGreen).ShowDialog();
            }

        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.RestoreDirectory = true;
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.DefaultExt = "txt";

            string strConfig;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                strConfig = File.ReadAllText(openFile.FileName, Encoding.UTF8);

                if (strConfig.Contains("ABP"))
                {
                    abrirForm(new FormModoAbp());

                    List<CTextBox> cTextBoxes = new List<CTextBox>();
                    cTextBoxes.Add(FormModoAbp.formInstance.acessoDeviceAddress);
                    cTextBoxes.Add(FormModoAbp.formInstance.acessoAppskey);
                    cTextBoxes.Add(FormModoAbp.formInstance.acessoNwkskey);
                    cTextBoxes.Add(FormModoAbp.formInstance.acessoDeveui);

                    int textBoxAtual = 0;
                    int comboBoxAtual = 0;
                    int i = 4;

                    while (i < strConfig.Length)
                    {
                        if (strConfig[i] != '\n')
                        {
                            cTextBoxes[textBoxAtual].Texts += strConfig[i];
                            i++;
                        }
                        else
                        {
                            textBoxAtual++;
                            i++;
                        }

                        if (textBoxAtual == cTextBoxes.Count)
                        {
                            break;
                        }
                    }

                    List<CComboBox> cComboBoxes = new List<CComboBox>();
                    cComboBoxes.Add(FormModoAbp.formInstance.acessoClasse);
                    cComboBoxes.Add(FormModoAbp.formInstance.acessoNumTentativas);

                    while (i < strConfig.Length)
                    {
                        if (strConfig[i] != '\n')
                        {
                            cComboBoxes[comboBoxAtual].SelectedIndex = cComboBoxes[comboBoxAtual].Items.IndexOf(strConfig[i].ToString());
                            i++;

                        }
                        else
                        {
                            comboBoxAtual++;
                            i++;
                        }

                        if (comboBoxAtual == cComboBoxes.Count)
                        {
                            break;
                        }
                    }

                    if (FormModoAbp.formInstance.acessoNumTentativas.SelectedItem.ToString() != "0")
                    {
                        FormModoAbp.formInstance.acessoToggleModoConfirmacao.Checked = true;
                    }

                    new CustomDialog("Sucesso!", "Arquivo carregado com sucesso.", Color.LimeGreen).ShowDialog();


                } 
                else if (strConfig.Contains("OTAA"))
                {
                    abrirForm(new FormModoOtaa());

                    List <CTextBox> cTextBoxes = new List<CTextBox>();
                    cTextBoxes.Add(FormModoOtaa.formInstance.acessoAppkey);
                    cTextBoxes.Add(FormModoOtaa.formInstance.acessoDeveui);

                    int textBoxAtual = 0;
                    int comboBoxAtual = 0;
                    int i = 5;

                    while (i < strConfig.Length)
                    {
                        if (strConfig[i] != '\n')
                        {
                            cTextBoxes[textBoxAtual].Texts += strConfig[i];
                            i++;
                        }
                        else
                        {
                            textBoxAtual++;
                            i++;
                        }

                        if (textBoxAtual == cTextBoxes.Count)
                        {
                            break;
                        }
                    }

                    List<CComboBox> cComboBoxes = new List<CComboBox>();
                    cComboBoxes.Add(FormModoOtaa.formInstance.acessoClasse);
                    cComboBoxes.Add(FormModoOtaa.formInstance.acessoNumTentativas);
                    cComboBoxes.Add(FormModoOtaa.formInstance.acessoAutoJoin);
                    cComboBoxes.Add(FormModoOtaa.formInstance.acessoNumTentativasJoin);
                    cComboBoxes.Add(FormModoOtaa.formInstance.acessoIntervaloTentativasJoin);

                    //Define classe e numero de tentativas
                    while (i < strConfig.Length)
                    {
                        if (strConfig[i] != '\n')
                        {
                            cComboBoxes[comboBoxAtual].SelectedIndex = cComboBoxes[comboBoxAtual].Items.IndexOf(strConfig[i].ToString());
                            i++;

                        }
                        else
                        {
                            comboBoxAtual++;
                            i++;
                        }

                        if (comboBoxAtual == 2)
                        {
                            break;
                        }
                    }

                    //Define auto join.
                    cComboBoxes[comboBoxAtual].SelectedIndex = int.Parse(strConfig[i].ToString());
                    comboBoxAtual++;
                    i++;
                    i++;

                    //Define número de tentativas e intervalo de tentatvas do join.
                    string numTentativas = "";
                    string numIntervalo = "";

                    while (strConfig[i] != '\n')
                    {
                        numTentativas += strConfig[i].ToString();
                        i++;
                    }

                    i++;

                    while (i < strConfig.Length)
                    {
                        numIntervalo += strConfig[i].ToString();
                        i++;
                    }

                    cComboBoxes[comboBoxAtual].SelectedIndex = cComboBoxes[comboBoxAtual].Items.IndexOf(numTentativas);
                    comboBoxAtual++;
                    cComboBoxes[comboBoxAtual].SelectedIndex = cComboBoxes[comboBoxAtual].Items.IndexOf(numIntervalo);

                    //Verificação de campos/ativar toggles.
                    if (FormModoOtaa.formInstance.acessoNumTentativas.SelectedIndex != 0)
                    {
                        FormModoOtaa.formInstance.acessoToggleModoConfirmacao.Checked = true;
                    }

                    if (FormModoOtaa.formInstance.acessoAutoJoin.SelectedIndex != 0)
                    {
                        FormModoOtaa.formInstance.acessoToggleConfiguracoesJoin.Checked = true;
                    }


                    new CustomDialog("Sucesso!", $"Arquivo carregado com sucesso.", Color.LimeGreen).ShowDialog();

                } 
                else
                {
                    new CustomDialog("Erro!", "Não foi possível carregar as chaves ou identifcar o modo de conexão.", Color.OrangeRed).ShowDialog();

                }
            }
        }

        private void modoAbpButton_Click(object sender, EventArgs e)
        {
            abrirForm(new FormModoAbp());

        }

        private void modoOtaaButton_Click(object sender, EventArgs e)
        {
            abrirForm(new FormModoOtaa());

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

        /******/

        //Tooltips


    }
}
