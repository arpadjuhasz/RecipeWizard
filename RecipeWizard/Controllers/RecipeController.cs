using Microsoft.AspNetCore.Mvc;
using RecipeWizard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWizard.Controllers
{
    [Route("api/recipe")]
    public class RecipeController : Controller
    {
        private readonly RecipeService _recipeService;
        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpHead("{id}")]
        public IActionResult GetRecipeCount(Guid id)
        {
            if (_recipeService.CheckRecipeExists(id))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var recipe = _recipeService.GetById(id);
            if (recipe != null) { return Ok(recipe);  }
            else { return NotFound();  }
        }


        [HttpGet("count")]
        public IActionResult GetRecipeCount()
        {
            return Ok(new { CountOfAllRecipes = _recipeService.CountRecipes() });
        }


    }
}
