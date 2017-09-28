using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntiveFDV_DevExercise;

namespace IntiveFDV_DevExerciseTest
{
  [TestClass]
  public class RentByFamilyTest
  {
    private RentByFamily instance;
    private DateTime startRent = new DateTime(2017, 10, 01, 09, 15, 25);
    private DateTime endRent = new DateTime(2017, 10, 02, 09, 22, 35);

    [TestMethod]
    public void RentFamily_WithOutDiscount()
    {
      instance = new RentByFamily();
      instance.AddRent(TypeRent.Hour);
      instance.AddRent(TypeRent.Day);
      for (int i = 0; i < instance.Rents.Count; i++)
      {
        instance.Rents[i].SetRentDates(startRent, endRent);
      }
      Assert.AreEqual(140, instance.GetPrice());
    }

    [TestMethod]
    public void RentFamily_WithDiscount()
    {
      instance = new RentByFamily();
      instance.AddRent(TypeRent.Week);
      instance.AddRent(TypeRent.Week);
      instance.AddRent(TypeRent.Day);
      for (int i = 0; i < instance.Rents.Count; i++)
      {
        instance.Rents[i].SetRentDates(startRent, endRent);
      }
      Assert.AreEqual(196, instance.GetPrice());
    }

    [TestMethod]
    public void RentFamily_WithOutRents()
    {
      instance = new RentByFamily();
      Assert.AreEqual(0, instance.GetPrice());
    }
  }
}
