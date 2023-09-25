using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class DepartmentRepository : GenericRepositoryA<Department>, IDepartmentRepository{
    public DepartmentRepository(PharmacyContext context) : base(context){}

   

}