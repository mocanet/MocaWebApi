Imports System.Net
Imports System.Web.Http

Imports Moca.Di

Namespace Web

    ''' <summary>
    ''' Moca 用 API Controller の抽象クラス
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class MocaApiController
        Inherits ApiController

        ''' <summary>ページに対しての依存性注入</summary>
        Private _injector As MocaInjector

#Region " Logging For Log4net "
        ''' <summary>Logging For Log4net</summary>
        Private Shared ReadOnly _mylog As log4net.ILog = log4net.LogManager.GetLogger(String.Empty)
#End Region

#Region " コンストラクタ／デストラクタ "

        ''' <summary>
        ''' デフォルトコンストラクタ
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            MyBase.New()

            Try
                ' 属性による依存性の注入
                _injector = New MocaWebApiInjector()
                _injector.Inject(Me)
            Catch ex As Exception
                _mylog.Error(ex)
                Throw ex
            End Try
        End Sub

        ''' <summary>
        ''' デストラクタ
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overrides Sub Finalize()
            MyBase.Finalize()
            _injector.DaoDispose(Me)
        End Sub

#End Region
#Region " Methods "

        ''' <summary>
        ''' 例外スロー
        ''' </summary>
        ''' <param name="message"></param>
        ''' <remarks></remarks>
        Protected Sub throwHttpResponseException(ByVal message As String)
            Dim msg As System.Net.Http.HttpResponseMessage
            msg = New System.Net.Http.HttpResponseMessage
            msg.Content = New System.Net.Http.StringContent(message)
            Throw New HttpResponseException(msg)
        End Sub

#End Region

    End Class

End Namespace
