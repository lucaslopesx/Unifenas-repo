using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void questao3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questao3 Q3 = new Questao3();
            Q3.ShowDialog();
        }
    }
}
