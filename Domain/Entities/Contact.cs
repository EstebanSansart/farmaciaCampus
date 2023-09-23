using Domain.Entities.Generics;
using iText.Kernel.Crypto.Securityhandler;

namespace Domain.Entities;

public class Contact : BaseEntityA
{
    public string Description {get;set;}
    
    public int Id_person {get;set;}
    public Person Person {get;set;}
    
    public int Id_contact_type {get;set;}   
    public Contact_Type Contact_Type {get;set;} 

    public int Id_contact_category {get;set;}
    public Contact_category Contact_Categories {get;set;}
}
