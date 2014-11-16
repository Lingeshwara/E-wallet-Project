<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SidePage.aspx.cs" Inherits="FoodFromTheHeart.SidePag" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <div class="sidebar">
                <!-- insert your sidebar items here -->
                <h3>Latest Side Bar</h3>
                <h4>This is our Side Bar</h4>
                <h5>January 1st, 2010</h5>
                <p>Side Bar<br /><a href="#">Read more</a></p>
                <p></p>
                <h4>This is our Side Bar</h4>
                <h5>January 1st, 2010</h5>
                <p>Side Bar<br /><a href="#">Read more</a></p>
                <h3>Useful Links</h3>
                <ul>
                  <li><a href="#">link 1</a></li>
                  <li><a href="#">link 2</a></li>
                  <li><a href="#">link 3</a></li>
                  <li><a href="#">link 4</a></li>
                </ul>

                <h3>Search</h3>
                <form method="post" action="#" id="search_form">
                  <p>
                    <input class="search" type="text" name="search_field" value="Enter keywords....." />
                    <input name="search" type="image" style="border: 0; margin: 0 0 -9px 5px;" 
                          src="Styles/search.png" alt="Search" title="Search" />
                  </p>
                </form>

              </div>


</asp:Content>
