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
    public partial class RentCarForm : Form
    {
        string examplarVIN;
        public RentCarForm(string vin)
        {
            InitializeComponent();
            examplarVIN = vin;
        }

       
        private void Rentbutton_Click(object sender, EventArgs e)
        {
            if (radioButtonCompany.Checked)
            {
                string companyName = RentCarNameTextBox.Text;
                Client client = new Client
                {
                    Address = AddresstextBox.Text,
                    Phone = PhonetextBox.Text,
                    E_mail = EmailtextBox.Text
                };
                Company company = new Company
                {
                    Client = client,
                    Title = companyName,
                    Code = companyCodeTextBox.Text
                };
                using (CarRentalSystemDatabaseEntities c = new CarRentalSystemDatabaseEntities())
                {
                    c.Clients.Add(client);
                    c.Companies.Add(company);
                    c.Rents.Add(new Rent
                    {
                        ExamplarVIN = examplarVIN,
                        Pick_up = DateTime.Parse(dateTimePicker1.Text),
                        Return = DateTime.Parse(dateTimePicker2.Text),
                        ClientID = client.ID
                    });
                    c.SaveChanges();
                }
            }
            else
            if(radioButtonIndividual.Checked)
            {
                string[] fullName = RentCarNameTextBox.Text.Split(' ');
                Client client = new Client
                {
                    Address = AddresstextBox.Text,
                    Phone = PhonetextBox.Text,
                    E_mail = EmailtextBox.Text
                };
                Person individual = new Person
                {
                    Client = client,
                    Name = fullName[0],
                    Surname = fullName[1]
                };
                using (CarRentalSystemDatabaseEntities c = new CarRentalSystemDatabaseEntities())
                {
                    c.Clients.Add(client);
                    c.People.Add(individual);
                    c.Rents.Add(new Rent
                    {
                        ExamplarVIN = examplarVIN,
                        Pick_up = DateTime.Parse(dateTimePicker1.Text),
                        Return = DateTime.Parse(dateTimePicker2.Text),
                        ClientID = client.ID
                    });
                    c.SaveChanges();
                }
            }
            this.Dispose();         
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RentCarNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RentCarNameTextBox.Text))
            {
                e.Cancel = true;
                RentCarNameTextBox.Focus();
                errorProvider1.SetError(RentCarNameTextBox, "Please enter client name!");
            }
        }

        private void companyCodeTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void PhonetextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void AddresstextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void EmailtextBox_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
