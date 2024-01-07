﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="CSE355BYS.report" MasterPageFile="~/template.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <p>
        Güncellenecek Sağlık Raporu Numarası
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Sağlık Raporu Hastalık
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Sağlık Raporu Tarih
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Sağlık Raporu Engel Yüzdesi
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="editHealthReport" Text="Sağlık Raporunu Düzenle" />
        <asp:Label id="Label2" runat="server" Text=" " />
    </p>
    <br />
    <p>
        Güncellenecek Ram Raporu Numarası
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        Ram Raporu Hastalık
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        Ram Raporu Tarih
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button4" runat="server" OnClick="editRamReport" Text="Ram Raporunu Düzenle" />
        <asp:Label id="Label3" runat="server" Text=" " />
    </p>
    <br />

    <p>
        <asp:Button ID="Button1" runat="server" OnClick="list_report" Text="Listele" />
        &nbsp;
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="NOT_VALID_REPORT_FOR_STUDENT" Text="Geçerli Olmayan Raporları Listele" />
        &nbsp;
    </p>
    <br />
     <p>
        <asp:Label id="Label1" runat="server" Text=" " />
    </p>
    
    <p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    </p>
    <p>
        &nbsp;
    </p>
</asp:Content>

