using Domain.Entities;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;

public interface IProviderRepository : IGenericRepositoryA<Provider>
{
   // Task<IEnumerable<Provider>> GetTotalStockPurchasedByProvider();
}
