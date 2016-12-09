namespace CarRentalSystem
{
    partial class AddCarForm
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
            this.components = new System.ComponentModel.Container();
            this.AddCarForm_NameLabel = new System.Windows.Forms.Label();
            this.AddCarForm_ClassLabel = new System.Windows.Forms.Label();
            this.AddCarForm_BodyLabel = new System.Windows.Forms.Label();
            this.AddCarForm_PriceLabel = new System.Windows.Forms.Label();
            this.AddCarForm_AddButton = new System.Windows.Forms.Button();
            this.AddCarForm_CancelButton = new System.Windows.Forms.Button();
            this.AddCarForm_NameTextBox = new System.Windows.Forms.TextBox();
            this.AddCarForm_ClassTextBox = new System.Windows.Forms.TextBox();
            this.AddCarForm_BodyTextBox = new System.Windows.Forms.TextBox();
            this.AddCarForm_PriceTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarForm_NameLabel
            // 
            this.AddCarForm_NameLabel.AutoSize = true;
            this.AddCarForm_NameLabel.Location = new System.Drawing.Point(12, 21);
            this.AddCarForm_NameLabel.Name = "AddCarForm_NameLabel";
            this.AddCarForm_NameLabel.Size = new System.Drawing.Size(35, 13);
            this.AddCarForm_NameLabel.TabIndex = 1;
            this.AddCarForm_NameLabel.Text = "Name";
            // 
            // AddCarForm_ClassLabel
            // 
            this.AddCarForm_ClassLabel.AutoSize = true;
            this.AddCarForm_ClassLabel.Location = new System.Drawing.Point(12, 60);
            this.AddCarForm_ClassLabel.Name = "AddCarForm_ClassLabel";
            this.AddCarForm_ClassLabel.Size = new System.Drawing.Size(32, 13);
            this.AddCarForm_ClassLabel.TabIndex = 2;
            this.AddCarForm_ClassLabel.Text = "Class";
            // 
            // AddCarForm_BodyLabel
            // 
            this.AddCarForm_BodyLabel.AutoSize = true;
            this.AddCarForm_BodyLabel.Location = new System.Drawing.Point(12, 102);
            this.AddCarForm_BodyLabel.Name = "AddCarForm_BodyLabel";
            this.AddCarForm_BodyLabel.Size = new System.Drawing.Size(31, 13);
            this.AddCarForm_BodyLabel.TabIndex = 3;
            this.AddCarForm_BodyLabel.Text = "Body";
            // 
            // AddCarForm_PriceLabel
            // 
            this.AddCarForm_PriceLabel.AutoSize = true;
            this.AddCarForm_PriceLabel.Location = new System.Drawing.Point(13, 143);
            this.AddCarForm_PriceLabel.Name = "AddCarForm_PriceLabel";
            this.AddCarForm_PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.AddCarForm_PriceLabel.TabIndex = 4;
            this.AddCarForm_PriceLabel.Text = "Price";
            // 
            // AddCarForm_AddButton
            // 
            this.AddCarForm_AddButton.Location = new System.Drawing.Point(141, 205);
            this.AddCarForm_AddButton.Name = "AddCarForm_AddButton";
            this.AddCarForm_AddButton.Size = new System.Drawing.Size(109, 24);
            this.AddCarForm_AddButton.TabIndex = 5;
            this.AddCarForm_AddButton.Text = "Add...";
            this.AddCarForm_AddButton.UseVisualStyleBackColor = true;
            this.AddCarForm_AddButton.Click += new System.EventHandler(this.AddCarForm_AddButton_Click);
            // 
            // AddCarForm_CancelButton
            // 
            this.AddCarForm_CancelButton.Location = new System.Drawing.Point(256, 205);
            this.AddCarForm_CancelButton.Name = "AddCarForm_CancelButton";
            this.AddCarForm_CancelButton.Size = new System.Drawing.Size(109, 24);
            this.AddCarForm_CancelButton.TabIndex = 6;
            this.AddCarForm_CancelButton.Text = "Cancel";
            this.AddCarForm_CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddCarForm_NameTextBox
            // 
            this.AddCarForm_NameTextBox.Location = new System.Drawing.Point(53, 18);
            this.AddCarForm_NameTextBox.Name = "AddCarForm_NameTextBox";
            this.AddCarForm_NameTextBox.Size = new System.Drawing.Size(252, 20);
            this.AddCarForm_NameTextBox.TabIndex = 7;
            this.AddCarForm_NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddCarForm_NameTextBox_Validating);
            // 
            // AddCarForm_ClassTextBox
            // 
            this.AddCarForm_ClassTextBox.Location = new System.Drawing.Point(53, 57);
            this.AddCarForm_ClassTextBox.Name = "AddCarForm_ClassTextBox";
            this.AddCarForm_ClassTextBox.Size = new System.Drawing.Size(165, 20);
            this.AddCarForm_ClassTextBox.TabIndex = 8;
            this.AddCarForm_ClassTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddCarForm_ClassTextBox_Validating);
            // 
            // AddCarForm_BodyTextBox
            // 
            this.AddCarForm_BodyTextBox.Location = new System.Drawing.Point(53, 102);
            this.AddCarForm_BodyTextBox.Name = "AddCarForm_BodyTextBox";
            this.AddCarForm_BodyTextBox.Size = new System.Drawing.Size(165, 20);
            this.AddCarForm_BodyTextBox.TabIndex = 9;
            this.AddCarForm_BodyTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddCarForm_BodyTextBox_Validating);
            // 
            // AddCarForm_PriceTextBox
            // 
            this.AddCarForm_PriceTextBox.Location = new System.Drawing.Point(53, 140);
            this.AddCarForm_PriceTextBox.Name = "AddCarForm_PriceTextBox";
            this.AddCarForm_PriceTextBox.Size = new System.Drawing.Size(70, 20);
            this.AddCarForm_PriceTextBox.TabIndex = 10;
            this.AddCarForm_PriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddCarForm_PriceTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 241);
            this.Controls.Add(this.AddCarForm_PriceTextBox);
            this.Controls.Add(this.AddCarForm_BodyTextBox);
            this.Controls.Add(this.AddCarForm_ClassTextBox);
            this.Controls.Add(this.AddCarForm_NameTextBox);
            this.Controls.Add(this.AddCarForm_CancelButton);
            this.Controls.Add(this.AddCarForm_AddButton);
            this.Controls.Add(this.AddCarForm_PriceLabel);
            this.Controls.Add(this.AddCarForm_BodyLabel);
            this.Controls.Add(this.AddCarForm_ClassLabel);
            this.Controls.Add(this.AddCarForm_NameLabel);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCarForm_NameLabel;
        private System.Windows.Forms.Label AddCarForm_ClassLabel;
        private System.Windows.Forms.Label AddCarForm_BodyLabel;
        private System.Windows.Forms.Label AddCarForm_PriceLabel;
        private System.Windows.Forms.Button AddCarForm_AddButton;
        private System.Windows.Forms.Button AddCarForm_CancelButton;
        private System.Windows.Forms.TextBox AddCarForm_NameTextBox;
        private System.Windows.Forms.TextBox AddCarForm_ClassTextBox;
        private System.Windows.Forms.TextBox AddCarForm_BodyTextBox;
        private System.Windows.Forms.TextBox AddCarForm_PriceTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}