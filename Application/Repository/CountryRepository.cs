using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class CountryRepository : GenericRepositoryA<Country>, ICountryRepository{
    public CountryRepository(PharmacyContex context) : base(context){}

   

}