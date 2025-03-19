using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Xml.Linq;
using System.IO;
// Global asax part done by Smit Lagdhirbhai Desai, aspx page and server control done by Aryan Barot
namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label7.Text = string.Empty;
            Label8.Text = string.Empty;
            if (!IsPostBack)
            {
                lblAppStartTime.Text = "Application started on: " + Application["ApplicationStartTime"].ToString();
                lblTotalAccessRequests.Text = "Access requests since start: " + Application["accessrequest"].ToString();
            }

            //Label7.Text = "Welcome User";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["cookieID"];

            if ((myCookies == null) || (myCookies["Username"] == ""))
            {
                Response.Redirect("Staff_login.aspx");
            }
            else
            {
                // Redirect to the Staff but first check for the staff
                string filePath = Server.MapPath("~/App_Data/Staff.xml");

                if (File.Exists(filePath))
                {
                    XDocument xmlDoc = XDocument.Load(filePath);
                    var userNode = xmlDoc.Root.Elements("Staff")
                        .FirstOrDefault(usr => usr.Element("username").Value.Equals(myCookies["Username"], StringComparison.OrdinalIgnoreCase));

                    if (userNode != null)
                    {
                        Label8.Text = myCookies["Username"];
                        Response.Redirect("Staff_registration.aspx");
                    }
                    else
                    {
                        Label7.Text = "You are not staff right now please log in as staff";
                        // Output that username does not exist

                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["cookieID"];
            if ((myCookies == null) || (myCookies["Username"] == ""))
            {
                Response.Redirect("member_login.aspx");
            }
            else
            {
                Label8.Text = myCookies["Username"];
                Response.Redirect("Index.aspx");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["cookieID"] != null)
            {
                HttpCookie myCookies = new HttpCookie("cookieID");
                myCookies.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(myCookies);
                Label7.Text = "Welcome User";
            }
        }
    }
}