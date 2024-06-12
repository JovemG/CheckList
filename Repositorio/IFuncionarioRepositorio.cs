using CheckList.Models;
using System.Collections.Generic;

namespace CheckList.Repositorio
{
    public interface IFuncionarioRepositorio
	{
		FuncionarioModel ListarPorMatricula(int matricula);
		List<FuncionarioModel> BuscarTodos();
		FuncionarioModel Adicionar(FuncionarioModel funcionario);
		FuncionarioModel Atualizar(FuncionarioModel funcionario);

		bool Apagar(int matricula);
	}
}
