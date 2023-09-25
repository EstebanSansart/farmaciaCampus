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
public class CategoryController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public CategoryController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<CategoryDto>> Get(){
       var records = await _UnitOfWork.Categories.GetAllAsync();
       return _Mapper.Map<List<CategoryDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoryFullDto>> Get(int id){
       var record = await _UnitOfWork.Categories.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<CategoryFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<CategoryDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Categories.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<CategoryDto>>(records);
       IPager<CategoryDto> pager = new Pager<CategoryDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoryDto>> Post(CategoryDto recordDto){
       var record = _Mapper.Map<Category>(recordDto);
       _UnitOfWork.Categories.Add(record);
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
    public async Task<ActionResult<CategoryDto>> Put(int id, [FromBody]CategoryDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Category>(recordDto);
       record.Id = id;
       _UnitOfWork.Categories.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Categories.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Categories.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}