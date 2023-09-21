using Domain.Entities.Generics;

namespace Domain.Entities;

public class Buy : BaseEntityA
{
    public DateTime Fech_buy {get;set;}

    public int  Id_provider {get;set;}
    public Provider Provider {get;set;}

    public int  Id_employee {get;set;}
    public Employee Employee {get;set;}
    
    public  ICollection<Detail_buy> Detail_Buys {get;set;}
}
