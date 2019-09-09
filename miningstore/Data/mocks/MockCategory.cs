using miningstore.Data.Interfaces;
using miningstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Data.mocks
{
    public class MockCategory : IAllCategories
    {
        public IEnumerable<Category> AllCategories
        {

            get
            {
                return new List<Category>
                {
                    new Category{  CategoryName  = "Процессоры" , DescCategory ="Сердце" },
                    new Category{  CategoryName  = "Видеокарты" , DescCategory ="Роботники" }
                };
            }
        }
    }
}
