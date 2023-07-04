Imports System.Data.SqlClient
Public Class clsInd_TxDITxDB
    '
    '   IdTxDITx, IdITx, IdTx, IdTipoRel, CodigoTx, IsPrimaryCategory,
    '   IdTipoRelacion, IdCreado, IdUltimoCambio, IdBorradoL
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_TxDITx
        Dim detList As New listInd_TxDITx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdTxDITx, IdITx, IdTx, IdTipoRel, CodigoTx, IsPrimaryCategory, " &
            "       IdTipoRelacion, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_TxDITx " &
            "ORDER BY IdTxDITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_TxDITx
            Do While rdr.Read
                det = New clsInd_TxDITx
                det.IdTxDITx = CInt(rdr("IdTxDITx"))
                If rdr("IdITx") Is DBNull.Value Then
                    det.IdITx = Nothing
                Else
                    det.IdITx = rdr("IdITx").ToString
                End If
                '
                If rdr("IdTx") Is DBNull.Value Then
                    det.IdTx = Nothing
                Else
                    det.IdTx = rdr("IdTx").ToString
                End If
                '
                If rdr("IdTipoRel") Is DBNull.Value Then
                    det.IdTipoRel = Nothing
                Else
                    det.IdTipoRel = rdr("IdTipoRel").ToString
                End If
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IsPrimaryCategory") Is DBNull.Value Then
                    det.IsPrimaryCategory = Nothing
                Else
                    det.IsPrimaryCategory = rdr("IsPrimaryCategory").ToString
                End If
                '
                If rdr("IdTipoRelacion") Is DBNull.Value Then
                    det.IdTipoRelacion = Nothing
                Else
                    det.IdTipoRelacion = rdr("IdTipoRelacion").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_TxDITx
        '
        Dim det As New clsInd_TxDITx
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdTxDITx, IdITx, IdTx, IdTipoRel, CodigoTx, IsPrimaryCategory, " &
            "       IdTipoRelacion, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_TxDITx " &
            "Where  IdTxDITx = @IdTxDITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTxDITx", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdTxDITx = CInt(rdr("IdTxDITx"))
                If rdr("IdITx") Is DBNull.Value Then
                    det.IdITx = Nothing
                Else
                    det.IdITx = rdr("IdITx").ToString
                End If
                '
                If rdr("IdTx") Is DBNull.Value Then
                    det.IdTx = Nothing
                Else
                    det.IdTx = rdr("IdTx").ToString
                End If
                '
                If rdr("IdTipoRel") Is DBNull.Value Then
                    det.IdTipoRel = Nothing
                Else
                    det.IdTipoRel = rdr("IdTipoRel").ToString
                End If
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IsPrimaryCategory") Is DBNull.Value Then
                    det.IsPrimaryCategory = Nothing
                Else
                    det.IsPrimaryCategory = rdr("IsPrimaryCategory").ToString
                End If
                '
                If rdr("IdTipoRelacion") Is DBNull.Value Then
                    det.IdTipoRelacion = Nothing
                Else
                    det.IdTipoRelacion = rdr("IdTipoRelacion").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_TxDITx) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_TxDITx  " &
        "       ( IdITx, IdTx, IdTipoRel, CodigoTx, IsPrimaryCategory, " &
        "           IdTipoRelacion, IdCreado, IdUltimoCambio, IdBorradoL ) " &
        "values ( @IdITx, @IdTx, @IdTipoRel, @CodigoTx, @IsPrimaryCategory, " &
        "           @IdTipoRelacion, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        If det.IdITx = Nothing Then
            cmd.Parameters.AddWithValue("@IdITx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITx", det.IdITx)
        End If
        '
        If det.IdTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx", det.IdTx)
        End If
        '
        If det.IdTipoRel = Nothing Then
            cmd.Parameters.AddWithValue("@IdTipoRel", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTipoRel", det.IdTipoRel)
        End If
        '
        If det.CodigoTx Is Nothing Then
            cmd.Parameters.AddWithValue("@CodigoTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodigoTx", det.CodigoTx)
        End If
        '
        If det.IsPrimaryCategory = Nothing Then
            cmd.Parameters.AddWithValue("@IsPrimaryCategory", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IsPrimaryCategory", det.IsPrimaryCategory)
        End If
        '
        If det.IdTipoRelacion = Nothing Then
            cmd.Parameters.AddWithValue("@IdTipoRelacion", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTipoRelacion", det.IdTipoRelacion)
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
                "SELECT IDENT_CURRENT('Ind_TxDITx') FROM Ind_TxDITx"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_TxDITx) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_TxDITx " &
            "SET " &
            "       IdITx               = @IdITx, " &
            "       IdTx                = @IdTx, " &
            "       IdTipoRel           = @IdTipoRel, " &
            "       CodigoTx            = @CodigoTx, " &
            "       IsPrimaryCategory   = @IsPrimaryCategory, " &
            "       IdTipoRelacion      = @IdTipoRelacion, " &
            "       IdCreado            = @IdCreado, " &
            "       IdUltimoCambio      = @IdUltimoCambio, " &
            "       IdBorradoL          = @IdBorradoL " &
            "WHERE  IdTxDITx            = @IdTxDITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdITx = Nothing Then
            cmd.Parameters.AddWithValue("@IdITx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITx", det.IdITx)
        End If
        '
        If det.IdTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx", det.IdTx)
        End If
        '
        If det.IdTipoRel = Nothing Then
            cmd.Parameters.AddWithValue("@IdTipoRel", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTipoRel", det.IdTipoRel)
        End If
        '
        If det.CodigoTx Is Nothing Then
            cmd.Parameters.AddWithValue("@CodigoTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodigoTx", det.CodigoTx)
        End If
        '
        If det.IsPrimaryCategory = Nothing Then
            cmd.Parameters.AddWithValue("@IsPrimaryCategory", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IsPrimaryCategory", det.IsPrimaryCategory)
        End If
        '
        If det.IdTipoRelacion = Nothing Then
            cmd.Parameters.AddWithValue("@IdTipoRelacion", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTipoRelacion", det.IdTipoRelacion)
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
        cmd.Parameters.AddWithValue("@IdTxDITx", det.IdTxDITx)
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
