Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Private Sub contenedor_items_menu_Init(sender As Object, e As EventArgs) Handles navbarSupportedContent.Init

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        request = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/AlinNegrusier/pagina_tineret/master/menu.json"), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim jResults As Object = JObject.Parse(rawresp)

        Dim ul As HtmlGenericControl = Crear_Elemento("ul",, "navbar-nav mr-auto")

        For Each item_menu In jResults
            For Each atributos In item_menu
                Dim hay_subniveles As Boolean = False
                If Not atributos("SUBNIVELES") Is Nothing Then
                    hay_subniveles = True
                End If

                If hay_subniveles Then
                    Dim li As HtmlGenericControl = Crear_Elemento("li",, "nav-item dropdown")
                    Dim a As HtmlGenericControl = Crear_Elemento("a", atributos("ID"), "nav-link dropdown-toggle", atributos("REDIRECCION"))
                    a.Attributes.Add("role", "button")
                    a.Attributes.Add("data-toggle", "dropdown")
                    a.Attributes.Add("aria-haspopup", "true")
                    a.Attributes.Add("aria-expanded", "false")
                    a.InnerText = atributos("NOMBRE_WEB")
                    Dim div As HtmlGenericControl = Crear_Elemento("div",, "dropdown-menu")
                    div.Attributes.Add("aria-labelledby", "navbarDropdown")

                    For Each subitem In atributos("SUBNIVELES")
                        Dim a_subitem As HtmlGenericControl
                        Dim url As String = HttpContext.Current.Request.Url.AbsoluteUri

                        If url.ToUpper.Contains(subitem("REDIRECCION").ToString.ToUpper) Then
                            a_subitem = Crear_Elemento("a",, "dropdown-item active", subitem("REDIRECCION"))
                            li.Attributes.Add("class", "nav-item dropdown active")
                        Else
                            a_subitem = Crear_Elemento("a",, "dropdown-item", subitem("REDIRECCION"))
                        End If

                        a_subitem.InnerText = subitem("NOMBRE_WEB")
                        div.Controls.Add(a_subitem)
                    Next

                    li.Controls.Add(a)
                    li.Controls.Add(div)
                    ul.Controls.Add(li)
                Else
                    Dim url As String = HttpContext.Current.Request.Url.AbsoluteUri
                    Dim li As HtmlGenericControl
                    If url.ToUpper.Contains(atributos("REDIRECCION").ToString.ToUpper) Then
                        li = Crear_Elemento("li",, "nav-item active")
                    Else
                        li = Crear_Elemento("li",, "nav-item")
                    End If

                    'Dim li As HtmlGenericControl = Crear_Elemento("li",, "nav-item")
                    Dim a As HtmlGenericControl = Crear_Elemento("a",, "nav-link")
                    a.Attributes.Add("href", atributos("REDIRECCION"))
                    a.InnerText = atributos("NOMBRE_WEB")
                    li.Controls.Add(a)
                    ul.Controls.Add(li)
                End If


            Next
        Next

        navbarSupportedContent.Controls.Add(ul)

        'CAJA BUSCAR
        Dim div_buscar As HtmlGenericControl = Crear_Elemento("div",, "form-inline my-2 my-lg-0")
        Dim input_buscar As HtmlGenericControl = Crear_Elemento("input",, "form-control mr-sm-2 expanding_input")
        input_buscar.Attributes.Add("type", "search")
        input_buscar.Attributes.Add("placeholder", "Caută un articol...")
        input_buscar.Attributes.Add("aria-label", "Search")

        Dim button_buscar As HtmlGenericControl = Crear_Elemento("Button",, "btn btn-outline-light my-2 my-sm-0")
        button_buscar.Attributes.Add("type", "submit")
        Dim icono_buscar As HtmlGenericControl = Crear_Elemento("i",, "fas fa-search")
        button_buscar.Controls.Add(icono_buscar)

        div_buscar.Controls.Add(input_buscar)
        div_buscar.Controls.Add(button_buscar)
        navbarSupportedContent.Controls.Add(div_buscar)
    End Sub

    Function Crear_Elemento(ByVal tipo_control As String, Optional id As String = "", Optional clase As String = "", Optional href As String = "") As HtmlGenericControl
        Dim NewControl As New HtmlGenericControl(tipo_control)

        If id <> "" Then
            NewControl.ID = id
        End If

        If clase <> "" Then
            NewControl.Attributes.Add("class", clase)
        End If

        If href <> "" Then
            NewControl.Attributes.Add("href", href)
        End If

        Return NewControl
    End Function
End Class