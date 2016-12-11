using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalSystem
{
    public partial class AddExamplarForm : Form
    {
        int carid;
        SqlConnection connection;
        string connectionString;
        public AddExamplarForm(int carid, string connectionstr)
        {
            InitializeComponent();
            this.carid = carid;
            this.connectionString = connectionstr;
        }

        private void AddExamplarButton_Click(object sender, EventArgs e) //normal INSERT
        {
            /*
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
                var ex = context.Examplars.FirstOrDefault(x => x.VIN == this.VINtextBox.Text);

                if(ex == null) context.SaveChanges();
            }
            */
            string query = "INSERT INTO Examplar(VIN, CarID, Year, Color, Fuel_cost) VALUES(@VIN, @CarID, @Year, @Color, @Fuel_cost)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@VIN", this.VINtextBox.Text);
                command.Parameters.AddWithValue("@CarID", this.carid);
                command.Parameters.AddWithValue("@Year", Int32.Parse(this.YearTextBox.Text));
                command.Parameters.AddWithValue("@Color", this.ColorTextBox.Text);
                command.Parameters.AddWithValue("@Fuel_cost", decimal.Parse(this.FuelTextBox.Text));

                command.ExecuteScalar();
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
