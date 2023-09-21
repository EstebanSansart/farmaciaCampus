using Domain.Entities.Generics;

namespace Domain.Entities;

public class Medicine : BaseEntityA
{
    public DateTime  Fech_creation {get;set;}
    public DateTime  Fech_expiration {get;set;}
    public int  Id_fech_expiration {get;set;}
    public int  Id_medicine_info {get;set;}
    public int  Id_estate {get;set;}

    
}
