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
        private readonly uint maxNumberOfIngredients;
        private string name;
        private string[] ingredients;
        private string instructions;
        private FoodCategory category;

        /// <summary>
        /// 
        /// </summary>
        public uint MaxNumberOfIngedients
        {
            get { return maxNumberOfIngredients; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string[] Ingedients
        {
            get
            {
                return ingredients;
            }
            set
            {
                //if (!String.IsNullOrEmpty(value))
                ingredients = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string? Instructions
        {
            get
            {
                return instructions;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    instructions = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public FoodCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxNumberOfIngredients"></param>
        public Recipe(uint maxNumberOfIngredients)
        {
            if (maxNumberOfIngredients > 0)
                this.maxNumberOfIngredients = maxNumberOfIngredients;
                ingredients = new string[maxNumberOfIngredients];
        }


        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIngredientAt(int index)
        {
            return ingredients[index] == null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            return false;
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
                if (!String.IsNullOrEmpty(ingredients[i]))
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

            for (int i = 0; i < maxNumberOfIngredients; i++)
            {
                if (!String.IsNullOrEmpty(ingredients[i]))
                    if (String.IsNullOrEmpty(combinedIngredients))
                        combinedIngredients += ingredients[i];
                    else
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
            return ingredients[0];
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
