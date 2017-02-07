using System;
using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<Car> _allCars = new List<Car>{};

    public Car(string makeModel, int price, int miles)
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
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int inputPrice)
    {
      _price = inputPrice;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int inputMiles)
    {
      _miles = inputMiles;
    }
    
    public void SaveCar()
    {
      _allCars.Add(this);
    }
    public static void ClearAll()
    {
      _allCars.Clear();
    }


  }
}
