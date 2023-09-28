using Domain.Entities;
using Domain.Interfaces.Generics.GenericId;
using iText.Html2pdf.Attach.Impl.Tags;

namespace Domain.Interfaces;

public interface IMedicineRepository : IGenericRepositoryA<Medicine>
{
    Task <IEnumerable<Medicine>> GetProviderA();
    Task<IEnumerable<object>>  GetProviderMedicineContact();    
    Task<IEnumerable<Medicine>> GetMedicinesExpiringBefore2024();
    
}