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
public class EmployeeController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public EmployeeController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<EmployeeDto>> Get(){
       var records = await _UnitOfWork.Employees.GetAllAsync();
       return _Mapper.Map<List<EmployeeDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EmployeeFullDto>> Get(int id){
       var record = await _UnitOfWork.Employees.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<EmployeeFullDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<EmployeeDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Employees.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<EmployeeDto>>(records);
       IPager<EmployeeDto> pager = new Pager<EmployeeDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EmployeeDto>> Post(EmployeeDto recordDto){
       var record = _Mapper.Map<Employee>(recordDto);
       _UnitOfWork.Employees.Add(record);
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
    public async Task<ActionResult<EmployeeDto>> Put(int id, [FromBody]EmployeeDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Employee>(recordDto);
       record.Id = id;
       _UnitOfWork.Employees.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Employees.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Employees.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
   /*  
    [HttpGet]
    [MapToApiVersion("1.3")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<EmployeeDto>>> Get13([FromQuery] Params conf)
    {
        var param = new Param(conf);
        var records = await _UnitOfWork.Employees.GetAllAsync(param);
        var recordDtos = _Mapper.Map<List<EmployeeDto>>(records);
        IPager<EmployeeDto> pager = new Pager<EmployeeDto>(recordDtos, records?.Count(), param);

        var EmployeSae = await _UnitOfWork.Employees.GetEmployeSale();

        var response = new
        {
            Pager = pager,
            expiracion = EmployeSae
        };

        return Ok(response);
    } */
}