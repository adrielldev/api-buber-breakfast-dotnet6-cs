using System;
using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfasts;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("breakfasts")]
public class BreakfastsController : ControllerBase
{
   
    private readonly IBreakfastService _breakfastService;
    
    public BreakfastsController(IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    }
    
    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet
        );

        _breakfastService.CreateBreakfast(breakfast);

        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet
        ); 
        return CreatedAtAction(
            actionName:nameof(GetBreakfast),
            routeValues:new {id = breakfast.Id},
            value:      response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        Breakfast breakfast = _breakfastService.GetBreakfast(id);

        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet
        ); 
        
        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id,UpsertBreakfastRequest request)
    {
        return Ok(request);
    }
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }




    
}