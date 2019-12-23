using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsDishes.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(HomeContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> AllChefs = dbContext.Chefs.Include(c => c.ChefDishes).ToList();
            return View(AllChefs);
        }
        [HttpGet("new")]
        public IActionResult AddChef()
        {

            return View("AddChef");
        }
        [HttpPost("new")]
        public IActionResult AddChef(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddChef");
            }
        }
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = dbContext.Dishes.Include(c => c.Maker).ToList();
            return View(AllDishes);
        }
        [HttpGet("newDish")]
        public IActionResult AddDishes()
        {
            // List<Dish> makers  = dbContext.Dishes.Include(d => d.Maker).ToList();
            @ViewBag.Makers = dbContext.Chefs.ToList();
            // Console.WriteLine("##########################################");
        //     foreach(var m in @ViewBag.Makers)
        // {
        //     Console.WriteLine("##########################################");
        //     Console.WriteLine(m);
        // } 
            return View("AddDishes");
        }

        [HttpPost("newDish")]
        public IActionResult AddDishes(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {
                return View("AddDishes");
            }
        }



    }
}
