using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class CityRepository : GenericRepositoryA<City>, ICityRepository{
    public CityRepository(PharmacyContex context) : base(context){}

   

}