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
            tura_count++;

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

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                zwyciezca_jest = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                zwyciezca_jest = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                zwyciezca_jest = true;

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                zwyciezca_jest = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                zwyciezca_jest = true;

            if (zwyciezca_jest)
            {
                DPrzycisk();

                String zwyciezca = "";
                if (tura)
                {
                    zwyciezca = "O";
                    o_wygrana.Text = (Int32.Parse(o_wygrana.Text) + 1).ToString();
                    
                }
                else
                {
                    zwyciezca = "X";
                    x_wygrana.Text = (Int32.Parse(x_wygrana.Text) + 1).ToString();
                    

                }
                MessageBox.Show(zwyciezca + " Wygrywa", "Yay!!");
                newGameToolStripMenuItem.PerformClick(); 
            }else
            {
                if (tura_count == 9)
                {
                    remis.Text = (Int32.Parse(remis.Text) + 1).ToString();
                    MessageBox.Show("Remis", "Ehhh");
                    newGameToolStripMenuItem.PerformClick();
                }
            }
        }

        private void DPrzycisk()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tura = true;
            tura_count = 0;

           
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
                }
           
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (tura)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetPunktówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_wygrana.Text = "0";
            x_wygrana.Text = "0";
            remis.Text = "0";
        }
    }
}
