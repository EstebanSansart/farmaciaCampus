using Domain.Entities.Generics;

namespace Domain.Entities;
public class Role: BaseEntityA
{
    public string Description { get; set; } = String.Empty;
    public IEnumerable<User> Users { get; set; } = new HashSet<User>();
    public ICollection<Role_user> Role_Users {get;set;}
}