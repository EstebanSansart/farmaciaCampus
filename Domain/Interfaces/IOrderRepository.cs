using Domain.Entities;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;

public interface IOrderRepository : IGenericRepositoryA<Order>
{
    public Task<IEnumerable<Order>> GetAfterDateJanuary();
}

