namespace Domain.Entities.Generics;

public class Medicine_info : BaseEntityA
{
    public string  Name {get;set;}
    public string  Description {get;set;}
    public int  Price {get;set;}
    public string  Discount {get;set;}
    public bool  Need_prescription {get;set;}
    public int  Id_medicine_name {get;set;}

    public Category Categories {get;set;}
    public Presentation Presentations {get;set;}

    public int  Id_medicine_brand {get;set;}
    public Medicine_brand Medicine_brands {get;set;}
    
    public ICollection<Medicine> Medicines {get;set;}
    public ICollection<Inventory> Inventories {get;set;}


} 
