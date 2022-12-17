namespace Assignment4
{
    public partial class FormMain : Form
    {
        const int maxNumOfElements = 10;
        const int maxNumOfIngredients = 10;
        private RecipeManager recipeManager;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddRecipe_Click(object sender, EventArgs e)
        {
            currRecipe.Name = txtNameOfRecipe.Text;
            currRecipe.Category = (FoodCategory) cmbCategory.SelectedIndex;
            currRecipe.Instructions = txtInstructions.Text;

            if (currRecipe.CurrentNumberOfIngredients() > 0) 
            {
                recipeManager.Add(currRecipe);
                //recipeManager.Add(txtNameOfRecipe.Text, cmbCategory.Text, lblInstructions.Text);

                UpdateGUI();
                ClearSelection();

                currRecipe = new Recipe(maxNumOfIngredients);
            }
            else
            {
                MessageBox.Show("No ingredients specififed", "Error");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditStart_Click(object sender, EventArgs e)
        {
            if (lstRecipe.SelectedIndex >= 0 && lstRecipe.SelectedIndex < recipeManager.GetCurrentNumberOfRecipes())
            {
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
        /// 
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int recipeIndexToDelete = lstRecipe.SelectedIndex;
            recipeManager.DeleteElement(recipeIndexToDelete);
            lstRecipe.Items.RemoveAt(recipeIndexToDelete);
            ClearSelection();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
            currRecipe = new Recipe(maxNumOfIngredients);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ClearSelection()
        {
            txtNameOfRecipe.Clear();
            txtInstructions.Clear();
            cmbCategory.SelectedIndex = -1;
            lstRecipe.SelectedIndex = -1;
        }

        /// <summary>
        /// 
        /// </summary>
        public void InitializeGUI()
        {
            txtNameOfRecipe.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;
            txtInstructions.Text = string.Empty;
            this.Text = "Paul's Recipe Manager";
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRecipeIndex = lstRecipe.SelectedIndex;

            if (selectedRecipeIndex >= 0 && selectedRecipeIndex < lstRecipe.Items.Count)
            {
                currRecipe = recipeManager.GetRecipeAt(selectedRecipeIndex);

                txtNameOfRecipe.Text = currRecipe.Name;
                txtInstructions.Text = currRecipe.Instructions;
                cmbCategory.SelectedIndex = (int)currRecipe.Category;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstRecipe_MouseDoubleClick(object sender, EventArgs e)
        {
            int selectedRecipeIndex = lstRecipe.SelectedIndex;
            if (selectedRecipeIndex >= 0)
            {
                Recipe selectedRecipe = recipeManager.GetRecipeAt(selectedRecipeIndex);
                String strOut = $"{selectedRecipe.Name}\n\n" +
                                $"Ingredients: {selectedRecipe.GetIngredientsString()}\n" +
                                $"--------------------\n\n" +
                                $"{selectedRecipe.Instructions}";
                MessageBox.Show(strOut, "COOKING INSTRUCTIONS");
            }
        }
    }
}