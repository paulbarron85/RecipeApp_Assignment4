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

        private void btnAddIngredients_Click(object sender, EventArgs e)
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

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            currRecipe.Name = txtNameOfRecipe.Text;
            currRecipe.Category = (FoodCategory) cmbCategory.SelectedIndex;
            currRecipe.Instructions = txtInstructions.Text;

            recipeManager.Add(currRecipe);
            //recipeManager.Add(txtNameOfRecipe.Text, cmbCategory.Text, lblInstructions.Text);

            UpdateGUI();
            ClearSelection();

            currRecipe = new Recipe(maxNumOfIngredients);
        }

        private void btnEditStart_Click(object sender, EventArgs e)
        {
            btnAddIngredients.Enabled = false;
            btnAddRecipe.Enabled = false;
        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            btnAddIngredients.Enabled = true;
            btnAddRecipe.Enabled = true;

            UpdateGUI();
            ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            recipeManager.DeleteElement(lstRecipe.SelectedIndex);
        }

        private void btnClear_Click(object sender, EventArgs e)
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
                MessageBox.Show(String.Format("{0}\n{1}", selectedRecipe.GetIngredientsString(), selectedRecipe.Instructions, selectedRecipe.Category.ToString()));
            }
        }
    }
}