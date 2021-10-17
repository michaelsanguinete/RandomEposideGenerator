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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Marque uma opção!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (checkBox1.Checked)
            {
                Form2 teste = new Form2();
                teste.ShowDialog();
            }
            if (checkBox2.Checked)
            {
                string text = System.IO.File.ReadAllText(@"C:\Users\micha\source\repos\Tela\FamilyGuy.txt");

                string[] linha = new string[text.Length];

                linha = text.Split('\n');

                Random r = new Random();
                int posicao = r.Next(linha.Length);
                string _nome = linha[posicao];

                MessageBox.Show(_nome);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
