namespace Assignment4
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAddRecipe = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtNameOfRecipe = new System.Windows.Forms.TextBox();
            this.lblNameOfRecipe = new System.Windows.Forms.Label();
            this.lblListRecipt = new System.Windows.Forms.Label();
            this.lblListCategory = new System.Windows.Forms.Label();
            this.lblListNumIngedients = new System.Windows.Forms.Label();
            this.lstRecipe = new System.Windows.Forms.ListBox();
            this.btnEditStart = new System.Windows.Forms.Button();
            this.btnEditFinish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.grpAddRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddRecipe
            // 
            this.grpAddRecipe.Controls.Add(this.textBox1);
            this.grpAddRecipe.Controls.Add(this.btnAddRecipe);
            this.grpAddRecipe.Controls.Add(this.cmbCategory);
            this.grpAddRecipe.Controls.Add(this.btnAddIngredients);
            this.grpAddRecipe.Controls.Add(this.lblCategory);
            this.grpAddRecipe.Controls.Add(this.txtNameOfRecipe);
            this.grpAddRecipe.Controls.Add(this.lblNameOfRecipe);
            this.grpAddRecipe.Location = new System.Drawing.Point(39, 36);
            this.grpAddRecipe.Name = "grpAddRecipe";
            this.grpAddRecipe.Size = new System.Drawing.Size(590, 654);
            this.grpAddRecipe.TabIndex = 0;
            this.grpAddRecipe.TabStop = false;
            this.grpAddRecipe.Text = "Add New Recipe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 362);
            this.textBox1.TabIndex = 7;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(26, 584);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(513, 34);
            this.btnAddRecipe.TabIndex = 6;
            this.btnAddRecipe.Text = "Add recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(122, 112);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(182, 33);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(359, 113);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(180, 34);
            this.btnAddIngredients.TabIndex = 3;
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(26, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 25);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // txtNameOfRecipe
            // 
            this.txtNameOfRecipe.Location = new System.Drawing.Point(165, 45);
            this.txtNameOfRecipe.Name = "txtNameOfRecipe";
            this.txtNameOfRecipe.Size = new System.Drawing.Size(374, 31);
            this.txtNameOfRecipe.TabIndex = 1;
            // 
            // lblNameOfRecipe
            // 
            this.lblNameOfRecipe.AutoSize = true;
            this.lblNameOfRecipe.Location = new System.Drawing.Point(28, 48);
            this.lblNameOfRecipe.Name = "lblNameOfRecipe";
            this.lblNameOfRecipe.Size = new System.Drawing.Size(133, 25);
            this.lblNameOfRecipe.TabIndex = 0;
            this.lblNameOfRecipe.Text = "Name of recipe";
            // 
            // lblListRecipt
            // 
            this.lblListRecipt.AutoSize = true;
            this.lblListRecipt.Location = new System.Drawing.Point(783, 57);
            this.lblListRecipt.Name = "lblListRecipt";
            this.lblListRecipt.Size = new System.Drawing.Size(59, 25);
            this.lblListRecipt.TabIndex = 1;
            this.lblListRecipt.Text = "Name";
            // 
            // lblListCategory
            // 
            this.lblListCategory.AutoSize = true;
            this.lblListCategory.Location = new System.Drawing.Point(955, 57);
            this.lblListCategory.Name = "lblListCategory";
            this.lblListCategory.Size = new System.Drawing.Size(84, 25);
            this.lblListCategory.TabIndex = 2;
            this.lblListCategory.Text = "Category";
            // 
            // lblListNumIngedients
            // 
            this.lblListNumIngedients.AutoSize = true;
            this.lblListNumIngedients.Location = new System.Drawing.Point(1200, 61);
            this.lblListNumIngedients.Name = "lblListNumIngedients";
            this.lblListNumIngedients.Size = new System.Drawing.Size(149, 25);
            this.lblListNumIngedients.TabIndex = 3;
            this.lblListNumIngedients.Text = "No. of ingedients";
            // 
            // lstRecipe
            // 
            this.lstRecipe.FormattingEnabled = true;
            this.lstRecipe.ItemHeight = 25;
            this.lstRecipe.Location = new System.Drawing.Point(757, 115);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(631, 479);
            this.lstRecipe.TabIndex = 4;
            this.lstRecipe.SelectedIndexChanged += new System.EventHandler(this.lstRecipe_SelectedIndexChanged);
            this.lstRecipe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRecipe_MouseDoubleClick);
            // 
            // btnEditStart
            // 
            this.btnEditStart.Location = new System.Drawing.Point(757, 620);
            this.btnEditStart.Name = "btnEditStart";
            this.btnEditStart.Size = new System.Drawing.Size(112, 34);
            this.btnEditStart.TabIndex = 5;
            this.btnEditStart.Text = "Edit-Begin";
            this.btnEditStart.UseVisualStyleBackColor = true;
            this.btnEditStart.Click += new System.EventHandler(this.btnEditStart_Click);
            // 
            // btnEditFinish
            // 
            this.btnEditFinish.Location = new System.Drawing.Point(930, 620);
            this.btnEditFinish.Name = "btnEditFinish";
            this.btnEditFinish.Size = new System.Drawing.Size(112, 34);
            this.btnEditFinish.TabIndex = 6;
            this.btnEditFinish.Text = "Edit-Finish";
            this.btnEditFinish.UseVisualStyleBackColor = true;
            this.btnEditFinish.Click += new System.EventHandler(this.btnEditFinish_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1103, 620);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1276, 620);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(847, 680);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(466, 25);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Text = "Double click on item for ingediants _cooking instructions!";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 724);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditFinish);
            this.Controls.Add(this.btnEditStart);
            this.Controls.Add(this.lstRecipe);
            this.Controls.Add(this.lblListNumIngedients);
            this.Controls.Add(this.lblListCategory);
            this.Controls.Add(this.lblListRecipt);
            this.Controls.Add(this.grpAddRecipe);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.grpAddRecipe.ResumeLayout(false);
            this.grpAddRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddIngredients;
        private Button btnAddRecipe;
        private Button btnEditStart;
        private Button btnEditFinish;
        private Button btnDelete;
        private Button btnClear;
        private ComboBox cmbCategory;
        private GroupBox grpAddRecipe;
        private Label lblNameOfRecipe;
        private Label lblCategory;
        private Label lblListCategory;
        private Label lblListNumIngedients;
        private Label lblListRecipt;
        private ListBox lstRecipe;
        private TextBox txtNameOfRecipe;

        private Label lblInstructions;
        private TextBox textBox1;
    }
}