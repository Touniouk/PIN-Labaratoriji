<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PIN_Labaratoriji._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    Vježba 1:<br />
        Hello, World!
    <hr />
    Vježba 2:<br />
    <asp:Label ID="Label1" runat="server" Text="Unesi magičnu riječ:"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Magična riječ pogođena:" Visible="False"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text="Magična riječ nije pogođena:" Visible="False"></asp:Label>
    <asp:TextBox ID="EnterMagicWord_Text" runat="server"></asp:TextBox>
    <asp:Button ID="CheckMagicWord_Button" runat="server" Text="Provjeri" OnClick="CheckMagicWord_Button_Click" />

</asp:Content>
