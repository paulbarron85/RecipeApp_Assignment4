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
        private string? name;
        private string[]? ingredients;
        private string? instructions;
        private FoodCategory category;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxNumberOfIngredients"></param>
        public Recipe(uint maxNumberOfIngredients)
        {
            if (maxNumberOfIngredients <= 0)
                this.maxNumberOfIngredients = maxNumberOfIngredients;
        }

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
            get
            {
                return category;
            }
            set
            {
                //if (!String.IsNullOrEmpty(value))
                category = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string? Name 
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
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddIngredient(int index, string value)
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIngredientAt(int index)
        {
            return false;
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
        public int CurrentNumberOfIngredients()
        {
            return 0;
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
        public void DeleteIngedientAt(int indwx)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int FindVacantPosition()
        {
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetIngredientsString()
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "";
        }
    }
}
