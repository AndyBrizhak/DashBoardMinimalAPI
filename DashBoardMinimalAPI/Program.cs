using DashBoardMinimalAPI;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/rooms", async
    () => Results.Ok(StaticDetails.RoomsStatus))
    .WithName("GetRooms")
    .Produces(200);

app.MapGet("/api/room/{key:int}", async
    (int key) =>
{
    if (key < 1 || key>20)
    { 
        return Results.BadRequest("Invalid key for room");
    }
    return Results.Ok(StaticDetails.RoomsStatus.FirstOrDefault(u=>u.Key==key));
})
    .WithName("GetRoom")
    .Produces(200);

app.MapPut("/api/changestatus/{key:int}", 
    ([FromBody] string status, int key) =>
    {
     StaticDetails.RoomsStatus[key] = status;
    });

app.UseHttpsRedirection();


app.Run();


