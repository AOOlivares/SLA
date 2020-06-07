using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingListAssistant.Core.Models;

namespace ShoppingListAssistant.Core.Interfaces
{
    public interface IIngredientsRepository
    {
        Task<IList<Ingredient>> GetIngredientsAsync();
        Task AddIngredientAsync(string ingredientName, string ingredientCategory);
        Task DeleteIngredientAsync(Ingredient ingredient);
    }
}