using Cad.Dominio.Entidades;
using Cad.Dominio.Interfaces;
using Cad.Infra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Cad.Infra.Repositorio
{
    public class PessoaRepositorio: AcessoDAL, IPessoaServico
    {
        private string cnxSqlServer;
        private SqlDataReader dr;
        private SqlCommand cmd;
        private string MsgErro;

        private IContatoServico _contatoServico;

        public PessoaRepositorio(string strConexao): base(strConexao)
        {
            cnxSqlServer = strConexao;
            _contatoServico = new ContatoRepositorio(strConexao);
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
            string sql = "UPDATE pessoa SET ";
            sql += "Nome=@Nome, Nascimento=@Nascimento, Cpf=@Cpf, Sexo=@Sexo";
            sql += " WHERE id=@id";

            try
            {
                cmd = CriaSqlCommand(sql, CommandType.Text);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Nascimento",pessoa.Nascimento);
                cmd.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                cmd.Parameters.AddWithValue("@Sexo", pessoa.Sexo);
                cmd.Parameters.AddWithValue("@id", pessoa.id);
                int linha = cmd.ExecuteNonQuery();
                cmd.Dispose();
                MsgErro = string.Format(Mensagens.Mensagem.Update, linha);

            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }

        }

        public int CalculaIdade(Pessoa pessoa)
        {
            return DateTime.Now.Year - pessoa.Nascimento.Year;
        }

        public void Deletar(int id)
        {
            string sql = "DELETE FROM pessoa";
            sql += " WHERE id=@id";

            try
            {
                cmd = CriaSqlCommand(sql, CommandType.Text);
                cmd.Parameters.AddWithValue("@id", id);
                int linha = cmd.ExecuteNonQuery();
                cmd.Dispose();
                MsgErro = string.Format(Mensagens.Mensagem.Delete, linha);

            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }
        }

        public string Erro()
        {
            return MsgErro;
        }

        public void Incluir(Pessoa pessoa)
        {
            string sql = "INSERT INTO pessoa ";
            sql += "(Nome, Nascimento, Cpf, Sexo)";
            sql += " VALUES ";
            sql += "(@Nome, @Nascimento, @Cpf, @Sexo)";

            try
            {
                cmd = CriaSqlCommand(sql, CommandType.Text);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Nascimento",pessoa.Nascimento);
                cmd.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                cmd.Parameters.AddWithValue("@Sexo", pessoa.Sexo);
                int linha = cmd.ExecuteNonQuery();
                cmd.Dispose();
                MsgErro = string.Format(Mensagens.Mensagem.Insert, linha);

            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }
        }

        public List<Pessoa> ObterLista(Pessoa pessoa)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            string sql = this.MontaSql(pessoa);
            try
            {
                dr = CriaDataReader(sql);
                while (dr.Read())
                {
                    listaPessoas.Add(
                        new Pessoa
                            {
                                id = (int)dr["id"],
                                Nome = (string)dr["Nome"],
                                Cpf = (string)dr["Cpf"],
                                Nascimento = (DateTime)dr["Nascimento"],
                                Sexo = (string)dr["Sexo"]
                            }
                        );
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }

            return listaPessoas;
        }

        public Pessoa ObterUmRegistro(int id)
        {
            Pessoa pessoa = new Pessoa();
            string sql = this.MontaSql(new Pessoa { id = id });

            try
            {
                dr = CriaDataReader(sql);
                while (dr.Read())
                {
                    pessoa = new Pessoa
                    {
                        id = (int) dr["id"],
                        Nome = (string) dr["Nome"],
                        Cpf = (string) dr["Cpf"],
                        Nascimento = (DateTime) dr["Nascimento"],
                        Sexo = (string) dr["Sexo"],
                        Contatos = _contatoServico.ObterLista(new Contato{idPessoa = (int) dr["id"]})
                    };
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }

            return pessoa;
        }
    }
}
