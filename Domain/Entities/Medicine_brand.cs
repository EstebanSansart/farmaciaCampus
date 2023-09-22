namespace Domain.Entities.Generics;

public class Medicine_brand : BaseEntityA
{
    public string  Name {get;set;}
    public ICollection<Medicine_info> Medicine_Infos {get;set;}
}