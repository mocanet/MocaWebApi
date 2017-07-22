
Imports System.Web.Routing
Imports System.Web.Http

Imports Microsoft.AspNet.FriendlyUrls

Public Module RouteConfig

    Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.EnableFriendlyUrls()
        '' Web API 用
        'routes.MapHttpRoute(name:="DefaultApi",
        '                    routeTemplate:="api/{controller}/{id}",
        '                    defaults:=New With {.id = System.Web.Http.RouteParameter.Optional})
        ' Web API 用(セッション利用)
        routes.MapHttpRoute(name:="DefaultApi",
                            routeTemplate:="api/{controller}/{id}",
                            defaults:=New With {.id = RouteParameter.Optional}
                            ).RouteHandler = New Moca.Web.SessionHttpControllerRouteHandler
    End Sub

End Module
