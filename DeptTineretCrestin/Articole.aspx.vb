﻿Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Articole
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Dim id_articulo As String = request.QueryString("id")

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
                    articulo.FECHA = Convert.ToDateTime(atributos("FECHA"))
                    articulo.FECHA_REDACCION = Convert.ToDateTime(atributos("FECHA_REDACCION"))
                    articulo.AUTOR = atributos("AUTOR")
                End If
            Next
        Next

        Me.titulo_articulo.Text = articulo.TITULO
        Me.Autor.Text = articulo.AUTOR
        Me.Data_Redactarii.Text = articulo.FECHA_REDACCION
        Me.continut_articol.Text = articulo.CONTENIDO


    End Sub

End Class