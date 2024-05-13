namespace DesignPatterns.FactoryMethodExercise.models
{
    internal abstract class Food(string name, decimal price, DateOnly expirationDate)
    {
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public DateOnly ExpirationDate { get; set; } = expirationDate;

        public virtual string Info()
            => $"Name: {Name}, Price: {Price}, Expiration Date: {ExpirationDate}";
    }
}
