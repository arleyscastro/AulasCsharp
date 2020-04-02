using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Cad.Dominio.Entidades;
using Cad.Dominio.Interfaces;
using Cad.Infra.Data;

namespace Cad.Infra.Repositorio
{
    public class PessoaRepositorio: AcessoDAL, IPessoaServico
    {
        private string cnxSqlServer;
        private SqlDataReader dr;
        private SqlCommand cmd;
        private string MsgErro;

        public PessoaRepositorio(string strConexao): base(strConexao)
        {
            cnxSqlServer = strConexao;
        }

        private string MontaSql(Pessoa pessoa)
        {
            string sql = "SELECT id, Nome, Nascimento, Cpf, Sexo FROM Pessoa WHERE 1=1 ";

            if (pessoa.id > 0)
            {
                sql += " AND id = " + pessoa.id;
            }

            if (!string.IsNullOrEmpty(pessoa.Nome))
            {
                sql += " AND Nome Like '%" + pessoa.Nome + "%'";
            }

            if (!string.IsNullOrEmpty(pessoa.Cpf)) 
            {
                sql += " AND Cpf = '" + pessoa.Cpf.Trim() + "'";
            }

            if (!string.IsNullOrEmpty(pessoa.Sexo))
            {
                sql += " AND Sexo = '" + pessoa.Sexo.Trim() + "'";
            }

            return sql;
        }

        public void Alterar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public int CalculaIdade(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public string Erro()
        {
            return MsgErro;
        }

        public void Incluir(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ObterLista(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Pessoa ObterUmRegistro(int id)
        {
            throw new NotImplementedException();
        }
    }
}
