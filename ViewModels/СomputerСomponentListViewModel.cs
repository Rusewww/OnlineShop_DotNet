using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.ViewModels
{
    public class СomputerСomponentListViewModel
    {
        public IEnumerable<СomputerСomponent> getAllСomputerСomponents { get; set; }

        public string currCategory { get; set; }
    }
}
