using Domain.Entities.Generics;

namespace Domain.Entities;

public class Medicine : BaseEntityA
{
    public DateTime  Date_creation {get;set;}
    public DateTime  Date_expiration {get;set;}
    public string Name_medicine {get;set;}
    
    public int  Id_Inventory {get;set;}
    public Inventory Inventory {get;set;}
    public int  Id_state {get;set;}
    public State State {get;set;}

    public ICollection<Sale> Sales {get; set;} = new HashSet<Sale>();
    public ICollection<Detail_sale> Detail_Sales {get;set;}
    public ICollection<Buy> Buys {get; set;} = new HashSet<Buy>();
    public ICollection<Detail_buy> Detail_Buys {get;set;}


    
}
