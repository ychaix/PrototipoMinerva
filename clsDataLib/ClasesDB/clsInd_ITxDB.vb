Imports System.Data.SqlClient
Public Class clsInd_ITxDB
    '
    '   IdITx, IdTxDITx, CodigoCategoría, CodSec, IdMarca, ReferenciaFrabricante, EmpaqueVenta, UnidadVenta,
    '   FraccionVenta, TamanioVenta, CodigoArrancelario, IdCreado, IdUltimoCambio, IdBorradoL 
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_ITx
        Dim detList As New listInd_ITx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdITx, IdTxDITx, CodigoCategoría, CodSec, IdMarca, ReferenciaFrabricante, EmpaqueVenta, UnidadVenta, " &
            "       FraccionVenta, TamanioVenta, CodigoArrancelario, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_ITx " &
            "ORDER BY IdITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_ITx
            Do While rdr.Read
                det = New clsInd_ITx
                det.IdITx = CInt(rdr("IdITx"))
                If rdr("IdTxDITx") Is DBNull.Value Then
                    det.IdTxDITx = Nothing
                Else
                    det.IdTxDITx = rdr("IdTxDITx").ToString
                End If
                '
                If rdr("CodigoCategoría") Is DBNull.Value Then
                    det.CodigoCategoría = Nothing
                Else
                    det.CodigoCategoría = rdr("CodigoCategoría").ToString
                End If
                '
                If rdr("CodSec") Is DBNull.Value Then
                    det.CodSec = Nothing
                Else
                    det.CodSec = rdr("CodSec").ToString
                End If
                '
                If rdr("IdMarca") Is DBNull.Value Then
                    det.IdMarca = Nothing
                Else
                    det.IdMarca = rdr("IdMarca").ToString
                End If
                '
                If rdr("ReferenciaFrabricante") Is DBNull.Value Then
                    det.ReferenciaFrabricante = Nothing
                Else
                    det.ReferenciaFrabricante = rdr("ReferenciaFrabricante").ToString
                End If
                '
                If rdr("EmpaqueVenta") Is DBNull.Value Then
                    det.EmpaqueVenta = Nothing
                Else
                    det.EmpaqueVenta = rdr("EmpaqueVenta").ToString
                End If
                '
                If rdr("UnidadVenta") Is DBNull.Value Then
                    det.UnidadVenta = Nothing
                Else
                    det.UnidadVenta = rdr("UnidadVenta").ToString
                End If
                '
                If rdr("FraccionVenta") Is DBNull.Value Then
                    det.FraccionVenta = Nothing
                Else
                    det.FraccionVenta = rdr("FraccionVenta").ToString
                End If
                '
                If rdr("TamanioVenta") Is DBNull.Value Then
                    det.TamanioVenta = Nothing
                Else
                    det.TamanioVenta = rdr("TamanioVenta").ToString
                End If
                '
                If rdr("CodigoArrancelario") Is DBNull.Value Then
                    det.CodigoArrancelario = Nothing
                Else
                    det.CodigoArrancelario = rdr("CodigoArrancelario").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_ITx
        '
        Dim det As New clsInd_ITx
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdITx, IdTxDITx, CodigoCategoría, CodSec, IdMarca, ReferenciaFrabricante, EmpaqueVenta, UnidadVenta, " &
            "       FraccionVenta, TamanioVenta, CodigoArrancelario, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_ITx " &
            "Where  IdITx = @IdITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdITx", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdITx = CInt(rdr("IdITx"))
                If rdr("IdTxDITx") Is DBNull.Value Then
                    det.IdTxDITx = Nothing
                Else
                    det.IdTxDITx = rdr("IdTxDITx").ToString
                End If
                '
                If rdr("CodigoCategoría") Is DBNull.Value Then
                    det.CodigoCategoría = Nothing
                Else
                    det.CodigoCategoría = rdr("CodigoCategoría").ToString
                End If
                '
                If rdr("CodSec") Is DBNull.Value Then
                    det.CodSec = Nothing
                Else
                    det.CodSec = rdr("CodSec").ToString
                End If
                '
                If rdr("IdMarca") Is DBNull.Value Then
                    det.IdMarca = Nothing
                Else
                    det.IdMarca = rdr("IdMarca").ToString
                End If
                '
                If rdr("ReferenciaFrabricante") Is DBNull.Value Then
                    det.ReferenciaFrabricante = Nothing
                Else
                    det.ReferenciaFrabricante = rdr("ReferenciaFrabricante").ToString
                End If
                '
                If rdr("EmpaqueVenta") Is DBNull.Value Then
                    det.EmpaqueVenta = Nothing
                Else
                    det.EmpaqueVenta = rdr("EmpaqueVenta").ToString
                End If
                '
                If rdr("UnidadVenta") Is DBNull.Value Then
                    det.UnidadVenta = Nothing
                Else
                    det.UnidadVenta = rdr("UnidadVenta").ToString
                End If
                '
                If rdr("FraccionVenta") Is DBNull.Value Then
                    det.FraccionVenta = Nothing
                Else
                    det.FraccionVenta = rdr("FraccionVenta").ToString
                End If
                '
                If rdr("TamanioVenta") Is DBNull.Value Then
                    det.TamanioVenta = Nothing
                Else
                    det.TamanioVenta = rdr("TamanioVenta").ToString
                End If
                '
                If rdr("CodigoArrancelario") Is DBNull.Value Then
                    det.CodigoArrancelario = Nothing
                Else
                    det.CodigoArrancelario = rdr("CodigoArrancelario").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_ITx) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_ITx  " &
        "       ( IdTxDITx, CodigoCategoría, CodSec, IdMarca, ReferenciaFrabricante, EmpaqueVenta, UnidadVenta, " &
        "           FraccionVenta, TamanioVenta, CodigoArrancelario, IdCreado, IdUltimoCambio, IdBorradoL ) " &
        "values ( @IdTxDITx, @CodigoCategoría, @CodSec, @IdMarca, @ReferenciaFrabricante, @EmpaqueVenta, @UnidadVenta, " &
        "           @FraccionVenta, @TamanioVenta, @CodigoArrancelario, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdTxDITx = Nothing Then
            cmd.Parameters.AddWithValue("@IdTxDITx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTxDITx", det.IdTxDITx)
        End If
        '
        If det.CodigoCategoría Is Nothing Then
            cmd.Parameters.AddWithValue("@CodigoCategoría", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodigoCategoría", det.CodigoCategoría)
        End If
        '
        If det.CodSec Is Nothing Then
            cmd.Parameters.AddWithValue("@CodSec", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodSec", det.CodSec)
        End If
        '
        If det.IdMarca = Nothing Then
            cmd.Parameters.AddWithValue("@IdMarca", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdMarca", det.IdMarca)
        End If
        '
        If det.ReferenciaFrabricante Is Nothing Then
            cmd.Parameters.AddWithValue("@ReferenciaFrabricante", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@ReferenciaFrabricante", det.ReferenciaFrabricante)
        End If
        '
        If det.EmpaqueVenta Is Nothing Then
            cmd.Parameters.AddWithValue("@EmpaqueVenta", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@EmpaqueVenta", det.EmpaqueVenta)
        End If
        '
        If det.UnidadVenta Is Nothing Then
            cmd.Parameters.AddWithValue("@UnidadVenta", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@UnidadVenta", det.UnidadVenta)
        End If
        '
        If det.FraccionVenta = Nothing Then
            cmd.Parameters.AddWithValue("@FraccionVenta", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@FraccionVenta", det.FraccionVenta)
        End If
        '
        If det.TamanioVenta = Nothing Then
            cmd.Parameters.AddWithValue("@TamanioVenta", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TamanioVenta", det.TamanioVenta)
        End If
        '
        If det.CodigoArrancelario Is Nothing Then
            cmd.Parameters.AddWithValue("@CodigoArrancelario", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodigoArrancelario", det.CodigoArrancelario)
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
                "SELECT IDENT_CURRENT('Ind_ITx') FROM Ind_ITx"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_ITx) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_ITx " &
            "SET " &
            "       IdTxDITx                = @IdTxDITx, " &
            "       CodigoCategoría         = @CodigoCategoría, " &
            "       CodSec                  = @CodSec, " &
            "       IdMarca                 = @IdMarca, " &
            "       ReferenciaFrabricante   = @ReferenciaFrabricante, " &
            "       EmpaqueVenta            = @EmpaqueVenta, " &
            "       UnidadVenta             = @UnidadVenta, " &
            "       FraccionVenta           = @FraccionVenta, " &
            "       TamanioVenta            = @TamanioVenta, " &
            "       CodigoArrancelario      = @CodigoArrancelario, " &
            "       IdCreado                = @IdCreado, " &
            "       IdUltimoCambio          = @IdUltimoCambio, " &
            "       IdBorradoL              = @IdBorradoL " &
            "WHERE  IdITx                   = @IdITx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdTxDITx = Nothing Then
            cmd.Parameters.AddWithValue("@IdTxDITx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTxDITx", det.IdTxDITx)
        End If
        '
        If det.CodigoCategoría Is Nothing Then
            cmd.Parameters.AddWithValue("@CodigoCategoría", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodigoCategoría", det.CodigoCategoría)
        End If
        '
        If det.CodSec Is Nothing Then
            cmd.Parameters.AddWithValue("@CodSec", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodSec", det.CodSec)
        End If
        '
        If det.IdMarca = Nothing Then
            cmd.Parameters.AddWithValue("@IdMarca", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdMarca", det.IdMarca)
        End If
        '
        If det.ReferenciaFrabricante Is Nothing Then
            cmd.Parameters.AddWithValue("@ReferenciaFrabricante", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@ReferenciaFrabricante", det.ReferenciaFrabricante)
        End If
        '
        If det.EmpaqueVenta Is Nothing Then
            cmd.Parameters.AddWithValue("@EmpaqueVenta", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@EmpaqueVenta", det.EmpaqueVenta)
        End If
        '
        If det.UnidadVenta Is Nothing Then
            cmd.Parameters.AddWithValue("@UnidadVenta", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@UnidadVenta", det.UnidadVenta)
        End If
        '
        If det.FraccionVenta = Nothing Then
            cmd.Parameters.AddWithValue("@FraccionVenta", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@FraccionVenta", det.FraccionVenta)
        End If
        '
        If det.TamanioVenta = Nothing Then
            cmd.Parameters.AddWithValue("@TamanioVenta", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TamanioVenta", det.TamanioVenta)
        End If
        '
        If det.CodigoArrancelario Is Nothing Then
            cmd.Parameters.AddWithValue("@CodigoArrancelario", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodigoArrancelario", det.CodigoArrancelario)
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
        cmd.Parameters.AddWithValue("@IdITx", det.IdITx)
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
