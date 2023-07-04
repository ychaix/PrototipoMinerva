Imports System.Data.SqlClient
Public Class clsBitacoraDB
    '
    Public Shared Function insertBitacora(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal bitacora As clsBitacora) As Integer
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(usuario, pwd, bd)
        Dim strSQL As String =
            "INSERT Bitacora (Modulo, Accion, Descripcion, Documento, ValorAnterior, ValorActual, Observaciones, UsuarioCrea) " &
            "values (@Modulo, @Accion, @Descripcion, @Documento, @ValorAnterior, @ValorActual, @Observaciones, @UsuarioCrea) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@Modulo", bitacora.Modulo)
        cmd.Parameters.AddWithValue("@Accion", bitacora.Accion)
        cmd.Parameters.AddWithValue("@Descripcion", bitacora.Descripcion)
        '
        If bitacora.Documento <> Nothing Then
            cmd.Parameters.AddWithValue("@Documento", bitacora.Documento)
        Else
            cmd.Parameters.AddWithValue("@Documento", DBNull.Value)
        End If
        '
        cmd.Parameters.AddWithValue("@ValorAnterior", bitacora.ValorAnterior)
        cmd.Parameters.AddWithValue("@ValorActual", bitacora.ValorActual)
        '
        If bitacora.Observaciones <> Nothing Then
            cmd.Parameters.AddWithValue("@Observaciones", bitacora.Observaciones)
        Else
            cmd.Parameters.AddWithValue("@Observaciones", DBNull.Value)
        End If
        '
        cmd.Parameters.AddWithValue("@UsuarioCrea", bitacora.UsuarioCrea)
        '
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Dim strPKEY As String =
                "SELECT IDENT_CURRENT('Bitacora') FROM Bitacora"
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
    Public Shared Function listaBitacoraFechas(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal fecIni As Date, ByVal fecFin As Date) As List(Of clsBitacora)
        Dim bitacoraList As New List(Of clsBitacora)
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(usuario, pwd, bd)
        Dim strSQL As String =
                "SELECT B.idBitacora, B.Modulo, B.Accion, B.Descripcion, B.Documento, B.ValorAnterior, B.ValorActual, B.Observaciones, B.UsuarioCrea, B.FechaCrea " &
                "FROM   Bitacora B " &
                "WHERE  B.FechaCrea >= @FecIni and B.FechaCrea < @FecFin " &
                "Order by idBitacora desc "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@fecIni", DateSerial(Year(fecIni), Month(fecIni), Day(fecIni)))
        cmd.Parameters.AddWithValue("@fecFin", DateSerial(Year(fecFin), Month(fecFin), Day(fecFin)))
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim bitacora As clsBitacora
            Do While rdr.Read
                bitacora = New clsBitacora
                bitacora.idBitacora = CInt(rdr("idBitacora"))
                bitacora.Modulo = rdr("Modulo").ToString
                bitacora.Accion = rdr("Accion").ToString
                bitacora.Descripcion = rdr("Descripcion").ToString
                '
                bitacora.Documento = Nothing
                If rdr("Descripcion") <> Nothing Then
                    bitacora.Documento = rdr("Documento").ToString
                End If
                '
                bitacora.ValorAnterior = rdr("ValorAnterior").ToString
                bitacora.ValorActual = rdr("ValorActual").ToString
                ' 
                bitacora.Observaciones = Nothing
                If rdr("Observaciones") <> Nothing Then
                    bitacora.Observaciones = rdr("Observaciones").ToString
                End If
                '
                bitacora.UsuarioCrea = rdr("UsuarioCrea").ToString
                bitacora.FechaCrea = CDate(rdr("FechaCrea"))
                bitacoraList.Add(bitacora)
            Loop
            rdr.Close()
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        Return bitacoraList
    End Function
    '
    Public Shared Function SalidaNoRegistrada(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As Boolean
        '
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(usuario, pwd, bd)
        Dim strSQl As String =
            "Select top(1) accion from bitacora " &
            "where  usuariocrea = @usuario " &
            "order by idbitacora desc "
        '
        Dim cmd As New SqlCommand(strSQl, cnn)
        cmd.Parameters.AddWithValue("@usuario", usuario)
        ' 
        Try
            cnn.Open()
            Dim mAccion As String = cmd.ExecuteScalar
            If mAccion <> "Salir" Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        ' 
    End Function
    '
    Public Shared Function selectUltimaFecha(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As Date
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT top(1) FechaCrea " &
            "FROM Bitacora " &
            "WHERE Accion = 'Ingresar' " &
            "order by idbitacora desc"
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Return CDate(cmd.ExecuteScalar)
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Function
    '
End Class
