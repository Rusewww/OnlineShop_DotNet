using Microsoft.AspNetCore.Mvc;
using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.Data.Models;
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
        [Route("СomputerСomponents/List")]
        [Route("СomputerСomponents/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<СomputerСomponent> сomponents = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                сomponents = _allComponents.ComputerСomponents.OrderBy(i => i.id);

            }
            else
            {
                if (string.Equals("Processors", category, StringComparison.OrdinalIgnoreCase))
                {
                    сomponents = _allComponents.ComputerСomponents.Where(i => i.Category.categoryName.Equals("Processor")).OrderBy(i => i.id);
                    currCategory = "Processor";
                }
                else if (string.Equals("Graphic_cards", category, StringComparison.OrdinalIgnoreCase))
                {
                    сomponents = _allComponents.ComputerСomponents.Where(i => i.Category.categoryName.Equals("Graphic card")).OrderBy(i => i.id);
                    currCategory = "Graphic card";
                }

                currCategory = _category;

            }

            var componentObj = new СomputerСomponentListViewModel
            {
                getAllСomputerСomponents = сomponents,
                currCategory = currCategory
            };


            ViewBag.Title = "OComShop";
            return View(componentObj);
        }
    }
}