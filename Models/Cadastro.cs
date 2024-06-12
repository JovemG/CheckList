using Microsoft.AspNetCore.Mvc;

namespace CheckList.Models
{
	public class Cadastro : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
