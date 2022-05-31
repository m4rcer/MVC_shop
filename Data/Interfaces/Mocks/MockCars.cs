using shopStuding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.Data.Interfaces.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory carsCategory = new MockCategory();
        public IEnumerable<Car> Cars { get 
            {
                return new List<Car>
                {
                    new Car {name = "Tesla",
                        img = "/img/tesla.jpg",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        shortDesc = "Экологичный автомобиль",
                        category = carsCategory.AllCategories.ElementAt(0)},
                    new Car {name = "BMW",
                        img = "/img/bmw.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        shortDesc = "Мощный автомобиль",
                        category = carsCategory.AllCategories.ElementAt(1)}
                };
            }
            set { Cars = value; }
            }
        public IEnumerable<Car> FavouriteCars { get; set; }

        public Car getCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
