using wt_lab6_6minimalapi_savostikova.Data;
using wt_lab6_6minimalapi_savostikova.Models;

var builder = WebApplication.CreateBuilder(args);

// Настройка Swagger (Блок 6)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Включаем Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ===== БЛОК 1 =====
app.MapGet("/", () => "Minimal API работает!");

app.MapGet("/api/info", () =>
{
    return new
    {
        Application = "Web Technologies",
        Technology = "ASP.NET Core Minimal API",
        Version = "1.1"
    };
});

// ===== БЛОК 3. GET-запросы =====
app.MapGet("/api/dishes", (string? search) =>
{
    var dishes = DishStore.Dishes.AsEnumerable();
    if (!string.IsNullOrWhiteSpace(search))
    {
        dishes = dishes.Where(x => x.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
    }
    return Results.Ok(dishes);
});

app.MapGet("/api/dishes/{id}", (int id) =>
{
    var dish = DishStore.Dishes.FirstOrDefault(x => x.Id == id);
    if (dish == null) return Results.NotFound();
    return Results.Ok(dish);
});

// ===== БЛОК 4. POST-запрос =====
app.MapPost("/api/dishes", (Dish dish) =>
{
    var newId = DishStore.Dishes.Count == 0 ? 1 : DishStore.Dishes.Max(x => x.Id) + 1;
    dish.Id = newId;
    DishStore.Dishes.Add(dish);
    
    return Results.Created($"/api/dishes/{dish.Id}", dish);
});

// ===== БЛОК 5. PUT и DELETE =====
app.MapPut("/api/dishes/{id}", (int id, Dish updatedDish) =>
{
    var dish = DishStore.Dishes.FirstOrDefault(x => x.Id == id);
    if (dish == null) return Results.NotFound();

    dish.Name = updatedDish.Name;
    dish.Category = updatedDish.Category;
    dish.Price = updatedDish.Price;
    dish.IsAvailable = updatedDish.IsAvailable;

    return Results.Ok(dish);
});

app.MapDelete("/api/dishes/{id}", (int id) =>
{
    var dish = DishStore.Dishes.FirstOrDefault(x => x.Id == id);
    if (dish == null) return Results.NotFound();

    DishStore.Dishes.Remove(dish);
    return Results.NoContent();
});

// ===== ЗАПУСК =====
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Run($"http://0.0.0.0:{port}");