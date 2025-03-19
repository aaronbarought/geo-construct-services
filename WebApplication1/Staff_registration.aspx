<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff_registration.aspx.cs" Inherits="WebApplication1.Staff_registration" %>

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
             <span><b><u>Welcome Staff Members!!</u></b></span><br />
&nbsp;<br />

           <asp:Label ID="Label1" runat="server" Text="UserName:" Width="200px" required Font-Bold="True"></asp:Label>&nbsp;
       <asp:TextBox ID="UserInput" runat="server" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>
   
            <br />
              
 
                              <br />
	   <asp:Label ID="Label2" runat="server" Text="Password:" Width="200px" required Font-Bold="True"></asp:Label>&nbsp;
       <asp:TextBox ID="PasswordInput" runat="server" TextMode="Password" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>
   

    <br />



     <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register New Members" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button2" runat="server" Text="Remove New Members" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
             <br />
             <asp:Button ID="Button3" runat="server" Text="Prints All Member Details" Width="425px" OnClick="Button3_Click" />
       <br />
       <br />
             <asp:Label ID="Label3" runat="server" Text="All member details here"></asp:Label>
             <br />
            <br />
    <asp:Label ID="Error" runat="server" Forecolor="red" Text=""  ><b></b></asp:Label>
     
        </div>
    </form>
</body>
</html>
