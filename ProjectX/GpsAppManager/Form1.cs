using Gps.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
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
                using (var client = new ServiceClient<IServiceRepository>("BasicHttpBinding_IGpsRepository"))
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
            //var data = new GpsViewModel
            //{
            //    ID = Guid.NewGuid(),
            //    Code = "MN",
            //    Description = "Minnesota"
            //};

            var data = new LocationViewModel
            {
                Latitude = 1,
                Longitude = 1
            };

            var result = Utils.DoPostData(data, "PushLocation");

            if (result)
            {
                MessageBox.Show("Inserted successfully.", "GPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            var result = Utils.DoGetDataList<LocationViewModel>("GetAllLocation");

            if (result != null)
            {
                //MessageBox.Show(string.Format("{0} - {1}", result.Code, result.Description), "GPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




    }
}
