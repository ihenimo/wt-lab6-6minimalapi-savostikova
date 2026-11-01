namespace wt_lab6_6minimalapi_savostikova.Models;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; } = "";        // Название блюда
    public string Category { get; set; } = "";    // Категория (Пицца, Суп, Напитки)
    public decimal Price { get; set; }            // Цена
    public bool IsAvailable { get; set; }         // В наличии
}