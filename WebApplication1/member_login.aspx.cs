﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Net;
// User control of member login page done by Smit Lagdhirbhai Desai
namespace WebApplication1
{
    public partial class member_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            {
                string username = username_input.Text; // Replace with the actual ID of your username TextBox
                string password = passsword_input.Text; // Replace with the actual ID of your password TextBox

                string filePath = Server.MapPath("~/App_Data/Member.xml");

                if (File.Exists(filePath))
                {

                    string hashingPassword = ClassLibrary1.Class1.ComputeSha256Hash(password);



                    XDocument xmlDoc = XDocument.Load(filePath);
                    var userNode = xmlDoc.Root.Elements("Member")
                        .FirstOrDefault(usr => usr.Element("Username").Value.Equals(username, StringComparison.OrdinalIgnoreCase)
                                                && usr.Element("Password").Value.Equals(hashingPassword));

                    if (userNode != null)
                    {
                        // User found, set a cookie
                        HttpCookie myCookies = new HttpCookie("cookieID");
                        myCookies["Username"] = username;
                        myCookies.Expires = DateTime.Now.AddDays(5); // Set the cookie to expire in 5 days
                        Response.Cookies.Add(myCookies);

                        // Alert success
                        ClientScript.RegisterStartupScript(this.GetType(), "loginSuccess", "alert('Login success');", true);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        // User not found
                        ClientScript.RegisterStartupScript(this.GetType(), "loginFail", "alert('Login unsuccessful');", true);
                    }
                }
                else
                {
                    // Members.xml not found
                    ClientScript.RegisterStartupScript(this.GetType(), "noFile", "alert('The user file does not exist.');", true);
                }
            }

        }
    }
}