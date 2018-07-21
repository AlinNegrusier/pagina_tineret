Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Private Sub contenedor_items_menu_Init(sender As Object, e As EventArgs) Handles contenedor_items_menu.Init

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        request = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/AlinNegrusier/pagina_tineret/master/menu.json"), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim jResults As Object = JObject.Parse(rawresp)
        Debug.Write(jResults("name"))
        Debug.Write(jResults("name").ToString())

        'TxtFornavn.Text = If(jResults("name") Is Nothing, "", jResults("name").ToString())
        'TxtAdresse.Text = If(jResults("address") Is Nothing, "", jResults("address").ToString())

    End Sub
End Class