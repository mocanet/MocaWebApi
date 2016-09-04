
Imports Moca.Db

Namespace Db.Impl

    ''' <summary>
	''' DaoSample データアクセス
	''' </summary>
    ''' <remarks></remarks>
    Public Class DaoSample
        Inherits AbstractDao
        Implements IDaoSample

        Public Function GetValue(id As Integer) As String Implements IDaoSample.GetValue
            Return "DaoSample Function GetValue(id As Integer) As String : " & id
        End Function

    End Class

End Namespace
