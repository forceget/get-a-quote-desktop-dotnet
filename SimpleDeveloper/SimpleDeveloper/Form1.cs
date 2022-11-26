using AirPort;
using City;
using Country;
using Location;
using Nest;
using Newtonsoft.Json;
using Port;
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
using static Port.MPort;

namespace SimpleDeveloper
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PortGet(object sender, EventArgs e)
        {
            RPort r = new RPort();
            FilterForm formPort = new FilterForm();
            formPort.Take = 10;
            formPort.Offset = 0;
            formPort.Sort.Column = "NAME";
            formPort.Sort.Type = "ASC";

            var liste = r.MultipleGet(formPort).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
        }
        private void AirPortGet(object sender, EventArgs e)
        {
            RAirPort airPort = new RAirPort();
            MAirPort.FilterForm formAirPort = new MAirPort.FilterForm();
            formAirPort.Take = 10;
            formAirPort.Offset = 0;
            formAirPort.Sort.Column = "NAME";
            formAirPort.Sort.Type = "ASC";

            var liste = airPort.MultipleGet(formAirPort).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
        }
        private void CountryGet(object sender, EventArgs e)
        {
            RCountry country = new RCountry();
            MCountry.FilterForm formCountry = new MCountry.FilterForm();
            formCountry.Take = 10;
            formCountry.Offset = 0;
            formCountry.Sort.Column = "NAME";
            formCountry.Sort.Type = "ASC";

            var liste = country.MultipleGet(formCountry).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
        }
        private void StateGet(object sender, EventArgs e)
        {
            RState state = new RState();
            MState.FilterForm formState = new MState.FilterForm();
            formState.Take = 10;
            formState.Offset = 0;
            formState.Sort.Column = "NAME";
            formState.Sort.Type = "ASC";

            var liste = state.MultipleGet(formState).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
        }
        private void CityGet(object sender, EventArgs e)
        {
            RCity city = new RCity();
            MCity.FilterForm formCity = new MCity.FilterForm();
            formCity.Take = 10;
            formCity.Offset = 0;
            formCity.Sort.Column = "NAME";
            formCity.Sort.Type = "ASC";

            var liste = city.MultipleGet(formCity).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
        }
        private void LocationGet(object sender, EventArgs e)
        {
            RLocation location = new RLocation();
            MLocation.FilterForm formLocation = new MLocation.FilterForm();
            formLocation.Take = 10;
            formLocation.Offset = 0;
            formLocation.Sort.Column = "NAME";
            formLocation.Sort.Type = "ASC";

            var liste = location.MultipleGet(formLocation).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
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

            var liste = location.MultipleGet(formLocation).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
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

            var liste = location.MultipleGet(formLocation).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
        }
    }
}
