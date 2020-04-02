
using System.Data;
using System.Data.SqlClient;

namespace Cad.Infra.Data
{
    public class AcessoDAL
    {
        private string Conexao;
        private SqlConnection cx = null;

        public AcessoDAL(string conexaoSqlServer)
        {
            Conexao = conexaoSqlServer;
        }

        protected private SqlConnection CriaSqlConnection()
        {
            if (cx == null)
            {
                cx = new SqlConnection(Conexao);
                cx.Open();
            }

            return cx;
        }

        protected SqlDataReader CriaDataReader(string sql)
        {
            SqlCommand cm = new SqlCommand(sql, CriaSqlConnection() );
            SqlDataReader dr = cm.ExecuteReader(CommandBehavior.Default);
            cm.Dispose();
            return dr;
        }

        protected SqlDataAdapter CriaDataAdapter(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, CriaSqlConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return da;
        }

        protected DataSet CriaDataSet(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, CriaSqlConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        protected SqlCommand CriaSqlCommand(string sql)
        {
            SqlCommand cmd = CriaSqlConnection().CreateCommand();
            cmd.CommandText = sql;
            return cmd;
        }


    }
}
