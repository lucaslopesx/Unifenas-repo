using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            if (listTabuada.Items.Count == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    int res = num * i;
                    listTabuada.Items.Add(num + " * " + i +" = " + res);
                }
            }
            /*
            else
            {
                for(int i = 9; i >= 0; i--)
                {
                    listTabuada.Items.RemoveAt(i);
                }
            }
            */
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listTabuada.Items.Count > 0)
            {
                for (int i = 9; i >= 0; i--)
                {
                    listTabuada.Items.RemoveAt(i);
                }
            }
        }
    }
}
