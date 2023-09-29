using ApiJakPharmacy.Controllers;
using ApiJakPharmacy.Dtos;
using AutoMapper;
using Domain.Entities;
using ApiJakPharmacy.Helpers;
using Domain.Interfaces.Params;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ApiJakPharmacy.Dtos.MedicineDtos;

namespace ApiJakPharmacy.Controllers;
[ApiVersion("1.0")]
[ApiVersion("1.1")]
[ApiVersion("1.2")]
[ApiVersion("1.3")]


public class InventoryController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public InventoryController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<InventoryDto>> Get(){
       var records = await _UnitOfWork.Inventories.GetAllAsync();
       return _Mapper.Map<List<InventoryDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<InventoryFullDto>> Get(int id){
       var record = await _UnitOfWork.Inventories.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<InventoryFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<InventoryDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Inventories.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<InventoryDto>>(records);
       IPager<InventoryDto> pager = new Pager<InventoryDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<InventoryDto>> Post(InventoryDto recordDto){
       var record = _Mapper.Map<Inventory>(recordDto);
       _UnitOfWork.Inventories.Add(record);
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
    public async Task<ActionResult<InventoryDto>> Put(int id, [FromBody]InventoryDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Inventory>(recordDto);
       record.Id = id;
       _UnitOfWork.Inventories.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Inventories.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Inventories.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }

    

[HttpGet]
[MapToApiVersion("1.2")]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
public async Task<ActionResult<IEnumerable<Inventory>>> GetMedicinaStockMenos50()
{
        try
        {
        var medicinesWithStockLessThan50 = await _UnitOfWork.Inventories.GetMedicinaStockMenos50();
        var medicineDtos = _Mapper.Map<List<InventoryDto>>(medicinesWithStockLessThan50);
        return Ok(medicineDtos);
    }
    catch (Exception)
        {
        return BadRequest();
    }
}





    
}


