using Gps.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gps.App.Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new ServiceClient<IGpsRepository>("BasicHttpBinding_IGpsRepository"))
                {
                    var abc = client.Proxy.GetMessage();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var client = new ServiceClient<IGpsRepository>("BasicHttpBinding_IGpsRepository"))
            {
                var data = new GpsViewModel
                {
                    ID = Guid.NewGuid(),
                    Code = "MN",
                    Description = "Minnesota"
                };

                var result = client.Proxy.InsertGpsData(data);
                if (result)
                {
                    MessageBox.Show("Insert data successfully.", "GPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var client = new ServiceClient<IGpsRepository>("BasicHttpBinding_IGpsRepository"))
            {
                var result = client.Proxy.GetGpsData();
                if (result != null)
                {
                    MessageBox.Show(string.Format("{0} - {1}", result.Code, result.Description), "GPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }
}
