using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Image Captcha done by Aryan Barot
namespace WebApplication1
{
    public partial class Imageprocess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            ServiceReference1.ServiceClient fromService = new ServiceReference1.ServiceClient("BasicHttpsBinding_IService");
            string myStr, userLeng;

            if (Session["generatedString"] == null)
            {
                if (Session["userlength"] == null)
                {
                    userLeng = "5";
                }
                else
                    userLeng = Session["userlength"].ToString();
                myStr = fromService.GetVerifierString(userLeng);
                Session["generatedString"] = myStr;

            }
            else
            {
                myStr = Session["generatedString"].ToString();
            }

            Stream myStream = fromService.GetImage(myStr);
            System.Drawing.Image myImage = System.Drawing.Image.FromStream(myStream);
            Response.ContentType = "image/jpeg";
            myImage.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}