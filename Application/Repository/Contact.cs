using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class ContactRepository : GenericRepositoryA<Contact>, IContactRepository{
    public ContactRepository(PharmacyContext context) : base(context){}

   

}