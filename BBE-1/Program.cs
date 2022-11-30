using BBE_1.Services.Data;

var builder = WebApplication.CreateBuilder(args);{
    builder.Services.AddHttpsRedirection(options =>
{
    Console.WriteLine(int.TryParse(Environment.GetEnvironmentVariable("PORT"), out var p) ? p : null);
    options.HttpsPort = int.TryParse(Environment.GetEnvironmentVariable("PORT"), out var p2) ? p2 : null;
});
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

