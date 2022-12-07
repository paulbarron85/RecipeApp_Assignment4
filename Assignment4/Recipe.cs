using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// Every recipe has:
    /// • a list of ingredients (strings)
    /// • a description (instructions)
    /// • a category as listed in the enum FoodCategory.
    /// </summary>
    internal class Recipe
    {
        private string[]? ingredients;
        private string? instructions;
        private FoodCategory category;
    }
}
