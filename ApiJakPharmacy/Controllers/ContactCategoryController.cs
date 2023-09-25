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
public class ContactCategoryController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public ContactCategoryController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<ContactCategoryDto>> Get(){
       var records = await _UnitOfWork.Contact_Categories.GetAllAsync();
       return _Mapper.Map<List<ContactCategoryDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ContactCategoryFullDto>> Get(int id){
       var record = await _UnitOfWork.Contact_Categories.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<ContactCategoryFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<ContactCategoryDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Contact_Categories.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<ContactCategoryDto>>(records);
       IPager<ContactCategoryDto> pager = new Pager<ContactCategoryDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ContactCategoryDto>> Post(ContactCategoryDto recordDto){
       var record = _Mapper.Map<Contact_category>(recordDto);
       _UnitOfWork.Contact_Categories.Add(record);
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
    public async Task<ActionResult<ContactCategoryDto>> Put(int id, [FromBody]ContactCategoryDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Contact_category>(recordDto);
       record.Id = id;
       _UnitOfWork.Contact_Categories.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Contact_Categories.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Contact_Categories.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}