namespace CarRentalSystem
{
    partial class MainForm
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
            this.labelCars = new System.Windows.Forms.Label();
            this.Examplars_label = new System.Windows.Forms.Label();
            this.Rents_label = new System.Windows.Forms.Label();
            this.Equipment_label = new System.Windows.Forms.Label();
            this.Cars_listBox = new System.Windows.Forms.ListBox();
            this.Examplars_listBox = new System.Windows.Forms.ListBox();
            this.Rents_listBox = new System.Windows.Forms.ListBox();
            this.Equipment_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Location = new System.Drawing.Point(25, 19);
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(28, 13);
            this.labelCars.TabIndex = 0;
            this.labelCars.Text = "Cars";
            // 
            // Examplars_label
            // 
            this.Examplars_label.AutoSize = true;
            this.Examplars_label.Location = new System.Drawing.Point(182, 19);
            this.Examplars_label.Name = "Examplars_label";
            this.Examplars_label.Size = new System.Drawing.Size(55, 13);
            this.Examplars_label.TabIndex = 1;
            this.Examplars_label.Text = "Examplars";
            // 
            // Rents_label
            // 
            this.Rents_label.AutoSize = true;
            this.Rents_label.Location = new System.Drawing.Point(341, 19);
            this.Rents_label.Name = "Rents_label";
            this.Rents_label.Size = new System.Drawing.Size(35, 13);
            this.Rents_label.TabIndex = 2;
            this.Rents_label.Text = "Rents";
            // 
            // Equipment_label
            // 
            this.Equipment_label.AutoSize = true;
            this.Equipment_label.Location = new System.Drawing.Point(500, 19);
            this.Equipment_label.Name = "Equipment_label";
            this.Equipment_label.Size = new System.Drawing.Size(57, 13);
            this.Equipment_label.TabIndex = 3;
            this.Equipment_label.Text = "Equipment";
            // 
            // Cars_listBox
            // 
            this.Cars_listBox.FormattingEnabled = true;
            this.Cars_listBox.Location = new System.Drawing.Point(26, 45);
            this.Cars_listBox.Name = "Cars_listBox";
            this.Cars_listBox.Size = new System.Drawing.Size(153, 225);
            this.Cars_listBox.TabIndex = 4;
            // 
            // Examplars_listBox
            // 
            this.Examplars_listBox.FormattingEnabled = true;
            this.Examplars_listBox.Location = new System.Drawing.Point(185, 45);
            this.Examplars_listBox.Name = "Examplars_listBox";
            this.Examplars_listBox.Size = new System.Drawing.Size(153, 225);
            this.Examplars_listBox.TabIndex = 5;
            // 
            // Rents_listBox
            // 
            this.Rents_listBox.FormattingEnabled = true;
            this.Rents_listBox.Location = new System.Drawing.Point(344, 45);
            this.Rents_listBox.Name = "Rents_listBox";
            this.Rents_listBox.Size = new System.Drawing.Size(153, 225);
            this.Rents_listBox.TabIndex = 6;
            // 
            // Equipment_listBox
            // 
            this.Equipment_listBox.FormattingEnabled = true;
            this.Equipment_listBox.Location = new System.Drawing.Point(503, 45);
            this.Equipment_listBox.Name = "Equipment_listBox";
            this.Equipment_listBox.Size = new System.Drawing.Size(153, 225);
            this.Equipment_listBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 469);
            this.Controls.Add(this.Equipment_listBox);
            this.Controls.Add(this.Rents_listBox);
            this.Controls.Add(this.Examplars_listBox);
            this.Controls.Add(this.Cars_listBox);
            this.Controls.Add(this.Equipment_label);
            this.Controls.Add(this.Rents_label);
            this.Controls.Add(this.Examplars_label);
            this.Controls.Add(this.labelCars);
            this.Name = "MainForm";
            this.Text = "Car rental System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCars;
        private System.Windows.Forms.Label Examplars_label;
        private System.Windows.Forms.Label Rents_label;
        private System.Windows.Forms.Label Equipment_label;
        private System.Windows.Forms.ListBox Cars_listBox;
        private System.Windows.Forms.ListBox Examplars_listBox;
        private System.Windows.Forms.ListBox Rents_listBox;
        private System.Windows.Forms.ListBox Equipment_listBox;
    }
}

