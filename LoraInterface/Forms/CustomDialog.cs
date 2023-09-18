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
    public partial class CustomDialog : Form
    {

        public CustomDialog(string msg)
        {
            InitializeComponent();
            msgText.Text = msg;
            msgText.Dock = DockStyle.Fill;
            
        }

        private void fecharJanelaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
