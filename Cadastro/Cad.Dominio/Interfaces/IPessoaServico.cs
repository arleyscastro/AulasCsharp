using Cad.Dominio.Entidades;
using System.Collections.Generic;

namespace Cad.Dominio.Interfaces
{
    public interface IPessoaServico
    {
        string Erro();
        void Incluir(Pessoa pessoa);
        void Alterar(Pessoa pessoa);
        void Deletar(int id);
        Pessoa ObterUmRegistro(int id);
        List<Pessoa> ObterLista(Pessoa pessoa);
        int CalculaIdade(Pessoa pessoa);

    }
}
