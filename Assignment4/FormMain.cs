namespace Assignment4
{
    public partial class FormMain : Form
    {
        const int maxNumOfElements = 10;
        const int maxNumOfIngredients = 10;
        private readonly RecipeManager recipeManager;
        private Recipe currRecipe;
        public FormMain()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeGUI();
            recipeManager = new RecipeManager(maxNumOfElements);
            currRecipe = new Recipe(maxNumOfIngredients);
        }

        /// <summary>
        /// Fill combo box options with all those available from the ENUM FoodCategory
        /// </summary>
        private void InitializeComboBox()
        {
            string[] enumElements = Enum.GetNames(typeof(FoodCategory));
            foreach (var item in enumElements)
            {
                cmbCategory.Items.Add(item);
            }
        }

        /// <summary>
        /// Open an instance of FormIngredients so the user can enter the ingedients for a recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddIngredients_Click(object sender, EventArgs e)
        {
            // Creates new ingredients form and opens as a dialog box
            FormIngedients dlg = new(currRecipe);
            DialogResult dlgResult = dlg.ShowDialog();

            // Manages case where user click ok button
            if (dlgResult == DialogResult.OK)
            {
                // If no ingredients were added, shows message dialog
                if (currRecipe.CurrentNumberOfIngredients() <= 0)
                    MessageBox.Show("No ingredients specififed", "Error");
            }
        }

        /// <summary>
        /// Verify all input has been filled for recipe and then add it to the reipe manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddRecipe_Click(object sender, EventArgs e)
        {
            currRecipe.Name = txtNameOfRecipe.Text;
            currRecipe.Category = (FoodCategory) cmbCategory.SelectedIndex;
            currRecipe.Instructions = txtInstructions.Text;
            
            if (string.IsNullOrEmpty(currRecipe.Name))
            {
                MessageBox.Show("No Recipe name specified", "Error");
                return;
            }

            if (string.IsNullOrEmpty(currRecipe.Instructions))
            {
                MessageBox.Show("No instructions specififed", "Error");
                return;
            }

            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Food Category not specified", "Error");
                return;
            }

            if (currRecipe.CurrentNumberOfIngredients() <= 0) 
            {
                MessageBox.Show("No ingredients specififed", "Error");
                return;
            }

            if (recipeManager.GetCurrentNumberOfRecipes() < maxNumOfElements)
            {
                recipeManager.Add(currRecipe);
                //recipeManager.Add(txtNameOfRecipe.Text, cmbCategory.Text, lblInstructions.Text);

                UpdateGUI();
                ClearSelection();

                currRecipe = new Recipe(maxNumOfIngredients);
            }
            else
            {
                MessageBox.Show("Maximum number of recipes reached", "Error");
                return;
            }
        }

        /// <summary>
        /// Begin editing the currently selected recipe
        /// Check that a recipe has been selected and if so disable while in edit mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditStart_Click(object sender, EventArgs e)
        {
            int selectedRecipeIndex = lstRecipe.SelectedIndex;
            int numOfRecipes = recipeManager.GetCurrentNumberOfRecipes();

            if (numOfRecipes > 0 && selectedRecipeIndex >= 0 && selectedRecipeIndex <= numOfRecipes)
            {
                currRecipe = recipeManager.GetRecipeAt(selectedRecipeIndex);

                txtNameOfRecipe.Text = currRecipe.Name;
                txtInstructions.Text = currRecipe.Instructions;
                cmbCategory.SelectedIndex = (int)currRecipe.Category;

                btnAddRecipe.Enabled = false;
                lstRecipe.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnEditStart.Enabled = false;
                btnEditFinish.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid recipe selection", "Error");
            }
        }

        /// <summary>
        /// Finish the editing mode and re-enable buttons that had been disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditFinish_Click(object sender, EventArgs e)
        {
            btnAddRecipe.Enabled = true;
            lstRecipe.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            btnEditStart.Enabled = true;
            btnEditFinish.Enabled = false;

            currRecipe.Name = txtNameOfRecipe.Text;
            currRecipe.Category = (FoodCategory)cmbCategory.SelectedIndex;
            currRecipe.Instructions = txtInstructions.Text;

            recipeManager.ChangeElement(lstRecipe.SelectedIndex, currRecipe);

            UpdateGUI();
            ClearSelection();
            currRecipe = new Recipe(maxNumOfIngredients);
        }

        /// <summary>
        /// Open currently selected recipe in a new popup window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int recipeIndexToDelete = lstRecipe.SelectedIndex;

            if (recipeIndexToDelete >= 0)
            {
                recipeManager.DeleteElement(recipeIndexToDelete);
                lstRecipe.Items.RemoveAt(recipeIndexToDelete);
                ClearSelection();
            }
        }

        /// <summary>
        /// Clear all entered data and create an object for a new recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
            currRecipe = new Recipe(maxNumOfIngredients);
        }

        /// <summary>
        /// Clear list box selection and any text entered for current recipe
        /// </summary>
        private void ClearSelection()
        {
            txtNameOfRecipe.Clear();
            txtInstructions.Clear();
            cmbCategory.SelectedIndex = -1;
            lstRecipe.SelectedIndex = -1;
        }

        /// <summary>
        /// Set up fields for new GUI
        /// </summary>
        public void InitializeGUI()
        {
            txtNameOfRecipe.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;
            txtInstructions.Text = string.Empty;
            lstRecipe.Font = new Font(FontFamily.GenericMonospace.Name, 9);
            this.Text = "Paul's Recipe Manager";
        }

        /// <summary>
        /// Update List box with all recipes
        /// </summary>
        public void UpdateGUI()
        {
            lstRecipe.Items.Clear();

            string[] recipeStringArray = recipeManager.RecipeListToString();
            for (int i = 0; i < recipeStringArray.Length; i++) 
            {
                if (recipeStringArray[i] != null)
                    lstRecipe.Items.Add(recipeStringArray[i]);
            }
        }

        /// <summary>
        /// Change options/buttons available to user based on which recipe (if any) is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRecipeIndex = lstRecipe.SelectedIndex;
            int numOfRecipes = recipeManager.GetCurrentNumberOfRecipes();

            if (numOfRecipes > 0 && selectedRecipeIndex >= 0 && selectedRecipeIndex <= numOfRecipes)
            {
                btnEditStart.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEditStart.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Open a selected recipe in a message box when the user double clicks on a recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstRecipe_MouseDoubleClick(object sender, EventArgs e)
        {
            int selectedRecipeIndex = lstRecipe.SelectedIndex;
            if (selectedRecipeIndex >= 0)
            {
                Recipe? selectedRecipe = recipeManager.GetRecipeAt(selectedRecipeIndex);
                String strOut = $"{selectedRecipe.Name ?? ""}\n\n" +
                                $"Ingredients: {selectedRecipe.GetIngredientsString()}\n" +
                                $"--------------------\n\n" +
                                $"{selectedRecipe.Instructions}";
                MessageBox.Show(strOut, "COOKING INSTRUCTIONS");
            }
        }
    }
}