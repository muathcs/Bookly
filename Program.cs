var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

//builder.Services.Configure<ConnectionStrings>(
//    builder.Configuration.GetSection(nameof(ConnectionStrings))
//);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();  // Map controllers to endpoints

app.Run();
