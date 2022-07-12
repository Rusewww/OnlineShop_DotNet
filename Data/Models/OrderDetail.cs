namespace OnlineShop_DotNet.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int  componentID { get; set; }
        public uint price { get; set; }
        public virtual СomputerСomponent computerComponent { get; set; }
        public virtual Order order { get; set; }
    }
}
