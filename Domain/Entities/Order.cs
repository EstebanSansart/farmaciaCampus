using Domain.Entities.Generics;

namespace Domain.Entities;

public class Order : BaseEntityA
{
    public string Code {get;set;}
    public DateTime  Date {get;set;}
    public string  Detail {get;set;}
    public DateTime  Date_expiration {get;set;}
    public int  Id_venta {get;set;}
    
    
}
