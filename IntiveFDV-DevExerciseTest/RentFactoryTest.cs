using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntiveFDV_DevExercise;
using IntiveFDV_DevExercise.Model;

namespace IntiveFDV_DevExerciseTest
{
  [TestClass]
  public class RentFactoryTest
  {
    IRent instance;

    [TestMethod]
    public void CreateRentByHour()
    {
      double estimatedPrice = 5;
      double estimatedRentPrice = 30;
      CreateRent(new DateTime(2017, 10, 01, 15, 22, 35), TypeRent.Hour);
      Assert.AreEqual(Convert.ToDouble(estimatedPrice), ((RentHour)instance).Price);
      Assert.AreEqual(Convert.ToDouble(estimatedRentPrice), instance.GetPrice());
    }

    [TestMethod]
    public void CreateRentByDay()
    {
      double estimatedPrice = 20;
      double estimatedRentPrice = 280;
      CreateRent(new DateTime(2017, 10, 15, 15, 22, 35), TypeRent.Day);
      Assert.AreEqual(Convert.ToDouble(estimatedPrice), ((RentDay)instance).Price);
      Assert.AreEqual(Convert.ToDouble(estimatedRentPrice), instance.GetPrice());
    }

    [TestMethod]
    public void CreateRentByWeek()
    {
      double estimatedPrice = 60;
      double estimatedRentPrice = 180;
      CreateRent(new DateTime(2017, 10, 22, 15, 22, 35), TypeRent.Week);
      Assert.AreEqual(Convert.ToDouble(estimatedPrice), ((RentWeek)instance).Price);
      Assert.AreEqual(Convert.ToDouble(estimatedRentPrice), instance.GetPrice());
    }

    /// <summary>
    /// Create and SetDates of and Rent
    /// </summary>
    /// <param name="endRent">Finish date of rent</param>
    /// <param name="type">Type of rent to create</param>
    /// <returns>Instance of Rent</returns>
    private void CreateRent(DateTime endRent, TypeRent type)
    {
      var startRent = new DateTime(2017, 10, 01, 09, 15, 25);
      instance = RentFactory.CreateInstance(type);
      instance.SetRentDates(startRent, endRent);
    }
  }
}
