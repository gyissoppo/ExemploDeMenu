using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDeMenu
{
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Atualizar atu;
        Consultar con;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            atu = new Atualizar();
            con = new Consultar();
            exc = new Excluir();
        }//fim construtor

        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog();
        }//fim consultar

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            cad.ShowDialog();
            Visible = true;
        }//fim cadastrar

        private void button3_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//fim atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }//fim excluir
    }//fim classe
}//fim projeto
