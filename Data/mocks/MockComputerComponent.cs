using OnlineShop_DotNet.Data.interfaces;
using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet.Data.mocks
{
    public class MockComputerComponent : IAllСomputerСomponents
    {
        private readonly IСomputerСomponentsCategory _categoryComputerComponents = new MockCategory();

        public IEnumerable<СomputerСomponent> ComputerСomponents {
            get
            {
                return new List<СomputerСomponent>
                {
                    new СomputerСomponent {
                        name = "AMD Ryzen 5 5600G", 
                        shortDesc = "Socket type: Socket AM4; Number of cores: 6; Processor clock speed: 3900 MHz", 
                        longDesc = "Socket type: Socket AM4; Number of Cores: 6; Processor Clock Frequency: 3900 MHz; Maximum Clock Frequency: 4.4 GHz; Process Technology: 7nm", 
                        img = "/img/Ryzen5.jpg", 
                        price = 6705, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryComputerComponents.AllCategories.First()
                    },
                    new СomputerСomponent {
                        name = "Intel Core i5-11400F", 
                        shortDesc = "Socket type: Socket 1200; Number of cores: 6; Processor clock speed: 2600 MHz", 
                        longDesc = "Socket type: Socket 1200; Number of cores: 6; Processor clock speed: 2600 MHz Maximum Clock Frequency: 4.4 GHz; Process Technology: 7nm", 
                        img = "/img/intel_i5.jpg", 
                        price = 5300, 
                        isFavourite = false, 
                        available = true, 
                        Category = _categoryComputerComponents.AllCategories.First()
                    },
                    new СomputerСomponent {
                        name = "AMD Ryzen 9 5900X", 
                        shortDesc = "Socket type: Socket AM4; Number of cores: 12; Processor clock speed: 3700 MH", 
                        longDesc = "Socket AM4; Number of Cores: 1; Processor Clock Frequency: 3700 MHz; Maximum Clock Frequency: 4.8 GHz; Process Technology: 7n", 
                        img = "/img/Ryzen9.jpg", 
                        price = 15474, 
                        isFavourite = true, 
                        available = false, 
                        Category = _categoryComputerComponents.AllCategories.First()
                    },
                    new СomputerСomponent {
                        name = "Gigabyte GeForce RTX 2060 Super Windforce", 
                        shortDesc = "Graphics chip: GeForce RTX 2060 Super; Memory: 8GB; Width of memory: 256-bit", 
                        longDesc = "Graphic chip: GeForce RTX 2060 Super; Memory: 8GB; Width: 256-bit; Minimum required power supply: 550W; Memory type: GDDR6", 
                        img = "/img/RTX2060.jpg", 
                        price = 20500, 
                        isFavourite = false, 
                        available = true, 
                        Category = _categoryComputerComponents.AllCategories.Last()
                    },
                    new СomputerСomponent {
                        name = "Gigabyte GeForce RTX 3070 Ti Gaming", 
                        shortDesc = "Graphics chip: GeForce RTX 3070 Ti; Memory: 8GB; Width of memory: 256-bit", 
                        longDesc = "Graphic chip: GeForce RTX 3070 Ti; Memory: 8GB; Width: 256-bit; Minimum required power supply: 750W; Memory type: GDDR6", 
                        img = "/img/RTX3070Ti.png", 
                        price = 32200, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryComputerComponents.AllCategories.Last()
                    },
                    new СomputerСomponent {
                        name = "Asus Radeon RX 6800 XT TUF Gaming", 
                        shortDesc = "Graphics chip: RX 6800 XT; Memory: 16GB; Width of memory: 256-bit", 
                        longDesc = "Graphic chip: RX 6800 XT; Memory: 16GB; Width: 256-bit; Minimum required power supply: 750W; Memory type: GDDR6", 
                        img = "/img/RX6800XT.jpg", 
                        price = 41500, 
                        isFavourite = false, 
                        available = false, 
                        Category = _categoryComputerComponents.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<СomputerСomponent> GetFavourite { get; set; }

        public СomputerСomponent GetObjectСomputerСomponent(int CompounentId)
        {
            throw new NotImplementedException();
        }
    }
}
