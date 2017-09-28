using System;

namespace IntiveFDV_DevExercise.Model
{
  public class RentHour : RentBase, IRent
  {
    /// <summary>
    /// The instance
    /// </summary>
    private static RentHour instance = null;

    /// <summary>
    /// Gets the instance.
    /// </summary>
    /// <returns></returns>
    public static RentHour GetInstance()
    {
      if (instance == null)
        instance = new RentHour();

      return instance;
    }

    public RentHour()
    {
      Price = 5;
    }

    public double GetPrice()
    {
      double priceToPay = 0;

      var hours = Math.Floor((EndRent - StartRent).TotalHours);
      priceToPay = hours * Price;
      return priceToPay;
    }

    public void SetRentDates(DateTime startRent, DateTime endRent)
    {
      StartRent = startRent;
      EndRent = endRent;
    }
  }
}
