<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member_registration.aspx.cs" Inherits="WebApplication1.Member_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
 <br />
      <span><b><u>Member Registration</u></b></span>
        <br />

           <asp:Label ID="Label1" runat="server" Text="UserName:" Width="200px" required Font-Bold="True"></asp:Label>&nbsp;<br />
&nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="1550px"></asp:TextBox>
   
            <br />
              
 
                              <br />
	   <asp:Label ID="Label2" runat="server" Text="Password:" Width="200px" required Font-Bold="True"></asp:Label>&nbsp;
            <br />
            <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="1550px"></asp:TextBox>
   

    <br />




            <asp:Image ID="Image1" runat="server" Height="100px" Width="288px" />
     <br />
     <br />
      <asp:TextBox ID="textInput1" runat="server" Height="35px" Width="194px" BorderColor="#999999"></asp:TextBox> 
         &nbsp;&nbsp;&nbsp;&nbsp; 
         <asp:RequiredFieldValidator ForeColor="red" runat="server" id="RequiredFieldValidator1" controltovalidate="textInput1" errormessage="Enter The String Here!" Font-Bold="True" />
            <br />
            <br />
            <asp:Label ID="ErrorLabel" runat="server" Text="Label"></asp:Label>
     <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Register" />
       <br />
        <br />
            <br />
    <asp:Label ID="Error" runat="server" Forecolor="red" Text=""  ><b></b></asp:Label>
     
        </div>
    </form>
</body>
</html>
