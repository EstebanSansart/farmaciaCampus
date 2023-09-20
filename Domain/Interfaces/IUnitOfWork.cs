using Domain.Entities;

namespace Domain.Interfaces;
public interface IUnitOfWork{
    IRolRepository Rols { get; }    
    IUserRepository Users { get; }
    Task<int> SaveChanges();
}