using LoveCart.Library.Business.Abstract;
using LoveCart.Presentation.WEB.LoveCartUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LoveCart.Library.Utilities.Dto;

namespace LoveCart.Presentation.WEB.LoveCartUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICartTitleService _cartTitleService;

        public HomeController(ILogger<HomeController> logger, ICartTitleService cartTitleService)
        {
            _logger = logger;
            _cartTitleService = cartTitleService;
        }

        public async Task<IActionResult> Index(int id=1)
        {
            var data = await _cartTitleService.GetCartTitleAsync(id);
            return View(data);
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


        [HttpPost]
        public async Task<IActionResult> AddCartDetail(CartDetailDto Model)
        {

            var data = await _cartTitleService.CreateCartDetailAsync(Model);
            return Redirect("/Home/Index/"+Model.TitleId);
        }
    }
}