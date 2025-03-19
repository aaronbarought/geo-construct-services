using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary1;
// Cookies done by Aryan Barot, Encryption/Hash done by Smit Lagdhirbhai Desai 
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text; // Replace with the actual ID of your username TextBox
            string password = TextBox2.Text; // Replace with the actual ID of your password TextBox

            string filePath = Server.MapPath("~/App_Data/Member.xml");

            if (File.Exists(filePath))
            {
                XDocument xmlDoc = XDocument.Load(filePath);
                var userNode = xmlDoc.Root.Elements("Member")
                    .FirstOrDefault(usr => usr.Element("Username").Value.Equals(username, StringComparison.OrdinalIgnoreCase));

                if (userNode != null && userNode.Element("Password").Value.Equals(password))
                {
                    // Check if FirstLoginTime is already set
                    var firstLoginNode = userNode.Element("FirstLoginTime");
                    if (firstLoginNode == null)
                    {
                        // First time login
                        string formattedFirstLoginTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                        firstLoginNode = new XElement("FirstLoginTime", formattedFirstLoginTime);
                        userNode.Add(firstLoginNode);
                        xmlDoc.Save(filePath); // Save the first login time
                    }

                    // Regardless of whether it's the first login or not, set the cookie with the first login time
                    HttpCookie myCookies = new HttpCookie("cookieID");
                    myCookies["Username"] = username;
                    myCookies.Expires = DateTime.Now.AddDays(5); // Set the cookie to expire in 5 days
                    Response.Cookies.Add(myCookies);

                    // Display the first login time
                    Label3.Text = $"Username: {username}, First Login Time: {firstLoginNode.Value}";
                }
                else
                {
                    // Incorrect password or user doesn't exist
                    Label3.Text = "Login unsuccessful. Please check your username and password.";
                }
            }
            else
            {
                // Members.xml not found
                Label3.Text = "Login unsuccessful. The user file does not exist.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string hashing = ClassLibrary1.Class1.ComputeSha256Hash(TextBox3.Text);
            Label7.Text = hashing;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Assuming you want to also clear the username from the session or a label
            string username = (string)Session["username"] ?? Request.Cookies["MemberCookieId"]?["Username"];

            if (!string.IsNullOrEmpty(username))
            {
                string filePath = Server.MapPath("~/App_Data/Member.xml");
                if (File.Exists(filePath))
                {
                    XDocument xmlDoc = XDocument.Load(filePath);
                    var userNode = xmlDoc.Root.Elements("Member")
                        .FirstOrDefault(usr => usr.Element("Username").Value.Equals(username, StringComparison.OrdinalIgnoreCase));

                    if (userNode != null)
                    {
                        // Optionally remove the FirstLoginTime element if you don't want to keep track of it anymore
                        var firstLoginNode = userNode.Element("FirstLoginTime");
                        if (firstLoginNode != null)
                        {
                            firstLoginNode.Remove();
                            xmlDoc.Save(filePath); // Save changes to the XML file
                        }

                        // Clear the specific cookie
                        if (Request.Cookies["MemberCookieId"] != null)
                        {
                            HttpCookie myCookies = new HttpCookie("MemberCookieId")
                            {
                                Expires = DateTime.Now.AddDays(-1) // Set it to expire in the past
                            };
                            Response.Cookies.Add(myCookies);
                        }

                        // Update UI to reflect the cookie clearance
                        Label3.Text = "Cookie cleared successfully.";
                    }
                    else
                    {
                        Label3.Text = "User not found.";
                    }
                }
                else
                {
                    Label3.Text = "The Member.xml file does not exist.";
                }
            }
            else
            {
                Label3.Text = "No user is currently logged in.";
            }
        }
    }
}