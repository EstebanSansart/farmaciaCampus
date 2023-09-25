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
public class DocumentTypeController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public DocumentTypeController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<DocumentTypeDto>> Get(){
       var records = await _UnitOfWork.Document_Types.GetAllAsync();
       return _Mapper.Map<List<DocumentTypeDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<DocumentTypeFullDto>> Get(int id){
       var record = await _UnitOfWork.Document_Types.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<DocumentTypeFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<DocumentTypeDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Document_Types.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<DocumentTypeDto>>(records);
       IPager<DocumentTypeDto> pager = new Pager<DocumentTypeDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<DocumentTypeDto>> Post(DocumentTypeDto recordDto){
       var record = _Mapper.Map<Document_type>(recordDto);
       _UnitOfWork.Document_Types.Add(record);
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
    public async Task<ActionResult<DocumentTypeDto>> Put(int id, [FromBody]DocumentTypeDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Document_type>(recordDto);
       record.Id = id;
       _UnitOfWork.Document_Types.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Document_Types.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Document_Types.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}