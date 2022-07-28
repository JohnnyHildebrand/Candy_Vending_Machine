using Candy_Vending_Machine.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Candy_Vending_Machine.Controllers
		 {
		 public class HomeController : Controller
					{
					private readonly ILogger<HomeController> _logger;

					public HomeController(ILogger<HomeController> logger)
							 {
							 _logger = logger;
							 }

					public IActionResult Candy()
							 {
							 CandyViewModel avm = new CandyViewModel();
							 List<DTO.Candy> candys = new List<DTO.Candy>()
{
new DTO.Candy{ Id = 2, Name = "Smelly", Weight = 1.1, Price =  12.83 },
new DTO.Candy{ Id = 3, Name = "Tasty", Weight = 2.3, Price =  17.45 },
new DTO.Candy{ Id = 1, Name = "Beauty", Weight = 3.4, Price=  23.23 },
};
							 avm.Candys = candys;
							 return View(avm);
							 }


					public IActionResult Index()
							 {
							 return View();
							 }

					public IActionResult Privacy()
							 {
							 return View();
							 }

					[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
					public IActionResult Error()
							 {
							 return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
							 }
					}
		 }