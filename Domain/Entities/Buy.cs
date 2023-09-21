using Domain.Entities.Generics;

namespace Domain.Entities;

public class Buy : BaseEntityA
{
    public DateTime Fech_buy {get;set;}
    public int  Id_supplier {get;set;}
    public int  Id_employee {get;set;}
}
