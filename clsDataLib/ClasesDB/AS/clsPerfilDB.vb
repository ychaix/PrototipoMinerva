Imports System.Data.SqlClient
Public Class clsPerfilDB
    Public Shared Function lista(ByVal login As String, ByVal pwd As String, ByVal bd As String) As List(Of clsPerfil)
        Dim detList As New List(Of clsPerfil)
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdPerfil, Perfil, UsuarioCrea, FechaCrea, UsuarioModifica, FechaModifica, Estado, " &
            "       case Estado " &
            "           when '0' then 'INACTIVO' " &
            "           when '1' then 'ACTIVO' " &
            "           else 'INACTIVO' " &
            "       end as cEstado " &
            "FROM Perfil " &
            "ORDER BY Perfil"
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsPerfil
            Do While rdr.Read
                det = New clsPerfil
                det.IdPerfil = CInt(rdr("IdPerfil"))
                det.Perfil = rdr("Perfil").ToString
                det.UsuarioCrea = rdr("UsuarioCrea").ToString
                det.UsuarioModifica = rdr("UsuarioModifica").ToString
                det.FechaCrea = rdr("FechaCrea").ToString
                det.FechaModifica = rdr("FechaModifica").ToString
                det.Estado = rdr("Estado").ToString
                det.cEstado = rdr("cEstado").ToString
                detList.Add(det)
            Loop
            rdr.Close()
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        Return detList
    End Function
    '
    Public Shared Function lista_Cbo(ByVal login As String, ByVal pwd As String, ByVal bd As String) As List(Of clsPerfil)
        Dim detList As New List(Of clsPerfil)
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdPerfil, Perfil FROM Perfil Where Estado = 1 ORDER BY Perfil"
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsPerfil
            Do While rdr.Read
                det = New clsPerfil
                det.IdPerfil = CInt(rdr("IdPerfil"))
                det.Perfil = rdr("Perfil").ToString
                detList.Add(det)
            Loop
            rdr.Close()
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        Return detList
    End Function
    '
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal idPerfil As Integer) As clsPerfil
        Dim det As New clsPerfil
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdPerfil, Perfil, UsuarioCrea, FechaCrea, UsuarioModifica, FechaModifica FROM Perfil WHERE IdPerfil = @idPerfil"
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@idPerfil", idPerfil)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdPerfil = CInt(rdr("IdPerfil"))
                det.Perfil = rdr("Perfil").ToString
                det.UsuarioCrea = rdr("UsuarioCrea").ToString
                det.FechaCrea = CDate(rdr("FechaCrea"))
                If IsDBNull(rdr("UsuarioModifica")) Then
                    det.UsuarioModifica = Nothing
                Else
                    det.UsuarioModifica = rdr("UsuarioModifica").ToString
                End If
                If IsDBNull(rdr("FechaModifica")) Then
                    det.FechaModifica = Nothing
                Else
                    det.FechaModifica = CDate(rdr("FechaModifica"))
                End If
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
    End Function
    '
    Public Shared Function insertar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal perfil As clsPerfil) As Integer
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "INSERT Perfil (Perfil, UsuarioCrea, UsuarioModifica) values (@Perfil, @UsuarioCrea, @UsuarioCrea)"
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@Perfil", perfil.Perfil)
        cmd.Parameters.AddWithValue("@UsuarioCrea", perfil.UsuarioCrea)
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Dim strPKEY As String =
                "SELECT IDENT_CURRENT('Perfil') FROM Perfil"
            Dim cmdPKEY As New SqlCommand(strPKEY, cnn)
            Dim idPerfil As Integer = CInt(cmdPKEY.ExecuteScalar)
            Return idPerfil
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Function
    '
    Public Shared Function actualizar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal newPerfil As clsPerfil) As Boolean
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "UPDATE Perfil " &
            "SET Perfil = @newPerfil, " &
            "       Estado = @newEstado, " &
            "       UsuarioModifica = @newUsuarioModifica, " &
            "       FechaModifica = @newFechaModifica " &
            "WHERE IdPerfil = @newidPerfil "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@newPerfil", newPerfil.Perfil)
        cmd.Parameters.AddWithValue("@newEstado", newPerfil.Estado)
        cmd.Parameters.AddWithValue("@newUsuarioModifica", newPerfil.UsuarioModifica)
        cmd.Parameters.AddWithValue("@newFechaModifica", DateTime.Now)
        '
        cmd.Parameters.AddWithValue("@newidPerfil", newPerfil.IdPerfil)
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
