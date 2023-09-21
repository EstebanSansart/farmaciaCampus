using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class PostRepository : GenericRepositoryA<Post>, IPostRepository{
    public PostRepository(PharmacyContex context) : base(context){}

   

}