<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CadastrarSolicitacao.aspx.cs" Inherits="GEFAM.WebUI.View.CadastrarSolicitacao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#imbPlus").click(function (event) {
                $("#dadosComplementares").toggle();
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Cadastrar Solicitação</h1>
    <hr />
    <fieldset>
        <legend>Dados do Paciente</legend>
        <div class="edit-singlecolmun">
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        &nbsp;
                    </label>
                </div>
                <div class="edit-field">
                    <img src="../Styles/imagens/plus24.png" id="imbPlus" style="margin-top: -2px" />
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        Nome: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtNomePaciente" runat="server" MaxLength="150" Width="500px" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        CPF: *
                    </label>
                </div>
                <div class="edit-field">
                    <asp:TextBox ID="txtCPF" runat="server" MaxLength="11" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="edit-multicolums">
                <div class="edit-label">
                    <label>
                        &nbsp;
                    </label>
                </div>
                <div class="edit-field">
                    <asp:ImageButton ID="ImageButton1" ImageUrl="~/Styles/imagens/search.png" runat="server"
                        Style="margin-top: -2px" />
                </div>
            </div>
        </div>
        <div id="dadosComplementares" style="margin-left: 3em; display: none">
            <div class="edit-singlecolmun">
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
                <div class="edit-multicolums">
                    <div class="edit-label">
                        <label>
                            Nome da Mãe: *
                        </label>
                    </div>
                    <div class="edit-field">
                        <asp:TextBox ID="txtNomeMae" runat="server" MaxLength="150" Width="400px"></asp:TextBox>
                    </div>
                </div>
                <div class="edit-multicolums">
                    <div class="edit-label">
                        <label>
                            Nome da Responsável: *
                        </label>
                    </div>
                    <div class="edit-field">
                        <asp:TextBox ID="txtNomeResponsavel" runat="server" MaxLength="150" Width="400px"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
    </fieldset>
    <%--ToDo: Modal--%>
    <%--<asp:UpdatePanel runat="server" ID="updPop">
            <ContentTemplate>
                <div class="botoes_direita" style="display: none">
                    <asp:LinkButton ID="lnkInserir" Text="Inserir" runat="server" />
                </div>
                <div id="mdCadastro" class="modalpopup" style="display: none; width: 520px">
                    <uc1:uccCadastrarBanco ID="uccCadastro" runat="server" />
                </div>
                <ajaxToolkit:ModalPopupExtender ID="mpeCadastro" runat="server" BackgroundCssClass="modalbackground"
                    PopupControlID="mdCadastro" TargetControlID="lnkInserir">
                </ajaxToolkit:ModalPopupExtender>
            </ContentTemplate>
            
        </asp:UpdatePanel>--%>
</asp:Content>
