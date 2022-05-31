using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopStuding.Data.Interfaces;
using shopStuding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.Controlers
{
    public class HomeController : Controller
    {
        private readonly IAllCars carRepository;

        public HomeController(IAllCars carRepository)
        {
            this.carRepository = carRepository;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel { favouriteCars = carRepository.FavouriteCars};
            return View(homeCars);
        }
    }
}
