using Domain.Entities.Generics;

namespace Domain.Entities;

public class Type_person : BaseEntityA
{
    public string Description {get;set;}
    ICollection<Person> People {get;set;}
    
}
