var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CORS
var origin = new List<string>();
builder.Configuration.Bind("AllowedOrigins", origin);
builder.Services.AddCors(options =>
{
    options.AddPolicy("usemefreeApiCORS", policy =>
    {
        if (origin?.Count > 0)
            policy.WithOrigins(origin.ToArray()).AllowAnyHeader().AllowAnyMethod().AllowCredentials();
        else
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("usemefreeApiCORS");

app.UseAuthorization();

app.MapControllers();

app.Run();
