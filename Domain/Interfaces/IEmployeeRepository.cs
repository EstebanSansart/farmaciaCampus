using Domain.Entities;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;

public interface IEmployeeRepository : IGenericRepositoryA<Employee>
{
   // Task<IEnumerable<object>> GetEmployeSale();
}
