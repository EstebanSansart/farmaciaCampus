using Domain.Entities;
using Domain.Interfaces.Generics.GenericId;
using iText.Html2pdf.Attach.Impl.Tags;

namespace Domain.Interfaces;

public interface IMedicineRepository : IGenericRepositoryA<Medicine>
{
    public Task <IEnumerable<Medicine>> GetProviderA();
    public Task<IEnumerable<object>>  GetProviderMedicineContact();
    
}