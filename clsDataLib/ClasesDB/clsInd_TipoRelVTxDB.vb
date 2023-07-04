Imports System.Data.SqlClient
Public Class clsInd_TipoRelVTxDB
    '   IdTipoRelVTx, IdTiposRelPadre, IdTx1, IdTx1, IdTx2, IdCreado, IdUltimoCambio, IdBorradoL
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_TipoRelVTx
        Dim detList As New listInd_TipoRelVTx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdTipoRelVTx, IdTiposRelPadre, IdTx1, IdTx1, IdTx2, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_TipoRelVTx " &
            "ORDER BY IdTipoRelVTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_TipoRelVTx
            Do While rdr.Read
                det = New clsInd_TipoRelVTx
                cmd.Parameters.AddWithValue("@IdTipoRelVTx", det.IdTipoRelVTx)
                If det.IdTiposRelPadre = Nothing Then
                    cmd.Parameters.AddWithValue("@IdTiposRelPadre", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdTiposRelPadre", det.IdTiposRelPadre)
                End If
                '
                If det.IdTx1 = Nothing Then
                    cmd.Parameters.AddWithValue("@IdTx1", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdTx1", det.IdTx1)
                End If
                '
                If det.IdTx1 = Nothing Then
                    cmd.Parameters.AddWithValue("@IdTx1", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdTx1", det.IdTx1)
                End If
                '
                If det.IdTx2 = Nothing Then
                    cmd.Parameters.AddWithValue("@IdTx2", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdTx2", det.IdTx2)
                End If
                '
                If det.IdCreado = Nothing Then
                    cmd.Parameters.AddWithValue("@IdCreado", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdCreado", det.IdCreado)
                End If
                '
                If det.IdUltimoCambio = Nothing Then
                    cmd.Parameters.AddWithValue("@IdUltimoCambio", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdUltimoCambio", det.IdUltimoCambio)
                End If
                '
                If det.IdBorradoL = Nothing Then
                    cmd.Parameters.AddWithValue("@IdBorradoL", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdBorradoL", det.IdBorradoL)
                End If
                '
                detList.Add(det)
            Loop
            rdr.Close()
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        Return detList
        '
    End Function
    '
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_TipoRelVTx
        '
        Dim det As New clsInd_TipoRelVTx
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdTipoRelVTx, IdTiposRelPadre, IdTx1, IdTx1, IdTx2, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_TipoRelVTx " &
            "Where  IdTipoRelVTx = @IdTipoRelVTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTipoRelVTx", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdTipoRelVTx = CInt(rdr("IdTipoRelVTx"))
                If det.IdTiposRelPadre = Nothing Then
                    cmd.Parameters.AddWithValue("@IdTiposRelPadre", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdTiposRelPadre", det.IdTiposRelPadre)
                End If
                '
                If det.IdTx1 = Nothing Then
                    cmd.Parameters.AddWithValue("@IdTx1", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdTx1", det.IdTx1)
                End If
                '
                If det.IdTx1 = Nothing Then
                    cmd.Parameters.AddWithValue("@IdTx1", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdTx1", det.IdTx1)
                End If
                '
                If det.IdTx2 = Nothing Then
                    cmd.Parameters.AddWithValue("@IdTx2", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdTx2", det.IdTx2)
                End If
                '
                If det.IdCreado = Nothing Then
                    cmd.Parameters.AddWithValue("@IdCreado", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdCreado", det.IdCreado)
                End If
                '
                If det.IdUltimoCambio = Nothing Then
                    cmd.Parameters.AddWithValue("@IdUltimoCambio", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdUltimoCambio", det.IdUltimoCambio)
                End If
                '
                If det.IdBorradoL = Nothing Then
                    cmd.Parameters.AddWithValue("@IdBorradoL", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@IdBorradoL", det.IdBorradoL)
                End If
                '             
            Else
                det = Nothing
            End If
            rdr.Close()
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        Return det
        '
    End Function
    '
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_TipoRelVTx) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_TipoRelVTx  " &
        "       ( IdTiposRelPadre, IdTx1, IdTx1, IdTx2, IdCreado, IdUltimoCambio, IdBorradoL " &
        "values ( @IdTiposRelPadre, @IdTx1, @IdTx1, @IdTx2, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        If det.IdTiposRelPadre = Nothing Then
            cmd.Parameters.AddWithValue("@IdTiposRelPadre", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTiposRelPadre", det.IdTiposRelPadre)
        End If
        '
        If det.IdTx1 = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx1", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx1", det.IdTx1)
        End If
        '
        If det.IdTx1 = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx1", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx1", det.IdTx1)
        End If
        '
        If det.IdTx2 = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx2", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx2", det.IdTx2)
        End If
        '
        If det.IdCreado = Nothing Then
            cmd.Parameters.AddWithValue("@IdCreado", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdCreado", det.IdCreado)
        End If
        '
        If det.IdUltimoCambio = Nothing Then
            cmd.Parameters.AddWithValue("@IdUltimoCambio", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdUltimoCambio", det.IdUltimoCambio)
        End If
        '
        If det.IdBorradoL = Nothing Then
            cmd.Parameters.AddWithValue("@IdBorradoL", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdBorradoL", det.IdBorradoL)
        End If
        '
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Dim strPKEY As String =
                "SELECT IDENT_CURRENT('Ind_TipoRelVTx') FROM Ind_TipoRelVTx"
            Dim cmdPKEY As New SqlCommand(strPKEY, cnn)
            Dim id As Integer = CInt(cmdPKEY.ExecuteScalar)
            Return id
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Function
    '
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_TipoRelVTx) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_TipoRelVTx " &
            "SET " &
            "       IdTiposRelPadre         = @IdTiposRelPadre, " &
            "       IdTx1                   = @IdTx1, " &
            "       IdTx1                   = @IdTx1, " &
            "       IdTx2                   = @IdTx2, " &
            "       IdCreado                = @IdCreado, " &
            "       IdUltimoCambio          = @IdUltimoCambio, " &
            "       IdBorradoL              = @IdBorradoL " &
            "WHERE  IdTipoRelVTx            = @IdTipoRelVTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdTiposRelPadre = Nothing Then
            cmd.Parameters.AddWithValue("@IdTiposRelPadre", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTiposRelPadre", det.IdTiposRelPadre)
        End If
        '
        If det.IdTx1 = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx1", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx1", det.IdTx1)
        End If
        '
        If det.IdTx1 = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx1", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx1", det.IdTx1)
        End If
        '
        If det.IdTx2 = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx2", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx2", det.IdTx2)
        End If
        '
        If det.IdCreado = Nothing Then
            cmd.Parameters.AddWithValue("@IdCreado", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdCreado", det.IdCreado)
        End If
        '
        If det.IdUltimoCambio = Nothing Then
            cmd.Parameters.AddWithValue("@IdUltimoCambio", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdUltimoCambio", det.IdUltimoCambio)
        End If
        '
        If det.IdBorradoL = Nothing Then
            cmd.Parameters.AddWithValue("@IdBorradoL", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdBorradoL", det.IdBorradoL)
        End If
        cmd.Parameters.AddWithValue("@IdTipoRelVTx", det.IdTipoRelVTx)
        '
        Try
            cnn.Open()
            Dim count As Integer = cmd.ExecuteNonQuery()
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Function
    '
End Class
