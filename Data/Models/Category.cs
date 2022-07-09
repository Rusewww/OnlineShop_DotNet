namespace OnlineShop_DotNet.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string categoryName { get; set; }

        public string desc { get; set; }

        public List<СomputerСomponent> СomputerСomponents { get; set; }
    }
}
