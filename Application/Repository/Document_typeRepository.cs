using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Document_typeRepository : GenericRepositoryA<Document_type>, IDocument_typeRepository{
    public Document_typeRepository(PharmacyContext context) : base(context){}

    protected override async Task<IEnumerable<Document_type>> GetAll(Expression<Func<Document_type, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Persons)                                
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Persons)                        
            .ToListAsync();
    }

}