namespace CarRentalSystem
{
    partial class AddExamplarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VINtextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.FuelTextBox = new System.Windows.Forms.TextBox();
            this.AddExamplarButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fuel economy";
            // 
            // VINtextBox
            // 
            this.VINtextBox.Location = new System.Drawing.Point(99, 22);
            this.VINtextBox.Name = "VINtextBox";
            this.VINtextBox.Size = new System.Drawing.Size(207, 20);
            this.VINtextBox.TabIndex = 6;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(99, 62);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(94, 20);
            this.YearTextBox.TabIndex = 7;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(98, 100);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(94, 20);
            this.ColorTextBox.TabIndex = 8;
            // 
            // FuelTextBox
            // 
            this.FuelTextBox.Location = new System.Drawing.Point(98, 142);
            this.FuelTextBox.Name = "FuelTextBox";
            this.FuelTextBox.Size = new System.Drawing.Size(94, 20);
            this.FuelTextBox.TabIndex = 9;
            // 
            // AddExamplarButton
            // 
            this.AddExamplarButton.Location = new System.Drawing.Point(85, 192);
            this.AddExamplarButton.Name = "AddExamplarButton";
            this.AddExamplarButton.Size = new System.Drawing.Size(107, 27);
            this.AddExamplarButton.TabIndex = 10;
            this.AddExamplarButton.Text = "Add...";
            this.AddExamplarButton.UseVisualStyleBackColor = true;
            this.AddExamplarButton.Click += new System.EventHandler(this.AddExamplarButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(200, 192);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 27);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddExamplarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 245);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddExamplarButton);
            this.Controls.Add(this.FuelTextBox);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.VINtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddExamplarForm";
            this.Text = "AddExamplarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VINtextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox FuelTextBox;
        private System.Windows.Forms.Button AddExamplarButton;
        private System.Windows.Forms.Button CancelButton;
    }
}