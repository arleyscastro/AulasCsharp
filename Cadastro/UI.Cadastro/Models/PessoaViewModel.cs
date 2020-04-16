using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cad.Dominio.Entidades;

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

        public List<PessoaViewModel> ListaPessoasViewModel(List<Pessoa> PessoaDominio)
        {
            List<PessoaViewModel> LtdRet = new List<PessoaViewModel>();
            foreach (Pessoa p in PessoaDominio)
            {
                LtdRet.Add(new PessoaViewModel
                {
                    id = p.id,
                    Nome = p.Nome,
                    Cpf = p.Cpf,
                    Nascimento = p.Nascimento,
                    Sexo = p.Sexo
                });
            }
            return LtdRet;
        }

        public PessoaViewModel UmaPessoaViewModel(Pessoa pessoa)
        {
            return new PessoaViewModel {
                id = pessoa.id,
                Nome = pessoa.Nome,
                Cpf = pessoa.Cpf,
                Nascimento = pessoa.Nascimento,
                Sexo = pessoa.Sexo
            };
        }

        public Pessoa UmaPessoaDominio(PessoaViewModel pessoa)
        {
            return new Pessoa {
                id = pessoa.id,
                Nome = pessoa.Nome,
                Cpf = pessoa.Cpf,
                Nascimento = pessoa.Nascimento,
                Sexo = pessoa.Sexo
            };
        }

    }
}
