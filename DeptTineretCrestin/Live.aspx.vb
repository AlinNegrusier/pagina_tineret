Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Live
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Dim id_articulo As String = Request.QueryString("cautare")

        Dim solicitud As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        solicitud = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/AlinNegrusier/pagina_tineret/master/live.json"), HttpWebRequest)

        response = DirectCast(solicitud.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim jResults As Object = JObject.Parse(rawresp)

        ' Dim lista_articulos = From articulos In articulos_json Select articulos

        Dim URL As String = ""
        Dim fecha As String = ""

        For Each item In jResults
            For Each atributos In item

                fecha = atributos("FECHA")
                URL = atributos("URL")

            Next
        Next

        If fecha <> "" Then
            runJQueryCode("InicializaContador('" & fecha & "');")
            panel_video.Text = "<div class='video_responsive'><iframe src='" & URL & "' width='560' height='314' allowfullscreen='allowfullscreen'></iframe></div>"
        Else
            panel_subtitlu.Visible = False
            panel_video.Text = "<h3 class='titlu'>Ne cerem scuze dar înca nu a fost stabilită data următoarei tranmisii!</h3>"
        End If

    End Sub

    Public Function runJQueryCode(ByVal message As String) As Boolean
        Dim requestSM As ScriptManager = ScriptManager.GetCurrent(Page)
        If requestSM IsNot Nothing AndAlso requestSM.IsInAsyncPostBack Then
            ScriptManager.RegisterClientScriptBlock(Page, GetType(Page), Guid.NewGuid().ToString(), getjQueryCode(message), True)
        Else
            Page.ClientScript.RegisterClientScriptBlock(GetType(Page), Guid.NewGuid().ToString(), getjQueryCode(message), True)
        End If

        Return True
    End Function

    Private Function getjQueryCode(ByVal jsCodetoRun As String) As String
        Dim sb As New StringBuilder()
        sb.AppendLine("$(document).ready(function() {")
        sb.AppendLine(jsCodetoRun)
        sb.AppendLine(" });")

        Return sb.ToString()
    End Function
End Class