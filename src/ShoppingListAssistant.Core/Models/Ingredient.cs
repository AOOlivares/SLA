using System;

namespace ShoppingListAssistant.Core.Models
{
    public class Ingredient : IEquatable<Ingredient>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public bool Equals(Ingredient other)
        {
            return Id == other.Id;
        }
    }
}