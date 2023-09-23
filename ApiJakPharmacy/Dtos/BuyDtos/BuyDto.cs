using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class BuyDto{

    [Required]
    public DateTime BuyDate { get; set; }
    [Required]
    public int ProviderId { get; set; }
    [Required]
    public int EmployeeId { get; set; }
}