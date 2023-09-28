using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class PresentationRepository : GenericRepositoryA<Presentation>, IPresentationRepository{
    public PresentationRepository(PharmacyContext context) : base(context){}

   
         protected override async Task<IEnumerable<Presentation>> GetAll(Expression<Func<Presentation, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Medicine_Infos)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Medicine_Infos)
            .ToListAsync();
    }

}