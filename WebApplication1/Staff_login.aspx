<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff_login.aspx.cs" Inherits="WebApplication1.Staff_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1 style="color:black;" align="center">Staff Login Page</h1>
  <br />
     <asp:Label ID="Label3" runat="server" Forecolor="blue" Text=""  ><b></b></asp:Label>&nbsp;
     <br />
  <br />
 
  <strong style="color:darkred;">Welcome Staff Members!!</strong>   <br />  
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

		  
    	
	   <asp:Button ID="GoButton" runat="server" Text="Login" onclick="GoButton_Click" />
    
    <br />
           <br />

    <asp:Label ID="Error" runat="server" Forecolor="red" Text=""  ><b></b></asp:Label>&nbsp;
     
    <br />
     <br />
        </div>
    </form>
</body>
</html>
