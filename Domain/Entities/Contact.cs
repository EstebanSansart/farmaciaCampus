using Domain.Entities.Generics;

namespace Domain.Entities;

public class Contact : BaseEntityA
{
    public int Id_person {get;set;}
    public int Id_contact_type {get;set;}
    public int Id_contact_category {get;set;}
    public string Dascription {get;set;}
}
