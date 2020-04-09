using System;
using System.ComponentModel.DataAnnotations;

namespace UI.Cadastro.Models
{
    public class PessoaViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(255, MinimumLength = 4)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatório!")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(14)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O Sexo é obrigatório!", AllowEmptyStrings = false)]
        public string Sexo { get; set; }

    }
}
