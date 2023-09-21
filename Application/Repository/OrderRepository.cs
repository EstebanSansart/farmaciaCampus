using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class OrderRepository : GenericRepositoryA<Order>, IOrderRepository{
    public OrderRepository(PharmacyContex context) : base(context){}

   

}