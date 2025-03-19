<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="member_login.aspx.cs" Inherits="WebApplication1.member_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:black;" align="center">Member Login Page</h1>
 <br />
     <asp:Label ID="Label3" runat="server" Forecolor="black" Text=""  ><b></b></asp:Label>&nbsp;
     <br />
  <br />
  <strong style="color:darkred;">Welcome Members!!</strong>   <br />  
    <br />

	   <asp:Label ID="Label1" runat="server" Text="Name:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="username_input" runat="server" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>

                <br />
          <br />
		  
		     <asp:Label ID="Label2" runat="server" Text="Password:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="passsword_input"  TextMode="Password" runat="server" Height="25px" width="100%" BorderColor="#999999" >
    
       </asp:TextBox>
                <br />
          <br />

	        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    
            <br />
    
    <br />
           <br />

    <asp:Label ID="Error" runat="server" Forecolor="red" Text=""  ><b></b></asp:Label>&nbsp;
     
    <br />
     <br />
            <!-- Registration Link -->
            Not a User? 
            <asp:HyperLink ID="HyperLinkRegister" runat="server" NavigateUrl="~/member_registration.aspx">Register here</asp:HyperLink>.
        </div>
    </form>
</body>
</html>
