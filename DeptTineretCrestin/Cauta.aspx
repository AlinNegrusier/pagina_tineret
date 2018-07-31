<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Cauta.aspx.vb" Inherits="DeptTineretCrestin.Cauta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="box-flex fullheight fullwidth"> 
     
            
         <div class="row">
            <div class="box-flex fullwidth">
                <div class="fullwidth">
                    <img src="Img/cabecera_articulo.png" class="cabecera_articulo" />
                 </div>
                <h1 class="titlu"><asp:Label runat="server" ID="titulo_articulo" Text="Rezultatele Căutării: "></asp:Label></h1>
            </div>
        </div>

             <asp:Panel runat="server" ID="panel_sin_datos" class="row">
            <div class="box-flex fullwidth">
                <h1 class="titlu"><asp:Label runat="server" ID="Label1" Text="Articolul căutat nu a fost găsit"></asp:Label></h1>
            </div>
        </asp:Panel>

       <div class="row">
            <div class="box-flex fullwidth text-left continut_articol"> 
               
                <%--<asp:Literal runat="server" ID="continut_articol"></asp:Literal>--%>

           


            </div>
        </div>



   </div>
        </div>
    <asp:Panel runat="server" ID="panel_distribuie" class="row">
        <div class="box-flex fullwidth text-right" style="padding-top:0px;"> 
                <p class="titlu" style="font-size: 1rem;">Ți-a fost folositor articolul?, Distribuie si celorlalți!</p>
                <div class="addthis_inline_share_toolbox"></div>
            </div>
    </asp:Panel>

    <div class="row">
            <div class="box-flex fullwidth">
                <h1 class="titlu"><asp:Label runat="server" ID="mesaj_sfarsit" Text="Sfârșit"></asp:Label></h1>
                <div class="fullwidth">
                    <img src="Img/pie_articulo.png" class="cabecera_articulo" />
                 </div>
            </div>
        </div>
</asp:Content>
