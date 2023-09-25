using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class CategoryRepository : GenericRepositoryA<Category>, ICategoryRepository{
    public CategoryRepository(PharmacyContext context) : base(context){}

   

}