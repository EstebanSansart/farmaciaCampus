using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

public sealed class InventoryRepository : GenericRepositoryA<Inventory>, IInventoryRepository{

    private readonly PharmacyContext _context;
    public InventoryRepository(PharmacyContext context) : base(context){
         _context = context;     
    }
          protected override async Task<IEnumerable<Inventory>> GetAll(Expression<Func<Inventory, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Medicine_info)        
                .Include(x => x.Medicines)        
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Medicine_info)        
                .Include(x => x.Medicines)        
            .ToListAsync();
    }



    public async Task<IEnumerable<Inventory>> GetMedicinaStockMenos50() =>
                    await _context.Inventories
                    .Join(_context.Medicines, h => h.Id, m => m.Id,
                        (h, m) => new Inventory
                        {
                            Name_medicine = m.Name_medicine,
                            Total_stock = h.Total_stock
                        })
                    .Where(h => h.Total_stock < 50)
                    .ToListAsync();
                    


}