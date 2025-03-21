using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.FriendlyUrls.Resolvers;

namespace WebApplication1
{
    public partial class ViewSwitcher : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "Imageprocess.aspx";
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.ServiceClient test = new ServiceReference1.ServiceClient();
                string userLength = textInput.Text;
                int len = int.Parse(textInput.Text);  // To check whether input is an integer
                if (len <= 0 || len > 10)
                {
                    Label1.Visible = true;
                    Label1.Text = "Length should be less be less than or equal to 10 and greater than 0(Zero)";
                }
                else
                {

                    Session["userLength"] = userLength;    // Saving the user length in sessionvariable userLength, required by imageProcess.aspx
                    string mystr = test.GetVerifierString(userLength);
                    Session["generatedString"] = mystr;     // Saving the random string  in sessionvariable generatedString, required by imageProcess.aspx
                                                            //Stream imageStr = test.GetImage(mystr);
                                                            //System.Drawing.Image capImg = System.Drawing.Image.FromStream(imageStr);
                                                            //System.Web.UI.WebControls.Image capImg = System.Web.UI.WebControls.Image.FromStream(imageStr);
                                                            //Image1.Width = capImg.Width;
                                                            //Image1 = capImg;                
                    button1.Text = "Show me another image";
                    Image1.Visible = true;
                    test.Close();
                }
            }
            catch (Exception e1)
            {
                Label1.Visible = true;
                Label1.Text = e1.Message;
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["generatedString"].Equals(textInput1.Text))    // Comparing input string and random string
                {
                    Label1.Visible = true;
                    Label1.Text = "The code you entered is correct!";
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "The string entered is incorrect so please try again!";
                }
            }
            catch (Exception e1)
            {
                Label1.Text = e1.Message;
            }
        }
    }
}