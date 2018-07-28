<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Acasa.aspx.vb" Inherits="DeptTineretCrestin.Acasa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="box-flex verset fullheight">
        <div class="row">
            <div class="col justify-content-center">
                <h2><b><i>"…V-am scris, tinerilor, fiindcă sunteţi tari şi Cuvântul lui Dumnezeu rămâne în voi şi aţi biruit pe cel rău.”</i></b></h2>
            </div>
            </div>
        
        <div class="row">
            <div class="col justify-content-center">
                <h3><span class="referinta">1 Ioan 2:14</span></h3>
            </div>
        </div>
        </div>
    <div class="box-flex fullheight" style="display:table;"> 
        <div class="col justify-content-center mesaj_bunvenit mesaj_bunvenit_text">
                 
			Bine ai venit pe pagina oficiala al departamentului de tineret creştin penticostal, comunitatea Madrid!
			
        </div>
    </div>

    <div class="box-flex fullheight cajaTimeline">
        <div class="row">
            <div class="box-flex fullheight fullwidth"> 
                <h1 class="titlu">Ultimele Evenimente</h1>
            </div>
        </div>

         <div class="row d-sm-none">
            <div class="box-flex fullheight fullwidth"> 
                <h6 class="titlu">(Glisați spre stânga sau dreapta)</h6>
            </div>
        </div>
        
<section class="cd-horizontal-timeline">
	<div class="timeline">
		<div class="events-wrapper">
            <asp:Panel ID="lista_eventos_barra" runat="server" CssClass="events">
				

			</asp:Panel>
			<%--<div class="events">
				<ol>
					<li><a href="#0" data-date="16/01/2014">16 Jan</a></li>
					<li><a href="#0" data-date="28/02/2014">28 Feb</a></li>
					<li><a href="#0" data-date="20/04/2014">20 Mar</a></li>
					<li><a href="#0" data-date="20/05/2014">20 May</a></li>
					<li><a href="#0" data-date="09/07/2015" class="selected">09 Jul</a></li>
					
				</ol>

				<span class="filling-line" aria-hidden="true"></span>
			</div>--%> 
            <!-- .events -->
		</div> <!-- .events-wrapper -->
			
		<ul class="cd-timeline-navigation">
			<li><a href="#0" class="prev inactive">Prev</a></li>
			<li><a href="#0" class="next">Next</a></li>
		</ul> <!-- .cd-timeline-navigation -->
	</div> <!-- .timeline -->

    <asp:Panel runat="server" CssClass="events-content" ID="contenido_eventos">


    </asp:Panel>

	<%--<div class="events-content">
		<ol>
			<li data-date="16/01/2014">
				<h2>Horizontal Timeline</h2>
				<em>January 16th, 2014</em>
				<p>	
					Lorem ipsum dolor sit amet, consectetur adipisicing elit. Illum praesentium officia, fugit recusandae ipsa, quia velit nulla adipisci? Consequuntur aspernatur at, eaque hic repellendus sit dicta consequatur quae, ut harum ipsam molestias maxime non nisi reiciendis eligendi! Doloremque quia pariatur harum ea amet quibusdam quisquam, quae, temporibus dolores porro doloribus.
				</p>
			</li>

			<li data-date="28/02/2014">
				<h2>Event title here</h2>
				<em>February 28th, 2014</em>
				<p>	
					Lorem ipsum dolor sit amet, consectetur adipisicing elit. Illum praesentium officia, fugit recusandae ipsa, quia velit nulla adipisci? Consequuntur aspernatur at, eaque hic repellendus sit dicta consequatur quae, ut harum ipsam molestias maxime non nisi reiciendis eligendi! Doloremque quia pariatur harum ea amet quibusdam quisquam, quae, temporibus dolores porro doloribus.
				</p>
			</li>

			<li data-date="20/04/2014">
				<h2>Event title here</h2>
				<em>March 20th, 2014</em>
				<p>	
					Lorem ipsum dolor sit amet, consectetur adipisicing elit. Illum praesentium officia, fugit recusandae ipsa, quia velit nulla adipisci? Consequuntur aspernatur at, eaque hic repellendus sit dicta consequatur quae, ut harum ipsam molestias maxime non nisi reiciendis eligendi! Doloremque quia pariatur harum ea amet quibusdam quisquam, quae, temporibus dolores porro doloribus.
				</p>
			</li>

			<li data-date="20/05/2014">
				<h2>Event title here</h2>
				<em>May 20th, 2014</em>
				<p>	
					Lorem ipsum dolor sit amet, consectetur adipisicing elit. Illum praesentium officia, fugit recusandae ipsa, quia velit nulla adipisci? Consequuntur aspernatur at, eaque hic repellendus sit dicta consequatur quae, ut harum ipsam molestias maxime non nisi reiciendis eligendi! Doloremque quia pariatur harum ea amet quibusdam quisquam, quae, temporibus dolores porro doloribus.
				</p>
			</li>

			<li class="selected" data-date="09/07/2015">
				<h2>Event title here</h2>
				<em>July 9th, 2015</em>
				<p>	
					Lorem ipsum dolor sit amet, consectetur adipisicing elit. Illum praesentium officia, fugit recusandae ipsa, quia velit nulla adipisci? Consequuntur aspernatur at, eaque hic repellendus sit dicta consequatur quae, ut harum ipsam molestias maxime non nisi reiciendis eligendi! Doloremque quia pariatur harum ea amet quibusdam quisquam, quae, temporibus dolores porro doloribus.
				</p>
			</li>

			
		</ol>
	</div> --%>
    
    <!-- .events-content -->
</section>
	
        
    </div>

    
</asp:Content>
