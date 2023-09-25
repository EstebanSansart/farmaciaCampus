using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class EmployeeRepository : GenericRepositoryA<Employee>, IEmployeeRepository{
    public EmployeeRepository(PharmacyContext context) : base(context){}

   

}