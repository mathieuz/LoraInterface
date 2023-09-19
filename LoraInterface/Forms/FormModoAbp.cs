﻿using System;
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

            //Inicializando número de retentativas ComboBox.
            for (int i = 0; i <= 7; i++)
            {
                numeroRetentativasComboBox.Items.Add(i.ToString());
            }

            numeroRetentativasComboBox.SelectedIndex = 0;

            //Definindo classes de conexão
            classeComboBox.Items.Add("A");
            classeComboBox.Items.Add("B");
            classeComboBox.Items.Add("C");
            classeComboBox.SelectedIndex = 0;

            //Definindo colapso de abas
            modoDeConfirmacaoGroup.Height = 40;
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

                        //Altera estilo de controle.
                        conectarLoraButton.BackColor = Color.LimeGreen;

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
                //Fecha conexão.
                serialPort.Close();

                //Habilita/desabilita os controles do form.
                conectarCOMButton.Text = "Conectar COM";
                comboBoxCOM.Enabled = true;
                chavesDeAtivacaoGroup.Enabled = false;
                configuracoesConexaoGroup.Enabled = false;

                //Altera estilo de controle.
                conectarLoraButton.BackColor = Color.Gainsboro;

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

        //Envia as chaves e configurações de conexão com o Lora.
        private void conectarLoraButton_Click(object sender, EventArgs e)
        {
            if (!MainForm.formInstance.ColapsarConsole())
            {
                MainForm.formInstance.ColapsarConsole();

            }

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

            MainForm.formInstance.console.AppendText("Conexão no Modo ABP bem-sucedida!" + Environment.NewLine);
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

    }
}