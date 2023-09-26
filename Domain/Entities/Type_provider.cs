using Domain.Entities.Generics;

namespace Domain.Entities;

public class Type_provider : BaseEntityA {
  public string Name { get; set; }

  public ICollection<Provider> Providers { get; set; }
}