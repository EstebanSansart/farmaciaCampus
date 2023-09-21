using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class InventoryRepository : GenericRepositoryA<Inventory>, IInventoryRepository{
    public InventoryRepository(PharmacyContex context) : base(context){}


}