using Domain.Entities.Generics;

namespace Domain.Entities;

public class Detail_sale : BaseEntityA
{
    public int Id_medicine {get;set;}
    public Medicine Medicine {get;set;}
    
    public int Id_sale {get;set;}
    public Sale Sale {get;set;}
}
