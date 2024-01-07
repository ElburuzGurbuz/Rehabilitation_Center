<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CSE355BYS._default" MasterPageFile="~/login.Master" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p>
        Username&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Password&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        
        <!-- <input type="password" name="TextBox2" /> -->
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş" style="height: 26px" />
    </p>
     <p>
        <asp:Label id="Label1" runat="server" Text=" " />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

