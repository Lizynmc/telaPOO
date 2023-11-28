using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using crud_teste.Model;
using System.Data;

namespace crud_teste.DAL
{
    public class PessoaDAL : Conexao
    {
        MySqlCommand comando = null;

        //metodo para listar

        public DataTable Listar()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM pessoa ORDER BY nome", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;

            }
            catch(Exception erro)
                {
                throw erro;

            }
        }



    }
}
