using DashBoardMinimalAPI;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IRooms, Rooms>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/availability", /*async*/
    () => Results.Ok(StaticDetails.RoomsStatus))
    /*.WithName("GetAvailability)"*/
    .Produces(200);

app.MapGet("/api/coupon/{key:int}", (int key) =>
{
    return Results.Ok(StaticDetails.RoomsStatus.FirstOrDefault(u=>u.Key==key));
})
    /*.WithName("GetRoomStatus")*/
    .Produces(200);

//app.MapPut("/api/coupon/{key:int}", (int key) =>);

app.UseHttpsRedirection();


app.Run();


