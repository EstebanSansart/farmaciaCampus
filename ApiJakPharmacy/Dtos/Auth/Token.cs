using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class Token{       

    [Required(ErrorMessage = "Es necesario tener iniciada una seccion!")]
    public string RefreshToken { get; set; }   
}