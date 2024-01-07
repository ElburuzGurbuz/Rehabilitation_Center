<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="CSE355BYS.employee" MasterPageFile="~/template.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="List_employee" Text="Çalışanları Listele" />
        <asp:Button ID="Button5" runat="server" OnClick="List_instructor" Text="Eğitmenleri Listele" />
        <asp:Button ID="Button6" runat="server" OnClick="List_psychologist" Text="Psikologları Listele" />
        <asp:Button ID="Button7" runat="server" OnClick="List_staff" Text="İşçileri Listele" />
        <asp:Button ID="Button2" runat="server" OnClick="EMPLOYEE_BELOW_AVG_SALARY" Text="Ortalamanın Altında Maaş Alan Eğitmenler" />
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

