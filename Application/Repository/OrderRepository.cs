using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class OrderRepository : GenericRepositoryA<Order>, IOrderRepository{
    private readonly PharmacyContext _context;
    public OrderRepository(PharmacyContext context) : base(context){

        _context = context;
    }

          public async Task<IEnumerable<Order>> GetAfterDateJanuary()
        {
            DateTime january1st2023 = new DateTime(2023, 1, 1);

            return await Task.FromResult(_Entities
                .Where(order => order.Order_Date > january1st2023)
                .AsEnumerable());
        }
}