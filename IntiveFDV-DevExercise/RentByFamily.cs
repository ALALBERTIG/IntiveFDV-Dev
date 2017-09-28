using System.Collections.Generic;
using System.Linq;
using IntiveFDV_DevExercise.Model;

namespace IntiveFDV_DevExercise
{
  public class RentByFamily
  {
    public IList<IRent> Rents { get; set; }
    
    public RentByFamily()
    {
      Rents = new List<IRent>();
    }

    public double GetPrice()
    {
      double priceToPay = 0;
      priceToPay = Rents.Count() > 0 ? Rents.Sum(x => x.GetPrice()) : 0;
      if (Rents.Count() >= 3 && Rents.Count() <= 5)
        return GetDiscount(priceToPay);
      else
        return priceToPay;
    }

    public void AddRent(TypeRent rent)
    {
      Rents.Add(RentFactory.CreateInstance(rent));
    }

    /// <summary>
    /// Determine if any discount if apply to price
    /// </summary>
    /// <param name="priceToPay">Total price of the rents</param>
    /// <returns></returns>
    private double GetDiscount(double priceToPay)
    {
      double newPrice = priceToPay;
      //Percent of discount applied to Family Rental
      double percentDiscount = 30;
      double discount = priceToPay * percentDiscount / 100;
      newPrice = priceToPay - discount;
      return newPrice;
    }
  }
}
