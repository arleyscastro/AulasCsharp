using System;

namespace Model.Entity.Entity
{
    public class Pessoa
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
    }
}
