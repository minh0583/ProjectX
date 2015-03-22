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
            var result = false;

            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                int lat = rng.Next(516400146, 630304598);
                int lon = rng.Next(224464416, 341194152);

                var data = new LocationViewModel
                {
                    Decription = string.Format("Test Data {0}", i),
                    Latitude = 18d + lat / 1000000000d,
                    Longitude = -72d - lon / 1000000000d
                };

                result = Utils.DoPostData(data, "PushLocation");

                if (!result)
                {
                    break;
                }
                
            }

            for (int i = 0; i < 10; i++)
            {
                var data = new LocationViewModel
                {
                    Decription = string.Format("Test Data {0}", i),
                    Latitude = i,
                    Longitude = i + 10
                };

                result = Utils.DoPostData(data, "PushLocation");

                if (!result)
                {
                    break;
                }
            }

            if (result)
            {
                MessageBox.Show("Inserted successfully.", "GPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some errors occurs.", "GPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataGridView1.DataSource = result;
                //MessageBox.Show(string.Format("{0} - {1}", result.Code, result.Description), "GPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var result = Utils.DoDelete<LocationViewModel>("DeleteAllLocation");

            //if (result)
            //{
            //    MessageBox.Show("Deleted successfully.", "GPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Deleted fail.", "GPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }




    }
}
