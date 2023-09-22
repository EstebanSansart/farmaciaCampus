using Domain.Entities.Generics;

namespace Domain.Entities;

public class Eps : BaseEntityA
{
    //Entidad Prestadora de Servicios
    public int Id_typo_eps {get;set;}

    public Type_eps Type_Eps {get;set;}
    public Person Person {get;set;}

    public ICollection<Employee_eps> Employee_Eps {get;set;}
}
