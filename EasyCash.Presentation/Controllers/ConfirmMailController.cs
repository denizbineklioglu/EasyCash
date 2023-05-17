using EasyCash.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyCash.Presentation.Controllers
{
	public class ConfirmMailController : Controller
	{
		[HttpGet]
		public IActionResult Index(int id)
		{
			var value = TempData["Mail"];
			return View();
		}

		[HttpPost]
		public IActionResult Index(ConfirmMailViewModel model)
		{
			return View();
		}
	}
}
