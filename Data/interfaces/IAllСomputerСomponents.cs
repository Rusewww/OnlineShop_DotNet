using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Data.interfaces
{
    public interface IAllСomputerСomponents
    {
        IEnumerable<СomputerСomponent> ComputerСomponents { get; }

        IEnumerable<СomputerСomponent> GetFavourite { get; }

        СomputerСomponent GetObjectСomputerСomponent(int CompounentId);
    }
}
