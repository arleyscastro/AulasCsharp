using System;
using System.Collections.Generic;

namespace Cad.Dominio.Entidades
{
    public class Pessoa
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public List<Contato> Contatos { get; set; }

        public Pessoa()
        {
            Contatos = new List<Contato>();
        }
    }
}
