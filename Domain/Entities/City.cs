using Domain.Entities.Generics;

namespace Domain.Entities;

public class City : BaseEntityA
{
    public string  Name {get;set;}

    public int  Id_departament {get;set;}
    public Departament Departament {get;set;}
    
    public ICollection<Address> Addresses {get;set;}
}