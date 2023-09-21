using Domain.Entities.Generics;
using iText.StyledXmlParser.Css.Validate.Impl.Datatype;

namespace Domain.Entities;

public class Person : BaseEntityA
{
    public string Name {get;set;}
    public string Register_date {get;set;}
    public DateTime  Birth_date {get;set;}

    public Employee Employee {get;set;}
    public Type_person Type_Person {get;set;}
    public Document_type Document_type {get;set;}


   public ICollection<Contact> Contacts {get;set;}
   public ICollection<Address> Addresses {get;set;}
   public ICollection<User> Users {get;set;}
   public ICollection<Eps> Epss {get;set;}
   public ICollection<Provider> Providers {get;set;}

    
    

}
