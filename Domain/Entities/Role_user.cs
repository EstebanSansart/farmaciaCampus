using Domain.Entities.Generics;

namespace Domain.Entities;

public class Role_user : BaseEntityA
{
    public int Id_user {get;set;}
    public User User {get;set;}

    public int Id_role {get;set;}
    public Role Role {get;set;}
}
