﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crud_teste.DAL;
using System.Data;
using crud_teste.Model;

namespace crud_teste.BLL
{
    public class PessoaBLL
    {
        PessoaDAL pessoaDAL= new PessoaDAL();
      //metodo para salvar
      public void Salvar(Pessoa pessoa)
        {
            try
            {
                pessoaDAL.Salvar(pessoa);

            }
            catch (Exception erro)
            {
                throw erro;

            }
        }
        
        
        //metodo para listar.

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAL.Listar();
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;            

            }
        }
    }
}
