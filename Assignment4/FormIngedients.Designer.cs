namespace Assignment4
{
    partial class FormIngedients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpIngedient = new System.Windows.Forms.GroupBox();
            this.lstIngedients = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameIngedient = new System.Windows.Forms.TextBox();
            this.lblNumberOfIngredients = new System.Windows.Forms.Label();
            this.lblCurrNum = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpIngedient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIngedient
            // 
            this.grpIngedient.Controls.Add(this.lstIngedients);
            this.grpIngedient.Controls.Add(this.btnDelete);
            this.grpIngedient.Controls.Add(this.btnEdit);
            this.grpIngedient.Controls.Add(this.btnAdd);
            this.grpIngedient.Controls.Add(this.txtNameIngedient);
            this.grpIngedient.Location = new System.Drawing.Point(31, 55);
            this.grpIngedient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpIngedient.Name = "grpIngedient";
            this.grpIngedient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpIngedient.Size = new System.Drawing.Size(460, 235);
            this.grpIngedient.TabIndex = 0;
            this.grpIngedient.TabStop = false;
            this.grpIngedient.Text = "Ingedient";
            // 
            // lstIngedients
            // 
            this.lstIngedients.FormattingEnabled = true;
            this.lstIngedients.ItemHeight = 15;
            this.lstIngedients.Location = new System.Drawing.Point(25, 73);
            this.lstIngedients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstIngedients.Name = "lstIngedients";
            this.lstIngedients.Size = new System.Drawing.Size(305, 139);
            this.lstIngedients.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(351, 108);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 20);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(351, 73);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 20);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Replace";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 37);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 20);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtNameIngedient
            // 
            this.txtNameIngedient.Location = new System.Drawing.Point(25, 38);
            this.txtNameIngedient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameIngedient.Name = "txtNameIngedient";
            this.txtNameIngedient.Size = new System.Drawing.Size(305, 23);
            this.txtNameIngedient.TabIndex = 0;
            // 
            // lblNumberOfIngredients
            // 
            this.lblNumberOfIngredients.AutoSize = true;
            this.lblNumberOfIngredients.Location = new System.Drawing.Point(31, 25);
            this.lblNumberOfIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfIngredients.Name = "lblNumberOfIngredients";
            this.lblNumberOfIngredients.Size = new System.Drawing.Size(126, 15);
            this.lblNumberOfIngredients.TabIndex = 1;
            this.lblNumberOfIngredients.Text = "Number of ingedients:";
            // 
            // lblCurrNum
            // 
            this.lblCurrNum.AutoSize = true;
            this.lblCurrNum.Location = new System.Drawing.Point(187, 25);
            this.lblCurrNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrNum.Name = "lblCurrNum";
            this.lblCurrNum.Size = new System.Drawing.Size(13, 15);
            this.lblCurrNum.TabIndex = 2;
            this.lblCurrNum.Text = "0";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(116, 301);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 20);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(233, 301);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 20);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormIngedients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 343);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCurrNum);
            this.Controls.Add(this.lblNumberOfIngredients);
            this.Controls.Add(this.grpIngedient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormIngedients";
            this.Text = "FormIngedients";
            this.grpIngedient.ResumeLayout(false);
            this.grpIngedient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAdd;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnOK;
        private GroupBox grpIngedient;
        private Label lblCurrNum;
        private Label lblNumberOfIngredients;
        private ListBox lstIngedients;
        private TextBox txtNameIngedient;
    }
}