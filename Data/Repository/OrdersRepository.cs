using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            //appDBContent.SaveChanges();

            var items = shopCart.ListShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    componentID = el.component.id,
                    orderId = order.id,
                    price = el.component.price
                };
                //appDBContent.OrderDetail.Add(orderDetail);
            }
            //appDBContent.SaveChanges();
        }
    }
}
