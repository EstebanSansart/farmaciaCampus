using Domain.Entities.Generics;

namespace Domain.Entities;

public class Person : BaseEntityA
{
    public string Name {get;set;}
    public string Register_date {get;set;}
    public DateTime  Birth_date {get;set;}

}
