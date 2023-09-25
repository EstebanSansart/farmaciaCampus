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
public class PresentationController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public PresentationController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<PresentationDto>> Get(){
       var records = await _UnitOfWork.Presentations.GetAllAsync();
       return _Mapper.Map<List<PresentationDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PresentationFullDto>> Get(int id){
       var record = await _UnitOfWork.Presentations.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<PresentationFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<PresentationDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Presentations.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<PresentationDto>>(records);
       IPager<PresentationDto> pager = new Pager<PresentationDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PresentationDto>> Post(PresentationDto recordDto){
       var record = _Mapper.Map<Presentation>(recordDto);
       _UnitOfWork.Presentations.Add(record);
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
    public async Task<ActionResult<PresentationDto>> Put(int id, [FromBody]PresentationDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Presentation>(recordDto);
       record.Id = id;
       _UnitOfWork.Presentations.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Presentations.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Presentations.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}