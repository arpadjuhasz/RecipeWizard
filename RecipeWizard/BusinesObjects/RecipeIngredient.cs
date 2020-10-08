using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWizard.BusinesObjects
{
    public class RecipeIngredient
    {
        public Guid Id { get; set; }

        public Guid RecipeId { get; set; }

        public Guid IngredientId { get; set; }

        public double Quantity { get; set; }

        public Guid MeasurementUnitId { get; set; }
    }
}
