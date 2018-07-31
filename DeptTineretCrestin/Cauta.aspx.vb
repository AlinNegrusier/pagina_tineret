Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Cauta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Dim id_articulo As String = Request.QueryString("cautare")

        Dim solicitud As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        solicitud = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/AlinNegrusier/pagina_tineret/master/articole.json"), HttpWebRequest)

        response = DirectCast(solicitud.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim jResults As Object = JObject.Parse(rawresp)

        ' Dim lista_articulos = From articulos In articulos_json Select articulos

        Dim articulo As New articulo

        For Each item In jResults
            For Each atributos In item
                If CInt(atributos("ID")) = CInt(id_articulo) Then
                    articulo.ID = CInt(atributos("ID"))
                    articulo.TITULO = atributos("TITULO")
                    articulo.DESCRIPCION = atributos("DESCRIPCION")
                    articulo.CONTENIDO = atributos("CONTENIDO")
                    articulo.TIPO_ARTICULO = atributos("TIPO_ARTICULO")
                    articulo.FECHA = Convert.ToDateTime(atributos("FECHA").ToString)
                    articulo.FECHA_REDACCION = Convert.ToDateTime(atributos("FECHA_REDACCION").ToString)
                    articulo.AUTOR = atributos("AUTOR")
                End If
            Next
        Next

        Me.titulo_articulo.Text = articulo.TITULO


    End Sub

End Class