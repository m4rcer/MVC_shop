using Microsoft.AspNetCore.Mvc;
using shopStuding.Data.Interfaces;
using shopStuding.Data.Models;
using shopStuding.Data.Repository;
using shopStuding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.Controlers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars carRepository;
        private readonly ShopCart shopCart;

        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            this.carRepository = carRepository;
            this.shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = shopCart.getShopItems();
            shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = carRepository.Cars.FirstOrDefault(i => i.id==id);
            if (item != null)
            {
                shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
