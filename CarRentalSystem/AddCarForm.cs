using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCarForm_AddButton_Click(object sender, EventArgs e)
        {
             using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
             {
                 context.Cars.Add(new Car
                 {
                     Title = this.AddCarForm_NameTextBox.Text,
                     Class = this.AddCarForm_ClassTextBox.Text,
                     Body = this.AddCarForm_BodyTextBox.Text,
                     Price = Int32.Parse(this.AddCarForm_PriceTextBox.Text)
                 });
                 context.SaveChanges();
             }
             this.Dispose();    
        }

        private void AddCarForm_NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddCarForm_NameTextBox.Text))
            {
                errorProvider1.SetError(AddCarForm_NameTextBox, "Please enter model name!");
                AddCarForm_NameTextBox.Focus();
            }
            else
            {
                errorProvider1.SetError(AddCarForm_NameTextBox, null);
            }
        }

        private void AddCarForm_ClassTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddCarForm_ClassTextBox.Text))
            {
                errorProvider1.SetError(AddCarForm_ClassTextBox, "Please enter model class!");
            }
            else
            {
                errorProvider1.SetError(AddCarForm_ClassTextBox, null);
            }
        }

        private void AddCarForm_BodyTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddCarForm_BodyTextBox.Text))
            {
                errorProvider1.SetError(AddCarForm_BodyTextBox, "Please enter model name!");
            }
            else
            {
                errorProvider1.SetError(AddCarForm_BodyTextBox, null);
            }
        }

        private void AddCarForm_PriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            int res;
            if (!int.TryParse(AddCarForm_PriceTextBox.Text, out res))
            {
                errorProvider1.SetError(AddCarForm_PriceTextBox, "Invalid value!");
            }
            else
            {
                errorProvider1.SetError(AddCarForm_PriceTextBox, null);
            }
        }
    }
}
