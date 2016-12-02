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
            string query = "SELECT * FROM Examplar, Car "+
                           "WHERE Examplar.CarID = Car.ID "+
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
                                   Year = row.Field<int>("Year"),
                                   Color = row.Field<string>("Color"),
                                   Fuel_cost = row.Field<decimal>("Fuel_cost"),
                                   FullRow = "VIN: " 
                                   + row.Field<string>("VIN") + "       Year: " 
                                   + row.Field<int>("Year") + "     Color: " 
                                   + row.Field<string>("Color") + "     Fuel cost: "
                                   + row.Field<decimal>("Fuel_cost")
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
                                       + row.Field<DateTime>("Pick-up") + "     Date to return: "
                                       + row.Field<DateTime>("Return")
                                   }).ToList();
                    
                    Rents_listBox.DataSource = results;
                    }
                Rents_listBox.DisplayMember = "FullRow";
                Rents_listBox.ValueMember = "Nr";
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
                Equipment_listBox.ValueMember = "ID";

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
    }
}
