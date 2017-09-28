using System;

namespace IntiveFDV_DevExercise.Model
{
  public class RentWeek : RentBase, IRent
  {
    /// <summary>
    /// The instance
    /// </summary>
    private static RentWeek instance = null;

    /// <summary>
    /// Gets the instance.
    /// </summary>
    /// <returns></returns>
    public static RentWeek GetInstance()
    {
      if (instance == null)
        instance = new RentWeek();

      return instance;
    }

    public RentWeek()
    {
      Price = 60;
    }

    public double GetPrice()
    {
      double priceToPay = 0;

      var weeks = Math.Floor((EndRent - StartRent).TotalDays / 7);
      priceToPay = weeks * Price;
      return priceToPay;
    }

    public void SetRentDates(DateTime startRent, DateTime endRent)
    {
      StartRent = startRent;
      EndRent = endRent;
    }
  }
}
