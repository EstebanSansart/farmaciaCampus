using Domain.Entities;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;

public interface ISaleRepository : IGenericRepositoryA<Sale>
{
    public Task<IEnumerable<object>> GetSalesByEmploye();
    Task<double> GetPromedioVenta();
    
}
