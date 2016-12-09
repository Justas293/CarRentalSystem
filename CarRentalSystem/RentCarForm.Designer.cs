namespace CarRentalSystem
{
    partial class RentCarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rentbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.RentCarNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonCompany = new System.Windows.Forms.RadioButton();
            this.radioButtonIndividual = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.companyCodeTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick-up day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Return day";
            // 
            // Rentbutton
            // 
            this.Rentbutton.Location = new System.Drawing.Point(92, 287);
            this.Rentbutton.Name = "Rentbutton";
            this.Rentbutton.Size = new System.Drawing.Size(91, 29);
            this.Rentbutton.TabIndex = 4;
            this.Rentbutton.Text = "Rent...";
            this.Rentbutton.UseVisualStyleBackColor = true;
            this.Rentbutton.Click += new System.EventHandler(this.Rentbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(189, 287);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(88, 29);
            this.Cancelbutton.TabIndex = 5;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "E-mail";
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(116, 84);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(168, 20);
            this.PhonetextBox.TabIndex = 10;
            this.PhonetextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PhonetextBox_Validating);
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(116, 110);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(168, 20);
            this.AddresstextBox.TabIndex = 11;
            this.AddresstextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddresstextBox_Validating);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(116, 138);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(168, 20);
            this.EmailtextBox.TabIndex = 12;
            this.EmailtextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmailtextBox_Validating);
            // 
            // RentCarNameTextBox
            // 
            this.RentCarNameTextBox.Location = new System.Drawing.Point(37, 25);
            this.RentCarNameTextBox.Name = "RentCarNameTextBox";
            this.RentCarNameTextBox.Size = new System.Drawing.Size(247, 20);
            this.RentCarNameTextBox.TabIndex = 14;
            this.RentCarNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RentCarNameTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name and Surname / Company name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 172);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 199);
            this.dateTimePicker2.MinDate = new System.DateTime(2016, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // radioButtonCompany
            // 
            this.radioButtonCompany.AutoSize = true;
            this.radioButtonCompany.Location = new System.Drawing.Point(116, 244);
            this.radioButtonCompany.Name = "radioButtonCompany";
            this.radioButtonCompany.Size = new System.Drawing.Size(69, 17);
            this.radioButtonCompany.TabIndex = 18;
            this.radioButtonCompany.TabStop = true;
            this.radioButtonCompany.Text = "Company";
            this.radioButtonCompany.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndividual
            // 
            this.radioButtonIndividual.AutoSize = true;
            this.radioButtonIndividual.Checked = true;
            this.radioButtonIndividual.Location = new System.Drawing.Point(199, 244);
            this.radioButtonIndividual.Name = "radioButtonIndividual";
            this.radioButtonIndividual.Size = new System.Drawing.Size(70, 17);
            this.radioButtonIndividual.TabIndex = 19;
            this.radioButtonIndividual.TabStop = true;
            this.radioButtonIndividual.Text = "Individual";
            this.radioButtonIndividual.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Company code";
            // 
            // companyCodeTextBox
            // 
            this.companyCodeTextBox.Location = new System.Drawing.Point(116, 55);
            this.companyCodeTextBox.Name = "companyCodeTextBox";
            this.companyCodeTextBox.Size = new System.Drawing.Size(168, 20);
            this.companyCodeTextBox.TabIndex = 21;
            this.companyCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.companyCodeTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RentCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 328);
            this.Controls.Add(this.companyCodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonIndividual);
            this.Controls.Add(this.radioButtonCompany);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RentCarNameTextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.PhonetextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Rentbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentCarForm";
            this.Text = "RentCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Rentbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox RentCarNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton radioButtonCompany;
        private System.Windows.Forms.RadioButton radioButtonIndividual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companyCodeTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}