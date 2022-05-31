using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using shopStuding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                new List<Car>
                {
                    new Car {name = "Tesla",
                        img = "/img/tesla.jpg",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        shortDesc = "Экологичный автомобиль",
                        category =  Categories["Электромобили"] },
                    new Car {name = "BMW",
                        img = "/img/bmw.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        shortDesc = "Мощный автомобиль",
                        category = Categories["Классические автомобили"] }
                }
                );
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories { get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", description = "Современный вид транспорта"},
                        new Category { categoryName = "Классические автомобили", description = "Автомобили с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (var c in list)
                    {
                        category.Add(c.categoryName, c);
                    }
                }

                return category;
            } }
    }
}
