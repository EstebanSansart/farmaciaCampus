namespace Domain.Models;
public class ProfitsPerProviderModel{
    public string ProviderName { get; set; } = null;
    public DateTime? InitialDate { get; set; } = null;
    public DateTime? FinalDate { get; set; } = null;    
}