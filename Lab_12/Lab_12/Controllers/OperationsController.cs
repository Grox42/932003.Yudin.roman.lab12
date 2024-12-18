using Lab_12.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_12.Controllers;

public class OperationsController : Controller
{
    [HttpGet]
    public IActionResult SingleAction() => View();

    [HttpPost]
    public IActionResult SingleAction([FromForm] RequestModel requestModel) =>
        requestModel is { Operator: Operator.Divide, SecondNumber: 0 } ?
            View("Error") :
            View("Response", requestModel);

    [HttpGet]
    public IActionResult SeparateActions() => View();

    [HttpPost]
    public IActionResult SeparateActions([FromForm] RequestModel requestModel) =>
        requestModel is { Operator: Operator.Divide, SecondNumber: 0 } ?
            View("Error") :
            View("Response", requestModel);

    [HttpGet]
    public IActionResult ModelBindingParam() => View();

    [HttpPost]
    public IActionResult ModelBindingParam([FromForm] RequestModel requestModel) =>
        requestModel is { Operator: Operator.Divide, SecondNumber: 0 } ?
            View("Error") :
            View("Response", requestModel);

    [HttpGet]
    public IActionResult ModelBindingSep() => View();

    [HttpPost]
    public IActionResult ModelBindingSep([FromForm] RequestModel requestModel) =>
        requestModel is { Operator: Operator.Divide, SecondNumber: 0 } ?
            View("Error") :
            View("Response", requestModel);
}