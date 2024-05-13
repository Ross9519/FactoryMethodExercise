using DesignPatterns.FactoryMethodExercise;
using DesignPatterns.FactoryMethodExercise.enums;
using DesignPatterns.FactoryMethodExercise.exceptions;
using DesignPatterns.FactoryMethodExercise.factories;
using DesignPatterns.FactoryMethodExercise.models;

try
{
    List<Food> foods =
    [
        FoodFactory.Get(FoodEnum.Fruit, "apple", 0.50M, new DateOnly(2024,05,16)),
        FoodFactory.Get(FoodEnum.Vegetable, "carrots", 1.1M, new DateOnly(2024,05,17)),
        FoodFactory.Get(FoodEnum.Meat, "whole chicken", 5.50M, new DateOnly(2024,05,20)),
        FoodFactory.Get(FoodEnum.Fruit, "1 kg of cherries", 100.0M, new DateOnly(2024,06,05)),
        FoodFactory.Get(FoodEnum.Vegetable, "oregano", 1.0M, new DateOnly(2024,12,01)),
        FoodFactory.Get(FoodEnum.Meat, "steak", 25.0M, new DateOnly(2024,05,25)),
    ];

    ShoppingCart cart = new();
    cart.AddItem(foods[4]);
    cart.AddItem(foods[5]);
    cart.AddItem(foods[1]);
    Console.WriteLine(cart.InfoCart());
    Console.WriteLine($"Total: {cart.CalculateTotal()}");
    cart.RemoveItem(foods[4]);
    cart.RemoveItem(foods[1]);
    Console.WriteLine();
    Console.WriteLine(cart.InfoCart());
    Console.WriteLine($"Total: {cart.CalculateTotal()}");
}
catch (FoodNotFoundException f)
{
    Console.WriteLine(f.Message);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
