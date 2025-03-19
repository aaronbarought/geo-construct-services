using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Net;
// Staff registration and XML manipulation done by Smit Lagdhirbhai Desai.
namespace WebApplication1
{
    public partial class Staff_registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = UserInput.Text;
            string password = PasswordInput.Text;
            string hashingPassword = ClassLibrary1.Class1.ComputeSha256Hash(password);

            string filePath = Server.MapPath("~/App_Data/Staff.xml");

            XDocument xmlDoc;
            if (File.Exists(filePath))
            {
                xmlDoc = XDocument.Load(filePath);
            }
            else
            {
                xmlDoc = new XDocument(new XElement("Staffs"));
            }

            var existingUser = xmlDoc.Root.Elements("Staff")
                .FirstOrDefault(usr => usr.Element("username").Value.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (existingUser != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "userExists", "alert('Username already exists.');", true);
                return;
            }

            xmlDoc.Root.Add(new XElement("Staff",
                new XElement("username", username),
                new XElement("password", hashingPassword))); // Passwords should be hashed and salted in a real-world scenario

            xmlDoc.Save(filePath);

            ClientScript.RegisterStartupScript(this.GetType(), "userRegistered", "alert('New staff member registered successfully.');", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string username = UserInput.Text; // Replace with the actual ID of your username TextBox
            string password = PasswordInput.Text; // Replace with the actual ID of your password TextBox
            string hashingPassword = ClassLibrary1.Class1.ComputeSha256Hash(password);

            string filePath = Server.MapPath("~/App_Data/Staff.xml");

            if (File.Exists(filePath))
            {
                XDocument xmlDoc = XDocument.Load(filePath);
                var userNode = xmlDoc.Root.Elements("Staff")
                    .FirstOrDefault(usr => usr.Element("username").Value.Equals(username, StringComparison.OrdinalIgnoreCase)
                                        && usr.Element("password").Value.Equals(hashingPassword));

                if (userNode != null)
                {
                    // If both username and password match, remove the staff member
                    userNode.Remove();
                    xmlDoc.Save(filePath);
                    ClientScript.RegisterStartupScript(this.GetType(), "userRemoved", "alert('Staff member removed successfully.');", true);
                }
                else
                {
                    // If username is found but password does not match, or user does not exist
                    ClientScript.RegisterStartupScript(this.GetType(), "userNotFound", "alert('Staff member not found or password incorrect.');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "fileNotFound", "alert('The Staff.xml file does not exist.');", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("~/App_Data/Staff.xml");

            if (File.Exists(filePath))
            {
                XDocument xmlDoc = XDocument.Load(filePath);
                var usernames = xmlDoc.Root.Elements("Staff").Select(usr => usr.Element("username").Value);

                if (usernames.Any())
                {
                    // Create a string that represents all usernames separated by a line break
                    Label3.Text = "Usernames: " + string.Join(", ", usernames);
                }
                else
                {
                    Label3.Text = "No staff members found.";
                }
            }
            else
            {
                Label3.Text = "The Staff.xml file does not exist.";
            }
        }
    }
}