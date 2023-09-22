using Domain.Entities.Generics;

namespace Domain.Entities;

public class Type_eps : BaseEntityA
{
    public string Name {get;set;}
    public ICollection<Eps> Epss {get;set;}

}
