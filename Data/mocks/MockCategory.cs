using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Data.mocks
{
    public class MockCategory : IСomputerСomponentsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>()
                {
                    new Category{ categoryName = "Processor", desc = "A central processing unit (CPU)."},
                    new Category { categoryName = "Graphic card", desc = "A graphics processing unit (GPU)." }
                };
            }
        }
    }
}
