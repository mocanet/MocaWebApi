
Imports System.Web.Http.WebHost
Imports System.Web.Routing

Namespace Web

    ''' <summary>
    '''  要求を指定された HttpServer インスタンスに渡すことができる IRouteHandler のセッションが利用できるインスタンスを返す HttpControllerHandler。
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SessionHttpControllerRouteHandler
        Inherits HttpControllerRouteHandler

        Protected Overrides Function GetHttpHandler(requestContext As Routing.RequestContext) As IHttpHandler
            Return New SessionHttpControllerHandler(requestContext.RouteData)
        End Function

    End Class

End Namespace
