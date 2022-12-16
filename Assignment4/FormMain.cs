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
            recipeManager = new RecipeManager(maxNumOfElements);
            currRecipe = new Recipe(maxNumOfIngredients);
        }

        private void InitializeComboBox()
        {
            string[] enumElements = Enum.GetNames(typeof(FoodCategory));
            foreach (var item in enumElements)
            {
                cmbCategory.Items.Add(item);
            }
        }

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

        private void BtnAddRecipe_Click(object sender, EventArgs e)
        {
            currRecipe.Name = txtNameOfRecipe.Text;
            currRecipe.Category = (FoodCategory) cmbCategory.SelectedIndex;
            currRecipe.Instructions = txtInstructions.Text;

            // TO DO: Add checks here for name, category and instructions are not null
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

        private void BtnEditStart_Click(object sender, EventArgs e)
        {
            if (lstRecipe.SelectedIndex >= 0 && lstRecipe.SelectedIndex < recipeManager.GetCurrentNumberOfRecipes())
            {
                btnAddIngredients.Enabled = false;
                btnAddRecipe.Enabled = false;

                currRecipe = recipeManager.GetRecipeAt(lstRecipe.SelectedIndex);

                txtNameOfRecipe.Text = currRecipe.Name;
                txtInstructions.Text = currRecipe.Instructions;
                cmbCategory.SelectedIndex = (int) currRecipe.Category;
                //??? = currRecipe.Ingedients;
            }
        }

        private void BtnEditFinish_Click(object sender, EventArgs e)
        {
            btnAddIngredients.Enabled = true;
            btnAddRecipe.Enabled = true;

            // CHECK THIS PART HERE
            recipeManager.ChangeElement(lstRecipe.SelectedIndex, currRecipe);

            UpdateGUI();
            ClearSelection();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            recipeManager.DeleteElement(lstRecipe.SelectedIndex);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }

        private void ClearSelection()
        {
            txtNameOfRecipe.Clear();
            txtInstructions.Clear();
            cmbCategory.SelectedIndex = -1;
            lstRecipe.SelectedIndex = -1;
        }

        public void InitializeGUI()
        {

        }
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

        private void lstRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstRecipe_MouseDoubleClick(object sender, EventArgs e)
        {
            int selectedRecipeIndex = lstRecipe.SelectedIndex;
            if (selectedRecipeIndex >= 0)
            {
                Recipe selectedRecipe = recipeManager.GetRecipeAt(selectedRecipeIndex);
                MessageBox.Show(String.Format("{0}\n{1}", selectedRecipe.GetIngredientsString(), selectedRecipe.Instructions, selectedRecipe.Name));
            }
        }
    }
}