namespace Assignment4
{
    public partial class FormMain : Form
    {
        const int maxNumOfElements = 10;
        const int maxNumOfIngredients = 10;
        private RecipeManager recipeMngr;
        private Recipe currRecipe;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            currRecipe = new Recipe(maxNumOfIngredients);
            // Creates new ingredients form and opens as a dialog box
            FormIngedients dlg = new FormIngedients(currRecipe);
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

        }

        private void btnEditStart_Click(object sender, EventArgs e)
        {

        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void ClearSelection()
        {

        }

        public void InitializeGUI()
        {

        }
        public void UpdateGUI()
        {

        }

        private void lstRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstRecipe_MouseDoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions.....", "Recipe Name");
        }
    }
}