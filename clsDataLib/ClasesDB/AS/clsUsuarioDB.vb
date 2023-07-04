Imports System.Data.SqlClient
Public Class clsUsuarioDB
    '
    ' idUsuario, Usuario, Nombres, Es_Administrador, Correo_Electronico, Celular, Tipo_Acceso, Req_Cambio_Clave,
    ' Frecuencia_Clave, limite_Intentos, Fecha_Ult_Clave, UsuarioModifica, FechaModifica, idPerfil, Estado
    '
    Public Shared Function lista(ByVal login As String, ByVal pwd As String, ByVal bd As String) As List(Of clsUsuario)
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '
        Dim detList As New List(Of clsUsuario)
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            " SELECT A.idUsuario, A.Usuario, A.Nombres,  A.Es_Administrador, A.Correo_Electronico, A.Celular, A.Tipo_Acceso, A.Req_Cambio_Clave, " &
            "       A.Frecuencia_Clave, A.limite_Intentos, A.Fecha_Ult_Clave, A.UsuarioModifica, A.FechaModifica, A.idPerfil, A.Estado, B.Perfil, " &
            "       case A.Estado " &
            "           when 0 then 'INACTIVO' " &
            "           when 1 then 'ACTIVO' " &
            "       end as cestado, " &
            "       A.UsuarioCrea, A.FechaCrea, A.UsuarioModifica, A.FechaModifica " &
            " FROM Usuario A " &
            "       Join Perfil B on B.IdPerfil = A.IdPerfil " &
            " ORDER BY Usuario"
        ' I
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsUsuario
            Do While rdr.Read
                det = New clsUsuario
                det.idUsuario = CInt(rdr("idUsuario"))
                det.Usuario = rdr("Usuario").ToString
                det.Nombres = rdr("Nombres").ToString
                det.Es_Administrador = CInt(rdr("Es_Administrador"))
                det.Correo_Electronico = rdr("Correo_Electronico").ToString
                det.Celular = rdr("Celular").ToString
                det.Tipo_Acceso = CInt(rdr("Tipo_Acceso"))
                det.Req_Cambio_Clave = CInt(rdr("Req_Cambio_Clave"))
                det.Frecuencia_Clave = CInt(rdr("Frecuencia_Clave"))
                det.Limite_Intentos = CInt(rdr("Limite_Intentos"))
                det.Fecha_Ult_Clave = CDate(rdr("Fecha_Ult_Clave"))
                '
                det.Perfil = rdr("Perfil").ToString
                det.idPerfil = CInt(rdr("idPerfil"))
                '
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
                det.Estado = CInt(rdr("Estado"))
                det.cEstado = rdr("CEstado").ToString
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
    Public Shared Function lista_Cbo(ByVal login As String, ByVal pwd As String, ByVal bd As String) As List(Of clsUsuario)
        '
        Dim detList As New List(Of clsUsuario)
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            " SELECT idUsuario, Usuario & ' - ' & Nombres as Usuario " &
            " FROM Usuario " &
            " ORDER BY Usuario "
        ' I
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsUsuario
            Do While rdr.Read
                det = New clsUsuario
                det.idUsuario = CInt(rdr("idUsuario"))
                det.Usuario = rdr("Usuario").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal idUsuario As Integer) As clsUsuario
        '
        Dim det As clsUsuario
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            " SELECT A.idUsuario, A.Usuario, A.Nombres,  A.Es_Administrador, A.Correo_Electronico, A.Celular, A.Tipo_Acceso, A.Req_Cambio_Clave, " &
            "       A.Frecuencia_Clave, A.limite_Intentos, A.Fecha_Ult_Clave, A.UsuarioModifica, A.FechaModifica, A.idPerfil, A.Estado, B.Perfil, " &
            "       case A.Estado " &
            "           when 0 then 'INACTIVO' " &
            "           when 1 then 'ACTIVO' " &
            "       end as cestado, " &
            "       Convert(varchar(300), DecryptByPassPhrase('$$M" & Chr(65) & Chr(82) & Chr(73) & "TA$$', A.PassEncrypt)) AS PassEncrypt, " &
            "       A.UsuarioCrea, A.FechaCrea, A.UsuarioModifica, A.FechaModifica " &
            " FROM Usuario A " &
            "       Join Perfil B on B.IdPerfil = A.IdPerfil " &
            "WHERE (idUsuario = @idUsuario) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@idUsuario", idUsuario)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det = New clsUsuario
                det.idUsuario = CInt(rdr("idUsuario"))
                det.Usuario = rdr("Usuario").ToString
                det.Nombres = rdr("Nombres").ToString
                det.Es_Administrador = CInt(rdr("Es_Administrador"))
                det.Correo_Electronico = rdr("Correo_Electronico").ToString
                det.Celular = rdr("Celular").ToString
                det.Tipo_Acceso = CInt(rdr("Tipo_Acceso"))
                det.Req_Cambio_Clave = CInt(rdr("Req_Cambio_Clave"))
                det.Frecuencia_Clave = CInt(rdr("Frecuencia_Clave"))
                det.Limite_Intentos = CInt(rdr("Limite_Intentos"))
                det.Fecha_Ult_Clave = CDate(rdr("Fecha_Ult_Clave"))
                '
                det.Perfil = rdr("Perfil").ToString
                det.idPerfil = CInt(rdr("idPerfil"))
                det.PassEncrypt = rdr("PassEncrypt").ToString
                '                
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
                det.Estado = CInt(rdr("Estado"))
                det.cEstado = rdr("CEstado").ToString
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
    Public Shared Function insertar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsUsuario) As Integer
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '        
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "INSERT Usuario (Usuario, Nombres, PassEncrypt, idPerfil, UsuarioCrea) " &
            "VALUES (@Usuario, @Nombres, ENCRYPTBYPASSPHRASE('$$MARITA$$', @PassEncrypt), @idPerfil, @UsuarioCrea); "
        '        
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        cmd.Parameters.AddWithValue("@Usuario", det.Usuario)
        cmd.Parameters.AddWithValue("@Nombres", det.Nombres)
        cmd.Parameters.AddWithValue("@PassEncrypt", det.PassEncrypt)
        cmd.Parameters.AddWithValue("@idPerfil", det.idPerfil)
        cmd.Parameters.AddWithValue("@UsuarioCrea", login)
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Dim strPKEY As String =
                "SELECT IDENT_CURRENT('Usuario') FROM Usuario"
            Dim cmdPKEY As New SqlCommand(strPKEY, cnn)
            Dim idUsuario As Integer = CInt(cmdPKEY.ExecuteScalar)
            Return idUsuario
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Function
    '
    Public Shared Function actualizar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsUsuario) As Boolean
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "UPDATE Usuario " &
            "SET    Nombres = @Nombres, " &
            "       Es_Administrador = @Es_Administrador, " &
            "       Correo_Electronico = @Correo_Electronico, " &
            "       Celular = @Celular, " &
            "       Tipo_Acceso = @Tipo_Acceso, " &
            "       Req_Cambio_Clave = @Req_Cambio_Clave, " &
            "       Frecuencia_Clave = @Frecuencia_Clave, " &
            "       Limite_Intentos = @Limite_Intentos, " &
            "       Fecha_Ult_Clave = @Fecha_Ult_Clave, " &
            "       idPerfil = @idPerfil, " &
            "       Estado = @Estado, " &
            "       UsuarioModifica = @UsuarioModifica, " &
            "       FechaModifica = @FechaModifica " &
            "WHERE  idUsuario = @idUsuario "
        '
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@Nombres", det.Nombres)
        cmd.Parameters.AddWithValue("@Es_Administrador", det.Es_Administrador)
        cmd.Parameters.AddWithValue("@Correo_Electronico", det.Correo_Electronico)
        cmd.Parameters.AddWithValue("@Celular", det.Celular)
        cmd.Parameters.AddWithValue("@Tipo_Acceso", det.Tipo_Acceso)
        cmd.Parameters.AddWithValue("@Req_Cambio_Clave", det.Req_Cambio_Clave)
        cmd.Parameters.AddWithValue("@Frecuencia_Clave", det.Frecuencia_Clave)
        cmd.Parameters.AddWithValue("@Limite_Intentos", det.Limite_Intentos)
        cmd.Parameters.AddWithValue("@Fecha_Ult_Clave", det.Fecha_Ult_Clave)
        cmd.Parameters.AddWithValue("@idPerfil", det.idPerfil)
        cmd.Parameters.AddWithValue("@Estado", det.Estado)
        cmd.Parameters.AddWithValue("@UsuarioModifica", det.UsuarioModifica)
        cmd.Parameters.AddWithValue("@FechaModifica", DateTime.Now)
        '
        cmd.Parameters.AddWithValue("@idUsuario", det.idUsuario)
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
    Public Shared Function selUsuarioClave(ByVal Login As String, ByVal Clave As String, ByVal BaseDato As String) As Integer
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '
        Dim idUsuario As Integer
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(Login, Clave, BaseDato)
        Dim strSQL As String =
            "SELECT idUsuario " &
            "FROM Usuario " &
            "WHERE ((Usuario = @Usuario) and Convert(varchar(300), DecryptByPassPhrase('$$M" & Chr(65) & Chr(82) & Chr(73) & "TA$$', PassEncrypt)) = @Clave) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@Usuario", Login)
        cmd.Parameters.AddWithValue("@Clave", Clave)
        Try
            cnn.Open()
            idUsuario = cmd.ExecuteScalar
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        Return idUsuario
    End Function
    '
    Public Shared Function selPerfilTipo(ByVal Login As String, ByVal Clave As String, ByVal BaseDato As String, ByVal idTipo As Integer) As Boolean
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '
        Dim idPerfil As Integer
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(Login, Clave, BaseDato)
        Dim strSQL As String =
            "SELECT idPerfil " &
            "FROM Usuario " &
            "WHERE (Usuario = @Usuario) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@Usuario", Login)
        Try
            cnn.Open()
            idPerfil = cmd.ExecuteScalar
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        If idPerfil = idTipo Then
            Return True
        Else
            Return False
        End If
    End Function
    '
    Public Shared Function existeUsuario(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal Usuario As String) As Boolean
        '        
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "Select Count(*) As cuenta From Usuario Where Usuario = @Usuario "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@Usuario", Usuario)
        Try
            cnn.Open()
            Dim count As Integer = cmd.ExecuteScalar()
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
    Public Shared Sub insertarAdminLogin(ByVal login As String, ByVal pwd As String, bd As String, ByVal newLogin As String, ByVal passwd As String)
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '
        '   CREATE login [joseph] WITH PASSWORD = N'Ninguno1*', DEFAULT_DATABASE= [master], DEFAULT_LANGUAGE= [us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;       
        '   CREATE USER joseph FROM LOGIN joseph;
        '   ALTER ROLE [db_datareader] ADD MEMBER [joseph]; 
        '   ALTER ROLE [db_datawriter] ADD MEMBER [joseph]; 
        '
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "   CREATE LOGIN [" & newLogin & "] WITH PASSWORD = N'" & passwd & "', DEFAULT_DATABASE= [" & bd & "], DEFAULT_LANGUAGE= [us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;  " &
            "   CREATE USER " & newLogin & " FROM LOGIN " & newLogin & "; " &
            "   ALTER ROLE [db_datareader] ADD MEMBER [" & newLogin & "]; " &
            "   ALTER ROLE [db_datawriter] ADD MEMBER [" & newLogin & "]; "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Sub
    '
    Public Shared Sub insertarLogin(ByVal login As String, ByVal pwd As String, bd As String, ByVal newLogin As String, ByVal passwd As String)
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '
        '   CREATE login [joseph] WITH PASSWORD = N'Ninguno1*', DEFAULT_DATABASE= [master], DEFAULT_LANGUAGE= [us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;       
        '   CREATE USER joseph FROM LOGIN joseph;
        '   ALTER ROLE [db_datareader] ADD MEMBER [joseph]; 
        '   ALTER ROLE [db_datawriter] ADD MEMBER [joseph]; 
        '
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "   CREATE USER " & newLogin & " FROM LOGIN " & newLogin & "; " &
            "   ALTER ROLE [db_datareader] ADD MEMBER [" & newLogin & "]; " &
            "   ALTER ROLE [db_datawriter] ADD MEMBER [" & newLogin & "]; "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Sub
    '
    Public Shared Sub actLoginPasswd(ByVal login As String, ByVal pwd As String, bd As String, ByVal passwd As String)
        '
        Dim cnn As SqlConnection = clsDB.ConectarRoot(login, pwd, bd)
        Dim strSQL As String =
            "   ALTER LOGIN [" & login & "] WITH PASSWORD = N'" & passwd & "'; "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Sub
    '
    Public Shared Function actNombreyEstado(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsUsuario) As Boolean
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "UPDATE Usuario " &
            "SET    Nombres = @Nombres, " &
            "       Estado = @Estado, " &
            "       UsuarioModifica = @UsuarioModifica, " &
            "       FechaModifica = @FechaModifica " &
            "WHERE  idUsuario = @idUsuario "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@Nombres", det.Nombres)
        cmd.Parameters.AddWithValue("@Estado", det.Estado)
        cmd.Parameters.AddWithValue("@UsuarioModifica", login)
        cmd.Parameters.AddWithValue("@FechaModifica", DateTime.Now)
        cmd.Parameters.AddWithValue("@idUsuario", det.idUsuario)
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
    Public Shared Function actClave(ByVal login As String, ByVal pwd As String, ByVal bd As String, mClave As String, ByVal mId As Integer) As Boolean
        ' idUsuario, Usuario, Nombres, Clave, idPerfil
        '
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(login, pwd, bd)
        Dim strSQL As String =
            "UPDATE Usuario " &
            "SET    PassEncrypt = EncryptByPassPhrase('$$M" & Chr(65) & Chr(82) & Chr(73) & "TA$$', '" & mClave & "'), " &
            "       UsuarioModifica = @UsuarioModifica, " &
            "       FechaModifica = @FechaModifica " &
            "WHERE  idUsuario = @idUsuario "
        '      
        Dim cmd As New SqlCommand(strSQL, cnn)
        '        
        cmd.Parameters.AddWithValue("@UsuarioModifica", login)
        cmd.Parameters.AddWithValue("@FechaModifica", DateTime.Now)
        cmd.Parameters.AddWithValue("@idUsuario", mId)
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
