using Domain.Entities.Generics;

namespace Domain.Entities;
public class Rol: BaseEntityA
{
    public string Description { get; set; } = String.Empty;

    public IEnumerable<User> Users { get; set; } = new HashSet<User>();
    ICollection<Role_user> Role_Users {get;set;}
}