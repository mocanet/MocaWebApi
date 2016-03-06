
Imports System.Web.Http.WebHost
Imports System.Web.Routing

Namespace Web

    ''' <summary>
    ''' セッション利用できる HttpControllerHandler
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SessionHttpControllerHandler
        Inherits HttpControllerHandler
        Implements IRequiresSessionState

        Public Sub New(ByVal routeData As RouteData)
            MyBase.New(routeData)
        End Sub

    End Class

End Namespace

