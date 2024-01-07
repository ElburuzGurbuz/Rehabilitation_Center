<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="psychologist.aspx.cs" Inherits="CSE355BYS.psychologist" MasterPageFile="~/template.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <p>
        identityNumber
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        firstName
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        lastName
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        gender
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        gsm
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        salary
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        City
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
        Street
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
        Apartment Name
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    </p>
    <p>
        Apartment Num
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    </p>
    <p>
        ZipCode
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
    </p>
    
    

    
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="add_psychologist" Text="Ekle" />
        &nbsp;
        
    </p>
    <br />
    <p>
        Çıkarılacak Psikolog ID
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="delete_psychologist" Text="Çıkar" />
        &nbsp;
    </p>
    <br />
     <p>
        <asp:Label id="Label1" runat="server" Text=" " />
    </p>
    

    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
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

