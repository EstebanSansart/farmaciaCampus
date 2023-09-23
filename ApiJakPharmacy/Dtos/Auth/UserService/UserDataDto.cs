namespace ApiJakPharmacy.Dtos;
public class UserDataDto{
    public string Username { get; set; }
    public bool IsAuthenticated { get; set; }
    public string Message { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
}