using Domain.Entities.Generics;

namespace Domain.Entities;

public class Provider: BaseEntityA {
  public int ProviderTypeId { get; set; }
  public Type_provider Type_Provider { get; set; }

  public int PersonId { get; set; }
  public Person Person { get; set; }

  public ICollection<Buy> Buys {get; set;}

}