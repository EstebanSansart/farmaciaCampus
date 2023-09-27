using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class ProviderRepository : GenericRepositoryA<Provider>, IProviderRepository{
    private readonly PharmacyContext _context;
    public ProviderRepository(PharmacyContext context) : base(context){
        _context = context;
    }
/*     public async Task<IEnumerable<Provider>> GetMedicineCountByProviderAsync()
    {
    var query = from provider in _context.Providers
                join Buy in _context.Buys on provider.Id equals buy.Id
                join Detail_buy in _context.Detail_Buys on Buy.Id equals Detail_buy.Id
                join Medicine in _context.Medicines on Detail_buy.MedicineId equals medicine.Id
                group new { provider, Medicine } by new { provider.Id, provider.Name } into g
                select new Provider
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                     = g.Count()
                };

    return await query.ToListAsync();
} */


}