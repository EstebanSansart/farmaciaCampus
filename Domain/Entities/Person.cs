using Domain.Entities.Generics;
using iText.StyledXmlParser.Css.Validate.Impl.Datatype;

namespace Domain.Entities;

public class Person : BaseEntityA
{
    public string Name {get;set;}
    public DateTime Register_date {get;set;}
    public DateTime  Birth_date {get;set;}

    public int Id_Type_Person {get;set;}
    public Type_person Type_Person {get;set;}
    public int Id_Document_type {get; set;}
    public Document_type Document_type {get;set;}

    public ICollection<Contact> Contacts {get;set;}
    public ICollection<Address> Addresses {get;set;}
    public ICollection<User> Users {get;set;}
    public ICollection<Sale> Sales {get;set;}
    public ICollection<Employee> Employees {get;set;}
    public ICollection<Provider> Providers {get;set;}
    public ICollection<Eps> Epss {get;set;}
}
