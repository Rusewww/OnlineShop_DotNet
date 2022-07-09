using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Data.interfaces
{
    public interface IСomputerСomponentsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
