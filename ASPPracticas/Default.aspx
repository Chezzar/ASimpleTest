<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPPracticas._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <asp:TextBox ID="txtConteo" runat="server" CssClass="text-success" Height="63px" OnTextChanged="txtConteo_TextChanged" TextMode="MultiLine" ToolTip="Ejemplo de Text Box de una linea"></asp:TextBox>
        <asp:Button ID="btnIncremementa" runat="server" OnClick="btnIncremementa_Click" Text="incrementa" CssClass="btn-danger" CommandName="deire" OnCommand="TestCommand" />
        <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" GroupName ="desire" />
        
    </p>

    <p>
        Primer Ejemplo<br/>
    </p>

    <p><asp:HyperLink ID="LinkDePureba" runat="server" NavigateUrl="~/WebForm1.aspx">Link Al To The Heaven</asp:HyperLink></p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" OnClientClick="return func();">Esto Tiene un Scrip de JavaScript</asp:LinkButton>

        <asp:ImageButton ID="ImageButton1" runat="server" Width="102px" />

        <script  type ="text/javascript">

            function func() {

                alert("im an javascript function NOW!!!!");

                return true;
            }

        </script>

    <p>
        <asp:DropDownList ID="ddlfrutas" runat="server">
            <asp:ListItem>Peritas</asp:ListItem>
            <asp:ListItem>Guabayas</asp:ListItem>
            <asp:ListItem>Aguacatos</asp:ListItem>
            <asp:ListItem>Mancanas</asp:ListItem>
            <asp:ListItem>Platanito Show</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnPruebas" runat="server" CssClass="btn-info" OnClick="btnPruebas_Click" Text="Test Test Test" />
    </p>

    <p>

        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Desde La base de datos</asp:ListItem>
        </asp:DropDownList>

    </p>
    

</asp:Content>
