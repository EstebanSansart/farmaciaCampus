using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class OrderFullDto : OrderDto{

    [Required]
    public int Id { get; set; }
}