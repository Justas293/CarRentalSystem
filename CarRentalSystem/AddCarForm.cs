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
    }
}
