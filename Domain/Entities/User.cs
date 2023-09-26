using Domain.Entities.Generics;

namespace Domain.Entities;
public class User: BaseEntityA{

    public string UserName { get; set; } 
    public string Password { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string AccessToken { get; set; } = String.Empty;
    public string RefreshToken { get; set; } = String.Empty;


    public int PersonId { get; set; }
    public Person Person {get; set; }

    public ICollection<Role> Roles { get; set; } = new HashSet<Role>();
    public ICollection<Role_user> Role_users { get; set; } 
}