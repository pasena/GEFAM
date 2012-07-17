<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CadastrarPaciente.aspx.cs" Inherits="GEFAM.WebUI.View.CadastrarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Cadastrar Paciente</h1>
    <hr />
    <fieldset>
        <legend>Dados do Paciente</legend>
        <div class="edit-singlecolmun">
            <div class="edit-label">
                <label>
                    Nome: *
                </label>
            </div>
            <div class="edit-field">
                <asp:TextBox ID="txtNomePaciente" runat="server" MaxLength="150" Width="700px"></asp:TextBox>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        CPF: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtCPF" runat="server" MaxLength="11"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Cartão Nacional de Saúde (CNS): *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="TextBox1" runat="server" MaxLength="11"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="edit-singlecolmun">
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Data de Nascimento: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtDataNascimento" runat="server" MaxLength="11"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Sexo: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:DropDownList ID="ddlSexo" runat="server">
                        <asp:ListItem Text="Selecione" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Masculino" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Feminio" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Raca/Cor: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:DropDownList ID="ddlRacaCor" runat="server">
                        <asp:ListItem Text="Selecione" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Branco" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Negro" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Pardo" Value="3"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="edit-singlecolmun">
            <div class="edit-label">
                <label>
                    Nome da Mãe: *
                </label>
            </div>
            <div class="edit-field">
                <asp:TextBox ID="txtNomeMae" runat="server" MaxLength="150" Width="500px"></asp:TextBox>
            </div>
            <div class="edit-label">
                <label>
                    Nome da Responsável: *
                </label>
            </div>
            <div class="edit-field">
                <asp:TextBox ID="txtNomeResponsavel" runat="server" MaxLength="150" Width="500px"></asp:TextBox>
            </div>
            <div class="edit-label">
                <label>
                    Telefone para contato: *
                </label>
            </div>
            <div class="edit-field">
                <asp:TextBox ID="txtTelefoneContato" runat="server" MaxLength="150" Width="100px"></asp:TextBox>
            </div>
        </div>
    </fieldset>
    <fieldset>
        <legend>Endereço </legend>
        <div class="edit-singlecolmun">
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Endereço Residencial (Rua, AV.): *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtLogradouro" runat="server" MaxLength="250" Width="700px"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Número: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtNumero" runat="server" MaxLength="10" Width="80px"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Bairro: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtBairro" runat="server" MaxLength="150" Width="250px"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="edit-singlecolmun">
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Município: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtMunicipio" runat="server" MaxLength="150" Width="300px"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        UF: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtUF" runat="server" MaxLength="2" Width="25px"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        CEP: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtCEP" runat="server" MaxLength="8" Width="70px"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Código IBGE Município: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtCodigoIBGE" runat="server" MaxLength="8" Width="150px"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="edit-singlecolmun">
            <div class="edit-label">
                <label>
                    Ponto de Referência: *
                </label>
            </div>
            <div class="edit-field">
                <asp:TextBox ID="txtPontoReferencia" runat="server" MaxLength="250" Width="700px"></asp:TextBox>
            </div>
        </div>
    </fieldset>
    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastar" />
</asp:Content>
