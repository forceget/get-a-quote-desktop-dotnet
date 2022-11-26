using AirPort;
using Nest;
using Newtonsoft.Json;
using Port;
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
    }
}
