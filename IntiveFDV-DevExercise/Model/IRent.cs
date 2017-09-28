using System;

namespace IntiveFDV_DevExercise.Model
{
  public interface IRent
  {
    /// <summary>
    /// Initialize dates of rent
    /// </summary>
    /// <param name="startRent">Initial date</param>
    /// <param name="endRent">End date</param>
    void SetRentDates(DateTime startRent, DateTime endRent);

    /// <summary>
    /// Calculate the amount to pay for rent a bike
    /// </summary>
    /// <returns></returns>
    double GetPrice();
  }
}
