using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class RecipeManager
    {
        private readonly Recipe?[] recipeList; // Array for storing recipes, if null then that index position is empty

        /// <summary>
        /// Constructor for the Recipe Manager
        /// </summary>
        /// <param name="maxNumberOfElements"></param>
        public RecipeManager(int maxNumberOfElements)
        {
            recipeList = new Recipe[maxNumberOfElements];  // Declares an array for storing recipes
        }

        /// <summary>
        /// Add a recipe to the Recipe Manager
        /// Check the recipe is non-null and then find a free position
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public bool Add(Recipe recipe)
        {
            bool success = false;
            
            //check so recipe is not null before adding to the recipList.
            if (recipe is not null)
            {
                int vacantPos = FindVacantPosition();
                if (vacantPos >= 0 && vacantPos < recipeList.Length)
                {
                    recipeList[vacantPos] = recipe;
                    success = true;
                }
            }

            return success;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="ingedients"></param>
        /// <returns></returns>
        /* Given as part of the assignment but not used
        public bool Add(string name, FoodCategory category, string[] ingedients)
        {
            //recipeList[0].Name = name;
            //recipeList[0].Category = category;
            //recipeList[0].Ingedients = ingedients;

            return false;
        } */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="recipe"></param>
        public void ChangeElement(int index, Recipe recipe)
        {
            if (index >= 0 && index < recipeList.Length && recipe != null)
            {
                recipeList[index] = recipe;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /* Comes from assignment but unused
        private bool CheckIndex(int index)
        {
            return (recipeList[index] != null);
        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public void DeleteElement(int index)
        {
            if (recipeList.Length > 0)
            {
                recipeList[index] = null;
                MoveElementsOneStepToLeft(index);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int FindVacantPosition()
        {
            int vacantPos;
            for (vacantPos = 0; vacantPos < recipeList.Length; vacantPos++)
            {
                if (recipeList[vacantPos] == null)
                    break;
            }
            return vacantPos;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetCurrentNumberOfRecipes()
        {
            int numOfRecipes;

            for (numOfRecipes = 0; numOfRecipes <= recipeList.Length; numOfRecipes++)
            {
                if (recipeList[numOfRecipes] == null)
                    break;
            }

            return numOfRecipes;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Recipe? GetRecipeAt(int index)
        {
            Recipe? recipe;

            recipe = recipeList[index];

            return recipe;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] RecipeListToString()
        {
            string[] rtnStringArray = new string[recipeList.Length];

            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] is not null)
                    rtnStringArray[i] = string.Format("{0, -40} {1, -40} {2, -2}", recipeList[i].Name, recipeList[i].Category.ToString(), recipeList[i].CurrentNumberOfIngredients().ToString() );
            }

            return rtnStringArray;
        }

        /// <summary>
        /// This method is used after deleted a recipe
        /// Move all recipes down the array by 1 to make sure there are no empty spaces
        /// </summary>
        /// <param name="index"></param>
        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < recipeList.Length; i++)
            {
                recipeList[i - 1] = recipeList[i];
                recipeList[i] = null;
            }
        }
    }
}
