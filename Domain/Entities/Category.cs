using Domain.Entities.Generics;

namespace Domain.Entities;

public class Category : BaseEntityA
{
    public string  Name {get;set;}
    
    ICollection<Medicine_info> Medicine_Infos {get;set;}
}
