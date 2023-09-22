namespace Domain.Entities.Generics;

public class Medicine_info : BaseEntityA
{
    public string  Name {get;set;}
    public string  Description {get;set;}
    public int  Price {get;set;}
    public byte  Discount {get;set;}
    public string  Img {get;set;}
    public bool  Need_prescription {get;set;}
    public int  Id_medicine_name {get;set;}

    public Category Category {get;set;}
    public Presentation Presentation {get;set;}

    public int  Id_medicine_brand {get;set;}
    public Medicine_brand Medicine_Brand {get;set;}
    
    public ICollection<Medicine> Medicines {get;set;}
    public ICollection<Inventory> Inventories {get;set;}


}
