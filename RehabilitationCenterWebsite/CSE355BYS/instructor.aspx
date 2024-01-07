<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructor.aspx.cs" Inherits="CSE355BYS.instructor" MasterPageFile="~/template.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <p>
        TC
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        Ad
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Soyad
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Uzmanlık
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
    </p>
    <p>
        Cinsiyet
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        GSM
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Maaş
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        Şehir
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
        Cadde-Sokak
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
        Apartman Adı
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    </p>
    <p>
        Apartman No
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    </p>
    <p>
        Posta Kodu
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
    </p>
    
    

    
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="add_instructor" Text="Ekle" />
        &nbsp;
        
    </p>
    <br />
    <p>
        Çıkarılacak Eğitmen ID
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="delete_instructor" Text="Çıkar" />
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

