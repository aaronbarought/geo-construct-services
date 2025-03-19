using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary1;
using System.Net;
// Image Captcha done by Aryan Barot.
namespace WebApplication1
{
    public partial class Member_registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Make sure ImageUrl is set only on the initial page load
            {
                LoadCaptchaImage(); // Load captcha image on initial page load
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            // First, check if CAPTCHA is correct
            if (Session["generatedString"] != null && Session["generatedString"].ToString() == textInput1.Text)
            {
                // CAPTCHA is correct, proceed with registration
                string filePath = Server.MapPath("~/App_Data/Member.xml");
                XDocument xmlDoc;

                // Check if the Member.xml file exists.
                if (File.Exists(filePath))
                {
                    // Load the document.
                    xmlDoc = XDocument.Load(filePath);
                }
                else
                {
                    // If the file does not exist, create a new document with the root element.
                    xmlDoc = new XDocument(new XElement("Members"));
                }

                // Get the username and password from the form's TextBoxes.
                string username = TextBox3.Text; // Replace TextBoxUsername with the actual ID of your username TextBox
                string password = TextBox4.Text; // Replace TextBoxPassword with the actual ID of your password TextBox




                /// Assignment 7 hashing
                string hashingPassword = ClassLibrary1.Class1.ComputeSha256Hash(TextBox4.Text);




                // Check if a user with the same username already exists.
                var existingUser = xmlDoc.Root.Elements("Member")
                    .FirstOrDefault(usr => usr.Element("Username").Value.Equals(username, StringComparison.OrdinalIgnoreCase));

                if (existingUser != null)
                {
                    // If a user with the same username exists, display an error message.
                    ErrorLabel.Text = "Username already exists. Please choose a different username.";
                }
                else
                {
                    // Add the new user with FirstLoginTime.
                    var firstLoginTime = DateTime.Now;
                    xmlDoc.Root.Add(new XElement("Member",
                        new XElement("Username", username),


                        // storing pasword
                        new XElement("Password", hashingPassword), // Note: Storing passwords in plain text is insecure.
                        new XElement("FirstLoginTime", firstLoginTime.ToString("MM/dd/yyyy hh:mm tt"))
                    ));

                    // Save the updated document back to the file.
                    xmlDoc.Save(filePath);

                    // Redirect to login page after successful registration.
                    HttpCookie myCookies = new HttpCookie("cookieID");
                    myCookies["Username"] = username;
                    myCookies.Expires = DateTime.Now.AddDays(5); // Set the cookie to expire in 5 days
                    Response.Cookies.Add(myCookies);



                    //
                    Response.Redirect("Index.aspx");
                }
            }
            else
            {
                // CAPTCHA is not correct, show error message
                ErrorLabel.Text = "CAPTCHA verification failed. Please try again.";
                LoadCaptchaImage(); // Refresh CAPTCHA image
            }
        }

        private void LoadCaptchaImage()
        {
            ServiceReference1.ServiceClient fromService = new ServiceReference1.ServiceClient("BasicHttpsBinding_IService");
            string userlength = "5";
            Session["userlength"] = userlength;
            string myStr = fromService.GetVerifierString(userlength);
            Session["generatedString"] = myStr;
            Image1.ImageUrl = "~/Imageprocess.aspx"; // Load captcha image
            Image1.Visible = true;
        }


    }
}

