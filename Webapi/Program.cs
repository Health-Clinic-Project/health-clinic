using Bl;
using Bl.Api;
using Dal;
using Dal.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// שירותי DAL ו-BL
builder.Services.AddSingleton<IDal, DalManager>();
builder.Services.AddSingleton<IBlManager, BlManager>();

// הגדרת CORS - מאפשר ל-React לגשת לשרת API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // הכתובת שבה רץ ה-React
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// הפעלת CORS עם המדיניות שהגדרת
app.UseCors("AllowReactApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
