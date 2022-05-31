using shopStuding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.Data.Interfaces.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", description = "Современный вид транспорта"},
                    new Category { categoryName = "Классические автомобили", description = "Автомобили с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
