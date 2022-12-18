using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// Class representing a recipe, consists of a name, a category, a list of ingredients (strings) and a description (instructions)
    /// Max number of ingredients is set in the constructor
    /// </summary>
    public class Recipe
    {
        private readonly uint maxNumberOfIngredients;
        private string name = string.Empty;
        private string[] ingredients;
        private string instructions = string.Empty;
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
        /// Takes an ingredient as a string and adds it to an array of string ingredients
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        //public bool AddIngredient(int index, string value)
        public bool AddIngredient(string value)
        {
            int firstVacantPosition = FindVacantPosition();

            if (!String.IsNullOrEmpty(value) && firstVacantPosition >= 0 && firstVacantPosition < maxNumberOfIngredients)
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
            return !string.IsNullOrEmpty(ingredients[index]);
        }

        /// <summary>
        /// Check whether there is a non-empty string at the given index position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// 
        /* Given as part of the assignment but not used
        private bool CheckIndex(int index)
        {
            return ingredients[index] != null;
        }
        */

        /// <summary>
        /// Count the number of non empty strings
        /// </summary>
        /// <returns></returns>
        public uint CurrentNumberOfIngredients()
        {
            uint currNumIngredients = 0;
            for (int i = 0; i < maxNumberOfIngredients; i++)
            {
                if (CheckIngredientAt(i))
                    currNumIngredients += 1;
            }

            return currNumIngredients;
        }

        /// <summary>
        /// Fill ingredient string array with empty strings
        /// </summary>
        public void DefaultValues()
        {
            if (CurrentNumberOfIngredients() > 0)
            {
                for (int i = 0; i < ingredients.Length; i++)
                {
                    ingredients[i] = string.Empty;
                }
            }
        }

        /// <summary>
        /// Remove the ingredient at the index position by setting the string to empty
        /// Then move all the ingredients above that index down by 1 so there's no gaps.
        /// </summary>
        /// <param name="index"></param>
        public void DeleteIngedientAt(int index)
        {
            if (index >= 0 && index < ingredients.Length)
            {
                ingredients[index] = string.Empty;
                MoveElementsOneStepToLeft(index);
            }
        }

        /// <summary>
        /// Find the first free position in the array of ingredients
        /// Return -1 if array is full
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
        /// Return a single string with all the recipe ingredients separated by a comma
        /// </summary>
        /// <returns></returns>
        public string GetIngredientsString()
        {
            string combinedIngredients = string.Empty;

            if (ingredients[0] is not null)
                combinedIngredients += ingredients[0];

            for (int i = 1; i < maxNumberOfIngredients; i++)
            {
                if (!string.IsNullOrEmpty(ingredients[i]))
                    combinedIngredients += ", " + ingredients[i];
            }

            return combinedIngredients;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /* Given as part of the assignment but not used     
        public string ToString()
        {
            string returnString = string.Empty;

            return returnString;
        }*/

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
