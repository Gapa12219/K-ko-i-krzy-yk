using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        bool tura = true;
        int tura_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witam", "Kółko i krzyżyk");
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void przycisk(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (tura)
            {
                B.Text = "X";
            }else
            {
                B.Text = "O";
            }
            tura = !tura;
            B.Enabled = false;
        }
    }
}
