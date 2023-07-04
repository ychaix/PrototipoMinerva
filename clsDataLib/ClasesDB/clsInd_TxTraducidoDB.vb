Imports System.Data.SqlClient
Public Class clsInd_TxTraducidoDB
    '
    '   IdTxTraducido, IdTx, IdIdioma, DescripciónParaFormulario, DescCortaTxTraducida, 
    '   DescrDetTxTraducida, Aclaraciones, IdCreado, IdUltimoCambio, IdBorradoL
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_TxTraducido
        Dim detList As New listInd_TxTraducido
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdTxTraducido, IdTx, IdIdioma, DescripciónParaFormulario, DescCortaTxTraducida, " &
            "       DescrDetTxTraducida, Aclaraciones, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_TxTraducido " &
            "ORDER BY IdTxTraducido "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_TxTraducido
            Do While rdr.Read
                det = New clsInd_TxTraducido
                det.IdTxTraducido = CInt(rdr("IdTxTraducido"))
                If rdr("IdTx") Is DBNull.Value Then
                    det.IdTx = Nothing
                Else
                    det.IdTx = rdr("IdTx").ToString
                End If
                '
                If rdr("IdIdioma") Is DBNull.Value Then
                    det.IdIdioma = Nothing
                Else
                    det.IdIdioma = rdr("IdIdioma").ToString
                End If
                '
                If rdr("DescripciónParaFormulario") Is DBNull.Value Then
                    det.DescripciónParaFormulario = Nothing
                Else
                    det.DescripciónParaFormulario = rdr("DescripciónParaFormulario").ToString
                End If
                '
                If rdr("DescCortaTxTraducida") Is DBNull.Value Then
                    det.DescCortaTxTraducida = Nothing
                Else
                    det.DescCortaTxTraducida = rdr("DescCortaTxTraducida").ToString
                End If
                '
                If rdr("DescrDetTxTraducida") Is DBNull.Value Then
                    det.DescrDetTxTraducida = Nothing
                Else
                    det.DescrDetTxTraducida = rdr("DescrDetTxTraducida").ToString
                End If
                '
                If rdr("Aclaraciones") Is DBNull.Value Then
                    det.Aclaraciones = Nothing
                Else
                    det.Aclaraciones = rdr("Aclaraciones").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_TxTraducido
        '
        Dim det As New clsInd_TxTraducido
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdTxTraducido, IdTx, IdIdioma, DescripciónParaFormulario, DescCortaTxTraducida, " &
            "       DescrDetTxTraducida, Aclaraciones, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_TxTraducido " &
            "Where  IdTxTraducido = @IdTxTraducido "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTxTraducido", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdTxTraducido = CInt(rdr("IdTxTraducido"))
                If rdr("IdTx") Is DBNull.Value Then
                    det.IdTx = Nothing
                Else
                    det.IdTx = rdr("IdTx").ToString
                End If
                '
                If rdr("IdIdioma") Is DBNull.Value Then
                    det.IdIdioma = Nothing
                Else
                    det.IdIdioma = rdr("IdIdioma").ToString
                End If
                '
                If rdr("DescripciónParaFormulario") Is DBNull.Value Then
                    det.DescripciónParaFormulario = Nothing
                Else
                    det.DescripciónParaFormulario = rdr("DescripciónParaFormulario").ToString
                End If
                '
                If rdr("DescCortaTxTraducida") Is DBNull.Value Then
                    det.DescCortaTxTraducida = Nothing
                Else
                    det.DescCortaTxTraducida = rdr("DescCortaTxTraducida").ToString
                End If
                '
                If rdr("DescrDetTxTraducida") Is DBNull.Value Then
                    det.DescrDetTxTraducida = Nothing
                Else
                    det.DescrDetTxTraducida = rdr("DescrDetTxTraducida").ToString
                End If
                '
                If rdr("Aclaraciones") Is DBNull.Value Then
                    det.Aclaraciones = Nothing
                Else
                    det.Aclaraciones = rdr("Aclaraciones").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_TxTraducido) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_TxTraducido  " &
        "       ( IdTx, IdIdioma, DescripciónParaFormulario, DescCortaTxTraducida, " &
        "           DescrDetTxTraducida, Aclaraciones, IdCreado, IdUltimoCambio, IdBorradoL ) " &
        "values ( @IdTx, @IdIdioma, @DescripciónParaFormulario, @DescCortaTxTraducida, " &
        "           @DescrDetTxTraducida, @Aclaraciones, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '        
        If det.IdTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx", det.IdTx)
        End If
        '
        If det.IdIdioma = Nothing Then
            cmd.Parameters.AddWithValue("@IdIdioma", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdIdioma", det.IdIdioma)
        End If
        '
        If det.DescripciónParaFormulario Is Nothing Then
            cmd.Parameters.AddWithValue("@DescripciónParaFormulario", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescripciónParaFormulario", det.DescripciónParaFormulario)
        End If
        '
        If det.DescCortaTxTraducida Is Nothing Then
            cmd.Parameters.AddWithValue("@DescCortaTxTraducida", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescCortaTxTraducida", det.DescCortaTxTraducida)
        End If
        '
        If det.DescrDetTxTraducida Is Nothing Then
            cmd.Parameters.AddWithValue("@DescrDetTxTraducida", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescrDetTxTraducida", det.DescrDetTxTraducida)
        End If
        '
        If det.Aclaraciones Is Nothing Then
            cmd.Parameters.AddWithValue("@Aclaraciones", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Aclaraciones", det.Aclaraciones)
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
                "SELECT IDENT_CURRENT('Ind_TxTraducido') FROM Ind_TxTraducido"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_TxTraducido) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_TxTraducido " &
            "SET " &
            "       IdTx                        = @IdTx, " &
            "       IdIdioma                    = @IdIdioma, " &
            "       DescripciónParaFormulario   = @DescripciónParaFormulario, " &
            "       DescCortaTxTraducida        = @DescCortaTxTraducida, " &
            "       DescrDetTxTraducida         = @DescrDetTxTraducida, " &
            "       Aclaraciones                = @Aclaraciones, " &
            "       IdCreado                    = @IdCreado, " &
            "       IdUltimoCambio              = @IdUltimoCambio, " &
            "       IdBorradoL                  = @IdBorradoL " &
            "WHERE  IdTxTraducido               = @IdTxTraducido "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx", det.IdTx)
        End If
        '
        If det.IdIdioma = Nothing Then
            cmd.Parameters.AddWithValue("@IdIdioma", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdIdioma", det.IdIdioma)
        End If
        '
        If det.DescripciónParaFormulario Is Nothing Then
            cmd.Parameters.AddWithValue("@DescripciónParaFormulario", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescripciónParaFormulario", det.DescripciónParaFormulario)
        End If
        '
        If det.DescCortaTxTraducida Is Nothing Then
            cmd.Parameters.AddWithValue("@DescCortaTxTraducida", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescCortaTxTraducida", det.DescCortaTxTraducida)
        End If
        '
        If det.DescrDetTxTraducida Is Nothing Then
            cmd.Parameters.AddWithValue("@DescrDetTxTraducida", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescrDetTxTraducida", det.DescrDetTxTraducida)
        End If
        '
        If det.Aclaraciones Is Nothing Then
            cmd.Parameters.AddWithValue("@Aclaraciones", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Aclaraciones", det.Aclaraciones)
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
        cmd.Parameters.AddWithValue("@IdTxTraducido", det.IdTxTraducido)
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
