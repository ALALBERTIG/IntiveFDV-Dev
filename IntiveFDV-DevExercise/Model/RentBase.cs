using System;

namespace IntiveFDV_DevExercise.Model
{
  public abstract class RentBase
  {
    private Guid BaseRentId;
    public double Price { get; set; }
    public DateTime StartRent { get; set; }
    public DateTime EndRent { get; set; }
    public Guid BikeId = Guid.NewGuid();

    public RentBase()
    {
      BaseRentId = Guid.NewGuid();
    }
  }
}
