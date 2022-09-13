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
    public partial class Pesquisar : Form
    {
        private string padrao = "";
        private string texto = "";
        public void setTexto(string txt) { texto = txt; }
        public string getTexto() { return texto; }
        private Random rnd = new Random();

        //instanciar form principal para fazer alterações nele por aqui
        private Form1 formPrincipal;

        public Pesquisar(Form1 frm)
        {
            InitializeComponent();
            formPrincipal = frm;
            rbtn_forca.Checked = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public void Buscar()
        {
            setTexto(formPrincipal.texto.Text);

            //Limpar cores em nova busca
            formPrincipal.texto.SelectAll();
            formPrincipal.texto.SelectionColor = Color.Black;
            formPrincipal.texto.SelectionBackColor = Color.White;

            //Case sensitive
            string temp_texto = getTexto();
            if (checkbox_case.Checked)
            {
                padrao = txtbox_pesquisar.Text;
                temp_texto = getTexto();

            }
            else if (!checkbox_case.Checked)
            {
                temp_texto = getTexto().ToLower();
                padrao = txtbox_pesquisar.Text.ToLower();
            }


            var form = new Form1();
            int indexInicial = 0;
            int startIndex = 0;


            while (indexInicial != -1)
            {
                indexInicial = GetIndex(startIndex, padrao, temp_texto);

                if (indexInicial != -1)
                {
                    formPrincipal.texto.Select(indexInicial, padrao.Length);
                    formPrincipal.texto.SelectionColor = Color.White;
                    formPrincipal.texto.SelectionBackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
                startIndex = indexInicial + padrao.Length;

            }
        }

        public int GetIndex(int startIndex, string padrao, string temp_texto)
        {
            int index = 0;
            if (rbtn_forca.Checked)
            {
                index = ForcaBruta.forcaBruta(startIndex, padrao, temp_texto);
            }
            else if (rbtn_rabin.Checked)
            {
                index = RabinKarp.RKSearch(startIndex, padrao, temp_texto);
            }
            else if (rbtn_kmp.Checked)
            {
                index = KMP.KMPSearch(startIndex, padrao, temp_texto);
            }
            else if (rbtn_boyer.Checked)
            {
                index = BoyerMoore.BMSearch(startIndex, padrao, temp_texto);
            }

            return index;
        }

        private void btn_substituir_Click(object sender, EventArgs e)
        {
            //Limpar cores em nova busca
            formPrincipal.texto.SelectAll();
            formPrincipal.texto.SelectionColor = Color.Black;
            formPrincipal.texto.SelectionBackColor = Color.White;
            

            if (checkbox_case.Checked)
            {
                formPrincipal.texto.Text = formPrincipal.texto.Text.Replace(txtbox_pesquisar.Text, txtbox_substituir.Text);
            }
            else if (!checkbox_case.Checked)
            {
                formPrincipal.texto.Text = formPrincipal.texto.Text.ToLower();
                formPrincipal.texto.Text = formPrincipal.texto.Text.Replace(txtbox_pesquisar.Text.ToLower(), txtbox_substituir.Text);
            }
        }

        private void txtbox_pesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
