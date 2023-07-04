Imports System.Data.SqlClient
Public Class clsInd_RelVITxDB
    '   IdRelVITx, IdITx1, IdITx2, IdRelVTx, IdCreado, IdUltimoCambio, IdBorradoL
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_RelVITx
        Dim detList As New listInd_RelVITx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdRelVITx, IdITx1, IdITx2, IdRelVTx, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_RelVITx " &
            "ORDER BY IdRelVITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_RelVITx
            Do While rdr.Read
                det = New clsInd_RelVITx
                det.IdRelVITx = CInt(rdr("IdRelVITx"))
                If rdr("IdITx1") Is DBNull.Value Then
                    det.IdITx1 = Nothing
                Else
                    det.IdITx1 = rdr("IdITx1").ToString
                End If
                '
                If rdr("IdITx2") Is DBNull.Value Then
                    det.IdITx2 = Nothing
                Else
                    det.IdITx2 = rdr("IdITx2").ToString
                End If
                '
                If rdr("IdRelVTx") Is DBNull.Value Then
                    det.IdRelVTx = Nothing
                Else
                    det.IdRelVTx = rdr("IdRelVTx").ToString
                End If
                '
                If rdr("IdCreado") Is DBNull.Value Then
                    det.IdCreado = Nothing
                Else
                    det.IdCreado = rdr("IdCreado").ToString
                End If
                '
                If rdr("IdUltimoCambio") Is DBNull.Value Then
                    det.IdUltimoCambio = Nothing
                Else
                    det.IdUltimoCambio = rdr("IdUltimoCambio").ToString
                End If
                '
                If rdr("IdBorradoL") Is DBNull.Value Then
                    det.IdBorradoL = Nothing
                Else
                    det.IdBorradoL = rdr("IdBorradoL").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_RelVITx
        '
        Dim det As New clsInd_RelVITx
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
             "SELECT IdRelVITx, IdITx1, IdITx2, IdRelVTx, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_RelVITx " &
            "Where  IdRelVITx = @IdRelVITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdRelVITx", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdRelVITx = CInt(rdr("IdRelVITx"))
                If rdr("IdITx1") Is DBNull.Value Then
                    det.IdITx1 = Nothing
                Else
                    det.IdITx1 = rdr("IdITx1").ToString
                End If
                '
                If rdr("IdITx2") Is DBNull.Value Then
                    det.IdITx2 = Nothing
                Else
                    det.IdITx2 = rdr("IdITx2").ToString
                End If
                '
                If rdr("IdRelVTx") Is DBNull.Value Then
                    det.IdRelVTx = Nothing
                Else
                    det.IdRelVTx = rdr("IdRelVTx").ToString
                End If
                '
                If rdr("IdCreado") Is DBNull.Value Then
                    det.IdCreado = Nothing
                Else
                    det.IdCreado = rdr("IdCreado").ToString
                End If
                '
                If rdr("IdUltimoCambio") Is DBNull.Value Then
                    det.IdUltimoCambio = Nothing
                Else
                    det.IdUltimoCambio = rdr("IdUltimoCambio").ToString
                End If
                '
                If rdr("IdBorradoL") Is DBNull.Value Then
                    det.IdBorradoL = Nothing
                Else
                    det.IdBorradoL = rdr("IdBorradoL").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_RelVITx) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_RelVITx  " &
        "       ( IdITx1, IdITx2, IdRelVTx, IdCreado, IdUltimoCambio, IdBorradoL " &
        "values ( @IdITx1, @IdITx2, @IdRelVTx, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        If det.IdITx1 = Nothing Then
            cmd.Parameters.AddWithValue("@IdITx1", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITx1", det.IdITx1)
        End If
        '
        If det.IdITx2 = Nothing Then
            cmd.Parameters.AddWithValue("@IdITx2", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITx2", det.IdITx2)
        End If
        '
        If det.IdRelVTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdRelVTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdRelVTx", det.IdRelVTx)
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
                "SELECT IDENT_CURRENT('Ind_RelVITx') FROM Ind_RelVITx"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_RelVITx) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_RelVITx " &
            "SET " &
            "       IdITx1         = @IdITx1, " &
            "       IdITx2         = @IdITx2, " &
            "       IdRelVTx       = @IdRelVTx, " &
            "       IdCreado       = @IdCreado, " &
            "       IdUltimoCambio = @IdUltimoCambio, " &
            "       IdBorradoL     = @IdBorradoL " &
            "WHERE  IdRelVITx      = @IdRelVITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdITx1 = Nothing Then
            cmd.Parameters.AddWithValue("@IdITx1", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITx1", det.IdITx1)
        End If
        '
        If det.IdITx2 = Nothing Then
            cmd.Parameters.AddWithValue("@IdITx2", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITx2", det.IdITx2)
        End If
        '
        If det.IdRelVTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdRelVTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdRelVTx", det.IdRelVTx)
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
        cmd.Parameters.AddWithValue("@IdRelVITx", det.IdRelVITx)
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
