<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<style>
    .section-header {
        font-size: xx-large;
        font-weight: bold;
        text-align: center;
        margin-bottom: 20px;
    }
    .section-sub-header {
        text-align: center;
        margin-bottom: 10px;
    }
    .section-content {
        text-align: center;
        margin-bottom: 15px;
    }
    .button-container {
        text-align: center;
        margin-top: 20px;
    }
</style>

<div class="section-header">
    <asp:Label ID="Label1" runat="server" Text="Know Your Weather"></asp:Label>
    <br />
</div>

<div class="section-sub-header">
    <asp:Label ID="Label2" runat="server" Text="From: Team 22"></asp:Label>
</div>

<div class="section-content">
    <asp:Label ID="Label3" runat="server" Text="Aryan Hiteshkumar Barot, Smit Lagdhirbhai Desai"></asp:Label>
</div>

<div class="section-content">
    <asp:Label ID="Label4" runat="server" Text="About: This application gives you weather details based on location coordinates and zipcode of the area, it also provides you with a 5-day weather forecast."></asp:Label>
</div>

<div class="section-content">
    <asp:Label ID="Label6" runat="server" Text="This application is useful for construction firms as it will help them plan according to the future"></asp:Label>
</div>

<div class="section-content">
    <asp:Label ID="Label5" runat="server" Text="Our Service Directory" Font-Size="Large" Font-Bold="True"></asp:Label>
</div>

<p>
        Weather Forecast</p>
    <p>
        - This service provides you a 5-day weather forecast of an area wwhen you provide a zipcode.</p>
    <p>
        &nbsp;</p>
    <p>
        Solar Energy Service</p>
    <p>
        - This service provides you the annual average solar intenisity for a given location</p>
    <p>
        &nbsp;</p>
    <p>
        Wind Intensity
    </p>
    <p>
        - This service provides you with annual average wind intensity of a given location
    </p>
    <p>
        &nbsp;</p>
    <p>
        Natural Hazard</p>
    <p>
        - This service provides you with earthquake index of a given location</p>
    <p>
        &nbsp;</p>
    <p>
        <table style="width:100%">

    <tr>

      <td>Application and Components Summary Table</td>

    </tr>

    

    <tr>

      <td>The application is deployed at:<br> <a href="http://webstrar22.fulton.asu.edu/page9/Default.aspx">http://webstrar22.fulton.asu.edu/page9/Default.aspx</a></td>

    </tr>



    <tr>

      <td>Percent of contribution:<br> Aryan Barot: 50% <br>Smit Lagdhirbhai Desai: 50%</td>

    </tr>



    <tr>

      <th>Provider name</th>

      <th>Page and component type, e.g., aspx, DLL, SVC, etc.</th>

      <th>Component description: What does the component do? What are input/parameter and output/return value?</th>

      <th>Actual resources and methods used to implement the component and where this component is used.</th>

      <th>Try It</th>

    </tr>



    <tr>

      <td>Aryan Barot</td>

      <td>aspx page and server control</td>

      <td>The public Default page that call and link all other pages</td>

      <td>GUI design and C# code behind GUI</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/Default.aspx">tryIt</a></td>

    </tr>



    <tr>

      <td>Aryan Barot</td>

      <td>Cookies</td>

      <td>Store user ID, session id, password</td>

      <td>GUI design and C# code behind GUI using HTTP cookies library. It is linked to the login page</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/Webform1.aspx">tryIt</a></td>

    </tr>



    <tr>

      <td>Aryan Barot</td>

      <td>Image Captcha</td>

      <td>User has to determine and enter the correct captcha in order to login</td>

      <td>GUI design and C# code behind GUI for component</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/member_registration.aspx">tryIt</a></td>

    </tr>



    <tr>

      <td>Aryan Barot</td>

      <td>User control</td>

      <td>Log in page and authentication verification</td>

      <td>C# Code behind GUI. Linked to the Default page</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/member_login">tryIt</a></td>

    </tr>



    <tr>

      <td>Smit Lagdhirbhai Desai</td>

      <td>XML file</td>

      <td>Store usernames and passwords</td>

      <td>Linked to the login page and the hashing function</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/Staff_registration">tryIt</a></td>

    </tr>



    <tr>

      <td>Smit Lagdhirbhai Desai</td>

      <td>DLL</td>

      <td>Hashing function:<br> Input: String<br> Output: String</td>

      <td>Use library class and local component to implement this library function. It is used in the saving data into XML file</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/Webform1.aspx">tryIt</a></td>

    </tr>



    <tr>

      <td>Smit Lagdhirbhai Desai</td>

      <td>Global.asax</td>

      <td>It keeps track of number of users that visits the website</td>

      <td>GUI design and C# code behind GUI for component</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/Default.aspx">tryIt</a></td>

    </tr>









  </table>

<div class="button-container">
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Member Login" OnClick="Button1_Click" Width="216px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Staff Login" Width="215px" OnClick="Button2_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Logout" />

    <br />
        <asp:Label ID="lblAppStartTime" runat="server" Text="Application Start Time: "></asp:Label>
        <br />
        <asp:Label ID="lblTotalAccessRequests" runat="server" Text="Total Access Requests: "></asp:Label>
        <br />


</div>

</asp:Content>
