Imports System.Data.SqlClient
Public Class clsInd_MetaDatoTraducidoDAtrTxDB
    '   IdMetaDatoAtrTxTrad, IdAtrTx, IdIdioma, NombreAtri, DescriptionDetalle, EncabezadoColumna, 
    '   ValorPorOmision, Prompt, MensajeError, Ayuda, IdCreado, IdUltimoCambio, IdBorradoL
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_MetaDatoTraducidoDAtrTx
        Dim detList As New listInd_MetaDatoTraducidoDAtrTx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdMetaDatoAtrTxTrad, IdAtrTx, IdIdioma, NombreAtri, DescriptionDetalle, EncabezadoColumna, " &
            "       ValorPorOmision, Prompt, MensajeError, Ayuda, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_MetaDatoTraducidoDAtrTx " &
            "ORDER BY IdMetaDatoAtrTxTrad "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_MetaDatoTraducidoDAtrTx
            Do While rdr.Read
                det = New clsInd_MetaDatoTraducidoDAtrTx
                det.IdMetaDatoAtrTxTrad = CInt(rdr("IdMetaDatoAtrTxTrad"))
                If rdr("IdAtrTx") Is DBNull.Value Then
                    det.IdAtrTx = Nothing
                Else
                    det.IdAtrTx = rdr("IdAtrTx").ToString
                End If
                '
                If rdr("IdIdioma") Is DBNull.Value Then
                    det.IdIdioma = Nothing
                Else
                    det.IdIdioma = rdr("IdIdioma").ToString
                End If
                '
                If rdr("NombreAtri") Is DBNull.Value Then
                    det.NombreAtri = Nothing
                Else
                    det.NombreAtri = rdr("NombreAtri").ToString
                End If
                '
                If rdr("DescriptionDetalle") Is DBNull.Value Then
                    det.DescriptionDetalle = Nothing
                Else
                    det.DescriptionDetalle = rdr("DescriptionDetalle").ToString
                End If
                '
                If rdr("EncabezadoColumna") Is DBNull.Value Then
                    det.EncabezadoColumna = Nothing
                Else
                    det.EncabezadoColumna = rdr("EncabezadoColumna").ToString
                End If
                '
                If rdr("ValorPorOmision") Is DBNull.Value Then
                    det.ValorPorOmision = Nothing
                Else
                    det.ValorPorOmision = rdr("ValorPorOmision").ToString
                End If
                '
                If rdr("Prompt") Is DBNull.Value Then
                    det.Prompt = Nothing
                Else
                    det.Prompt = rdr("Prompt").ToString
                End If
                '
                If rdr("MensajeError") Is DBNull.Value Then
                    det.MensajeError = Nothing
                Else
                    det.MensajeError = rdr("MensajeError").ToString
                End If
                '
                If rdr("Ayuda") Is DBNull.Value Then
                    det.Ayuda = Nothing
                Else
                    det.Ayuda = rdr("Ayuda").ToString
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
    Public Shared Function lista_Cbo(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As List(Of clsInd_MetaDatoTraducidoDAtrTx)
        Dim detList As New List(Of clsInd_MetaDatoTraducidoDAtrTx)
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdMetaDatoAtrTxTrad, NombreAtri " &
            "FROM   Ind_MetaDatoTraducidoDAtrTx " &
            "ORDER BY NombreAtri "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_MetaDatoTraducidoDAtrTx
            Do While rdr.Read
                det = New clsInd_MetaDatoTraducidoDAtrTx
                det.IdMetaDatoAtrTxTrad = CInt(rdr("IdMetaDatoAtrTxTrad"))
                det.NombreAtri = rdr("NombreAtri").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_MetaDatoTraducidoDAtrTx
        '
        Dim det As New clsInd_MetaDatoTraducidoDAtrTx
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdMetaDatoAtrTxTrad, IdAtrTx, IdIdioma, NombreAtri, DescriptionDetalle, EncabezadoColumna,  " &
            "       ValorPorOmision, Prompt, MensajeError, Ayuda, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_MetaDatoTraducidoDAtrTx " &
            "Where  IdMetaDatoAtrTxTrad = @IdMetaDatoAtrTxTrad "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdMetaDatoAtrTxTrad", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdMetaDatoAtrTxTrad = CInt(rdr("IdMetaDatoAtrTxTrad"))
                If rdr("IdAtrTx") Is DBNull.Value Then
                    det.IdAtrTx = Nothing
                Else
                    det.IdAtrTx = rdr("IdAtrTx").ToString
                End If
                '
                If rdr("IdIdioma") Is DBNull.Value Then
                    det.IdIdioma = Nothing
                Else
                    det.IdIdioma = rdr("IdIdioma").ToString
                End If
                '
                If rdr("NombreAtri") Is DBNull.Value Then
                    det.NombreAtri = Nothing
                Else
                    det.NombreAtri = rdr("NombreAtri").ToString
                End If
                '
                If rdr("DescriptionDetalle") Is DBNull.Value Then
                    det.DescriptionDetalle = Nothing
                Else
                    det.DescriptionDetalle = rdr("DescriptionDetalle").ToString
                End If
                '
                If rdr("EncabezadoColumna") Is DBNull.Value Then
                    det.EncabezadoColumna = Nothing
                Else
                    det.EncabezadoColumna = rdr("EncabezadoColumna").ToString
                End If
                '
                If rdr("ValorPorOmision") Is DBNull.Value Then
                    det.ValorPorOmision = Nothing
                Else
                    det.ValorPorOmision = rdr("ValorPorOmision").ToString
                End If
                '
                If rdr("Prompt") Is DBNull.Value Then
                    det.Prompt = Nothing
                Else
                    det.Prompt = rdr("Prompt").ToString
                End If
                '
                If rdr("MensajeError") Is DBNull.Value Then
                    det.MensajeError = Nothing
                Else
                    det.MensajeError = rdr("MensajeError").ToString
                End If
                '
                If rdr("Ayuda") Is DBNull.Value Then
                    det.Ayuda = Nothing
                Else
                    det.Ayuda = rdr("Ayuda").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_MetaDatoTraducidoDAtrTx) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_MetaDatoTraducidoDAtrTx  " &
        "       ( IdAtrTx, IdIdioma, NombreAtri, DescriptionDetalle, EncabezadoColumna, " &
        "           ValorPorOmision, Prompt, MensajeError, Ayuda, IdCreado, IdUltimoCambio, IdBorradoL ) " &
        "values ( @IdAtrTx, @IdIdioma, @NombreAtri, @DescriptionDetalle, @EncabezadoColumna, " &
        "           @ValorPorOmision, @Prompt, @MensajeError, @Ayuda, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdAtrTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdAtrTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdAtrTx", det.IdAtrTx)
        End If
        '
        If det.IdIdioma = Nothing Then
            cmd.Parameters.AddWithValue("@IdIdioma", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdIdioma", det.IdIdioma)
        End If
        '
        If det.NombreAtri Is Nothing Then
            cmd.Parameters.AddWithValue("@NombreAtri", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@NombreAtri", det.NombreAtri)
        End If
        '
        If det.DescriptionDetalle Is Nothing Then
            cmd.Parameters.AddWithValue("@DescriptionDetalle", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescriptionDetalle", det.DescriptionDetalle)
        End If
        '
        If det.EncabezadoColumna Is Nothing Then
            cmd.Parameters.AddWithValue("@EncabezadoColumna", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@EncabezadoColumna", det.EncabezadoColumna)
        End If
        '
        If det.ValorPorOmision Is Nothing Then
            cmd.Parameters.AddWithValue("@ValorPorOmision", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@ValorPorOmision", det.ValorPorOmision)
        End If
        '
        If det.Prompt Is Nothing Then
            cmd.Parameters.AddWithValue("@Prompt", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Prompt", det.Prompt)
        End If
        '
        If det.MensajeError Is Nothing Then
            cmd.Parameters.AddWithValue("@MensajeError", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@MensajeError", det.MensajeError)
        End If
        '
        If det.Ayuda Is Nothing Then
            cmd.Parameters.AddWithValue("@Ayuda", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Ayuda", det.Ayuda)
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
                "SELECT IDENT_CURRENT('Ind_MetaDatoTraducidoDAtrTx') FROM Ind_MetaDatoTraducidoDAtrTx"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_MetaDatoTraducidoDAtrTx) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_MetaDatoTraducidoDAtrTx " &
            "SET " &
            "       IdAtrTx                 = @IdAtrTx, " &
            "       IdIdioma                = @IdIdioma, " &
            "       NombreAtri              = @NombreAtri, " &
            "       DescriptionDetalle      = @DescriptionDetalle, " &
            "       EncabezadoColumna       = @EncabezadoColumna, " &
            "       ValorPorOmision         = @ValorPorOmision, " &
            "       Prompt                  = @Prompt, " &
            "       MensajeError            = @MensajeError, " &
            "       Ayuda                   = @Ayuda, " &
            "       IdCreado                = @IdCreado, " &
            "       IdUltimoCambio          = @IdUltimoCambio, " &
            "       IdBorradoL              = @IdBorradoL " &
            "WHERE  IdMetaDatoAtrTxTrad     = @IdMetaDatoAtrTxTrad "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        If det.IdAtrTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdAtrTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdAtrTx", det.IdAtrTx)
        End If
        '
        If det.IdIdioma = Nothing Then
            cmd.Parameters.AddWithValue("@IdIdioma", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdIdioma", det.IdIdioma)
        End If
        '
        If det.NombreAtri Is Nothing Then
            cmd.Parameters.AddWithValue("@NombreAtri", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@NombreAtri", det.NombreAtri)
        End If
        '
        If det.DescriptionDetalle Is Nothing Then
            cmd.Parameters.AddWithValue("@DescriptionDetalle", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescriptionDetalle", det.DescriptionDetalle)
        End If
        '
        If det.EncabezadoColumna Is Nothing Then
            cmd.Parameters.AddWithValue("@EncabezadoColumna", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@EncabezadoColumna", det.EncabezadoColumna)
        End If
        '
        If det.ValorPorOmision Is Nothing Then
            cmd.Parameters.AddWithValue("@ValorPorOmision", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@ValorPorOmision", det.ValorPorOmision)
        End If
        '
        If det.Prompt Is Nothing Then
            cmd.Parameters.AddWithValue("@Prompt", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Prompt", det.Prompt)
        End If
        '
        If det.MensajeError Is Nothing Then
            cmd.Parameters.AddWithValue("@MensajeError", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@MensajeError", det.MensajeError)
        End If
        '
        If det.Ayuda Is Nothing Then
            cmd.Parameters.AddWithValue("@Ayuda", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Ayuda", det.Ayuda)
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
        cmd.Parameters.AddWithValue("@IdMetaDatoAtrTxTrad", det.IdMetaDatoAtrTxTrad)
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
