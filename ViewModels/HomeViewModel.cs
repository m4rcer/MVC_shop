using shopStuding.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favouriteCars { get; set; }
    }
}
