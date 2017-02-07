using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
    }
    Post["/car_added"] = _ => {
      Car newCar = new Car {(Request.Form["new-make-model"]), (Request.Form["new-price"]), (Request.Form["new-miles"])};
      newCar.SaveCar();
      return View["car_added.cshtml", newCar];
    };
  }
}
