using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crud_teste.BLL;
using crud_teste.Model;

namespace crud_teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }


        //metodo para carregar os dados ou listar no grid
        private void Listar()
        {
            PessoaBLL pessoaBLL = new PessoaBLL();
            try
            {
                dataGridView.DataSource = pessoaBLL.Listar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os dados! \n " + erro,"AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

         

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            Listar();







        }
    }
}
