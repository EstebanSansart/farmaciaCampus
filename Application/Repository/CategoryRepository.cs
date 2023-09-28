using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class CategoryRepository : GenericRepositoryA<Category>, ICategoryRepository{
    public CategoryRepository(PharmacyContext context) : base(context){}

       protected override async Task<IEnumerable<Category>> GetAll(Expression<Func<Category, bool>> expression = null)
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