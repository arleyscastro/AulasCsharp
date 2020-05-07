using System;
using Cad.Dominio.Entidades;
using Cad.Dominio.Interfaces;
using Cad.Infra.Data;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Cad.Infra.Repositorio
{
    public class ContatoRepositorio: AcessoDAL, IContatoServico
    {
        private string cnxSqlServer;
        private SqlDataReader dr;
        private SqlCommand cmd;
        private string MsgErro;

        public ContatoRepositorio(string strConexao):base(strConexao)
        {
            cnxSqlServer = strConexao;
        }

        private string MontaSql(Contato contato)
        {
            string sql = "SELECT idContato, idPessoa, tipoContato, contato FROM Contato WHERE 1=1 ";

            if (contato.id > 0)
            {
                sql += " AND idContato = " + contato.id;
            }

            if (contato.idPessoa > 0)
            {
                sql += " AND idPessoa =" + contato.idPessoa;
            }

            if (!string.IsNullOrEmpty(contato.TipoContato)) 
            {
                sql += " AND tipoContato = '" + contato.TipoContato.Trim() + "'";
            }

            if (!string.IsNullOrEmpty(contato.contato))
            {
                sql += " AND contato = '" + contato.contato.Trim() + "'";
            }

            return sql;
        }

        public void Alterar(Contato contato)
        {
            string sql = "UPDATE Contato SET ";
            sql += " idPessoa=@idPessoa, tipoContato=@tipoContato, contato=@contato ";
            sql += " WHERE idContato=@idContato";
            try
            {
                cmd = CriaSqlCommand(sql, CommandType.Text);
                cmd.Parameters.AddWithValue("@idPessoa", contato.idPessoa);
                cmd.Parameters.AddWithValue("@tipoContato",contato.TipoContato);
                cmd.Parameters.AddWithValue("@contato", contato.contato);
                cmd.Parameters.AddWithValue("@idContato", contato.id);
                int linha = cmd.ExecuteNonQuery();
                cmd.Dispose();
                MsgErro = string.Format(Mensagens.Mensagem.Update, linha);

            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }
        }

        public void Deletar(int id)
        {
            string sql = "DELETE FROM Contato ";
            sql += " WHERE idContato=@idContato";
            try
            {
                cmd = CriaSqlCommand(sql, CommandType.Text);
                cmd.Parameters.AddWithValue("@idContato", id);
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

        public void Incluir(Contato contato)
        {
            string sql = "INSERT INTO Contato ";
            sql += " (idPessoa, tipoContato, contato)";
            sql += " VALUES ";
            sql += " (@idPessoa, @tipoContato, @contato )";
            try
            {
                cmd = CriaSqlCommand(sql, CommandType.Text);
                cmd.Parameters.AddWithValue("@idPessoa", contato.idPessoa);
                cmd.Parameters.AddWithValue("@tipoContato",contato.TipoContato);
                cmd.Parameters.AddWithValue("@contato", contato.contato);
                int linha = cmd.ExecuteNonQuery();
                cmd.Dispose();
                MsgErro = string.Format(Mensagens.Mensagem.Update, linha);

            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }
        }

        public List<Contato> ObterLista(Contato contato)
        {
            List<Contato> lista = new List<Contato>();

            string sql = MontaSql(contato);

            try
            {
                dr = CriaDataReader(sql);
                while ( dr.Read() )
                {
                    lista.Add(new Contato
                    {
                        id = (int)dr["idContato"],
                        TipoContato = (string)dr["tipoContato"],
                        contato = (string)dr["contato"],
                        idPessoa = (int)dr["idPessoa"]
                    });
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }

            return lista;
        }

        public Contato ObterUmRegistro(int id)
        {
            Contato contato = new Contato();

            string sql = MontaSql(new Contato{id = id});

            try
            {
                dr = CriaDataReader(sql);
                while ( dr.Read() )
                {
                    contato = new Contato
                    {
                        id = (int)dr["idContato"],
                        TipoContato = (string)dr["tipoContato"],
                        contato = (string)dr["contato"],
                        idPessoa = (int)dr["idPessoa"]
                    };
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MsgErro = e.Message;
            }

            return contato;
        }
    }
}
