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

            Zwyciezca();
        }

        private void Zwyciezca()
        {
            bool zwyciezca_jest = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                zwyciezca_jest = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                zwyciezca_jest = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                zwyciezca_jest = true;

            if (zwyciezca_jest)
            {
                String zwyciezca = "";
                if (tura)
                    zwyciezca = "O";
                else
                    zwyciezca = "X";

                MessageBox.Show(zwyciezca + "Wins", "Yay!!");
            }
        }
    }
}
