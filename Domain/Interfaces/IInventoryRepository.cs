using Domain.Entities;
using Domain.Interfaces.Generics;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;

public interface IInventoryRepository : IGenericRepositoryA<Inventory>
{
   public  Task<IEnumerable<Inventory>> GetMedicinaStockMenos50();
}


