Imports System.Data.SqlClient
Public Class clsInd_KitOJuegoDB
    '
    '   IdKitOJuego, IdITxJuegoGenerico, IdITxJuegoPropietario, IdITxGenerico, IdArticulo, CantidadDelJuego, IdUnidadMedidaDelJuego, 
    '   CodSec1, CodSec2, CantITxEnElJuego, IdUnidadIngrediente, IdCreado, IdUltimoCambio, IdBorradoL
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_KitOJuego
        Dim detList As New listInd_KitOJuego
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdKitOJuego, IdITxJuegoGenerico, IdITxJuegoPropietario, IdITxGenerico, IdArticulo, CantidadDelJuego, IdUnidadMedidaDelJuego, " &
            "       CodSec1, CodSec2, CantITxEnElJuego, IdUnidadIngrediente, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_KitOJuego " &
            "ORDER BY IdKitOJuego "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_KitOJuego
            Do While rdr.Read
                det = New clsInd_KitOJuego
                det.IdKitOJuego = CInt(rdr("IdKitOJuego"))
                If rdr("IdITxJuegoGenerico") Is DBNull.Value Then
                    det.IdITxJuegoGenerico = Nothing
                Else
                    det.IdITxJuegoGenerico = rdr("IdITxJuegoGenerico").ToString
                End If
                '
                If rdr("IdITxJuegoPropietario") Is DBNull.Value Then
                    det.IdITxJuegoPropietario = Nothing
                Else
                    det.IdITxJuegoPropietario = rdr("IdITxJuegoPropietario").ToString
                End If
                '
                If rdr("IdITxGenerico") Is DBNull.Value Then
                    det.IdITxGenerico = Nothing
                Else
                    det.IdITxGenerico = rdr("IdITxGenerico").ToString
                End If
                '
                If rdr("IdArticulo") Is DBNull.Value Then
                    det.IdArticulo = Nothing
                Else
                    det.IdArticulo = rdr("IdArticulo").ToString
                End If
                '
                If rdr("CantidadDelJuego") Is DBNull.Value Then
                    det.CantidadDelJuego = Nothing
                Else
                    det.CantidadDelJuego = rdr("CantidadDelJuego").ToString
                End If
                '
                If rdr("IdUnidadMedidaDelJuego") Is DBNull.Value Then
                    det.IdUnidadMedidaDelJuego = Nothing
                Else
                    det.IdUnidadMedidaDelJuego = rdr("IdUnidadMedidaDelJuego").ToString
                End If
                '
                If rdr("CodSec1") Is DBNull.Value Then
                    det.CodSec1 = Nothing
                Else
                    det.CodSec1 = rdr("CodSec1").ToString
                End If
                '
                If rdr("CodSec2") Is DBNull.Value Then
                    det.CodSec2 = Nothing
                Else
                    det.CodSec2 = rdr("CodSec2").ToString
                End If
                '
                If rdr("CantITxEnElJuego") Is DBNull.Value Then
                    det.CantITxEnElJuego = Nothing
                Else
                    det.CantITxEnElJuego = rdr("CantITxEnElJuego").ToString
                End If
                '
                If rdr("IdUnidadIngrediente") Is DBNull.Value Then
                    det.IdUnidadIngrediente = Nothing
                Else
                    det.IdUnidadIngrediente = rdr("IdUnidadIngrediente").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_KitOJuego
        '
        Dim det As New clsInd_KitOJuego
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
             "SELECT IdKitOJuego, IdITxJuegoGenerico, IdITxJuegoPropietario, IdITxGenerico, IdArticulo, CantidadDelJuego, IdUnidadMedidaDelJuego, " &
            "       CodSec1, CodSec2, CantITxEnElJuego, IdUnidadIngrediente, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_KitOJuego " &
            "Where  IdKitOJuego = @IdKitOJuego "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdKitOJuego", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdKitOJuego = CInt(rdr("IdKitOJuego"))
                If rdr("IdITxJuegoGenerico") Is DBNull.Value Then
                    det.IdITxJuegoGenerico = Nothing
                Else
                    det.IdITxJuegoGenerico = rdr("IdITxJuegoGenerico").ToString
                End If
                '
                If rdr("IdITxJuegoPropietario") Is DBNull.Value Then
                    det.IdITxJuegoPropietario = Nothing
                Else
                    det.IdITxJuegoPropietario = rdr("IdITxJuegoPropietario").ToString
                End If
                '
                If rdr("IdITxGenerico") Is DBNull.Value Then
                    det.IdITxGenerico = Nothing
                Else
                    det.IdITxGenerico = rdr("IdITxGenerico").ToString
                End If
                '
                If rdr("IdArticulo") Is DBNull.Value Then
                    det.IdArticulo = Nothing
                Else
                    det.IdArticulo = rdr("IdArticulo").ToString
                End If
                '
                If rdr("CantidadDelJuego") Is DBNull.Value Then
                    det.CantidadDelJuego = Nothing
                Else
                    det.CantidadDelJuego = rdr("CantidadDelJuego").ToString
                End If
                '
                If rdr("IdUnidadMedidaDelJuego") Is DBNull.Value Then
                    det.IdUnidadMedidaDelJuego = Nothing
                Else
                    det.IdUnidadMedidaDelJuego = rdr("IdUnidadMedidaDelJuego").ToString
                End If
                '
                If rdr("CodSec1") Is DBNull.Value Then
                    det.CodSec1 = Nothing
                Else
                    det.CodSec1 = rdr("CodSec1").ToString
                End If
                '
                If rdr("CodSec2") Is DBNull.Value Then
                    det.CodSec2 = Nothing
                Else
                    det.CodSec2 = rdr("CodSec2").ToString
                End If
                '
                If rdr("CantITxEnElJuego") Is DBNull.Value Then
                    det.CantITxEnElJuego = Nothing
                Else
                    det.CantITxEnElJuego = rdr("CantITxEnElJuego").ToString
                End If
                '
                If rdr("IdUnidadIngrediente") Is DBNull.Value Then
                    det.IdUnidadIngrediente = Nothing
                Else
                    det.IdUnidadIngrediente = rdr("IdUnidadIngrediente").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_KitOJuego) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_KitOJuego  " &
        "       ( IdITxJuegoGenerico, IdITxJuegoPropietario, IdITxGenerico, IdArticulo, CantidadDelJuego, IdUnidadMedidaDelJuego, " &
        "           CodSec1, CodSec2, CantITxEnElJuego, IdUnidadIngrediente, IdCreado, IdUltimoCambio, IdBorradoL ) " &
        "values ( @IdITxJuegoGenerico, @IdITxJuegoPropietario, @IdITxGenerico, @IdArticulo, @CantidadDelJuego, @IdUnidadMedidaDelJuego, " &
        "           @CodSec1, @CodSec2, @CantITxEnElJuego, @IdUnidadIngrediente, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdITxJuegoGenerico = Nothing Then
            cmd.Parameters.AddWithValue("@IdITxJuegoGenerico", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITxJuegoGenerico", det.IdITxJuegoGenerico)
        End If
        '
        If det.IdITxJuegoPropietario = Nothing Then
            cmd.Parameters.AddWithValue("@IdITxJuegoPropietario", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITxJuegoPropietario", det.IdITxJuegoPropietario)
        End If
        '
        If det.IdITxGenerico = Nothing Then
            cmd.Parameters.AddWithValue("@IdITxGenerico", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITxGenerico", det.IdITxGenerico)
        End If
        '
        If det.IdArticulo = Nothing Then
            cmd.Parameters.AddWithValue("@IdArticulo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdArticulo", det.IdArticulo)
        End If
        '
        If det.CantidadDelJuego = Nothing Then
            cmd.Parameters.AddWithValue("@CantidadDelJuego", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CantidadDelJuego", det.CantidadDelJuego)
        End If
        '
        If det.IdUnidadMedidaDelJuego = Nothing Then
            cmd.Parameters.AddWithValue("@IdUnidadMedidaDelJuego", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdUnidadMedidaDelJuego", det.IdUnidadMedidaDelJuego)
        End If
        '
        If det.CodSec1 Is Nothing Then
            cmd.Parameters.AddWithValue("@CodSec1", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodSec1", det.CodSec1)
        End If
        '
        If det.CodSec2 Is Nothing Then
            cmd.Parameters.AddWithValue("@CodSec2", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodSec2", det.CodSec2)
        End If
        '
        If det.CantITxEnElJuego = Nothing Then
            cmd.Parameters.AddWithValue("@CantITxEnElJuego", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CantITxEnElJuego", det.CantITxEnElJuego)
        End If
        '
        If det.IdUnidadIngrediente = Nothing Then
            cmd.Parameters.AddWithValue("@IdUnidadIngrediente", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdUnidadIngrediente", det.IdUnidadIngrediente)
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
                "SELECT IDENT_CURRENT('Ind_KitOJuego') FROM Ind_KitOJuego"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_KitOJuego) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_KitOJuego " &
            "SET " &
            "       IdITxJuegoGenerico          = @IdITxJuegoGenerico, " &
            "       IdITxJuegoPropietario       = @IdITxJuegoPropietario, " &
            "       IdITxGenerico               = @IdITxGenerico, " &
            "       IdArticulo                  = @IdArticulo, " &
            "       CantidadDelJuego            = @CantidadDelJuego, " &
            "       IdUnidadMedidaDelJuego      = @IdUnidadMedidaDelJuego, " &
            "       CodSec1                     = @CodSec1, " &
            "       CodSec2                     = @CodSec2, " &
            "       CantITxEnElJuego            = @CantITxEnElJuego, " &
            "       IdUnidadIngrediente         = @IdUnidadIngrediente, " &
            "       IdCreado                    = @IdCreado, " &
            "       IdUltimoCambio              = @IdUltimoCambio, " &
            "       IdBorradoL                  = @IdBorradoL " &
            "WHERE  IdKitOJuego                 = @IdKitOJuego "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.IdITxJuegoGenerico = Nothing Then
            cmd.Parameters.AddWithValue("@IdITxJuegoGenerico", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITxJuegoGenerico", det.IdITxJuegoGenerico)
        End If
        '
        If det.IdITxJuegoPropietario = Nothing Then
            cmd.Parameters.AddWithValue("@IdITxJuegoPropietario", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITxJuegoPropietario", det.IdITxJuegoPropietario)
        End If
        '
        If det.IdITxGenerico = Nothing Then
            cmd.Parameters.AddWithValue("@IdITxGenerico", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdITxGenerico", det.IdITxGenerico)
        End If
        '
        If det.IdArticulo = Nothing Then
            cmd.Parameters.AddWithValue("@IdArticulo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdArticulo", det.IdArticulo)
        End If
        '
        If det.CantidadDelJuego = Nothing Then
            cmd.Parameters.AddWithValue("@CantidadDelJuego", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CantidadDelJuego", det.CantidadDelJuego)
        End If
        '
        If det.IdUnidadMedidaDelJuego = Nothing Then
            cmd.Parameters.AddWithValue("@IdUnidadMedidaDelJuego", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdUnidadMedidaDelJuego", det.IdUnidadMedidaDelJuego)
        End If
        '
        If det.CodSec1 Is Nothing Then
            cmd.Parameters.AddWithValue("@CodSec1", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodSec1", det.CodSec1)
        End If
        '
        If det.CodSec2 Is Nothing Then
            cmd.Parameters.AddWithValue("@CodSec2", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodSec2", det.CodSec2)
        End If
        '
        If det.CantITxEnElJuego = Nothing Then
            cmd.Parameters.AddWithValue("@CantITxEnElJuego", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CantITxEnElJuego", det.CantITxEnElJuego)
        End If
        '
        If det.IdUnidadIngrediente = Nothing Then
            cmd.Parameters.AddWithValue("@IdUnidadIngrediente", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdUnidadIngrediente", det.IdUnidadIngrediente)
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
        cmd.Parameters.AddWithValue("@IdKitOJuego", det.IdKitOJuego)
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
