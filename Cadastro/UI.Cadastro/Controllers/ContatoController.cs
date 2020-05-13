using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cad.Dominio.Entidades;
using Cad.Dominio.Interfaces;
using Cad.Infra.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace UI.Cadastro.Controllers
{
    public class ContatoController : Controller
    {
        private IContatoServico _contatoServico;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public static IConfigurationRoot Configuration { get; set; }

        public ContatoController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            _contatoServico = new ContatoRepositorio(Configuration["ConexaoSqlServer:Conecta"]);
        }

        private string TipoContatoDescricao(string tipo)
        {
            string aux = "";
            switch (tipo)
            {
                case "T":
                    aux = "Telefone";
                    break;
                case "C":
                    aux = "Celular";
                    break;
                case "E":
                    aux = "E-mail";
                    break;
                case "S":
                    aux = "Web Site";
                    break;
            }

            return aux;
        }

        private string TableContato(int idPessoa)
        {
            string grid = "";
            grid += "<table class=\"table table-bordered table-striped\">";
            grid += "    <thead>";
            grid += "    <tr>";
            grid += "        <td>COD#</td>";
            grid += "        <td>TIPO</td>";
            grid += "        <td>CONTATO</td>";
            grid += "        <td>AÇÃO</td>";
            grid += "    </tr>";
            grid += "    </thead>";
            grid += "    <tbody>";

            List<Contato> contatos = _contatoServico.ObterLista(new Contato {idPessoa = idPessoa});

            
            foreach (var um in contatos)
            {
                grid += "    <tr>";
                grid += "        <td>" + um.id + "</td>";
                grid += "        <td>" + TipoContatoDescricao(um.TipoContato) + "</td>";
                grid += "        <td>" + um.contato + "</td>";
                grid += "        <td>" + "<a class=\"btn\" onclick=\"DeletaContato(" + um.id + ");\">Deletar</a>" + "</td>";
                grid += "    </tr>";    
            }
            //
            grid += "    </tbody>";
            grid += "</table>";

            return grid;
        }

        [HttpGet]
        public string MontaGridContatosPessoa(int idPessoa)
        {
            return TableContato(idPessoa);
        }

        [HttpPost]
        public string InsereContato(int id, int idPessoa, string TipoContato, string contato)
        {

            _contatoServico.Incluir(new Contato{ idPessoa = idPessoa, TipoContato = TipoContato, contato = contato});

            return TableContato(idPessoa);
        }

        [HttpDelete]
        public string DeletaContato(int id)
        {
            Contato cont = _contatoServico.ObterUmRegistro(id);

            _contatoServico.Deletar(id);

            return TableContato(cont.idPessoa);
        }

    }
}