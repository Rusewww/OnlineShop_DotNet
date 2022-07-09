using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Data.Repository
{
    public class CategoryRepository : IСomputerСomponentsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
