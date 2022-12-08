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
        private Recipe _recipe;
        public Recipe Recipe
        {
            get { return _recipe; }
            set { _recipe = value; }
        }

        public FormIngedients(Recipe recipe)
        {
            InitializeComponent();
        }

        public void InitializeGUI()
        {

        }
        public void UpdateGUI()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
