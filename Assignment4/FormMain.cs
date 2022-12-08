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
    }
}