using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class UserRepository : GenericRepositoryA<User>, IUserRepository{
    public UserRepository(PharmacyContex context) : base(context){}

    public async Task<User> GetUserByName(string name)=> await FindFisrtAsync(x => x.Username == name);

    public override async Task<User> FindFisrtAsync(Expression<Func<User, bool>> expression)
    =>await _Entity.Include(x => x.Rol).Where(expression).FirstOrDefaultAsync();

}