using Microsoft.AspNetCore.Mvc;
using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.ListShopItems = shopCart.getShopItems();
            if (shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "You must have goods!");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Order processed successfully";
            return View();
        }
    }
}
