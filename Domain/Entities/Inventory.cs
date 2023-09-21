using Domain.Entities.Generics;

namespace Domain.Entities;

public class Inventory : BaseEntityA
{
    public int Ubication {get;set;}
    public int Stock_total {get;set;}

    public int Id_medicine_info{get;set;}
    public Medicine_info Medicine_Info {get;set;}
}
