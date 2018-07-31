<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.vb" Inherits="DeptTineretCrestin.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="row">
            <div class="box-flex fullwidth">
                <h1 class="titlu"><asp:Label runat="server" ID="titulo_articulo" Text="Contact"></asp:Label></h1>
            </div>
        </div>

  <!-- Team -->
<div id="team" class="pb-5">
    <div class="container">
        <div class="row">
            <asp:Literal runat="server" ID="contactos"></asp:Literal>

            <!-- Team member -->
           <%-- <div class="col-xs-12 col-sm-6 col-md-4">
                <div class="image-flip" >
                    <div class="mainflip flip-0">
                        <div class="frontside">
                            <div class="card">
                                <div class="card-body text-center">
                                    <p><img class=" img-fluid" src="https://i.imgur.com/Aar6u8z.jpg" alt="card image"></p>
                                    <h4 class="card-title">Negrușier Pavel</h4>
                                    <p class="card-text text-left"><strong>Telefon: </strong> 642 775 495 <br />
                                        <strong>Email: </strong> pavelnegrusier@gmail.com
                                    </p>
                                    
                                    <a href="#" class="btn btn-outline-morado btn-sm"><i class="fa fa-plus"></i></a>
                                </div>
                            </div>
                        </div>
                        <div class="backside">
                            <div class="card">
                                <div class="card-body text-center mt-4">
                                    <h4 class="card-title">Negrușier Pavel</h4>
                                    <p class="card-text">This is basic card with image on top, title, description and button.This is basic card with image on top, title, description and button.This is basic card with image on top, title, description and button.</p>
                                    <ul class="list-inline">
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="https://www.facebook.com/pavel.negrusier">
                                                <i class="fab fa-facebook-f"></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>--%>
            <!-- ./Team member -->
            
        </div>
    </div>
</div>
</asp:Content>
