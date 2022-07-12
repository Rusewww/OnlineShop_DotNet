using Microsoft.AspNetCore.Mvc;
using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.Data.Models;

using OnlineShop_DotNet.ViewModels;

namespace OnlineShop_DotNet.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllСomputerСomponents _сomputerСomponentRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllСomputerСomponents сomputerСomponentRepository, ShopCart shopCart)
        {
            _сomputerСomponentRepository = сomputerСomponentRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _сomputerСomponentRepository.ComputerСomponents.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}