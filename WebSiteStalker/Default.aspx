<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebSiteStalker._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    </br>
    </br>
    
   <asp:TextBox ID="textBoxSearch" runat="server"></asp:TextBox>
    <asp:Button ID="ButtonSubmit" runat="server" Text="Search !" OnClick="ButtonSubmit_Click" />

    </br>
    </br>
   <div runat="server" id="mainTable">

   </div>
    
</asp:Content>
