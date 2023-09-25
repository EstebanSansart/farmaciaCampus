using Domain.Entities.Generics;

namespace Domain.Entities;

public class Eps : BaseEntityA
{
    //Entidad Prestadora de Servicios
    public int Id_type_eps {get;set;}
    public Type_eps Type_Eps { get; set; }

    

    public ICollection<Person> Persons {get; set;}
    public ICollection<Order> Orders {get; set;}
    public ICollection<Employee> Employees {get; set;} = new HashSet<Employee>();
    public ICollection<Employee_eps> Employee_Epss {get;set;}
}
