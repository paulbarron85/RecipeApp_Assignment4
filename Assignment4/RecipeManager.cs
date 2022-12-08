using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class RecipeManager
    {
        private Recipe[] RecipeList;

        public RecipeManager(int maxNumberOfElements)
        {
            RecipeList = new Recipe[maxNumberOfElements];  // Declares an array for storing recipes
        }
        public bool Add(Recipe recipe)
        {
            //check so recipe is not null before adding to the//recipList.
            return false;
        }
        private bool Add(string name, FoodCategory category, string[] ingedients)
        {
            return false;
        }

        private void ChangeElement(int index, Recipe recipe)
        {

        }

        private bool CheckIndex(int index)
        {
            return false;
        }

        private void DeleteElement(int index)
        {

        }

        private int FindVacantPosition()
        {
            return 0;
        }
        
        private int GetCurrentNumberOfRecipes()
        {
            return 0;
        }
        
        private Recipe GetRecipeAt(int index)
        {
            Recipe recipe = null;

            return recipe;
        }
        
        private string[] RecipeListToString()
        {
            string[] recipeList_string = null;

            return recipeList_string;
        }
        




        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < RecipeList.Length; i++)
            {
                RecipeList[i - 1] = RecipeList[i];
                RecipeList[i] = null;
            }
        }
    }
}
