using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class EmployeRepository : GenericRepositoryA<Employee>, IEmployeeRepository{
    public EmployeRepository(PharmacyContex context) : base(context){}

   

}