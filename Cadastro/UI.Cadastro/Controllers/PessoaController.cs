using Cad.Dominio.Entidades;
using Cad.Dominio.Interfaces;
using Cad.Infra.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;
using UI.Cadastro.Models;

namespace UI.Cadastro.Controllers
{
    public class PessoaController : Controller
    {
        private IPessoaServico _pessoaServico;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public static IConfigurationRoot Configuration { get; set; }

        public PessoaController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            _pessoaServico = new PessoaRepositorio(Configuration["ConexaoSqlServer:Conecta"]);
        }


        // GET: Pessoa
        public ActionResult Index()
        {
            PessoaViewModel aux = new PessoaViewModel();

            return View(aux.ListaPessoasViewModel(_pessoaServico.ObterLista(new Pessoa())));
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            PessoaViewModel pessoa = new PessoaViewModel();

            pessoa = pessoa.UmaPessoaViewModel(_pessoaServico.ObterUmRegistro(id));

            return PartialView("PessoaDetalhe",pessoa);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View(new PessoaViewModel());
        }

        // POST: Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaViewModel pessoa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pessoaServico.Incluir(pessoa.UmaPessoaDominio(pessoa));
                    return RedirectToAction(nameof(Index));
                }

                
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            PessoaViewModel pessoa = new PessoaViewModel();

            pessoa = pessoa.UmaPessoaViewModel(_pessoaServico.ObterUmRegistro(id));

            return View(pessoa);
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaViewModel pessoa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pessoaServico.Alterar(pessoa.UmaPessoaDominio(pessoa));
                }
            }
            catch
            {
                return View(pessoa);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public bool Delete(int id)
        {
            if (id > 0)
            {
                _pessoaServico.Deletar(id);
            }

            return _pessoaServico.Erro().Contains("Deleção");
        }

       
    }
}