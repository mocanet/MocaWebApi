Imports System.Net
Imports System.Web.Http

Imports Moca.Web
Imports Moca.Web.Attr

Public Class ValuesController
    Inherits MocaApiController

    ''' <summary>Session Access</summary>
    Protected sessionState As Web.ISession

    ''' <summary>Cookie Request Access</summary>
    <Cookie(CookieType.Request)>
    Protected cookieReq As ICookie
    ''' <summary>Cookie Response Access</summary>
    <Cookie(CookieType.Response)>
    Protected cookieRes As ICookie

    ''' <summary>Database Access</summary>
    Protected dao As Db.IDaoSample

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As String
        Debug.Print(sessionState.Name)
        If cookieReq.Company IsNot Nothing Then
            Debug.Print(cookieReq.Company.Value)
        End If
        Dim value As String
        value = dao.GetValue(id)
        sessionState.Name = value
        cookieRes.Company.Value = "Company" & id
        Return value
    End Function

    ' POST api/<controller>
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
