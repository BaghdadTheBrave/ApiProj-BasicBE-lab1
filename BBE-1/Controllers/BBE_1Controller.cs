using BBE_1.RAPI.user;
using BBE_1.RAPI.Category;
using BBE_1.RAPI.Record;
using BBE_1.Data;
using Microsoft.AspNetCore.Mvc;
using BBE_1.Services.Data;
using BBE_1.Services.Data;
namespace BBE_1.Controllers;

[ApiController]
public class BBE_1Controller : ControllerBase{
    private readonly IUserService _userService;
    private readonly IRecordService _recordService;
    private readonly ICategoryService _categoryService;

    public BBE_1Controller(IUserService service){
        _userService = service;
    }
    public BBE_1Controller(IRecordService service){
        _recordService = service;
    }
    public BBE_1Controller(ICategoryService service){
        _categoryService = service;
    }


    [HttpPost("/user")]
    public IActionResult CreateUser(CreateUserRequest request){
        var user = new User(request.id,request.name);
        _userService.CreateUser(user);
        return Ok(User);
    }
    [HttpPost("/Category")]
    public IActionResult CreateCategory(CreateCategoryRequest request){
        var Category = new Category(request.id,request.name);
        _categoryService.CreateCategory(Category);
        return Ok(Category);
    }
    [HttpPost("/Record")]
    public IActionResult CreateRecord(CreateRecordRequest request){
        var Record = new Record(request.id, request.idUser,request.idCategory,request.DateTimeOfRecord,request.spent);
        _recordService.CreateRecord(Record);
        return Ok();
    }

    
    [HttpGet("/Category")]
    public IActionResult GetCategories(){
        
        return Ok(_categoryService.GetCategories());
    }
    [HttpGet("/Record/{idUser:int}")]
    public IActionResult GetRecordsByUserId(int idUser){
        return Ok(_recordService.GetRecordsByUserId(idUser));
    }
    [HttpGet("/Record/{idUser:int}/{idCategory:int}")]
    public IActionResult GetRecordsByUserIdAndByCategoryId(int idUser, int idCategory){
        return Ok(_recordService.GetRecordsByUserAndCategory(idUser,idCategory));
    }
}