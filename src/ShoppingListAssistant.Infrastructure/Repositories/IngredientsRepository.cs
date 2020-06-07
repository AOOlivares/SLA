using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using ShoppingListAssistant.Core.Models;
using ShoppingListAssistant.Core.Interfaces;

namespace ShoppingListAssistant.Infrastructure.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private readonly IList<Ingredient> _ingredientsDB;

        public IngredientsRepository()
        {
            _ingredientsDB = new List<Ingredient>
            {
                new Ingredient
                {
                    Category = "Vegetagles",
                    Id = Guid.NewGuid(),
                    Name = "Tomate"
                },
                new Ingredient
                {
                    Category = "Vegetagles",
                    Id = Guid.NewGuid(),
                    Name = "Pepino"
                }
            };
        }

        public async Task<IList<Ingredient>> GetIngredientsAsync()
        {
            await Task.Delay(100);
            return _ingredientsDB;
        }
        public async Task AddIngredientAsync(string ingredientName, string ingredientCategory)
        {
            await Task.Delay(100);
            var ingredient = new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = ingredientName,
                Category = ingredientCategory
            };
            _ingredientsDB.Add(ingredient);
        }

        public async Task DeleteIngredientAsync(Ingredient ingredient)
        {
            await Task.Delay(100);

            _ingredientsDB.Remove(ingredient);
        }
    }
}