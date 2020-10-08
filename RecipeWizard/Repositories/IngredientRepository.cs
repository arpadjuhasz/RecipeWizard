using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RecipeWizard.BusinesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWizard.Repositories
{
    public class IngredientRepository : BaseRepository
    {
        public DbSet<IngredientGet> Ingredients { get; set; }

        public List<IngredientGet> GetIngredientsByRecipeId(Recipe recipe)
        {
            var ingredients =  Ingredients.FromSqlRaw(@"SELECT
                                                        i.Id,
                                                        i.Name,
                                                        ri.Quantity,
                                                        mu.Name AS MeasurementUnitName
                                                    FROM RecipeIngredients as ri
                                                    INNER JOIN Ingredients AS i ON(ri.IngredientId = i.Id)
                                                    INNER JOIN MeasurementUnits AS mu ON(ri.MeasurementUnitId = mu.Id)
                                                    WHERE ri.RecipeId = @RecipeId
                                                    ORDER BY i.Name", new SqlParameter("RecipeId", recipe.Id));
            return ingredients.ToList();
        }
    }
}
