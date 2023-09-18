using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoraInterface.Forms
{
    public partial class FormModoOtaa : Form
    {
        public FormModoOtaa()
        {
            InitializeComponent();

            //Inicializando portas COM
            for (int i = 0; i <= 50; i++)
            {
                comboBoxCOM.Items.Add("COM" + i.ToString());
            }

            comboBoxCOM.SelectedIndex = 0;

            //Definindo classes de conexão
            comboBoxClasse.Items.Add("A");
            comboBoxClasse.Items.Add("B");
            comboBoxClasse.Items.Add("C");
            comboBoxClasse.SelectedIndex = 0;
        }

    }
}
