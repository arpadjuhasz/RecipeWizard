using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWizard.BusinesObjects
{
    public class IngredientGet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string MeasurementUnitName { get; set; }
    }
}
