using DesignPatterns.FactoryMethodExercise.models;
using System.Text;

namespace DesignPatterns.FactoryMethodExercise
{
    internal class ShoppingCart
    {
        public List<Food> Cart { get; set; } = [];

        public void AddItem(Food food)
            => Cart.Add(food);

        public void RemoveItem(Food food)
            => Cart.Remove(food);

        public decimal CalculateTotal()
            => Cart.Select(f => f.Price).Sum();

        public string InfoCart()
        {
            StringBuilder sb = new();
            Cart.ForEach(f => sb.Append($"{f.Info()}\n"));
            return sb.ToString()[0..^1];
        }
    }
}
