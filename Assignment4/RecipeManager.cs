using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class RecipeManager
    {
        private Recipe[] recipeList;

        public RecipeManager(int maxNumberOfElements)
        {
            recipeList = new Recipe[maxNumberOfElements];  // Declares an array for storing recipes
        }
        public bool Add(Recipe recipe)
        {
            bool success = false;
            
            //check so recipe is not null before adding to the recipList.
            if (recipe != null)
            {
                int vacantPos = FindVacantPosition();
                if (vacantPos < recipeList.Length)
                {
                    recipeList[vacantPos] = recipe;
                    success = true;
                }
            }

            return success;
        }
        public bool Add(string name, FoodCategory category, string[] ingedients)
        {
            //recipeList[0].Name = name;
            //recipeList[0].Category = category;
            //recipeList[0].Ingedients = ingedients;

            return false;
        }

        public void ChangeElement(int index, Recipe recipe)
        {

        }

        private bool CheckIndex(int index)
        {
            return (recipeList[index] != null);
        }

        public void DeleteElement(int index)
        {
            recipeList[index] = null;
            MoveElementsOneStepToLeft(index);
        }

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
        
        public int GetCurrentNumberOfRecipes()
        {
            int numOfRecipes;
            for (numOfRecipes = 0; numOfRecipes < recipeList.Length; numOfRecipes++)
            {
                if (recipeList[numOfRecipes] == null)
                    break;
            }

            return numOfRecipes;
        }
        
        public Recipe GetRecipeAt(int index)
        {
            Recipe recipe;

            recipe = recipeList[index];

            return recipe;
        }

        public string[] RecipeListToString()
        {
            string[] rtnStringArray = new string[recipeList.Length];

            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                    rtnStringArray[i] = string.Format("{0, -40} {1, -40} {2, -2}", recipeList[i].Name, recipeList[i].Category.ToString(), recipeList[i].CurrentNumberOfIngredients().ToString());
            }

            return rtnStringArray;
        }


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
