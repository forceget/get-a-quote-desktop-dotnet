using AirPort;
using City;
using Country;
using Location;
using Newtonsoft.Json;
using Port;
using RestSharp.Extensions;
using State;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Token;
using static Port.MPort;

namespace SimpleDeveloper
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Login(object sender, EventArgs e)
        {
            MToken.FilterForm formtoken= new MToken.FilterForm();
            formtoken.Email = emailTextBox.Text;
            formtoken.PasswordHash = passwordTextBox.Text;

            var response = RToken.Login(formtoken);
            
            dataGridView1.DataSource = response;

        }
        private void PortGet(object sender, EventArgs e)
        {
            RPort r = new RPort();
            FilterForm formPort = new FilterForm();
            formPort.Take = 10;
            formPort.Offset = 0;
            formPort.Sort.Column = "NAME";
            formPort.Sort.Type = "ASC";

            var data = r.MultipleGet(formPort).item;
            dataGridView1.DataSource = data.ToList();
        }
        private void AirPortGet(object sender, EventArgs e)
        {
            RAirPort airPort = new RAirPort();
            MAirPort.FilterForm formAirPort = new MAirPort.FilterForm();
            formAirPort.Take = 10;
            formAirPort.Offset = 0;
            formAirPort.Sort.Column = "NAME";
            formAirPort.Sort.Type = "ASC";

            var data = airPort.MultipleGet(formAirPort);

            if (data != null)
            {
                dataGridView1.DataSource = data.item.ToList();
            }
        }
        private void CountryGet(object sender, EventArgs e)
        {
            RCountry country = new RCountry();
            MCountry.FilterForm formCountry = new MCountry.FilterForm();
            formCountry.Take = 10;
            formCountry.Offset = 0;
            formCountry.Sort.Column = "NAME";
            formCountry.Sort.Type = "ASC";

            var data = country.MultipleGet(formCountry).item;
            dataGridView1.DataSource = data.ToList();

        }
        private void StateGet(object sender, EventArgs e)
        {
            RState state = new RState();
            MState.FilterForm formState = new MState.FilterForm();
            formState.Take = 10;
            formState.Offset = 0;
            formState.Sort.Column = "NAME";
            formState.Sort.Type = "ASC";

            var data = state.MultipleGet(formState).item;
            dataGridView1.DataSource = data.ToList();

        }
        private void CityGet(object sender, EventArgs e)
        {
            RCity city = new RCity();
            MCity.FilterForm formCity = new MCity.FilterForm();
            formCity.Take = 10;
            formCity.Offset = 0;
            formCity.Sort.Column = "NAME";
            formCity.Sort.Type = "ASC";

            var data = city.MultipleGet(formCity).item;
            dataGridView1.DataSource = data.ToList();

        }
        private void LocationGet(object sender, EventArgs e)
        {
            RLocation location = new RLocation();
            MLocation.FilterForm formLocation = new MLocation.FilterForm();
            formLocation.Take = 10;
            formLocation.Offset = 0;
            formLocation.Sort.Column = "NAME";
            formLocation.Sort.Type = "ASC";
            formLocation.LocationTypes = 1;

            var data = location.MultipleGet(formLocation).item;
            dataGridView1.DataSource = data.ToList();
        }
        private void AmazonFulfillmentCenterGet(object sender, EventArgs e)
        {
            RLocation location = new RLocation();
            MLocation.FilterForm formLocation = new MLocation.FilterForm();
            formLocation.Take = 10;
            formLocation.Offset = 0;
            formLocation.Sort.Column = "NAME";
            formLocation.Sort.Type = "ASC";
            formLocation.LocationTypes = 1;

            var data = location.MultipleGet(formLocation).item;
            dataGridView1.DataSource = data.ToList();
        }
        private void ForcegetWarehouseGet(object sender, EventArgs e)
        {
            RLocation location = new RLocation();
            MLocation.FilterForm formLocation = new MLocation.FilterForm();
            formLocation.Take = 10;
            formLocation.Offset = 0;
            formLocation.Sort.Column = "NAME";
            formLocation.Sort.Type = "ASC";
            formLocation.LocationTypes = 7;

            var data = location.MultipleGet(formLocation).item;
            dataGridView1.DataSource = data.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RAirPort airPort = new RAirPort();
            MAirPort.FilterForm formAirPort = new MAirPort.FilterForm();
            formAirPort.Take = 10;
            formAirPort.Offset = 0;
            formAirPort.Sort.Column = "NAME";
            formAirPort.Sort.Type = "ASC";

            var item = airPort.MultipleGet(formAirPort);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
