using RecipeWizard.BusinesObjects;
using RecipeWizard.Repositories;
using System;

namespace RecipeWizard.Services
{
    public class RecipeService
    {
        private readonly RecipeRepository _recipeRepository;
        private readonly IngredientRepository _ingredientRepository;

        public RecipeService(RecipeRepository recipeRepository, IngredientRepository ingredientRepository)
        {
            _recipeRepository = recipeRepository;
            _ingredientRepository = ingredientRepository;
        }

        public bool CheckRecipeExists(Guid id)
        {
            if (id == Guid.Empty) { return false; }
            if (_recipeRepository.GetById(id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public RecipeGet GetById(Guid id)
        {
            if (Guid.Empty == id) { return null; }
            var recipe = _recipeRepository.GetById(id);
            if (recipe == null) { return null; }
            var ingredients = _ingredientRepository.GetIngredientsByRecipeId(recipe);
            
            var recipeGet = new RecipeGet
            {
                Id = recipe.Id,
                Name = recipe.Name,
                Description = recipe.Description,
                Ingredients = ingredients
            };
            return recipeGet;
        }

        public int CountRecipes()
        {
            return _recipeRepository.CountRecipes();
        }
    }
}
