using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OnlineShop_DotNet.Data.Models

{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(content) { ShopCartId = shopCartId };
        }

        public void AddToCart(СomputerСomponent component)
        {
            this.appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                component = component,
                price = component.price
            });

            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItem.Where (c => c.ShopCartId == ShopCartId).Include(s => s.component).ToList();
        }
    }
}
