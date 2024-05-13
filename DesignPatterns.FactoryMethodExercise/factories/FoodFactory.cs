using DesignPatterns.FactoryMethodExercise.enums;
using DesignPatterns.FactoryMethodExercise.exceptions;
using DesignPatterns.FactoryMethodExercise.models;

namespace DesignPatterns.FactoryMethodExercise.factories
{
    internal static class FoodFactory
    {
        public static Food Get(FoodEnum type, string name, decimal price, DateOnly expirationDate) => type switch
        {
            FoodEnum.Fruit => new Fruit(type, name, price, expirationDate),
            FoodEnum.Vegetable => new Vegetable(type, name, price, expirationDate),
            FoodEnum.Meat => new Meat(type, name, price, expirationDate),
            _ => throw new FoodNotFoundException(type)
        };
    }
}
