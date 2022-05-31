using Microsoft.EntityFrameworkCore;
using shopStuding.Data.Interfaces;
using shopStuding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent; 
        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> FavouriteCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.category);

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.category);

        public Car getCar(int id) => appDBContent.Car.FirstOrDefault(p => p.id == id);
    }
}
