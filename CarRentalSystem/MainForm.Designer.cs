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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MaintabPage = new System.Windows.Forms.TabPage();
            this.AddExamplarButton = new System.Windows.Forms.Button();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.Infobutton = new System.Windows.Forms.Button();
            this.Rentbutton = new System.Windows.Forms.Button();
            this.ClientstabPage = new System.Windows.Forms.TabPage();
            this.UpdateClientbutton = new System.Windows.Forms.Button();
            this.RemoveClientbutton = new System.Windows.Forms.Button();
            this.ReturnCarButton = new System.Windows.Forms.Button();
            this.ClientsRentlabel = new System.Windows.Forms.Label();
            this.RentslistBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientslistBox = new System.Windows.Forms.ListBox();
            this.EquipmenttabPage = new System.Windows.Forms.TabPage();
            this.FindEquipmentbutton = new System.Windows.Forms.Button();
            this.UpdateEquipmentbutton = new System.Windows.Forms.Button();
            this.RemoveEquipmentbutton = new System.Windows.Forms.Button();
            this.AddNewEquipmentbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AllEquipmentlistBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clientSearchBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.MaintabPage.SuspendLayout();
            this.ClientstabPage.SuspendLayout();
            this.EquipmenttabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Location = new System.Drawing.Point(9, 3);
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(28, 13);
            this.labelCars.TabIndex = 0;
            this.labelCars.Text = "Cars";
            // 
            // Examplars_label
            // 
            this.Examplars_label.AutoSize = true;
            this.Examplars_label.Location = new System.Drawing.Point(227, 3);
            this.Examplars_label.Name = "Examplars_label";
            this.Examplars_label.Size = new System.Drawing.Size(55, 13);
            this.Examplars_label.TabIndex = 1;
            this.Examplars_label.Text = "Examplars";
            // 
            // Rents_label
            // 
            this.Rents_label.AutoSize = true;
            this.Rents_label.Location = new System.Drawing.Point(227, 104);
            this.Rents_label.Name = "Rents_label";
            this.Rents_label.Size = new System.Drawing.Size(35, 13);
            this.Rents_label.TabIndex = 2;
            this.Rents_label.Text = "Rents";
            // 
            // Equipment_label
            // 
            this.Equipment_label.AutoSize = true;
            this.Equipment_label.Location = new System.Drawing.Point(9, 104);
            this.Equipment_label.Name = "Equipment_label";
            this.Equipment_label.Size = new System.Drawing.Size(57, 13);
            this.Equipment_label.TabIndex = 3;
            this.Equipment_label.Text = "Equipment";
            this.Equipment_label.Click += new System.EventHandler(this.Equipment_label_Click);
            // 
            // Cars_listBox
            // 
            this.Cars_listBox.FormattingEnabled = true;
            this.Cars_listBox.Location = new System.Drawing.Point(12, 19);
            this.Cars_listBox.Name = "Cars_listBox";
            this.Cars_listBox.Size = new System.Drawing.Size(214, 82);
            this.Cars_listBox.TabIndex = 4;
            this.Cars_listBox.SelectedIndexChanged += new System.EventHandler(this.Cars_listBox_SelectedIndexChanged);
            // 
            // Examplars_listBox
            // 
            this.Examplars_listBox.FormattingEnabled = true;
            this.Examplars_listBox.Location = new System.Drawing.Point(230, 19);
            this.Examplars_listBox.Name = "Examplars_listBox";
            this.Examplars_listBox.Size = new System.Drawing.Size(479, 82);
            this.Examplars_listBox.TabIndex = 5;
            this.Examplars_listBox.SelectedIndexChanged += new System.EventHandler(this.Examplars_listBox_SelectedIndexChanged);
            // 
            // Rents_listBox
            // 
            this.Rents_listBox.FormattingEnabled = true;
            this.Rents_listBox.Location = new System.Drawing.Point(230, 120);
            this.Rents_listBox.Name = "Rents_listBox";
            this.Rents_listBox.Size = new System.Drawing.Size(479, 95);
            this.Rents_listBox.TabIndex = 6;
            this.Rents_listBox.SelectedIndexChanged += new System.EventHandler(this.Rents_listBox_SelectedIndexChanged);
            // 
            // Equipment_listBox
            // 
            this.Equipment_listBox.FormattingEnabled = true;
            this.Equipment_listBox.Location = new System.Drawing.Point(12, 120);
            this.Equipment_listBox.Name = "Equipment_listBox";
            this.Equipment_listBox.Size = new System.Drawing.Size(212, 95);
            this.Equipment_listBox.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MaintabPage);
            this.tabControl1.Controls.Add(this.ClientstabPage);
            this.tabControl1.Controls.Add(this.EquipmenttabPage);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 531);
            this.tabControl1.TabIndex = 8;
            // 
            // MaintabPage
            // 
            this.MaintabPage.Controls.Add(this.AddExamplarButton);
            this.MaintabPage.Controls.Add(this.AddCarButton);
            this.MaintabPage.Controls.Add(this.Infobutton);
            this.MaintabPage.Controls.Add(this.Rentbutton);
            this.MaintabPage.Controls.Add(this.labelCars);
            this.MaintabPage.Controls.Add(this.Rents_listBox);
            this.MaintabPage.Controls.Add(this.Equipment_listBox);
            this.MaintabPage.Controls.Add(this.Rents_label);
            this.MaintabPage.Controls.Add(this.Cars_listBox);
            this.MaintabPage.Controls.Add(this.Examplars_label);
            this.MaintabPage.Controls.Add(this.Equipment_label);
            this.MaintabPage.Controls.Add(this.Examplars_listBox);
            this.MaintabPage.Location = new System.Drawing.Point(4, 22);
            this.MaintabPage.Name = "MaintabPage";
            this.MaintabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MaintabPage.Size = new System.Drawing.Size(789, 505);
            this.MaintabPage.TabIndex = 0;
            this.MaintabPage.Text = "Main";
            this.MaintabPage.UseVisualStyleBackColor = true;
            // 
            // AddExamplarButton
            // 
            this.AddExamplarButton.Location = new System.Drawing.Point(14, 406);
            this.AddExamplarButton.Name = "AddExamplarButton";
            this.AddExamplarButton.Size = new System.Drawing.Size(209, 42);
            this.AddExamplarButton.TabIndex = 11;
            this.AddExamplarButton.Text = "Add examplar...";
            this.AddExamplarButton.UseVisualStyleBackColor = true;
            this.AddExamplarButton.Click += new System.EventHandler(this.AddExamplarButton_Click);
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(12, 350);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(213, 41);
            this.AddCarButton.TabIndex = 10;
            this.AddCarButton.Text = "Add new car...";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // Infobutton
            // 
            this.Infobutton.Location = new System.Drawing.Point(230, 239);
            this.Infobutton.Name = "Infobutton";
            this.Infobutton.Size = new System.Drawing.Size(101, 38);
            this.Infobutton.TabIndex = 9;
            this.Infobutton.Text = "More info...";
            this.Infobutton.UseVisualStyleBackColor = true;
            // 
            // Rentbutton
            // 
            this.Rentbutton.Location = new System.Drawing.Point(12, 239);
            this.Rentbutton.Name = "Rentbutton";
            this.Rentbutton.Size = new System.Drawing.Size(212, 38);
            this.Rentbutton.TabIndex = 8;
            this.Rentbutton.Text = "Rent car";
            this.Rentbutton.UseVisualStyleBackColor = true;
            this.Rentbutton.Click += new System.EventHandler(this.Rentbutton_Click);
            // 
            // ClientstabPage
            // 
            this.ClientstabPage.Controls.Add(this.clientSearchBox);
            this.ClientstabPage.Controls.Add(this.UpdateClientbutton);
            this.ClientstabPage.Controls.Add(this.RemoveClientbutton);
            this.ClientstabPage.Controls.Add(this.ReturnCarButton);
            this.ClientstabPage.Controls.Add(this.ClientsRentlabel);
            this.ClientstabPage.Controls.Add(this.RentslistBox2);
            this.ClientstabPage.Controls.Add(this.label1);
            this.ClientstabPage.Controls.Add(this.ClientslistBox);
            this.ClientstabPage.Location = new System.Drawing.Point(4, 22);
            this.ClientstabPage.Name = "ClientstabPage";
            this.ClientstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientstabPage.Size = new System.Drawing.Size(789, 505);
            this.ClientstabPage.TabIndex = 1;
            this.ClientstabPage.Text = "Clients";
            this.ClientstabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateClientbutton
            // 
            this.UpdateClientbutton.Location = new System.Drawing.Point(26, 245);
            this.UpdateClientbutton.Name = "UpdateClientbutton";
            this.UpdateClientbutton.Size = new System.Drawing.Size(126, 32);
            this.UpdateClientbutton.TabIndex = 6;
            this.UpdateClientbutton.Text = "Update information...";
            this.UpdateClientbutton.UseVisualStyleBackColor = true;
            // 
            // RemoveClientbutton
            // 
            this.RemoveClientbutton.Location = new System.Drawing.Point(158, 245);
            this.RemoveClientbutton.Name = "RemoveClientbutton";
            this.RemoveClientbutton.Size = new System.Drawing.Size(108, 32);
            this.RemoveClientbutton.TabIndex = 5;
            this.RemoveClientbutton.Text = "Remove client";
            this.RemoveClientbutton.UseVisualStyleBackColor = true;
            this.RemoveClientbutton.Click += new System.EventHandler(this.RemoveClientbutton_Click);
            // 
            // ReturnCarButton
            // 
            this.ReturnCarButton.Location = new System.Drawing.Point(575, 245);
            this.ReturnCarButton.Name = "ReturnCarButton";
            this.ReturnCarButton.Size = new System.Drawing.Size(208, 32);
            this.ReturnCarButton.TabIndex = 4;
            this.ReturnCarButton.Text = "Return car";
            this.ReturnCarButton.UseVisualStyleBackColor = true;
            this.ReturnCarButton.Click += new System.EventHandler(this.ReturnCarButton_Click);
            // 
            // ClientsRentlabel
            // 
            this.ClientsRentlabel.AutoSize = true;
            this.ClientsRentlabel.Location = new System.Drawing.Point(269, 63);
            this.ClientsRentlabel.Name = "ClientsRentlabel";
            this.ClientsRentlabel.Size = new System.Drawing.Size(59, 13);
            this.ClientsRentlabel.TabIndex = 3;
            this.ClientsRentlabel.Text = "Client rents";
            // 
            // RentslistBox2
            // 
            this.RentslistBox2.FormattingEnabled = true;
            this.RentslistBox2.Location = new System.Drawing.Point(272, 79);
            this.RentslistBox2.Name = "RentslistBox2";
            this.RentslistBox2.Size = new System.Drawing.Size(511, 160);
            this.RentslistBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients";
            // 
            // ClientslistBox
            // 
            this.ClientslistBox.FormattingEnabled = true;
            this.ClientslistBox.Location = new System.Drawing.Point(26, 79);
            this.ClientslistBox.Name = "ClientslistBox";
            this.ClientslistBox.Size = new System.Drawing.Size(240, 160);
            this.ClientslistBox.TabIndex = 0;
            this.ClientslistBox.SelectedIndexChanged += new System.EventHandler(this.ClientslistBox_SelectedIndexChanged);
            // 
            // EquipmenttabPage
            // 
            this.EquipmenttabPage.Controls.Add(this.FindEquipmentbutton);
            this.EquipmenttabPage.Controls.Add(this.UpdateEquipmentbutton);
            this.EquipmenttabPage.Controls.Add(this.RemoveEquipmentbutton);
            this.EquipmenttabPage.Controls.Add(this.AddNewEquipmentbutton);
            this.EquipmenttabPage.Controls.Add(this.label2);
            this.EquipmenttabPage.Controls.Add(this.AllEquipmentlistBox);
            this.EquipmenttabPage.Location = new System.Drawing.Point(4, 22);
            this.EquipmenttabPage.Name = "EquipmenttabPage";
            this.EquipmenttabPage.Size = new System.Drawing.Size(789, 505);
            this.EquipmenttabPage.TabIndex = 2;
            this.EquipmenttabPage.Text = "Equipment";
            this.EquipmenttabPage.UseVisualStyleBackColor = true;
            // 
            // FindEquipmentbutton
            // 
            this.FindEquipmentbutton.Location = new System.Drawing.Point(465, 31);
            this.FindEquipmentbutton.Name = "FindEquipmentbutton";
            this.FindEquipmentbutton.Size = new System.Drawing.Size(86, 31);
            this.FindEquipmentbutton.TabIndex = 5;
            this.FindEquipmentbutton.Text = "Find...";
            this.FindEquipmentbutton.UseVisualStyleBackColor = true;
            this.FindEquipmentbutton.Click += new System.EventHandler(this.FindEquipmentbutton_Click);
            // 
            // UpdateEquipmentbutton
            // 
            this.UpdateEquipmentbutton.Location = new System.Drawing.Point(283, 105);
            this.UpdateEquipmentbutton.Name = "UpdateEquipmentbutton";
            this.UpdateEquipmentbutton.Size = new System.Drawing.Size(151, 31);
            this.UpdateEquipmentbutton.TabIndex = 4;
            this.UpdateEquipmentbutton.Text = "Update";
            this.UpdateEquipmentbutton.UseVisualStyleBackColor = true;
            this.UpdateEquipmentbutton.Click += new System.EventHandler(this.UpdateEquipmentbutton_Click);
            // 
            // RemoveEquipmentbutton
            // 
            this.RemoveEquipmentbutton.Location = new System.Drawing.Point(283, 68);
            this.RemoveEquipmentbutton.Name = "RemoveEquipmentbutton";
            this.RemoveEquipmentbutton.Size = new System.Drawing.Size(151, 31);
            this.RemoveEquipmentbutton.TabIndex = 3;
            this.RemoveEquipmentbutton.Text = "Remove";
            this.RemoveEquipmentbutton.UseVisualStyleBackColor = true;
            this.RemoveEquipmentbutton.Click += new System.EventHandler(this.RemoveEquipmentbutton_Click);
            // 
            // AddNewEquipmentbutton
            // 
            this.AddNewEquipmentbutton.Location = new System.Drawing.Point(283, 31);
            this.AddNewEquipmentbutton.Name = "AddNewEquipmentbutton";
            this.AddNewEquipmentbutton.Size = new System.Drawing.Size(151, 31);
            this.AddNewEquipmentbutton.TabIndex = 2;
            this.AddNewEquipmentbutton.Text = "Add New";
            this.AddNewEquipmentbutton.UseVisualStyleBackColor = true;
            this.AddNewEquipmentbutton.Click += new System.EventHandler(this.AddNewEquipmentbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipment:";
            // 
            // AllEquipmentlistBox
            // 
            this.AllEquipmentlistBox.FormattingEnabled = true;
            this.AllEquipmentlistBox.Location = new System.Drawing.Point(17, 31);
            this.AllEquipmentlistBox.Name = "AllEquipmentlistBox";
            this.AllEquipmentlistBox.Size = new System.Drawing.Size(260, 446);
            this.AllEquipmentlistBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(789, 505);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clientSearchBox
            // 
            this.clientSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.clientSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clientSearchBox.Location = new System.Drawing.Point(26, 24);
            this.clientSearchBox.Name = "clientSearchBox";
            this.clientSearchBox.Size = new System.Drawing.Size(243, 20);
            this.clientSearchBox.TabIndex = 7;
            this.clientSearchBox.TextChanged += new System.EventHandler(this.clientSearchBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Car rental System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.MaintabPage.ResumeLayout(false);
            this.MaintabPage.PerformLayout();
            this.ClientstabPage.ResumeLayout(false);
            this.ClientstabPage.PerformLayout();
            this.EquipmenttabPage.ResumeLayout(false);
            this.EquipmenttabPage.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MaintabPage;
        private System.Windows.Forms.TabPage ClientstabPage;
        private System.Windows.Forms.TabPage EquipmenttabPage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label ClientsRentlabel;
        private System.Windows.Forms.ListBox RentslistBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ClientslistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AllEquipmentlistBox;
        private System.Windows.Forms.Button UpdateEquipmentbutton;
        private System.Windows.Forms.Button RemoveEquipmentbutton;
        private System.Windows.Forms.Button AddNewEquipmentbutton;
        private System.Windows.Forms.Button Rentbutton;
        private System.Windows.Forms.Button ReturnCarButton;
        private System.Windows.Forms.Button Infobutton;
        private System.Windows.Forms.Button FindEquipmentbutton;
        private System.Windows.Forms.Button UpdateClientbutton;
        private System.Windows.Forms.Button RemoveClientbutton;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button AddExamplarButton;
        private System.Windows.Forms.TextBox clientSearchBox;
    }
}

