using Domain.Entities.Generics;

namespace Domain.Entities;

public class Contact_Type : BaseEntityA
{
    public string Name {get;set;}
    
    public ICollection<Contact> Contacts {get;set;}
}
