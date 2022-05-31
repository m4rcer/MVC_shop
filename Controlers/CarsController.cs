using Microsoft.AspNetCore.Mvc;
using shopStuding.Data.Interfaces;
using shopStuding.Data.Models;
using shopStuding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.Controlers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory carsCategories;

        public CarsController(IAllCars allCars, ICarsCategory carsCategories)
        {
            this.allCars = allCars;
            this.carsCategories = carsCategories;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            IEnumerable<Car> cars = null;
            string currentCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = allCars.Cars.OrderBy(c => c.id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allCars.Cars.Where(i => i.category.categoryName.Equals("Электромобили"));
                    currentCategory = "Электромобили";
                }
                else if(string.Equals("fuels", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allCars.Cars.Where(i => i.category.categoryName.Equals("Классические автомобили"));
                    currentCategory = "Классические автомобили";
                }
            }
            var carObj = new CarsListViewModel { allCars = cars, currentCategory = currentCategory };
            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);
        }
    }
}
