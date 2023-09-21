using Domain.Entities.Generics;

namespace Domain.Entities;

public class Inventory : BaseEntityA
{
    public int  Ubication {get;set;}
    public int  stock_total {get;set;}
    public int  Id_medicine_info{get;set;}
}
