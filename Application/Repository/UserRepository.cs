using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain.Interfaces;

namespace Application.Repository;
public sealed class UserRepository : GenericRepositoryA<User>, IUserRepository{
    public UserRepository(PharmacyContext context) : base(context){}

  public async Task<User> GetUserByName(string name)=> await FindFirst(x => x.UserName == name);
    protected override bool PaginateExpression(User entity, string search){
        return entity.UserName.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<User>> GetAll(Expression<Func<User, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Roles)
                .Include(x => x.Person)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Roles)
            .Include(x => x.Person)
            .ToListAsync();
    }
}