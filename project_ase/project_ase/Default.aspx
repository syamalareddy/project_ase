<%@ Page Title="" Language="C#" MasterPageFile="~/interior-design/MasterPage.master" Debug="true" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="interior_design_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">

   
    <h2>
    &nbsp&nbsp&nbsp Enter items here
    </h2>
    <form id="Form1" runat="server">
    <asp:Label ID="lbl_Name" runat="server" Text="Item_Name"></asp:Label>
    <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox><br />
    <asp:Label ID="lbl_Price" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="txt_Price" runat="server"></asp:TextBox><br />
    <asp:Label ID="lbl_Grocery_Store" runat="server" Text="Enter Grocery Store"></asp:Label>
    <asp:TextBox ID="txt_Grocery_Store" runat="server"></asp:TextBox><br />
    <asp:FileUpload ID="img_FileUpload" runat="server" /><br />
        <asp:Button ID="btn_upload" runat="server" Text="Upload" OnClick="btn_upload_Click"></asp:Button >
        </form>
   </asp:Content>




