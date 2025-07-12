using Formula1Backend.Seeders;
using Formula1Backend.Services;
using Formula1Backend.Config;  
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirFrontend", policy =>
    {
        policy.WithOrigins(
                "http://localhost:3000",
                "http://localhost:5173",         // para desarrollo local
                "https://formulini.netlify.app"      
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=formula1.db"));


builder.Services.AddScoped<EscuderiaServices>();
builder.Services.AddScoped<PilotoServices>();
builder.Services.AddScoped<PistaServices>();
builder.Services.AddAutoMapper(typeof(Mapping));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection(); 
app.UseCors("PermitirFrontend");
app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();
    DataSeeder.Seed(context);
}

app.Run();
