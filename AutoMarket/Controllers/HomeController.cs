using AutoMarket.core.Contracts;
using AutoMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutoMarket.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ICarService carService;

        public HomeController(ICarService _carService)
        {
            carService = _carService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await carService.GetPicturesAsync();
            return View(model);
        }


        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
