using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class RoleRepository : GenericRepositoryA<Role>, IRoleRepository
{
    public RoleRepository(PharmacyContext context) : base(context){}

   public async Task<Role> GetRoleByRoleName(UserRoles role)=> await FindFirst(x => x.Description == role.ToString());

    public async Task<Role> GetRoleByRoleName(string role) => await FindFirst(x => x.Description == role);
    protected override bool PaginateExpression(Role entity, string search){
        return entity.Description.Trim().StartsWith(search);
    }

    protected override async Task<IEnumerable<Role>> GetAll(Expression<Func<Role, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Users)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Users)
            .ToListAsync();
    }
}