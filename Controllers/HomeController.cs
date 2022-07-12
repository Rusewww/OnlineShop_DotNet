using Microsoft.AspNetCore.Mvc;
using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.ViewModels;

namespace OnlineShop_DotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllСomputerСomponents _сomputerСomponentRepository;

        public HomeController(IAllСomputerСomponents сomputerСomponentRepository)
        {
            _сomputerСomponentRepository = сomputerСomponentRepository;
        }

        public ViewResult Index()
        {
            var homeСomponent = new HomeViewModel
            {
                favComputerСomponents = _сomputerСomponentRepository.GetFavourite
            };
            return View(homeСomponent);
        }
    }
}