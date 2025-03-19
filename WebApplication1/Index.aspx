<%@ Page Language="C#" AutoEventWireUp="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index"%>

<!DOCTYPE html>
<style> table,th,td {border: 1px solid black;}</style>

<html>

<body>

    <form id="form1" runat="server">

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



  <h2>SERVICE DIRECTORY</h2>



  <table style="width:100%">

    <tr>

      <th>Provider name</th>

      <th>Service name, with input and output types</th>

      <th>Required Services (YES/NO)</th>

      <th>TryIt link</th>

      <th>Service description</th>

      

    </tr>

    <tr>

      <td>Aryan Barot</td>

      <td>Natural Hazard Service<br> Input type: Integer<br>

        Output type: Integer</td>

      <td>YES</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/Index.aspx">tryIt</a></td>

      <td>Uses an existing API, Provides an earthquake index for a location to aid in construction decisions and

        insurance assessments.</td>

    </tr>

    <tr>

      <td>Aryan Barot</td>

      <td>Wind Intensity<br> Input type: Integer<br>

        Output: string decimal</td>

        <td>YES</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page9/Index.aspx">tryIt</a></td>

      <td>Uses a 10 year dataset from NASA, Assesses the annual average wind intensity at a given location to ensure

        construction can withstand local wind conditions</td>





    </tr>



    <tr>

      <td>Aryan Barot</td>

      <td>Subscription Service</td>
        <td>NO</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page1/">tryIt</a></td>

      <td>Subscription service for my restaurant service, only subscribed user get access to the information</td>





    </tr>

    <tr>

      <td>Aryan Barot</td>

      <td>restaurant service</td>

        <td>NO</td>

      <td><a href="http://webstrar22.fulton.asu.edu/page1/">tryIt</a></td>

      <td>Gives access to the item details available in the menu only to the subscribed users </td>

    </tr>

    <tr>

    <td>Smit Lagdhirbhai Desai</td>

    <td>Weather Forecast<br> Input type: String - Zip code, Output type: list of array - 5 day Forecast<String, Int></td>

        <td>YES</td>

    <td><a href="http://webstrar22.fulton.asu.edu/page9/Index.aspx">tryIt</a></td>

    <td>Asks for zipcode and gives the five day forcast using API</td>

    </tr>



   


      <tr>
    <td>Smit Lagdhirbhai Desai</td>

    <td>Solar Energy Service<br> Input type: String - Zip code, Output type: Integer<String, Int>

    </td>

          <td>YES</td>

    <td><a href="http://webstrar22.fulton.asu.edu/page9/Index.aspx">tryIt</a></td>

    <td>Gives the solar intensity of the region of given zipcode using API for solar index and a mathematical formula

    </td>

    </tr>





    <tr>



    <td>Smit Lagdhirbhai Desai</td>

    <td>Average houseHold Income <br> Input type: string Zip code, Output type: String - money in dollars<String, Int>

    </td>

        <td>NO</td>

    <td><a href="http://webstrar22.fulton.asu.edu/page6/">tryIt</a></td>

    <td>Asks for zipcode and gives the average houseHold income of that area</td>

    </tr>





    <tr>

    <td>Smit Lagdhirbhai Desai</td>

    <td>membership<br> Input type: string array size 3, Name, email and comapny name , Output type: Sting message

      <String, Int>

    </td>

        <td>NO</td>

    <td><a href="http://webstrar22.fulton.asu.edu/page6/">tryIt</a></td>

    <td>Asks for user info and then adds the data to xml file and saves data for the membership to the construction club

    </td>

    </tr>



  </table>

        <h1>Integrated Services Are Here</h1>
        <h2>Know your area and have the best future construction site</h2>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Natural Hazard Services"></asp:Label>
    </p>
        <p>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Large" Text="Location Earthquake Counts "></asp:Label>
        <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Latitude [-90 to 90] and Longitude [-180 to 180]"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Height="73px" Text="Minimum Latitude" Width="204px" Font-Size="Small"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="154px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
&nbsp;<asp:Label ID="Label4" runat="server" Height="36px" Text="Minimum Longitude" Width="191px" Font-Size="Small"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="31px" Width="154px"></asp:TextBox>
    </p>
    <p>
        &nbsp;<asp:Label ID="Label5" runat="server" Height="27px" Text="Maximum Latitude" Width="180px" Font-Size="Small"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="31px" Width="154px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Height="35px" Text="Maximum Longitude" Width="179px" Font-Size="Small"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server" Height="32px" Width="154px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="SearchButton1" runat="server" Height="39px" OnClick="SearchButton1_Click" Text="Search!" Width="120px" Font-Size="Small" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Earthquake count" Font-Size="Small" ForeColor="#0099FF"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" ForeColor="Black" Text="Location Average Wind Energy Index" Font-Bold="True" Font-Size="Large"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Label ID="Label9" runat="server" Height="35px" Text="Latitude" Width="126px" Font-Size="Small"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="31px" Width="154px"></asp:TextBox>
    </p>
    <p>
        &nbsp;<asp:Label ID="Label10" runat="server" Text="Longtitude" Font-Size="Small"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Height="31px" Width="154px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="SearchButton2" runat="server" Height="39px" OnClick="SearchButton2_Click" Text="Search!" Width="120px" Font-Size="Small" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Text="Annual Avg Wind Intensity" BackColor="White" Font-Size="Small" ForeColor="#0099FF"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
        <p>
            <asp:Label ID="Label23" runat="server" Font-Bold="True" Text="Know Your Weather!!"></asp:Label>
        </p>
 <p>
     &nbsp;</p>
 <p>
     <asp:Label ID="Label13" runat="server" Text="Enter the zipcode for weather forecast"></asp:Label>
     &nbsp;
     <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
     &nbsp;&nbsp;
     <asp:Button ID="SubmitButton1" runat="server" OnClick="SubmitButton1_Click" Text="Submit" />
 
 </p>
        <p>
     <br />
     <asp:Label ID="Label14" runat="server" Text="Day1 Forecast"></asp:Label>
 </p>
 <p>
     <asp:Label ID="Label15" runat="server" Text="Day2 Forecast"></asp:Label>
 </p>
 <p>
     <asp:Label ID="Label16" runat="server" Text="Day3 Forecast"></asp:Label>
 </p>
 <p>
     &nbsp;</p>
 <p>
     &nbsp;</p>
 <p>
     &nbsp;</p>
 <p>
     <asp:Label ID="Label17" runat="server" Text="Solar Intensity"></asp:Label>
 </p>
 <p>
     <asp:Label ID="Label18" runat="server" Text="Enter the cordinates"></asp:Label>
 </p>
 <p>
     <asp:Label ID="Label19" runat="server" Text="Latitude"></asp:Label>
     <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
 </p>
 <p>
     &nbsp;</p>
        <p>
     <asp:Label ID="Label20" runat="server" Text="Longitude"></asp:Label>
     <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
 </p>
 <p>
     &nbsp;</p>
        <p>
     <asp:Button ID="SubmitButton2" runat="server" Text="Submit" OnClick="SubmitButton2_Click" />
 </p>
 <p>
     <asp:Label ID="Label21" runat="server" Text="Solar Intensity:"></asp:Label>
 &nbsp;&nbsp;
     <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
 </p>
    

</form>
    

</body>



</html>