using Domain.Entities.Generics;

namespace Domain.Entities;

public class Medicine : BaseEntityA
{
    public DateTime  Date_creation {get;set;}
    public DateTime  Date_expiration {get;set;}
    public int  Id_fech_expiration {get;set;}
    
    public int  Id_medicine_info {get;set;}
    public Medicine_info Medicine_Info {get;set;}

    public int  Id_estate {get;set;}
    public State State {get;set;}

    ICollection<Detail_sale> Detail_Sales {get;set;}
    ICollection<Detail_buy> Detail_Buys {get;set;}


    
}
