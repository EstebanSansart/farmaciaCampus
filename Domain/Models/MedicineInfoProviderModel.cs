namespace Domain.Models;
public class MedicineInfoProviderModel{
    public string ProviderName { get; set; } = null;
    public DateTime? InitialDate { get; set; } = null;
    public DateTime? FinalDate { get; set; } = null;
    public bool HasCoincidence  { get; set; } = true;
}

