using ApiJakPharmacy.Controllers;
using ApiJakPharmacy.Dtos;
using ApiJakPharmacy.Services;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApiJakPharmacy.Controllers;
public class AuthController:BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly ILogger<AuthController> _Logger;
    private readonly ITokenManager _TokenManager;
    

    public AuthController(
            IConfiguration conf, 
            IUnitOfWork unitOfWork,       
            IPasswordHasher<User> PasswordHasher,
            ILogger<AuthController> logger
    ){
        _Logger = logger;
        _UnitOfWork = unitOfWork;        
        _TokenManager = new TokenManager(PasswordHasher,conf);
    }
    
    [HttpPost("register")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> RegisterAsync(UserSignup model){        
        var user = _TokenManager.CreateUser(model);

        var existingUser = await _UnitOfWork.Users.GetUserByName(model.Username!);
        if (existingUser != null){
            return BadRequest($"El usuario {model.Username} ya se encuentra registrado.");
        }
        
        var defaultRol =  (await _UnitOfWork.Rols.GetRolByRoleName( Rols.Employee ))!;        
        try{
            user.Rol = defaultRol;
            _UnitOfWork.Users.Add(user);
            await _UnitOfWork.SaveChanges();
            return Ok($"El usuario  {model.Username} ha sido registrado exitosamente");

        }catch(Exception ex){
            _Logger.LogCritical($"Error: {ex.Message}");
            return StatusCode(StatusCodes.Status500InternalServerError,"Some Wrong");
        }
        
    }

    [HttpPost("Token")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> GetTokenAsync(UserLoggin model){
        TokenResponse userData = new(){IsAuthenticated = false,};
 
        User user = await _UnitOfWork.Users.GetUserByName(model.Username!);

        //-Validate User
        if (user == null){//-Validar existencia            
            userData.Message = $"No existe ningún usuario con el username {model.Username}.";
            return BadRequest(userData);                    

        }else if(!_TokenManager.ValidatePassword(user, model.Password!)){//-Validar Credenciales

            userData.Message =  $"Credenciales incorrectas para el usuario {model.Username}.";;
            return BadRequest(userData);
        }
        
        //-Create Response menssage
        userData.Message = "Ok";
        userData.IsAuthenticated = true;
        userData.Username = user.UserName;
        userData.Email = user.Email!;
        userData.AccessToken = _TokenManager.CreateAccessToken(user);
        userData.RefreshToken = _TokenManager.CreateRefreshToken();

        //-Save changes
        user.AccessToken = userData.AccessToken;
        user.RefreshToken = userData.RefreshToken;

        _UnitOfWork.Users.Update(user);
        await _UnitOfWork.SaveChanges();

        //-Return response
        return Ok(userData);
    }

    [HttpPost("changeRol")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> ChangeRolAsync(AddRole model){
        User user;
        try{
            string token = HttpContext.Request.Headers["Authorization"].FirstOrDefault() ?? throw new Exception("Invalid Token");                            
            //-Obtener usuario                        
            user = await _UnitOfWork.Users.GetUserByName(model.Username!);

            //-Valida usuario
            if (user == null){throw new Exception($"No existe el usuario.");}
            if(token != "Bearer " + user.AccessToken){throw new Exception($"Invalid Token.");}
        
        }catch (Exception ex){
            _Logger.LogError(ex.Message);

            return StatusCode(
                StatusCodes.Status500InternalServerError,
                "some Wrong"
            );
        }        
        //-Obtener rol solicitado
        Rol  existingRol = await _UnitOfWork.Rols.GetRolByRoleName(model.RoleName);
        if (existingRol == null){//-Validar rol
            return BadRequest($"Rol {model.RoleName} agregado a la cuenta {user.UserName} de forma exitosa.");
        }
                
        //-Agregar nuevo rol
        if (user.Rol == existingRol){
            user.Rol = existingRol;
            _UnitOfWork.Users.Update(user);
            await _UnitOfWork.SaveChanges();
        }

        //-Retornar respuesta
        return Ok($"Rol {model.RoleName} agregado a la cuenta {user.UserName} de forma exitosa.");               
    }

    [HttpPost("refresh/{username}")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> RefreshToken(string username){        
        //-Obtener token
        string token = HttpContext.Request.Headers["Authorization"].FirstOrDefault() ?? throw new Exception("Invalid Token");
        User user = await _UnitOfWork.Users.GetUserByName(username);

        if(user == null ){return BadRequest("User not found");}

        else if("Bearer " + user.RefreshToken != token){return BadRequest("refresh token invalid");}

        return Ok(new {
            username = user.UserName,
            AccessToken = _TokenManager.CreateAccessToken(user),
            refreshToken = token
        });

    }
}