<%@ Page Title="" Language="C#" MasterPageFile="~/CodeBased.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="codebaseexam4.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <center>
         <form id="form1" runat="server">
        
            <p>Select Product From the below List:</p>
            <asp:DropDownList ID="ProductDropDown" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ProductDropDown_SelectedIndexChanged">
                <asp:ListItem Value="">Select Product</asp:ListItem>
                <asp:ListItem>Camera</asp:ListItem>
                <asp:ListItem>Headphone</asp:ListItem>
                <asp:ListItem>Mobile</asp:ListItem>
                <asp:ListItem>Smartwatch</asp:ListItem>
            </asp:DropDownList>

              <asp:Button ID="Price" runat="server" Text="Get Price" onClick="Button1_Click"/>
           
         </form>
         <br />
            <br />
             <asp:Label ID="Message" runat="server" Text="Select one product" > </asp:Label>
            <br />
            <br /> 
            <asp:Image ID="ProductImage" runat="server" Visible="false" Height="260px" Width="299px" />
            <br />
            <br />
            <asp:Label ID="ProductPrice" runat="server" Text="Label"  Visible="false"> </asp:Label>
           
    </center>
        
</asp:Content>
