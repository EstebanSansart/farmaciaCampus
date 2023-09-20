using Application.Repositories;
using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public sealed class UnitOfWork : IUnitOfWork, IDisposable{
    private readonly PharmacyContex _Context;
    //-Repositories
    private IRolRepository _Role;
    private IUserRepository _User;

    public UnitOfWork(PharmacyContex context)=>_Context = context;

    //-Singletons
    public IRolRepository Rols => _Role ??= _Role = new RolRepository(_Context);
    public IUserRepository Users => _User ??= _User = new UserRepository(_Context);

    //-Other Properties
    public void Dispose()=> _Context.Dispose();
    public async Task<int> SaveChanges()=> await _Context.SaveChangesAsync();
}
