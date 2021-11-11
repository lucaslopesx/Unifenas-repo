using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaBD
{
    public partial class frmIncluir : Form
    {
        public frmIncluir()
        {
            InitializeComponent();
        }

        private DadosAgenda data = new DadosAgenda();

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            data.Nome = txtNome.Text;
            data.Telefone = txtTelefone.Text;
            data.Cidade = txtCidade.Text;
            data.Insert();

            MessageBox.Show("Registro incluido com sucesso!!");
            
            txtNome.Clear();
            txtCidade.Clear();
            txtTelefone.Clear();
        }

        private void cmdImagem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                ConverterFoto();
            }
        }

        private void ConverterFoto()
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] foto_array = new byte[ms.Length];
                ms.Position = 0;

                ms.Read(foto_array, 0, foto_array.Length);
                data.Foto = foto_array;
            }
        }
    }
}
