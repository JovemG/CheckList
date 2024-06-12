using CheckList.Data;
using CheckList.Models;

namespace CheckList.Repositorio
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
	{
		private readonly BancoContext _context;

		public FuncionarioRepositorio(BancoContext bancoContext) 
		{
			this._context = bancoContext;
		}


        public List<FuncionarioModel> BuscarTodos()
        {
			return _context.FuncionarioModel.ToList();
        }

        public FuncionarioModel Adicionar(FuncionarioModel funcionario)
		{
			_context.FuncionarioModel.Add(funcionario);
			_context.SaveChanges();
			return funcionario;
		}

        public FuncionarioModel ListarPorMatricula(int matricula)
        {
            return _context.FuncionarioModel.FirstOrDefault(x => x.Matricula == matricula);
        }

        public FuncionarioModel Atualizar(FuncionarioModel funcionario)
        {
            FuncionarioModel funcionarioDB = ListarPorMatricula(funcionario.Matricula);

            if (funcionarioDB == null) throw new System.Exception("Houve um erro na atualização do funcionário");

            funcionarioDB.Nome = funcionario.Nome;

            _context.FuncionarioModel.Update(funcionarioDB);
            _context.SaveChanges();

            return funcionarioDB;
           
        }

        public bool Apagar(int matricula)
        {
            FuncionarioModel funcionarioDB = ListarPorMatricula(matricula);

            if (funcionarioDB == null) throw new System.Exception("Houve um erro na delação do funcionario");

            _context.FuncionarioModel.Remove(funcionarioDB);
            _context.SaveChanges(); 

            return true;    
        }
    }
}
