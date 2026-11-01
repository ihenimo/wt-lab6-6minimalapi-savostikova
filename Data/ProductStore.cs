using wt_lab6_6minimalapi_savostikova.Models;

namespace wt_lab6_6minimalapi_savostikova.Data;

public static class DishStore
{
    public static List<Dish> Dishes { get; } = new()
    {
        new Dish { Id = 1, Name = "Пицца Пепперони", Category = "Пицца", Price = 550m, IsAvailable = true },
        new Dish { Id = 2, Name = "Суп Том Ям", Category = "Супы", Price = 380m, IsAvailable = true },
        new Dish { Id = 3, Name = "Цезарь с курицей", Category = "Салаты", Price = 420m, IsAvailable = true },
        new Dish { Id = 4, Name = "Лимонад", Category = "Напитки", Price = 150m, IsAvailable = false },
        new Dish { Id = 5, Name = "Чизкейк", Category = "Десерты", Price = 250m, IsAvailable = true }
    };
}