<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="FoodFromTheHeart._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="Styles/MaxStyle.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">


                      <div id="Login">
           
                                       <form id="Form1" runat="server">

                                       <table>
                                           <tr>
                                               <td style="font-size: large; font-weight: bold">
                                                Username:
                                               </td>
                                               
                                               <td class="style1">
                                                <asp:TextBox ID="tb_Username" runat="server"></asp:TextBox>                                              
                                               </td>
                                           </tr>

                                           <tr>
                                               <td style="font-size: large; font-weight: bold">
                                               Password:
                                               </td>
                                               
                                               <td class="style1">
                                               <asp:TextBox ID="tb_Password" runat="server" TextMode="Password"></asp:TextBox>
                                               </td>
                                           </tr>

                                           <tr>
                                               <td>
                                               
                                                   &nbsp;</td>
                                               
                                               <td id="buttonRight" class="style1">
                                               <asp:Button ID="btn_Submit" runat="server" Text="Login" Height="30px" Width="50px" 
                                                       onclick="btn_Submit_Click" />

                                                       <br />

                                               </td>
                                           </tr>

                                           <tr>
                                               <td colspan="2">
                                               
                                                   <asp:Label ID="lbl_messageNotice" runat="server" Text="" ForeColor="Red"></asp:Label>
                                               </td>
                                               
                                           </tr>
                                       </table>

                                       </form>

                                    </div>
    

</asp:Content>
