<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Location.aspx.cs" Inherits="Location" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 153px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                Location Name:</td>
            <td>
                <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Postal Code:</td>
            <td>
                <asp:TextBox ID="txtPCode" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Venue :</td>
            <td>
                <asp:TextBox ID="txtVenue" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Unit No :</td>
            <td>
                <asp:TextBox ID="txtUNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="BtnCreate" runat="server" onclick="Button1_Click" Text="Create Location" />
                <asp:Label ID="LblResult" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
