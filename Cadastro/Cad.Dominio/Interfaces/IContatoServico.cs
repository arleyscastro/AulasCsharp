using System.Collections.Generic;
using Cad.Dominio.Entidades;

namespace Cad.Dominio.Interfaces
{
    public interface IContatoServico
    {
        string Erro();
        void Incluir(Contato contato);
        void Alterar(Contato contato);
        void Deletar(int id);
        Contato ObterUmRegistro(int id);
        List<Contato> ObterLista(Contato contato);
    }
}
