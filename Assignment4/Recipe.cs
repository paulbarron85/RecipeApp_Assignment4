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
        private string name;

        public string Name { 
            get 
            { 
                return name; 
            } 
            set 
            {
                if (!String.IsNullOrEmpty(value))
                    name = value; 
            } 
        }

        public Recipe(int maxNumberOfIngredients)
        {

        }

        public bool AddIngredient(string name)
        {
            return false;
        }

        public bool CheckIngredientAt(string name)
        {
            return false;
        }

        private bool CheckIndex(string name)
        {
            return false;
        }

        public bool CheckNumberOfIngredients(string name)
        {
            return false;
        }

        public bool DefaultValues(string name)
        {
            return false;
        }

        public bool DeleteIngedientAt(string name)
        {
            return false;
        }

        public bool FindVacantPosition(string name)
        {
            return false;
        }

        public bool GetIngredientsStrin(string name)
        {
            return false;
        }

        public bool ToString(string name)
        {
            return false;
        }
    }
}
