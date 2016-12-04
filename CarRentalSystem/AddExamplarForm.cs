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
    }
}
