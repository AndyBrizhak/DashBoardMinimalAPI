using DashBoardMinimalAPI;
using DashBoardMinimalAPI.Models;
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

app.MapGet("/api/rooms", /*async*/
    () => Results.Ok(SD.Rooms))
    .WithName("GetRooms")
    .Produces(200);

app.MapGet("/api/room/{int}", /*async*/
    (int id) => 
{
    if (id < 1 || SD.Rooms.Count>20)
    { 
        return Results.BadRequest("Invalid key for room");
    }
    return Results.Ok(SD.Rooms.FirstOrDefault(u=>u.Id==id));
})
    .WithName("GetRoom")
    .Produces(200);

app.MapPut("/api/changestatus", 
    ([FromBody] string status, int id) =>
    {
        SD.Rooms[id].Status = status;
    });

app.UseHttpsRedirection();


app.Run();


