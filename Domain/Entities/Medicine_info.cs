using Domain.Entities.Generics;

namespace Domain.Entities;

public class Medicine_info : BaseEntityA
{
    public string  Name {get;set;}
    public string  Description {get;set;}
    public int  Price {get;set;}
    public int  Discount {get;set;}
    public string Image { get; set; }
    public bool  Need_order {get;set;}
    
    public int Id_Category {get;set;}
    public Category Category {get;set;}
    public int Id_Presentation {get;set;}
    public Presentation Presentation {get;set;}
    public int Id_MedicineBrand {get;set;}
    public Medicine_brand Medicine_brand {get;set;}
    
    public ICollection<Inventory> Inventories {get;set;}


} 
