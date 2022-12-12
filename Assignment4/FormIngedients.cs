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

        public FormIngedients(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
        }

        public void InitializeGUI()
        {

        }
        public void UpdateGUI()
        {
            lblCurrNum.Text = Recipe.CurrentNumberOfIngredients().ToString();
            lstIngedients.Items.Clear();
            for (int i = 0; i < Recipe.CurrentNumberOfIngredients(); i++)
            {
                lstIngedients.Items.Add(recipe.Ingedients[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = Recipe.AddIngredient(txtNameIngedient.Text);
            
            if (!success)
                MessageBox.Show("Add ingredient failed", "Error");
            else
                UpdateGUI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
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
    }
}
