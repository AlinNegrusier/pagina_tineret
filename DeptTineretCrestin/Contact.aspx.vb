Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Contact
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim todos_los_contactos As String = ""

        Dim un_contacto As String = " <div class='col-xs-12 col-sm-6 col-md-4'>
                <div class='image-flip' >
                    <div class='mainflip flip-0'>
                        <div class='frontside'>
                            <div class='card'>
                                <div class='card-body text-center'>
                                    <p><img class=' img-fluid' src='[FOTO]' alt='card image'></p>
                                    <h4 class='card-title'>[NOMBRE]</h4>
                                    <p class='card-text text-left'><strong>Telefon: </strong> [TELEFONO] <br />
                                        <strong>Email: </strong> [EMAIL]
                                    </p>
                                    
                                    <a href='#' class='btn btn-outline-morado btn-sm'><i class='fa fa-plus'></i></a>
                                </div>
                            </div>
                        </div>
                        <div class='backside'>
                            <div class='card'>
                                <div class='card-body text-center mt-4'>
                                    <h4 class='card-title'>[NOMBRE]</h4>
                                    <p class='card-text'>[DESCRIPCION]</p>
                                    [ELEMENTOS_FACEBOOK]
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>"

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        request = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/AlinNegrusier/pagina_tineret/master/contact.json"), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())

        Dim rawresp As String
        rawresp = reader.ReadToEnd()

        Dim jResults As Object = JObject.Parse(rawresp)

        Dim lista_contactos As New List(Of contacto)

        For Each item In jResults
            For Each atributos In item
                Dim contacto As New contacto
                contacto.ID = CInt(atributos("ID"))
                contacto.NOMBRE = atributos("NOMBRE")
                contacto.FOTO = atributos("FOTO")
                contacto.DESCRIPCION = atributos("DESCRIPCION")
                contacto.EMAIL = atributos("EMAIL")
                contacto.TELEFONO = atributos("TELEFONO")
                contacto.FACEBOOK = atributos("FACEBOOK")
                contacto.ORDEN = CInt(atributos("ORDEN"))
                lista_contactos.Add(contacto)
            Next

        Next

        Dim lista_contactos_ordenados = From contacto In lista_contactos Order By contacto.ORDEN Select contacto

        For Each contacto In lista_contactos_ordenados
            todos_los_contactos = todos_los_contactos & un_contacto.Replace("[NOMBRE]", contacto.NOMBRE).Replace("[FOTO]", contacto.FOTO).Replace("[EMAIL]", contacto.EMAIL).Replace("[TELEFONO]", contacto.TELEFONO).Replace("[DESCRIPCION]", contacto.DESCRIPCION)
            If Not contacto.FACEBOOK Is Nothing Then
                todos_los_contactos = todos_los_contactos.Replace("[ELEMENTOS_FACEBOOK]", "<ul class='list-inline'>
                                        <li class='list-inline-item'>
                                            <a class='social-icon text-xs-center' target='_blank' href='" & contacto.FACEBOOK & "'>
                                                <i class='fab fa-facebook-f'></i>
                                            </a>
                                        </li>
                                    </ul>")
            Else
                todos_los_contactos = todos_los_contactos.Replace("[ELEMENTOS_FACEBOOK]", "")
            End If

        Next

        Me.contactos.Text = todos_los_contactos

    End Sub
End Class