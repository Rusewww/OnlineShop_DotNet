using Microsoft.EntityFrameworkCore;
using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Data.Repository
{
    public class СomputerСomponentRepository : IAllСomputerСomponents
    {
        private readonly AppDBContent appDBContent;
        public СomputerСomponentRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<СomputerСomponent> ComputerСomponents => appDBContent.ComputerСomponents.Include(c => c.Category);

        public IEnumerable<СomputerСomponent> GetFavourite => appDBContent.ComputerСomponents.Where(p => p.isFavourite).Include(c => c.Category);

        public СomputerСomponent GetObjectСomputerСomponent(int CompounentId) => appDBContent.ComputerСomponents.FirstOrDefault(p => p.id == CompounentId);
    }
}       
