using AirPort;
using AutomaticPricing;
using City;
using Country;
using Location;
using Port;
using RestSharp.Extensions;
using State;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Token;
using static AirPort.MAirPort;
using static AutomaticPricing.MAutomaticPricing;
using static Port.MPort;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            RCountry country = new RCountry();
            MCountry.FilterForm formCountry = new MCountry.FilterForm();
            formCountry.Take = 10000;
            formCountry.Offset = 0;
            formCountry.Sort.Column = "NAME";
            formCountry.Sort.Type = "ASC";

            var data = country.MultipleGet(formCountry).item;
            foreach (var items in data)
            {
                comboBox3.Items.Add(new { Text = items.name, Value = items.id });
                comboBox3.DisplayMember= "Text";

                comboBox6.Items.Add(new { Text = items.name, Value = items.id });
                comboBox6.DisplayMember = "Text";
            }

             dataGridView1.DataSource = response;

            RLocation location = new RLocation();
            MLocation.FilterForm formLocation = new MLocation.FilterForm();
            formLocation.Take = 10;
            formLocation.Offset = 0;
            formLocation.Sort.Column = "NAME";
            formLocation.Sort.Type = "ASC";
            List<int> LocationTyp = new List<int>() { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12 };
            formLocation.LocationType = LocationTyp;

            var dataLocation = location.MultipleGet(formLocation).item;
            foreach (var items in dataLocation)
            {
                comboBox4.Items.Add(new { Text = items.name, Value = items.id });
                comboBox4.DisplayMember = "Text";

                comboBox7.Items.Add(new { Text = items.name, Value = items.id });
                comboBox7.DisplayMember = "Text";
            }
             dataGridView1.DataSource = response;

        }
        private void GetAQuate(object sender, EventArgs e)
        {
            RAutomaticPricing r = new RAutomaticPricing();
            MAutomaticPricing.Form formGetAQuate = new MAutomaticPricing.Form();
            formGetAQuate.FromType = comboBox2.Text.ToString();
            formGetAQuate.FromLocationCountryId = (comboBox3.SelectedItem as dynamic).Value;
            formGetAQuate.FromLocationId = (comboBox4.SelectedItem as dynamic).Value;

            formGetAQuate.ToType = comboBox5.Text.ToString();
            formGetAQuate.ToLocationCountryId = (comboBox4.SelectedItem as dynamic).Value;
            formGetAQuate.ToLocationId = (comboBox7.SelectedItem as dynamic).Value;
            if (formGetAQuate.FromType == "Port/Airport")
            {
                    formGetAQuate.Packages.Add(new FAutomaticPricingPackage
                    {
                        Height = textBox3.Text,
                        Length = textBox1.Text,
                        MetricType = "Metric",
                        PackageTypeId = "3",
                        TotalUnit = textBox4.Text,
                        Weight = textBox5.Text,
                        Width = textBox2.Text
                    });
            }
            else
            {
                
                formGetAQuate.Containers.Add(new FAutomaticPricingContainer
                {
                     TotalUnit= textBox7.Text,
                     Size= comboBox8.Text.ToString(),
                });
            }

            formGetAQuate.ProductAmount = textBox6.Text;
            formGetAQuate.ProductReadyDate= DateTime.Now;
            formGetAQuate.ShipmentLoadType = 2;
            formGetAQuate.Insurance = 2;
            formGetAQuate.CustomsClearance = 2;

            var data = r.GetAQuate(formGetAQuate);
            dataGridView1.DataSource = data.statusText.ToString();
            //dataGridView1.DataSource = data.ToList();
        }
        private void PortGet(object sender, EventArgs e)
        {
            RPort r = new RPort();
            MPort.FilterForm formPort = new MPort.FilterForm();
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
            foreach (var items in data)
            {
                comboBox3.Items.Add(items.name);
            }

            comboBox3.SelectedItem =

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
            List<int> LocationTyp = new List<int>() { 1 };
            formLocation.LocationType = LocationTyp;

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
            List<int> LocationTyp = new List<int>() { 1 };
            formLocation.LocationType = LocationTyp;

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
            List<int> LocationTyp = new List<int>() { 7 };
            formLocation.LocationType = LocationTyp;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (panel3.Visible.Equals(true))
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panel4.Visible.Equals(true))
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void panel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Port(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (panel5.Visible.Equals(true))
            {
                panel5.Visible = false;
            }
            else
            {
                panel5.Visible = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (panel6.Visible.Equals(true) && panel7.Visible.Equals(true))
            {
                panel6.Visible = false;
                panel7.Visible = true;
            }
            else
            {
                panel6.Visible = true;
                panel7.Visible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (panel6.Visible.Equals(true) && panel7.Visible.Equals(true))
            {
                panel7.Visible = false;
                panel6.Visible = true;
            }
            else
            {
                panel7.Visible = true;
                panel6.Visible = false;

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (panel8.Visible.Equals(true))
            {
                panel8.Visible = false;
            }
            else
            {
                panel8.Visible = true;

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible.Equals(true))
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
