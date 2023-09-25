using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Document_typeRepository : GenericRepositoryA<Document_type>, IDocument_typeRepository{
    public Document_typeRepository(PharmacyContext context) : base(context){}

   

}