using CheckList.Models;
using CheckList.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CheckList.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        public FuncionariosController(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }
        public IActionResult Index()
        {
            List<FuncionarioModel> funcionario = _funcionarioRepositorio.BuscarTodos();
            return View(funcionario);
        }

        public IActionResult CriarFuncionario()
        {
            return View();
        }


        public IActionResult CheckEPI()
        {
            return View();
        }

        public IActionResult EditarFuncionario(int matricula)
        {
            FuncionarioModel funcionario = _funcionarioRepositorio.ListarPorMatricula(matricula);
            return View(funcionario);

        }

        public IActionResult ApagarFuncionario(int matricula)
        {
            FuncionarioModel funcionario = _funcionarioRepositorio.ListarPorMatricula(matricula);
            return View(funcionario);

        }

        public IActionResult Apagar(int matricula)
        {
            _funcionarioRepositorio.Apagar(matricula);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Criar(FuncionarioModel funcionario)
        {
            _funcionarioRepositorio.Adicionar(funcionario);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(FuncionarioModel funcionario)
        {
            _funcionarioRepositorio.Atualizar(funcionario);
            return RedirectToAction("Index");
        }

    }
}
