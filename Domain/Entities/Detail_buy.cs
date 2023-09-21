using Domain.Entities.Generics;

namespace Domain.Entities;

public class Detail_buy : BaseEntityA
{
    public int  Id_medicine {get;set;}
    public Medicine Medicine {get;set;}
    
    public int  Id_bill {get;set;}

    public Buy Buy {get;set;}
}
