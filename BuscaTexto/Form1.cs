using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texto.Text = "";
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faculdade COTEMIG / 2018\n\nDesenvolvido por Victor Gomes", "Projeto Busca em Texto");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos TXT (*.txt)|*.txt|Arquivos RTF (*.rtf*)|*.rtf";
            var arquivo = "";


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                arquivo = ofd.FileName;
                texto.Text = System.IO.File.ReadAllText(@arquivo);
            }

        }

        public void Pesquisar()
        {
            //Abrir form de pesquisa
            var DialogBuscaTexto = new Pesquisar(this);
            DialogBuscaTexto.Show();
            DialogBuscaTexto.setTexto(texto.Text);
        }
        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void texto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                Pesquisar();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
