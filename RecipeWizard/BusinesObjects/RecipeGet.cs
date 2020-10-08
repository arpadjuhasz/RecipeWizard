using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWizard.BusinesObjects
{
    public class RecipeGet
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<IngredientGet> Ingredients { get; set; }
    }
}
