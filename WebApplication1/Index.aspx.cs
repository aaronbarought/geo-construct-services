using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SearchButton1_Click(object sender, EventArgs e)
        {
            string minLatitude = TextBox1.Text;
            string minLongitude = TextBox2.Text;
            string maxLatitude = TextBox3.Text;
            string maxLongitude = TextBox4.Text;
            Int32 minlat = Convert.ToInt32(minLatitude);
            Int32 minlng = Convert.ToInt32(minLongitude);
            Int32 maxlat = Convert.ToInt32(maxLatitude);
            Int32 maxlng = Convert.ToInt32(maxLongitude);


            ServiceReference2Aryan.Service1Client naturalhazard = new ServiceReference2Aryan.Service1Client();
            decimal hazardindex = naturalhazard.NaturalHazards(minlat, minlng, maxlat, maxlng);
            Label7.Text = hazardindex.ToString();
        }

        protected void SearchButton2_Click(object sender, EventArgs e)
        {
            string latitude = TextBox5.Text;
            string longitude = TextBox6.Text;
            Int32 lat = Convert.ToInt32(latitude);
            Int32 lng = Convert.ToInt32(longitude);

            if (!Int32.TryParse(latitude, out lat) || lat < -90 || lat > 89)
            {
                Label11.Text = "Latitude must be from -90 to 89 degrees.";
                return;
            }

            if (!Int32.TryParse(longitude, out lng) || lng < -180 || lng > 179)
            {
                Label11.Text = "Longitude must be from -180 to 179 degrees.";
                return;
            }




            ServiceReference2Aryan.Service1Client getwindintensity = new ServiceReference2Aryan.Service1Client();

            double windIndex = getwindintensity.GetWindintensity(lat, lng);
            Label11.Text = windIndex.ToString();

        }
        protected void SubmitButton1_Click(object sender, EventArgs e)
        {
            ServiceReference1Smit.Service1Client lesGo = new ServiceReference1Smit.Service1Client();
            string input = TextBox7.Text;

            string[] output = new string[5];
            output = lesGo.Weather5day(input);

            Label14.Text = output[0];
            Label15.Text = output[1];
            Label16.Text = output[2];
        }

        protected void SubmitButton2_Click(object sender, EventArgs e)
        {
            ServiceReference1Smit.Service1Client solar = new ServiceReference1Smit.Service1Client();
            string lat = TextBox1.Text;
            string longi = TextBox2.Text;
            decimal la = decimal.Parse(TextBox8.Text);
            decimal lo = decimal.Parse(TextBox9.Text);

            decimal solarIntensity = solar.SolarIntensity(la, lo);
            Label22.Text = solarIntensity.ToString();
        }

    }
}