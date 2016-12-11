using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CarRentalSystem
{
    public partial class MainForm : Form
    {
        SqlConnection connection;
        string connectionString;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CarRentalSystem.Properties.Settings.CarRentalDatabaseConnectionString"].ConnectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateCars();
            PopulateExamplars();
            PopulateEquipment();
            PopulateRents();
            PopulateEquipmentTab();
            PopulateClientsTab();
            PopulateClientRents();
            PopulateTopClients();
        }

        private void PopulateTopClients()
        {
            using (var context = new CarRentalSystemDatabaseEntities())
            {
                var results = (from c in context.Clients
                              join r in context.Rents on c.ID equals r.ClientID
                              group r by c into grp
                              let numberOfRents = grp.Count()
                              orderby numberOfRents descending
                              select new { row = grp.Key.Person.Name + " " + grp.Key.Person.Surname + grp.Key.Company.Title + " Number of rents: " + numberOfRents}).ToList();
                topClientsListBox.DataSource = results;
                topClientsListBox.DisplayMember = "row";
            }
        }

        private void PopulateClientsTab()
        {
            using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
            {
                //clients listbox
                var results_client = (from client in context.Clients
                                      select new
                                      {
                                          ID = client.ID,
                                          Name = client.Person.Name,
                                          Surname = client.Person.Surname,
                                          Title = client.Company.Title,
                                          PhoneNumber = client.Phone,
                                          row = client.Person.Name + " " + client.Person.Surname + client.Company.Title
                                      }).ToList();
                ClientslistBox.DataSource = results_client;
                ClientslistBox.DisplayMember = "row";
                ClientslistBox.ValueMember = "ID";

                context.SaveChanges();
            }
        }

        private void PopulateClientRents()
        {
            //client rents listbox
            using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
            {
                if (ClientslistBox.Items.Count != 0 )
                {
                    ClientslistBox.ValueMember = "ID";
                    var results_rents = (from rent in context.Rents
                                         where rent.ClientID == (int)ClientslistBox.SelectedValue
                                         select new
                                         {
                                             Nr = rent.Nr,
                                             ExamplarVIN = rent.ExamplarVIN,
                                             Pick_up = rent.Pick_up,
                                             Return = rent.Return,
                                             FullRow = "VIN: "
                                             + rent.ExamplarVIN + "       Date to pick up: "
                                             + rent.Pick_up + " - "
                                             + rent.Return
                                         }).ToList();

                    RentslistBox2.DataSource = results_rents;
                    RentslistBox2.DisplayMember = "FullRow";
                    RentslistBox2.ValueMember = "Nr";

                    context.SaveChanges();
                }
            }

        }

        private void PopulateEquipmentTab() //Entity framework //LINQ join
        {
            using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
            {
                AllEquipmentlistBox.DataSource = context.Equipments.ToList();
                AllEquipmentlistBox.DisplayMember = "Title";
                AllEquipmentlistBox.ValueMember = "ID";

                List<Examplar> examplars = context.Examplars.ToList();
                List<Car> cars = context.Cars.ToList();
                var carExamplars = (from examp in context.Examplars
                                    join car in context.Cars on examp.CarID equals car.ID
                                    select new
                                    {
                                        Vin = examp.VIN,
                                        Row = car.Title + " VIN: " + examp.VIN
                                   }).ToList();
                EquipmentExamplarListBox.DataSource = carExamplars;
                EquipmentExamplarListBox.DisplayMember = "Row";
                EquipmentExamplarListBox.ValueMember = "Vin";
            }
        }

        private void PopulateCars()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Car", connectionString))
            {
                DataTable carTable = new DataTable();
                adapter.Fill(carTable);

                Cars_listBox.DisplayMember = "Title";
                Cars_listBox.ValueMember = "ID";
                Cars_listBox.DataSource = carTable;
            }
        }

        private void PopulateExamplars()
        {
            string query = "SELECT * FROM Examplar, Car " +
                           "WHERE Examplar.CarID = Car.ID " +
                           "AND Car.ID = @CarID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CarID", Cars_listBox.SelectedValue);

                DataTable examplarTable = new DataTable();
                adapter.Fill(examplarTable);

                var results = (from row in examplarTable.AsEnumerable()
                               select new
                               {
                                   VIN = row.Field<String>("VIN"),
                                   //Year = row.Field<int>("Year"),
                                   //Color = row.Field<string>("Color"),
                                   //Fuel_cost = row.Field<decimal>("Fuel_cost"),
                                   FullRow = "VIN: "
                                   + row.Field<string>("VIN") + "       Year: "
                                   + row.Field<int>("Year") + "     Color: "
                                   + row.Field<string>("Color") + "     "
                                   + row.Field<decimal>("Fuel_cost") + " l / 100km"
                               }).ToList();

                Examplars_listBox.DataSource = results;
                Examplars_listBox.DisplayMember = "FullRow";
                Examplars_listBox.ValueMember = "VIN";

            }
        }

        private void PopulateRents()
        {
            string query = "SELECT * FROM Rent, Examplar " +
                           "WHERE Rent.ExamplarVIN = Examplar.VIN " +
                           "AND Examplar.VIN = @ExamplarVIN";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                Examplars_listBox.ValueMember = "VIN";
                if (!String.IsNullOrEmpty((string)Examplars_listBox.SelectedValue))
                {
                    command.Parameters.AddWithValue("@ExamplarVIN", Examplars_listBox.SelectedValue);

                    DataTable rentTable = new DataTable();
                    adapter.Fill(rentTable);

                    var results = (from row in rentTable.AsEnumerable()
                                   select new
                                   {
                                       ExamplarVIN = row.Field<string>("ExamplarVIN"),
                                       Pick_up = row.Field<DateTime>("Pick-up"),
                                       Return = row.Field<DateTime>("Return"),
                                       FullRow = "VIN: "
                                       + row.Field<string>("ExamplarVIN") + "       Date to pick up: "
                                       + row.Field<DateTime>("Pick-up") + " - "
                                       + row.Field<DateTime>("Return")
                                   }).ToList();

                    Rents_listBox.DataSource = results;
                }
                Rents_listBox.DisplayMember = "FullRow";
                //Rents_listBox.ValueMember = "Nr";
            }
        }

        private void PopulateEquipment()
        {
            string query = "SELECT Equipment.Title FROM Equipment, UseEquipment, Examplar " +
                           "WHERE UseEquipment.ExamplarVIN = Examplar.VIN " +
                           "AND UseEquipment.EquipmentID = Equipment.ID " +
                           "AND UseEquipment.ExamplarVIN = @ExamplarVIN";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                if (!String.IsNullOrEmpty((string)Examplars_listBox.SelectedValue))
                {
                    command.Parameters.AddWithValue("@ExamplarVIN", Examplars_listBox.SelectedValue);

                    DataTable equipmentTable = new DataTable();
                    adapter.Fill(equipmentTable);

                    Equipment_listBox.DataSource = equipmentTable;
                }
                Equipment_listBox.DisplayMember = "Title";
                //Equipment_listBox.ValueMember = "ID";

            }
        }

        private void Cars_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateExamplars();
            PopulateRents();
            if (String.IsNullOrEmpty((string)Examplars_listBox.SelectedValue))
            {
                Rents_listBox.DataSource = null;
                Rents_listBox.Items.Clear();
            }
            if (String.IsNullOrEmpty((string)Examplars_listBox.SelectedValue))
            {
                Equipment_listBox.DataSource = null;
                Equipment_listBox.Items.Clear();
            }
        }

        private void Examplars_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateRents();
            PopulateEquipment();
        }

        private void Rents_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateEquipment();
        }

        private void Equipment_label_Click(object sender, EventArgs e)
        {

        }

        private void AddNewEquipmentbutton_Click(object sender, EventArgs e)
        {
            string value = "";

            if (Dialog.InputBox("Add new...", "Enter equipment name", ref value) == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
                    {
                        context.Equipments.Add(new Equipment { Title = value });
                        context.SaveChanges();
                    }
                }
            }
            PopulateEquipmentTab();
        }

        private void RemoveEquipmentbutton_Click(object sender, EventArgs e)
        {
            using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
            {
                //AllEquipmentlistBox.ValueMember = "ID";
                Equipment item = context.Equipments.FirstOrDefault(eq => eq.ID == (int)AllEquipmentlistBox.SelectedValue);
                context.Equipments.Remove(item);
                context.SaveChanges();
            }
            PopulateEquipmentTab();
        }

        private void UpdateEquipmentbutton_Click(object sender, EventArgs e)
        {
            string value = "";
            if (Dialog.InputBox("Update...", "Enter new name", ref value) == DialogResult.OK)
            {
                using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
                {
                    Equipment item = context.Equipments.FirstOrDefault(eq => eq.ID == (int)AllEquipmentlistBox.SelectedValue);
                    item.Title = value;
                    context.SaveChanges();
                }
            }
            PopulateEquipmentTab();

        }

        private void FindEquipmentbutton_Click(object sender, EventArgs e)
        {
            string value = "";
            if (Dialog.InputBox("Update...", "Enter new name", ref value) == DialogResult.OK)
            {
                AllEquipmentlistBox.SelectedIndex = AllEquipmentlistBox.FindStringExact(value);
            }
        }

        private void ClientslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateClientRents();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            using (AddCarForm addcarform = new AddCarForm())
            {
                addcarform.ShowDialog();
            }
            PopulateCars();
        }

        private void AddExamplarButton_Click(object sender, EventArgs e)
        {
            Cars_listBox.ValueMember = "ID";
            using (AddExamplarForm addexamplarform = new AddExamplarForm((int)Cars_listBox.SelectedValue, connectionString))
            {
                addexamplarform.ShowDialog();
            }
            PopulateExamplars();
        }

        private void Rentbutton_Click(object sender, EventArgs e)
        {
            Examplars_listBox.ValueMember = "VIN";
            if (Examplars_listBox.SelectedValue != null)
            {
                using (RentCarForm rentcarform = new RentCarForm((string)Examplars_listBox.SelectedValue))
                {
                    rentcarform.ShowDialog();
                }

                PopulateExamplars();
                PopulateRents();
                PopulateClientsTab();
            }
            else MessageBox.Show("Nepasirinkote egzemplioriaus!");
        }

        private void ReturnCarButton_Click(object sender, EventArgs e)
        {
            using (var context = new CarRentalSystemDatabaseEntities())
            {
                if (RentslistBox2.Items.Count != 0)
                {
                    string clientname;
                    Rent rent = context.Rents.FirstOrDefault(x => x.Nr == (int)RentslistBox2.SelectedValue);
                    int days = (rent.Return - rent.Pick_up).Days;

                    Examplar examplar = context.Examplars.FirstOrDefault(ex => ex.VIN == rent.ExamplarVIN);
                    Car car = context.Cars.FirstOrDefault(c => c.ID == examplar.CarID);
                    Client client = context.Clients.FirstOrDefault(cl => cl.ID == (int)ClientslistBox.SelectedValue);
                    Person person = context.People.FirstOrDefault(p => p.ID == client.ID);
                    Company company = context.Companies.FirstOrDefault(com => com.ID == client.ID);
                    int price = days * car.Price;
                    if (company != null)
                    {
                        clientname = client.Company.Title;
                    }
                    else if (person != null)
                    {
                        clientname = client.Person.Name + " " + client.Person.Surname;
                    }
                    else clientname = "uknown";

                    MessageBox.Show(clientname + Environment.NewLine +
                                    "Car VIN: " + examplar.VIN + Environment.NewLine +
                                    "Rent price: " + price.ToString() + "€");
                    context.Rents.Remove(rent);

                    if (client.Rents.FirstOrDefault() == null)
                    {
                        context.Clients.Remove(client);
                        if (person != null) context.People.Remove(person);
                        if (company != null) context.Companies.Remove(company);
                    }
                    context.SaveChanges();
                }   
            }
            PopulateClientsTab();
            PopulateClientRents();
        }

        private void RemoveClientbutton_Click(object sender, EventArgs e)
        {
            using (var context = new CarRentalSystemDatabaseEntities())
            {
                if (ClientslistBox.Items.Count != 0)
                {
                    Client client = context.Clients.FirstOrDefault(cl => cl.ID == (int)ClientslistBox.SelectedValue);
                    Person person = context.People.FirstOrDefault(p => p.ID == client.ID);
                    Company company = context.Companies.FirstOrDefault(com => com.ID == client.ID);
                    if (client != null)
                    {
                        context.Clients.Remove(client);
                        if (person != null) context.People.Remove(person);
                        if (company != null) context.Companies.Remove(company);

                        context.SaveChanges();
                    }
                }
            }
            PopulateClientsTab();
        }

        private void clientSearchBox_TextChanged(object sender, EventArgs e)
        {
            using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
            {
                var results_client = (from client in context.Clients
                                      where client.Person.Surname.Contains(clientSearchBox.Text) || client.Company.Title.Contains(clientSearchBox.Text)
                                      select new
                                      {
                                          ID = client.ID,
                                          Name = client.Person.Name,
                                          Surname = client.Person.Surname,
                                          Title = client.Company.Title,
                                          PhoneNumber = client.Phone,
                                          row = client.Person.Name + " " + client.Person.Surname + client.Company.Title
                                      }).ToList();
                ClientslistBox.DataSource = results_client;
                ClientslistBox.DisplayMember = "row";
            }
            
        }

        private void Infobutton_Click(object sender, EventArgs e)
        {
            using (var context = new CarRentalSystemDatabaseEntities())
            {
                if (Cars_listBox.Items.Count != 0)
                {
                    Car car = context.Cars.FirstOrDefault(c => c.ID == (int)Cars_listBox.SelectedValue);
                    MessageBox.Show("Car model: " + car.Title + " " + car.Body + " " + car.Class + Environment.NewLine +
                                    "Price: " + car.Price + " €/day", "Info...");
                }
            }
        }

        private void addEquipmentToExamplarButton_Click(object sender, EventArgs e)
        {
            using(var context = new CarRentalSystemDatabaseEntities())
            {
                Equipment eq = context.Equipments.FirstOrDefault(x => x.ID == (int)AllEquipmentlistBox.SelectedValue);
                Examplar examp = context.Examplars.FirstOrDefault(y => y.VIN == (string)EquipmentExamplarListBox.SelectedValue);
                examp.Equipments.Add(eq);
                context.SaveChanges();
            }
        }

        private void examplarSearchBox_TextChanged(object sender, EventArgs e)
        {
            using (CarRentalSystemDatabaseEntities context = new CarRentalSystemDatabaseEntities())
            {
                var carExamplars = (from examp in context.Examplars
                                    join car in context.Cars on examp.CarID equals car.ID
                                    where car.Title.Contains(examplarSearchBox.Text)
                                    select new
                                    {
                                        Vin = examp.VIN,
                                        Row = car.Title + " VIN: " + examp.VIN
                                    }).ToList();
                EquipmentExamplarListBox.DataSource = carExamplars;
                EquipmentExamplarListBox.DisplayMember = "Row";
                EquipmentExamplarListBox.ValueMember = "Vin";
            }
        }

        private void removeExamplarButton_Click(object sender, EventArgs e)
        {
            if (Examplars_listBox.Items.Count != 0 && Equipment_listBox.Items.Count == 0 && Rents_listBox.Items.Count == 0)
            {
                string query = "DELETE Examplar WHERE VIN = @ExamplarVIN";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using(SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ExamplarVIN", (string)Examplars_listBox.SelectedValue);
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    //command.ExecuteScalar();
                }
                PopulateExamplars();
            }
        }
    }
}
