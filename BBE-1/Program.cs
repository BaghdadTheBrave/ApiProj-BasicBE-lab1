using BBE_1.Services.Data;

var builder = WebApplication.CreateBuilder(args);{
    builder.Services.AddControllers();
    builder.Services.AddSingleton<IUserService,UserService>();
    builder.Services.AddSingleton<IRecordService,RecordService>();
    builder.Services.AddSingleton<ICategoryService,CategoryService>();
}

var app = builder.Build();{
    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();

}
