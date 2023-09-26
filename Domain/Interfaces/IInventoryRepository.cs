using Domain.Entities;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;

public interface IInventoryRepository : IGenericRepositoryA<Inventory>
{
    Task<IEnumerable<Medicine>> GetMedicinaStockMenos50();
}


