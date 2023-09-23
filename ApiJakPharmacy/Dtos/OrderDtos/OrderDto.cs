using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class OrderDto{
    
    [Required]
    public DateTime OrderDate { get; set; }
    [Required]
    public DateTime ExpirationDate { get; set; }
    [Required]
    public string Detail { get; set; }
    [Required]
    public int SaleId { get; set; }
    [Required]
    public int EpsId { get; set; }

}