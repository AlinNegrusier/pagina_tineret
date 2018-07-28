Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Acasa
    Inherits System.Web.UI.Page

    Private Sub lista_eventos_barra_Init(sender As Object, e As EventArgs) Handles lista_eventos_barra.Init

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        request = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/AlinNegrusier/pagina_tineret/master/articole.json"), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim jResults As Object = JObject.Parse(rawresp)

        ' Dim lista_articulos = From articulos In articulos_json Select articulos

        Dim lista_articulos As New List(Of articulo)

        For Each item In jResults
            For Each atributos In item
                Dim articulo As New articulo
                articulo.ID = CInt(atributos("ID"))
                articulo.TITULO = atributos("TITULO")
                articulo.DESCRIPCION = atributos("DESCRIPCION")
                articulo.CONTENIDO = atributos("CONTENIDO")
                articulo.TIPO_ARTICULO = atributos("TIPO_ARTICULO")
                articulo.FECHA = Convert.ToDateTime(atributos("FECHA"))
                lista_articulos.Add(articulo)
            Next

        Next

        Dim lista_articulos_ordenados = From articulos In lista_articulos Order By articulos.FECHA Select articulos

        Dim ol As HtmlGenericControl = Crear_Elemento("ol")
        For Each item In lista_articulos_ordenados
            Dim li As HtmlGenericControl = Crear_Elemento("li")
            Dim a As HtmlGenericControl = Crear_Elemento("a",,, "#0")
            a.Attributes.Add("data-date", item.FECHA.ToString("MM/dd/yyyy"))
            If item Is lista_articulos_ordenados.Last Then
                a.Attributes.Add("class", "selected")
            End If
            a.InnerText = Fecha_Rumano(item.FECHA.ToString("MM/dd/yyyy"))
            li.Controls.Add(a)
            ol.Controls.Add(li)
        Next

        lista_eventos_barra.Controls.Add(ol)

        Dim span As HtmlGenericControl = Crear_Elemento("span",, "filling-line")
        span.Attributes.Add("aria-hidden", "true")
        lista_eventos_barra.Controls.Add(span)

    End Sub

    Private Sub contenido_eventos_Init(sender As Object, e As EventArgs) Handles contenido_eventos.Init

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        request = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/AlinNegrusier/pagina_tineret/master/articole.json"), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim jResults As Object = JObject.Parse(rawresp)

        ' Dim lista_articulos = From articulos In articulos_json Select articulos

        Dim lista_articulos As New List(Of articulo)

        For Each item In jResults
            For Each atributos In item
                Dim articulo As New articulo
                articulo.ID = CInt(atributos("ID"))
                articulo.TITULO = atributos("TITULO")
                articulo.DESCRIPCION = atributos("DESCRIPCION")
                articulo.CONTENIDO = atributos("CONTENIDO")
                articulo.TIPO_ARTICULO = atributos("TIPO_ARTICULO")
                articulo.FECHA = Convert.ToDateTime(atributos("FECHA"))
                lista_articulos.Add(articulo)
            Next

        Next

        Dim lista_articulos_ordenados = From articulos In lista_articulos Order By articulos.FECHA Select articulos

        Dim ol As HtmlGenericControl = Crear_Elemento("ol")
        For Each item In lista_articulos_ordenados
            Dim li As HtmlGenericControl
            If item Is lista_articulos_ordenados.Last Then
                li = Crear_Elemento("li",, "selected")
            Else
                li = Crear_Elemento("li")
            End If
            li.Attributes.Add("data-date", item.FECHA.ToString("MM/dd/yyyy"))
            Dim titulo As HtmlGenericControl = Crear_Elemento("h2")
            titulo.InnerText = item.TITULO

            Dim fecha_subtitulo As HtmlGenericControl = Crear_Elemento("em")
            fecha_subtitulo.InnerText = Fecha_Rumano(item.FECHA.ToString("MM/dd/yyyy"))

            Dim descripcion As HtmlGenericControl = Crear_Elemento("p")
            descripcion.InnerHtml = item.DESCRIPCION & "<div class='row'>
            <div class='box-flex fullheight fullwidth d-table text-center'> 
                <a class='btn btn-outline-morado my-2 my-sm-0 boton_leer_mas' href='Articole.aspx?id=" & item.ID & "'>Citeşte mai mult</a>
            </div>
        </div>"

            li.Controls.Add(titulo)
            li.Controls.Add(fecha_subtitulo)
            li.Controls.Add(descripcion)
            ol.Controls.Add(li)
        Next

        contenido_eventos.Controls.Add(ol)



    End Sub

    Function Fecha_Rumano(fecha As String) As String
        Dim fecha_texto As String = ""
        Dim array_fecha = fecha.Split("/")

        Dim mes As String = ""
        Select Case array_fecha(1)
            Case "01"
                mes = "Ian."
            Case "02"
                mes = "Feb."
            Case "03"
                mes = "Mar."
            Case "04"
                mes = "Apr."
            Case "05"
                mes = "Mai"
            Case "06"
                mes = "Iun."
            Case "07"
                mes = "Iul."
            Case "08"
                mes = "Aug."
            Case "09"
                mes = "Sep."
            Case "10"
                mes = "Oct."
            Case "11"
                mes = "Noi."
            Case "12"
                mes = "Dec."
        End Select

        fecha_texto = array_fecha(0) & " " & mes & ", " & array_fecha(2)
        Return fecha_texto
    End Function
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