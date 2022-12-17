using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// Every recipe has:
    /// - a name
    /// - a category as listed in the enum FoodCategory
    /// - a list of ingredients (strings)
    /// - a description (instructions)
    /// </summary>
    public class Recipe
    {
        private readonly uint maxNumberOfIngredients;
        private string name;
        private string[] ingredients;
        private string instructions;
        private FoodCategory category;

        /// <summary>
        /// Constuctor that accepts the max number of ingredients per recipe
        /// </summary>
        public uint MaxNumberOfIngedients
        {
            get { return maxNumberOfIngredients; }
        }

        /// <summary>
        /// Property: List of Ingredients
        /// </summary>
        public string[] Ingedients
        {
            get { return ingredients; }
            set
            {
                if (value is not null)
                    ingredients = value;
            }
        }

        /// <summary>
        /// Property: Instructions for the recipe
        /// </summary>
        public string Instructions
        {
            get { return instructions; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    instructions = value;
            }
        }

        /// <summary>
        /// Property: Category of the dish
        /// </summary>
        public FoodCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Property: Name of the recipe
        /// </summary>
        public string Name 
        { 
            get { return name; } 
            set 
            {
                if (!String.IsNullOrEmpty(value))
                    name = value; 
            } 
        }

        /// <summary>
        /// Constructor: if max Number of ingredients is less than 1 we just use 10
        /// Can't have a negative number of max ingredients
        /// </summary>
        /// <param name="maxNumberOfIngredients"></param>
        public Recipe(uint maxNumberOfIngredients)
        {
            if (maxNumberOfIngredients > 0)
                this.maxNumberOfIngredients = maxNumberOfIngredients;
            else
                this.maxNumberOfIngredients = 10;

            ingredients = new string[maxNumberOfIngredients];
        }


        /// <summary>
        /// Takes a string and adds to an array of string ingredients
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        //public bool AddIngredient(int index, string value)
        public bool AddIngredient(string value)
        {
            int firstVacantPosition = FindVacantPosition();
            if (!String.IsNullOrEmpty(value) && firstVacantPosition >= 0 && firstVacantPosition < maxNumberOfIngredients - 1)
            {
                ingredients[firstVacantPosition] = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if ingredient array position is filled and return true if has a value
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIngredientAt(int index)
        {
            return ingredients[index] != null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            return ingredients[index] != null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint CurrentNumberOfIngredients()
        {
            uint currNumIngredients = 0;
            for (int i = 0; i < maxNumberOfIngredients; i++)
            {
                if (CheckIndex(i))
                    currNumIngredients += 1;
            }

            return currNumIngredients;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DefaultValues()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="indwx"></param>
        public void DeleteIngedientAt(int index)
        {
            if (index < ingredients.Length)
            {
                ingredients[index] = string.Empty;
                MoveElementsOneStepToLeft(index);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int FindVacantPosition()
        {
            for (int i = 0; i < maxNumberOfIngredients; i++)
            {
                if (String.IsNullOrEmpty(ingredients[i]))
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetIngredientsString()
        {
            string combinedIngredients = string.Empty;

            if (ingredients[0] is not null)
                combinedIngredients += ingredients[0];

            for (int i = 1; i < maxNumberOfIngredients; i++)
            {
                if (ingredients[i] is not null)
                    combinedIngredients += ", " + ingredients[i];
            }

            return combinedIngredients;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            string returnString = string.Empty;

            return returnString;
        }

        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < ingredients.Length; i++)
            {
                ingredients[i - 1] = ingredients[i];
                ingredients[i] = String.Empty;
            }
        }
    }
}
