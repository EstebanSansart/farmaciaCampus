using Domain.Entities.Generics;

namespace Domain.Entities;

public class Detail_buy : BaseEntityA
{
  public int MedicineId { get; set; }
  public Medicine Medicine { get; set; }

  public int Buy_Id { get; set; }
  public Buy Buys { get; set; }
}