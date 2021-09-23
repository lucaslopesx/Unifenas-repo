using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vet = new int[5];
        int count = 0;
        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            int aux;
            aux = Convert.ToInt32(txtNumero.Text);
            txtNumero.Text = "";

            vet[count] = aux;
            count++;
            if (count > 4)
            {
                cmdIncluir.Enabled = false;
            }
        }

        private void cmdPares_Click(object sender, EventArgs e)
        {
            int par = 0;

            for (int i = 0; i < 5; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    par++;
                }
            }
            lblStatus.Text = Convert.ToString(par);
            
        }

        private void cmdImpares_Click(object sender, EventArgs e)
        {
            int imp = 0;

            for (int i = 0; i < 5; i++)
            {
                if (vet[i] % 2 == 1)
                {
                    imp++;
                }
            }
            lblStatus.Text = Convert.ToString(imp);

        }
    }
}
