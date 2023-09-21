using Domain.Entities.Generics;

namespace Domain.Entities;

public class Sale : BaseEntityA
{
    public DateTime Fecha_venta {get;set;}
    public int Id_person {get;set;}
    
}
