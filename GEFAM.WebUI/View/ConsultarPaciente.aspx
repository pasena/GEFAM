<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ConsultarPaciente.aspx.cs" Inherits="GEFAM.WebUI.View.ConsultarPaciente"
    Theme="Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Consultar Paciente</h1>
    <hr />
    <fieldset>
        <legend>Dados do Paciente</legend>
        <table id="filter">
            <tr>
                <td class="label">
                    Nome
                </td>
                <td>
                    <asp:TextBox ID="txtNomePaciente" runat="server" MaxLength="150"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="label">
                    CPF
                </td>
                <td>
                    <asp:TextBox ID="txtCPF" runat="server" MaxLength="11"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="label">
                    CNS
                </td>
                <td>
                    <asp:TextBox ID="txtCNS" runat="server" MaxLength="11"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="label">
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" />
                </td>
            </tr>
        </table>
    </fieldset>
    <div class="toolbar">
        <asp:LinkButton id="lnkCadastrar" Text="Cadastrar" runat="server" PostBackUrl="~/View/CadastrarPaciente.aspx" />
        <asp:LinkButton ID="lnkEditar" Text="Editar" runat="server" OnClientClick="FuncionalidadeNaoImplementada()"/>
        <asp:LinkButton ID="lnkExcluir" Text="Excluir" runat="server" OnClientClick="FuncionalidadeNaoImplementada()" />
    </div>
    <fieldset>
        <legend>Resultado</legend>
        <asp:GridView ID="grvResultado" runat="server" SkinID="GridResultado">
        </asp:GridView>
    </fieldset>
</asp:Content>
