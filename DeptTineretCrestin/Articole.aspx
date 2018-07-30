<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Articole.aspx.vb" Inherits="DeptTineretCrestin.Articole" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="box-flex fullheight fullwidth"> 
     
            
         <div class="row">
            <div class="box-flex fullwidth">
                <div class="fullwidth">
                    <img src="Img/cabecera_articulo.png" class="cabecera_articulo" />
                 </div>
                <h1 class="titlu"><asp:Label runat="server" ID="titulo_articulo" Text="Titlu Articol"></asp:Label></h1>
            </div>
        </div>

        <div class="row">
            <div class="box-flex fullwidth text-left" style="padding: 5px 20px 5px 20px;"> 
                <p class="subtitlu"><span class="descriptie_subtitlu">Autor: </span><asp:Label runat="server" ID="Autor" Text="Negrusier Cristian Alin"></asp:Label></p>
                <p class="subtitlu"><span class="descriptie_subtitlu">Data redactării: </span><asp:Label runat="server" ID="Data_Redactarii" Text="1 Ian., 2018"></asp:Label></p>
            </div>
        </div>

       <div class="row">
            <div class="box-flex fullwidth text-left continut_articol"> 
               
                <%--<asp:Literal runat="server" ID="continut_articol"></asp:Literal>--%>
            <p>Lorem <strong>ipsum</strong> dolor sit amet, consectetur adipiscing elit. Praesent sollicitudin ultricies quam sit amet viverra. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aenean sed facilisis massa, vel accumsan justo. Quisque eu augue condimentum, laoreet lacus in, rutrum massa. Vivamus eu bibendum sem, a auctor tellus. Sed porttitor purus sit amet ultricies sodales. Sed aliquet pellentesque eros ac imperdiet. Nulla ligula erat, lacinia eget leo et, congue euismod risus. Vestibulum ac tempor mi. Nulla mauris neque, laoreet in tristique non, fringilla vel elit. Cras sagittis arcu at turpis porttitor sagittis. Nulla eget rutrum nibh, id hendrerit eros.</p>
<p>Sed neque ligula, finibus eget pretium in, bibendum vel ligula. Cras <b><span class="titlu">posuere dui</span></b> a tincidunt tempor. Quisque dictum vehicula turpis, in dapibus nisl ultrices eget. Quisque et pharetra urna. Curabitur laoreet bibendum nisl. Morbi turpis sem, tempus a elementum eu, ornare sit amet ante. Vivamus sagittis, elit a hendrerit imperdiet, magna elit placerat lectus, at rutrum orci tellus non ex. Sed pulvinar aliquam nunc at mattis. Sed vel tortor tortor.</p>

<p>&nbsp;<img style="display: block; margin-left: auto; margin-right: auto; overflow: scroll; width: 100%; height: auto; max-width: 400px;" src="https://i.imgur.com/5MxftYu.png" width="641" height="564" /></p>

<p>Nulla a tortor quam. Ut aliquet vitae augue nec malesuada. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum aliquet metus felis, nec ornare mi dictum at. Nam tincidunt ligula sed felis consectetur condimentum. Quisque malesuada risus lorem, in aliquet risus consequat ac. Fusce cursus nec ex eu consequat. Proin vel est leo. Sed suscipit sem sed enim gravida laoreet. Fusce in risus eget justo consequat ornare. Vestibulum eleifend hendrerit orci, id vestibulum ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis at odio ac ligula placerat cursus sit amet sit amet augue. Morbi convallis dolor sed purus consectetur, eget blandit ex placerat. Duis a convallis libero.</p>

  <div class="video_responsive">
  <iframe src="//www.youtube.com/embed/uKsDFMUl138" width="560" height="314" allowfullscreen="allowfullscreen"></iframe>
</div>
<br />
                <p>Nulla a tortor quam. Ut aliquet vitae augue nec malesuada. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum aliquet metus felis, nec ornare mi dictum at. Nam tincidunt ligula sed felis consectetur condimentum. Quisque malesuada risus lorem, in aliquet risus consequat ac. Fusce cursus nec ex eu consequat. Proin vel est leo. Sed suscipit sem sed enim gravida laoreet. Fusce in risus eget justo consequat ornare. Vestibulum eleifend hendrerit orci, id vestibulum ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis at odio ac ligula placerat cursus sit amet sit amet augue. Morbi convallis dolor sed purus consectetur, eget blandit ex placerat. Duis a convallis libero.</p>
    


            </div>
        </div>



   </div>
        </div>
    <div class="row">
        <div class="box-flex fullwidth text-right" style="padding-top:0px;"> 
                <p class="titlu" style="font-size: 1rem;">Ți-a fost folositor articolul?, Distribuie si celorlalți!</p>
                <div class="addthis_inline_share_toolbox"></div>
            </div>
    </div>

    <div class="row">
            <div class="box-flex fullwidth">
                <h1 class="titlu">Sfârșit</h1>
                <div class="fullwidth">
                    <img src="Img/pie_articulo.png" class="cabecera_articulo" />
                 </div>
            </div>
        </div>
</asp:Content>
