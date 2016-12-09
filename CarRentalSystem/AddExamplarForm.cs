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
    public partial class AddExamplarForm : Form
    {
        int carid;
        public AddExamplarForm(int carid)
        {
            InitializeComponent();
            this.carid = carid;
        }

        private void AddExamplarButton_Click(object sender, EventArgs e)
        {
            using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
            {
                context.Examplars.Add(new Examplar
                {
                    VIN = this.VINtextBox.Text,
                    CarID = this.carid,
                    Year = Int32.Parse(this.YearTextBox.Text),
                    Color = this.ColorTextBox.Text,
                    Fuel_cost = Decimal.Parse(this.FuelTextBox.Text)
                });
                context.SaveChanges();
            }
            this.Dispose();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void VINtextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(VINtextBox.Text))
            {
                errorProvider1.SetError(VINtextBox, "Please enter VIN number!");
            }
            else
            {
                errorProvider1.SetError(VINtextBox, null);
            }
        }

        private void YearTextBox_Validating(object sender, CancelEventArgs e)
        {
            int res;
            if (!int.TryParse(YearTextBox.Text, out res))
            {
                errorProvider1.SetError(YearTextBox, "Invalid value!");
            }
            else
            {
                errorProvider1.SetError(YearTextBox, null);
            }
        }

        private void ColorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ColorTextBox.Text))
            {
                errorProvider1.SetError(ColorTextBox, "Please enter color!");
            }
            else
            {
                errorProvider1.SetError(ColorTextBox, null);
            }
        }

        private void FuelTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal res;
            if (!decimal.TryParse(FuelTextBox.Text, out res))
            {
                errorProvider1.SetError(FuelTextBox, "Invalid value!");
            }
            else
            {
                errorProvider1.SetError(FuelTextBox, null);
            }
        }
    }
}
