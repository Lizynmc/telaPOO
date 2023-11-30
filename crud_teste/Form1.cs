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
           Pessoa pessoa = new Pessoa();
            Salvar(pessoa);



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
        //metodo para salver
        private void Salvar (Pessoa pessoa)
        {
            PessoaBLL pessoaBLL = new PessoaBLL();

            try
            {








            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //metodo para carregar os dados ou listar no grid
        private void Listar()
        {
            PessoaBLL pessoaBLL = new PessoaBLL();
            try
            {
                dataGridView.DataSource = pessoaBLL.Listar();

                //rename colunas do datagridview

                dataGridView.Columns[0].HeaderText = "Código";
                dataGridView.Columns[1].HeaderText = "Nome";
                dataGridView.Columns[2].HeaderText = "Dt nasco";
                dataGridView.Columns[3].HeaderText = "Sexo";
                dataGridView.Columns[4].HeaderText = "CPF";
                dataGridView.Columns[5].HeaderText = "Celular";
                dataGridView.Columns[6].HeaderText = "Endreço";
                dataGridView.Columns[7].HeaderText = "Bairro";
                dataGridView.Columns[8].HeaderText = "Cidade";
                dataGridView.Columns[9].HeaderText = "UF";
                dataGridView.Columns[10].HeaderText = "CEP";

                //Excluir colunas do data grid

                dataGridView.Columns[6].Visible = false;
                dataGridView.Columns[7].Visible = false;
                dataGridView.Columns[8].Visible = false;
                dataGridView.Columns[9].Visible = false;
                dataGridView.Columns[10].Visible = false;


                //largura das colunas 

                dataGridView.Columns[0].Width = 45;
                dataGridView.Columns[1].Width = 160;
                dataGridView.Columns[2].Width = 70;
                dataGridView.Columns[3].Width = 40;
                dataGridView.Columns[4].Width = 75;
                dataGridView.Columns[5].Width = 85;
           





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
