using Domain.Entities.Generics;

namespace Domain.Entities;

public class Type_eps : BaseEntityA
{
    public string Name {get;set;}
    ICollection<Eps> Epss {get;set;}

}
