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
public class TypeProviderController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public TypeProviderController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<ProviderTypeDto>> Get(){
       var records = await _UnitOfWork.Type_Providers.GetAllAsync();
       return _Mapper.Map<List<ProviderTypeDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProviderTypeFullDto>> Get(int id){
       var record = await _UnitOfWork.Type_Providers.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<ProviderTypeFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<ProviderTypeDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Type_Providers.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<ProviderTypeDto>>(records);
       IPager<ProviderTypeDto> pager = new Pager<ProviderTypeDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProviderTypeDto>> Post(ProviderTypeDto recordDto){
       var record = _Mapper.Map<Type_provider>(recordDto);
       _UnitOfWork.Type_Providers.Add(record);
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
    public async Task<ActionResult<ProviderTypeDto>> Put(int id, [FromBody]ProviderTypeDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Type_provider>(recordDto);
       record.Id = id;
       _UnitOfWork.Type_Providers.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Type_Providers.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Type_Providers.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}