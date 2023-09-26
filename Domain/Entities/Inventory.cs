using Domain.Entities.Generics;

namespace Domain.Entities;

public class Inventory : BaseEntityA
{
    public int Ubication {get;set;}
    public int Total_stock {get;set;}

    public int Id_MedicineInfo {get;set;}
    public Medicine_info Medicine_info {get;set;}

    public ICollection<Medicine> Medicines {get;set;}
}