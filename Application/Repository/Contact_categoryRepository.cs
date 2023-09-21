using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Contact_categoryRepository : GenericRepositoryA<Contact_category>, IContact_categoryRepository{
    public Contact_categoryRepository(PharmacyContex context) : base(context){}

   

}