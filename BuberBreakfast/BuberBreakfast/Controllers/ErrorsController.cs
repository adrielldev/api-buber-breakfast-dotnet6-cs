namespace BuberBreakfast.Controllers;
using Microsoft.AspNetCore.Mvc;


public class ErrorsController : Controller
{
    [Route("/error")]
    public IActionResult Error()
    {   
         
        return Problem();
    }
}