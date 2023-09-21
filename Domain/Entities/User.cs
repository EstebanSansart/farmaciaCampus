using Domain.Entities.Generics;

namespace Domain.Entities;

    public class User : BaseEntityA
    {
    public int  Id_person {get;set;}
    public Person Person {get;set;}

    public string Username { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string AccessToken { get; set; } = String.Empty;
    public string RefreshToken { get; set; } = String.Empty;

    public int RolId { get; set; }
    public Rol Rol {get;set;}

    ICollection<Role_user> Role_Users {get;set;}
    }
