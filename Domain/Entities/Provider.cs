using Domain.Entities.Generics;

namespace Domain.Entities;

public class Provider : BaseEntityA
{
    public int Id_type_Provider {get;set;}
    public Type_provider Type_Provider {get;set;}

    public int Id_person {get;set;}
    public Person Person {get;set;}

    ICollection<Buy> Buys {get;set;}
}
