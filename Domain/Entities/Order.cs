using Domain.Entities.Generics;

namespace Domain.Entities;

public class Order : BaseEntityA
{
    public DateTime  Order_Date {get;set;}
    public string  Detail {get;set;}
    public DateTime  Date_expiration {get;set;}

    public int Id_sale {get;set;}
    public Sale Sale {get;set;}
    
    public int EpsId { get; set; }
    public Eps Eps { get; set; }
    
    
    
}
