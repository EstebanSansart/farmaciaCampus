using Domain.Entities.Generics;

namespace Domain.Entities;

public class Address : BaseEntityA
{
    public int Id_City {get;set;}
    public City City {get;set;}
    public string  Description {get;set;}
    public int  Id_person {get;set;}
    public Person Person {get;set;}
}
