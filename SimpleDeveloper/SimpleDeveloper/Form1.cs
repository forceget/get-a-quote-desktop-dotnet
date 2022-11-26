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
            FilterForm formP = new FilterForm();
            formP.Take = 10;
            formP.Offset = 0;
            formP.Sort.Column = "NAME";
            formP.Sort.Type = "ASC";

            var liste = r.MultipleGet(formP).Item;
            var data = JsonConvert.DeserializeObject(liste);
            richTextBox1.Text = data.ToString();
        }
    }
}
