<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Live.aspx.vb" Inherits="DeptTineretCrestin.Live" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
            <div class="col justify-content-center">
                <div class="fullwidth text-center">
                    <img src="Img/cabecera_articulo.png" class="cabecera_articulo" />
                 </div>
                <h1 class="titlu text-center"><i>Live</i></h1>
            </div>
        </div>
     <asp:Panel runat="server" ID="panel_subtitlu" class="row">
            <div class="box-flex fullwidth text-left" style="padding: 5px 20px 5px 20px;"> 
                <p class="subtitlu"><span class="descriptie_subtitlu">Timp până la urmatoarea transmisie: </span><span id="timp"></span></p>

            </div>
        </asp:Panel>

    

    <asp:Literal runat="server" ID="panel_video"></asp:Literal>
            
     <div class="row">
            <div class="box-flex fullwidth">
                
                <div class="fullwidth">
                    <img src="Img/pie_articulo.png" class="cabecera_articulo" />
                 </div>
            </div>
        </div>
    <script>


</script>
</asp:Content>