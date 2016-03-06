
Imports System.Reflection
Imports System.Web.Http

Namespace Web

    ''' <summary>
    ''' Http時のインタセプターで使用するWebServiceコンテンツ
    ''' </summary>
    ''' <remarks></remarks>
    Public Class HttpContentsWebApi
        Inherits MarshalByRefObject
        Implements IHttpContents

        Private _target As ApiController

        Private _queryStringMap As Hashtable

#Region " コンストラクタ "

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="target">ApiController</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal target As ApiController)
            _target = target
            _queryStringMap = New Hashtable
        End Sub

#End Region

#Region " Implements "

        Public ReadOnly Property Application As HttpApplicationState Implements IHttpContents.Application
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property QueryStringMap As Hashtable Implements IHttpContents.QueryStringMap
            Get
                Return _queryStringMap
            End Get
        End Property

        Public ReadOnly Property Request As HttpRequest Implements IHttpContents.Request
            Get
                Return HttpContext.Current.Request
            End Get
        End Property

        Public ReadOnly Property Response As HttpResponse Implements IHttpContents.Response
            Get
                Return HttpContext.Current.Response
            End Get
        End Property

        Public ReadOnly Property Session As HttpSessionState Implements IHttpContents.Session
            Get
                Return HttpContext.Current.Session
            End Get
        End Property

        Public ReadOnly Property Target As Object Implements IHttpContents.Target
            Get
                Return _target
            End Get
        End Property

#End Region

    End Class

End Namespace
