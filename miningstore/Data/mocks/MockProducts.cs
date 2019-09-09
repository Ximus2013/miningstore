using miningstore.Data.Interfaces;
using miningstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Data.mocks
{
    public class MockProducts : IAllProducts
    {

        private readonly IAllCategories _categoryProducts = new MockCategory();


        public IEnumerable<Product> AllProducts
        {
            get
            {
                return new List<Product>
                {
                    new Product{
                        Name ="Процессор Intel Core i5-6600K 3.5GHz/8GT/s/6MB (BX80662I56600K) s1151 BOX",
                        ShortDesc ="Новый процессор Intel Core i5-6600K 6-го поколения.",
                        LongDesc ="Intel Core i5-6600K производится по стандарту 14-нм техпроцесса, имеет 4 ядра, которые работают на штатной тактовой частоте 3.5 ГГц, 3.9 ГГц в режиме Turbo Boost 2.0. Объем кэш-памяти 3 уровня равен 6 МБ. Имеет 2-х канальный контроллер памяти DDR4 / DDR3L и разблокированный множитель.",
                        img ="/img/1.jpg",
                        price = 4950,
                        isfavorite = true,
                        available =true,
                        Category = _categoryProducts.AllCategories.First() },

                    new Product{
                        Name ="Процессор Intel Core i7-9700K 3.6GHz/8GT/s/12MB (BX80684I79700K) s1151 BOX",
                        ShortDesc ="Новый процессор Intel Core i7-9700K 9-го поколения. Предназначен для настольной платформы Intel LGA 1151.",
                        LongDesc ="Intel Core i7-9700K производится по стандарту 14-нм техпроцесса, имеет 8 ядер, которые работают в 8 потоков со штатной тактовой частотой 3.6 ГГц, 4.9 ГГц в режиме Turbo Boost. Объем кэш-памяти 3 уровня равен 12 МБ. Имеет 2-х канальный контроллер памяти DDR4.",
                        img ="/img/2.jpg",
                        price = 11609,
                        isfavorite = true,
                        available =true,
                        Category = _categoryProducts.AllCategories.First() },

                    new Product{
                        Name ="Процессор AMD Ryzen 3 1200 3.1GHz/8MB (YD1200BBAEBOX) sAM4 BOX",
                        ShortDesc ="В комплект поставки входит система охлаждения AMD Wraith Stealth.",
                        LongDesc ="Особенности микроархитектуры Zen В новой архитектуре AMD Zen используется мощный механизм исполнения, а также поддерживается функция одновременной многопоточности (SMT). Ядра Zen разработаны для эффективного использования имеющихся ресурсов микроархитектуры для обеспечения максимальной вычислительной производительности. Новая трехуровневая кэш-память с низкой задержкой и новые алгоритмы предварительной выборки значительно уменьшают количество кэш-промахов и увеличивают пропускную способность по сравнению с предыдущей микроархитектурой.",
                        img ="/img/3.jpg",
                        price = 1559,
                        isfavorite = true,
                        available =true,
                        Category = _categoryProducts.AllCategories.First() },

                    new Product{
                        Name ="Asus Pci-Ex Geforce Gtx 1060 Dual 6Gb Gddr5 ",
                        ShortDesc ="Видеокарта GeForce GTX 1060 Dual O3G от Asus ",
                        LongDesc ="Видеокарта GeForce GTX 1060 Dual O6G от Asus объемом памяти 6 ГБ GDDR5, основана на новой архитектуре Pascal и поддерживает предельно высокое разрешение экрана. Модель имеет стильный дизайн корпуса и оснащена запатентованными вентиляторами Wing-Blade, предоставляющими максимальную вентиляцию и обеспечивая на 105% больше давления воздушного потока. Эксклюзивная технология Auto-Extreme использующая компоненты Super Alloy Power II гарантирует превосходную стабильность. GPU Tweak II с XSplit Gamecaster, обеспечивает интуитивно тонкую калибровку производительности и безостановочный игровой стриминг.",
                        img ="/img/4.jpg",
                        price = 6500,
                        isfavorite = true,
                        available =true,
                        Category = _categoryProducts.AllCategories.Last() },

                     new Product{
                        Name ="Gigabyte PCI-Ex Radeon RX 570 Gaming 4GB GDDR5 (256bit)",
                        ShortDesc ="Gigabyte PCI-Ex Radeon RX 570 Gaming 4GB GDDR5 (256bit) (1244/7000) (DVI, HDMI, 3 x Display Port) (GV-RX570GAMING-4GD)",
                        LongDesc ="Видеокарта Gigabyte Gaming создана, чтобы удовлетворить все требования опытных игроков, основана на решении AMD Radeon, архитектура GPU — Polaris.",
                        img ="/img/5.jpg",
                        price = 4767,
                        isfavorite = true,
                        available =true,
                        Category = _categoryProducts.AllCategories.Last() }
                };
            }

        }
        public IEnumerable<Product> GetFavoriteProduct { get ; set ; }

        public Product GetProductID(int ProductID)
        {
            throw new NotImplementedException();
        }
    }
}
