using ApiJakPharmacy.Controllers;
using ApiJakPharmacy.Dtos;
using AutoMapper;
using Domain.Entities;
using ApiJakPharmacy.Helpers;
using Domain.Interfaces.Params;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiJakPharmacy.Controllers;
[ApiVersion("1.0")]
public class ProviderController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public ProviderController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<ProviderDto>> Get(){
       var records = await _UnitOfWork.Providers.GetAllAsync();
       return _Mapper.Map<List<ProviderDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProviderFullDto>> Get(int id){
       var record = await _UnitOfWork.Providers.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<ProviderFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<ProviderDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Providers.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<ProviderDto>>(records);
       IPager<ProviderDto> pager = new Pager<ProviderDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProviderDto>> Post(ProviderDto recordDto){
       var record = _Mapper.Map<Provider>(recordDto);
       _UnitOfWork.Providers.Add(record);
       await _UnitOfWork.SaveChanges();
       if (record == null){
           return BadRequest();
       }
       return CreatedAtAction(nameof(Post),new {id= record.Id, recordDto});
    }

    [HttpPut("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProviderDto>> Put(int id, [FromBody]ProviderDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Provider>(recordDto);
       record.Id = id;
       _UnitOfWork.Providers.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Providers.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Providers.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
   /*  [HttpGet]
    [MapToApiVersion("1.2")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<ProviderDto>>> Get13([FromQuery] Params conf)
    {
        var param = new Param(conf);
        var records = await _UnitOfWork.Providers.GetAllAsync(param);
        var recordDtos = _Mapper.Map<List<ProviderDto>>(records);
        IPager<ProviderDto> pager = new Pager<ProviderDto>(recordDtos, records?.Count(), param);

        // Llamar a la función GetTotalStockPurchasedByProviderAsync para obtener el total de stock comprado por proveedor
        var totalStockPurchasedByProvider = await GetTotalStockPurchasedByProvider();
        // Puedes hacer algo con la variable totalStockPurchasedByProvider, como agregarla al pager o devolverla en otro formato.

        return Ok(pager);
    }
    [HttpGet]
    [MapToApiVersion("1.3")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<ProviderDto>>> Get14([FromQuery] Params conf)
    {
        var param = new Param(conf);
        var records = await _UnitOfWork.Providers.GetAllAsync(param);
        var recordDtos = _Mapper.Map<List<ProviderDto>>(records);

        // Llamar a la función GetTotalStockPurchasedByProviderAsync para obtener el total de stock comprado por proveedor
        var totalStockPurchasedByProvider = await GetTotalStockPurchasedByProviderAsync();


        

        // Puedes hacer algo con la variable totalStockPurchasedByProvider, como agregarla al pager o devolverla en otro formato.

        // Convierte totalStockPurchasedByProvider a una lista de ProviderDto si es necesario
        var totalStockPurchasedDto = _Mapper.Map<List<ProviderDto>>(totalStockPurchasedByProvider);

        // Combina los datos de records y totalStockPurchasedDto en un solo objeto o haz lo que necesites con ellos
        // Aquí estoy asumiendo que ProviderDto es la clase que utilizas para representar a los proveedores
        // Puedes ajustar esto según tu estructura de datos y requisitos específicos

        IPager<ProviderDto> pager = new Pager<ProviderDto>(recordDtos, records?.Count(), param);
        return Ok(pager);
    }  */
}