using System;
using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<Car> _allCars = new List<Car>(){};

    public Car (string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
    public static List<Car> GetAllCars()
    {
      return _allCars;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string inputMakeModel)
    {
      _makeModel = inputMakeModel;
    }
    public string GetPrice()
    {
      return _price;
    }
    public void SetPrice(string inputPrice)
    {
      _price = inputPrice;
    }
    public string GetMiles()
    {
      return _miles;
    }
    public void SetMiles(string inputMiles)
    {
      _miles = inputMiles;
    }
    public void SaveCars()
    {
      _allCars.Add(Car());
    }
  }
}
