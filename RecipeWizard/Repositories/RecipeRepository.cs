using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RecipeWizard.BusinesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWizard.Repositories
{
    public class RecipeRepository : BaseRepository
    {
        public RecipeRepository(IConfiguration configuration) : base(configuration)
        { }

        public DbSet<Recipe> Recipes { get; set; }

        public Recipe GetById(Guid id)
        {
            return Recipes.FirstOrDefault(x => x.Id == id);
        }

        public int CountRecipes()
        {
            return Recipes.Count();
        }
    }
}
