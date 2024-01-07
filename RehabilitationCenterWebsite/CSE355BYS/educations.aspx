<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="educations.aspx.cs" Inherits="CSE355BYS.educations" MasterPageFile="~/template.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <p>
        Terapi Açıklaması
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        Tarih
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Psikolog ID
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Öğrenci ID
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="add_therapy" Text="Terapi Ekle" />
        <asp:Label ID="Label1" runat="server" Text=" " />
        &nbsp;
    </p>
    <br />
    <p>
        İptal Edilecek Terapi ID
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>

    <p>
        <asp:Button ID="Button2" runat="server" OnClick="delete_therapy" Text="Terapi İptal" />
        <asp:Label ID="Label2" runat="server" Text=" " />
        &nbsp;
    </p>
     <br />
    <p>
        Uygun Eğitmenler Aranacak Öğrencinin ID'si
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button10" runat="server" OnClick="sp_ListAppropriateInstructors" Text="Listele" />
    </p>
    <br />
    <p>
        Öğrenci ID
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
        Eğitmen ID
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button11" runat="server" OnClick="sp_addInstructorList" Text="Öğrenciye Eğitmen Ata" />
        <asp:Label ID="Label3" runat="server" Text=" " />
    </p>
    <br />
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="List_therapy" Text="Terapileri Listele" />
        <asp:Button ID="Button4" runat="server" OnClick="List_psychologist" Text="Psikologları Listele" />
        <asp:Button ID="Button5" runat="server" OnClick="List_student" Text="Öğrencileri Listele" />

        <asp:Button ID="Button7" runat="server" OnClick="LISTING_STUDENT_ASSIGNED_INST" Text="Öğrencilere Atanan Öğretmenleri Listele" />
        <asp:Button ID="Button8" runat="server" OnClick="LISTING_STUDENTS_ASSIGNED_TO_INSTRUCTOR" Text="Öğretmenlere Atanan Öğrenci Sayılarını Listele" />
        <asp:Button ID="Button6" runat="server" OnClick="TOP_10_MOST_DISABLE" Text="Özel İlgi Gereken Öğrencileri Listele" />
        <asp:Button ID="Button9" runat="server" OnClick="THERAPY_SESSION_IN_ONE_WEEK" Text="Bir Hafta İçindeki Terapiler" />

    </p>
    <br />
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

