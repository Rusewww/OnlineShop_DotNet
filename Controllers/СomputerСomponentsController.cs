using Microsoft.AspNetCore.Mvc;
using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.ViewModels;

namespace OnlineShop_DotNet.Controllers
{
    public class СomputerСomponentsController : Controller
    {
        private readonly IAllСomputerСomponents _allComponents;
        private readonly IСomputerСomponentsCategory _allCategories;

        public СomputerСomponentsController(IAllСomputerСomponents iAllComponents, IСomputerСomponentsCategory iAllCategories)
        {
            _allComponents = iAllComponents;
            _allCategories = iAllCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "OComShop";
            СomputerСomponentListViewModel obj = new СomputerСomponentListViewModel();
            obj.getAllСomputerСomponents = _allComponents.ComputerСomponents;
            obj.currCategory = "ComputerСomponents";
            return View(obj);
        }
    }
}
