using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Contact_typeRepository : GenericRepositoryA<Contact_Type>, IContact_typeRepository{
    public Contact_typeRepository(PharmacyContex context) : base(context){}

   

}