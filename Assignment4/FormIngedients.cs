using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class FormIngedients : Form
    {
        private Recipe recipe;
        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }

        /// <summary>
        /// Constructor for the FormIngredients
        /// </summary>
        /// <param name="recipe"></param>
        public FormIngedients(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// 
        /// </summary>
        public void InitializeGUI()
        {
            this.Text = "Add Ingredients";
            txtNameIngedient.Text = string.Empty;
            UpdateGUI();
        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateGUI()
        {
            lblCurrNum.Text = Recipe.CurrentNumberOfIngredients().ToString();
            lstIngedients.Items.Clear();
            for (int i = 0; i < Recipe.CurrentNumberOfIngredients(); i++)
            {
                lstIngedients.Items.Add(recipe.Ingedients[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool success;

            if (recipe.CurrentNumberOfIngredients() < recipe.MaxNumberOfIngedients)
                success = Recipe.AddIngredient(txtNameIngedient.Text);
            else
            {
                MessageBox.Show("Maximum number of ingredients reached", "Error");
                return;
            }

            if (!success)
                MessageBox.Show("Add ingredient failed", "Error");
            else
            {
                UpdateGUI();
                InitializeGUI();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click_Click(object sender, EventArgs e)
        {
            int index = lstIngedients.SelectedIndex;

            if (String.IsNullOrEmpty(txtNameIngedient.Text))
            {
                MessageBox.Show("Write an ingredient to replace current selected", "Error");
                return;
            }

            if (index >= 0)
            {
                bool exits = Recipe.CheckIngredientAt(index);
                if (exits) 
                {
                    Recipe.Ingedients[index] = txtNameIngedient.Text;
                    UpdateGUI();
                }
                else
                    MessageBox.Show("Index doesn't exist: " + index, "Error");
            }
            else
            {
                MessageBox.Show("No ingredient selected", "Error");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = lstIngedients.SelectedIndex;

            if (index >= 0)
            {
                Recipe.DeleteIngedientAt(index);
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("No ingredient selected", "Error");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            recipe.DefaultValues();
            this.Close();
        }
    }
}
