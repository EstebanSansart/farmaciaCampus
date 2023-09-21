using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class DepartamentRepository : GenericRepositoryA<Departament>, IDepartamentRepository{
    public DepartamentRepository(PharmacyContex context) : base(context){}

   

}