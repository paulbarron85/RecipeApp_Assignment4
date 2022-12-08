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
    public class Recipe
    {
        private string[]? ingredients;
        private string? instructions;
        private FoodCategory category;
        private string name;
        private readonly uint maxNumberOfIngedients;

        public string Ingedients
        {
            get; set;
        }
        public string Instructions
        {
            get; set;
        }
        public string Category
        {
            get; set;
        }
        public uint MaxNumberOfIngedients
        {
            get { return maxNumberOfIngedients; }
        }

        public string Name 
        { 
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

        public bool AddIngredient(int index, string value)
        {
            return false;
        }

        public bool CheckIngredientAt(int index)
        {
            return false;
        }

        private bool CheckIndex(int index)
        {
            return false;
        }

        public int CurrentNumberOfIngredients()
        {
            return 0;
        }

        public void DefaultValues()
        {

        }

        public void DeleteIngedientAt(int indwx)
        {

        }

        public int FindVacantPosition()
        {
            return 0;
        }

        public string GetIngredientsStrin()
        {
            return "";
        }

        public string ToString()
        {
            return "";
        }
    }
}
