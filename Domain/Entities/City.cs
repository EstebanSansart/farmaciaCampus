using Domain.Entities.Generics;

namespace Domain.Entities;

public class City : BaseEntityA
{
    public string  Name {get;set;}

    public int  Id_department {get;set;}
    public Department Department {get;set;}
    
    public ICollection<Address> Addresses {get;set;}
}