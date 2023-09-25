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
public class EpsController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public EpsController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<EpsDto>> Get(){
       var records = await _UnitOfWork.Epss.GetAllAsync();
       return _Mapper.Map<List<EpsDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EpsFullDto>> Get(int id){
       var record = await _UnitOfWork.Epss.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<EpsFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<EpsDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Epss.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<EpsDto>>(records);
       IPager<EpsDto> pager = new Pager<EpsDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EpsDto>> Post(EpsDto recordDto){
       var record = _Mapper.Map<Eps>(recordDto);
       _UnitOfWork.Epss.Add(record);
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
    public async Task<ActionResult<EpsDto>> Put(int id, [FromBody]EpsDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Eps>(recordDto);
       record.Id = id;
       _UnitOfWork.Epss.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Epss.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Epss.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}