using IntiveFDV_DevExercise.Model;

namespace IntiveFDV_DevExercise
{
  public static class RentFactory
  {

    public static IRent CreateInstance(TypeRent typeRent)
    {
      IRent instance = null;
      switch (typeRent)
      {
        case TypeRent.Hour:
          instance = RentHour.GetInstance();
          break;
        case TypeRent.Day:
          instance = RentDay.GetInstance();
          break;
        case TypeRent.Week:
          instance = RentWeek.GetInstance();
          break;
      }
      return instance;
    }
  }

  public enum TypeRent
  {
    Hour,
    Day,
    Week
  }
}
