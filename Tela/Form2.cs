using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\micha\source\repos\Tela\RickAndMorty.txt");

            string[] linha = new string[text.Length];

            linha = text.Split('\n');

            Random r = new Random();
            int posicao = r.Next(linha.Length);
            string nome = linha[posicao];
            textBox1.AppendText(nome);
            

            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
