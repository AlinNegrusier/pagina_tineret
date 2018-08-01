﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Live.aspx.vb" Inherits="DeptTineretCrestin.Live" %>
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


        function InicializaContador(fecha) {
            // Set the date we're counting down to
            //Mes/Dia/año
            var countDownDate = new Date(fecha).getTime();

            // Update the count down every 1 second
            var x = setInterval(function () {

                // Get todays date and time
                var now = new Date().getTime();

                // Find the distance between now and the count down date
                var distance = countDownDate - now;

                // Time calculations for days, hours, minutes and seconds
                var days = Math.floor(distance / (1000 * 60 * 60 * 24));
                var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
                var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
                var seconds = Math.floor((distance % (1000 * 60)) / 1000);

                // Display the result in the element with id="demo"
                document.getElementById("timp").innerHTML = days + " zile " + hours + " ore "
                    + minutes + " minute " + seconds + " secunde ";

                // If the count down is finished, write some text 
                if (distance < 0) {
                    clearInterval(x);
                    document.getElementById("timp").innerHTML = "Se transmite acum!";
                }
            }, 1000);
        }


</script>
</asp:Content>