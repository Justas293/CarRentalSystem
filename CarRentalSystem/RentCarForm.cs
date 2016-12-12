using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem
{
    public partial class RentCarForm : Form
    {
        string examplarVIN;
        public RentCarForm(string vin)
        {
            InitializeComponent();
            examplarVIN = vin;
            using (var context = new CarRentalSystemDatabaseEntities()) {
                if (radioButtonCompany.Checked)
                {
                    clientsComboBox.DataSource = context.Companies.ToList();
                    clientsComboBox.DisplayMember = "Title";
                    clientsComboBox.ValueMember = "ID";
                    clientsComboBox.SelectedIndex = -1;
                }
                if (radioButtonIndividual.Checked)
                {
                    var result = context.People.AsEnumerable().Select(p => new {Name = p.Name + " " + p.Surname, Id = p.ID }).ToList();
                    clientsComboBox.DataSource = result;
                    clientsComboBox.DisplayMember = "Name";
                    clientsComboBox.ValueMember = "Id";
                    clientsComboBox.SelectedIndex = -1;
                }
            }
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
                    int companyid;
                    var checkCompany = c.Clients.FirstOrDefault(z => z.Company.Title == companyName && z.Company.Code == companyCodeTextBox.Text);
                    if (checkCompany == null)
                    {
                        c.Clients.Add(client);
                        c.Companies.Add(company);
                    }
                    if (checkCompany != null) companyid = checkCompany.ID;
                    else companyid = client.ID;
                    c.Rents.Add(new Rent
                    {
                        ExamplarVIN = examplarVIN,
                        Pick_up = DateTime.Parse(dateTimePicker1.Text),
                        Return = DateTime.Parse(dateTimePicker2.Text),
                        ClientID = companyid
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
                    int cl_ID;
                    string surName = fullName[1];
                    string name = fullName[0];
                    var checkclient = c.Clients.FirstOrDefault(x => x.Person.Surname == surName && x.Person.Name == name);
                    if (checkclient != null) cl_ID = checkclient.ID;
                    else cl_ID = client.ID;
                    if (checkclient == null)
                    {
                        c.Clients.Add(client);
                        c.People.Add(individual);
                    }
                    c.Rents.Add(new Rent
                    {
                        ExamplarVIN = examplarVIN,
                        Pick_up = DateTime.Parse(dateTimePicker1.Text),
                        Return = DateTime.Parse(dateTimePicker2.Text),
                        ClientID = cl_ID
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
                errorProvider1.SetError(RentCarNameTextBox, "Please enter client name!");
            }
            else
            if (radioButtonIndividual.Checked)
            {
                if (!RentCarNameTextBox.Text.Contains(" "))
                {
                    errorProvider1.SetError(RentCarNameTextBox, "Please enter your surname!");
                }else
                {
                    errorProvider1.SetError(RentCarNameTextBox, null);
                }
            }
            else
            {
                errorProvider1.SetError(RentCarNameTextBox, null);
            }

        }

        private void companyCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(companyCodeTextBox.Text, out parsedValue))
            {
                errorProvider1.SetError(companyCodeTextBox, "Code must contain numbers only!");
            }
            else
            {
                errorProvider1.SetError(companyCodeTextBox, null);
            }
        }

        private void PhonetextBox_Validating(object sender, CancelEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(PhonetextBox.Text, out parsedValue) || PhonetextBox.TextLength > 9 || PhonetextBox.TextLength < 9)
            {
                errorProvider1.SetError(PhonetextBox, "Invalid phone number!");
            }
            else
            {
                errorProvider1.SetError(PhonetextBox, null);
            }
        }

        private void EmailtextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!new EmailAddressAttribute().IsValid(EmailtextBox.Text))
            {
                errorProvider1.SetError(EmailtextBox, "Invalid e-mail address!");
            }
            else
            {
                errorProvider1.SetError(EmailtextBox, null);
            }
        }

        private void AddresstextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddresstextBox.Text))
            {
                errorProvider1.SetError(AddresstextBox, "Please enter client address!");
            }
            else errorProvider1.SetError(AddresstextBox, null);
        }

        private void radioButtonIndividual_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new CarRentalSystemDatabaseEntities())
            {
                if (radioButtonCompany.Checked)
                {
                    clientsComboBox.DataSource = context.Companies.ToList();
                    clientsComboBox.DisplayMember = "Title";
                    clientsComboBox.ValueMember = "ID";
                }
                if (radioButtonIndividual.Checked)
                {
                    var result = context.People.AsEnumerable().Select(p => new { Name = p.Name + " " + p.Surname, Id = p.ID }).ToList();
                    clientsComboBox.DataSource = result;
                    clientsComboBox.DisplayMember = "Name";
                    clientsComboBox.ValueMember = "ID";
                }
            }
        }

        private void clientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new CarRentalSystemDatabaseEntities())
            {
                if (clientsComboBox.SelectedIndex != -1)
                {
                    clientsComboBox.ValueMember = "ID";
                    Client client = context.Clients.FirstOrDefault(c => c.ID == (int)clientsComboBox.SelectedValue);
                    Person person = context.People.FirstOrDefault(p => p.ID == client.ID);
                    Company company = context.Companies.FirstOrDefault(comp => comp.ID == client.ID);

                    if (client != null)
                    {
                        PhonetextBox.Text = client.Phone;
                        AddresstextBox.Text = client.Address;
                        EmailtextBox.Text = client.E_mail;
                        if (person != null)
                        {
                            RentCarNameTextBox.Text = person.Name + person.Surname;
                        }
                        else if (company != null) companyCodeTextBox.Text = company.Code;
                    }
                }
            }
        }
    }
}
