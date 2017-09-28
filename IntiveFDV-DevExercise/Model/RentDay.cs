using System;

namespace IntiveFDV_DevExercise.Model
{
  public class RentDay : RentBase, IRent
  {
    /// <summary>
    /// The instance
    /// </summary>
    private static RentDay instance = null;

    /// <summary>
    /// Gets the instance.
    /// </summary>
    /// <returns></returns>
    public static RentDay GetInstance()
    {
      if (instance == null)
        instance = new RentDay();

      return instance;
    }

    public RentDay()
    {
      Price = 20;
    }

    public double GetPrice()
    {
      double priceToPay = 0;

      var days = Math.Floor((EndRent - StartRent).TotalDays);
      priceToPay = days * Price;
      return priceToPay;
    }

    public void SetRentDates(DateTime startRent, DateTime endRent)
    {
      StartRent = startRent;
      EndRent = endRent;
    }
  }
}
