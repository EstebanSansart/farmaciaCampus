using Domain.Entities.Generics;

namespace Domain.Entities;

public class Departament : BaseEntityA
{
    public string  Name {get;set;}

    public int  Id_country {get;set;}
    public Country Country {get;set;}
    
    public ICollection<City> Cities {get;set;}
}
