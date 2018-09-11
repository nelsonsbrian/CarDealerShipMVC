using Microsoft.AspNetCore.Mvc;
using CarList.Models;
using System.Collections.Generic;
using System;


namespace CarList.Controllers
{
    public class CarsController : Controller
    {

        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allItems = new List<Car> {};
            return View(allItems);
        }


        [HttpGet("/cars/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/show")]
        public ActionResult show()
        {
            Car newCar = new Car(Request.Form["CarID"]);
            newCar.Make = (Request.Form["carMake"]);
            newCar.Model = (Request.Form["carModel"]);
            newCar.Note = (Request.Form["carNote"]);
            newCar.Price = (Request.Form["carPrice"]);
            newCar.Mileage = (Request.Form["carMileage"]);
            newCar.Save();
            List<Car> inventory = Car.GetAll();
            return View("show", inventory);
        }

    }
}
