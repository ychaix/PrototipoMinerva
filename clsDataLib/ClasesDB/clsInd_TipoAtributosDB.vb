Imports System.Data.SqlClient
Public Class clsInd_TipoAtributosDB
    '
    '   IdTipoAtributo, Codigo, DescripcionTipoAtrib, TipoDatoVisualizado, TipoDatoSalvado, 
    '   FuenteDelValor, Mascarilla, Validacion, Interrogable, [Multi-idioma], AmbitoAtrib 
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_TipoAtributos
        Dim detList As New listInd_TipoAtributos
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdTipoAtributo, Codigo, DescripcionTipoAtrib, TipoDatoVisualizado, TipoDatoSalvado, " &
            "       FuenteDelValor, Mascarilla, Validacion, Interrogable, [Multi-idioma] as Multi_idioma, AmbitoAtrib " &
            "FROM   Ind_TipoAtributos " &
            "ORDER BY Codigo "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_TipoAtributos
            Do While rdr.Read
                det = New clsInd_TipoAtributos
                det.IdTipoAtributo = CInt(rdr("IdTipoAtributo"))
                If rdr("Codigo") Is DBNull.Value Then
                    det.Codigo = Nothing
                Else
                    det.Codigo = rdr("Codigo").ToString
                End If
                '
                If rdr("DescripcionTipoAtrib") Is DBNull.Value Then
                    det.DescripcionTipoAtrib = Nothing
                Else
                    det.DescripcionTipoAtrib = rdr("DescripcionTipoAtrib").ToString
                End If
                '
                If rdr("TipoDatoVisualizado") Is DBNull.Value Then
                    det.TipoDatoVisualizado = Nothing
                Else
                    det.TipoDatoVisualizado = rdr("TipoDatoVisualizado").ToString
                End If
                '
                If rdr("TipoDatoSalvado") Is DBNull.Value Then
                    det.TipoDatoSalvado = Nothing
                Else
                    det.TipoDatoSalvado = rdr("TipoDatoSalvado").ToString
                End If
                '
                If rdr("FuenteDelValor") Is DBNull.Value Then
                    det.FuenteDelValor = Nothing
                Else
                    det.FuenteDelValor = rdr("FuenteDelValor").ToString
                End If
                '
                det.Mascarilla = CInt(rdr("Mascarilla"))
                If rdr("Validacion") Is DBNull.Value Then
                    det.Validacion = Nothing
                Else
                    det.Validacion = rdr("Validacion").ToString
                End If
                '
                det.Interrogable = CInt(rdr("Interrogable"))
                det.Multi_idioma = CInt(rdr("Multi_idioma"))
                If rdr("AmbitoAtrib") Is DBNull.Value Then
                    det.AmbitoAtrib = Nothing
                Else
                    det.AmbitoAtrib = rdr("AmbitoAtrib").ToString
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
    Public Shared Function lista_Cbo(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As List(Of clsInd_TipoAtributos)
        Dim detList As New List(Of clsInd_TipoAtributos)
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdTipoAtributo, Codigo + ' - ' + DescripcionTipoAtrib as DescripcionTipoAtrib " &
            "FROM   Ind_TipoAtributos " &
            "ORDER BY Codigo "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_TipoAtributos
            Do While rdr.Read
                det = New clsInd_TipoAtributos
                det.IdTipoAtributo = CInt(rdr("IdTipoAtributo"))
                det.DescripcionTipoAtrib = rdr("DescripcionTipoAtrib").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_TipoAtributos
        '
        Dim det As New clsInd_TipoAtributos
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdTipoAtributo, Codigo, DescripcionTipoAtrib, TipoDatoVisualizado, TipoDatoSalvado, " &
            "       FuenteDelValor, Mascarilla, Validacion, Interrogable, [Multi-idioma] as Multi_idioma, AmbitoAtrib " &
            "FROM   Ind_TipoAtributos " &
            "Where  IdTipoAtributo = @IdTipoAtributo "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTipoAtributo", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdTipoAtributo = CInt(rdr("IdTipoAtributo"))
                If rdr("Codigo") Is DBNull.Value Then
                    det.Codigo = Nothing
                Else
                    det.Codigo = rdr("Codigo").ToString
                End If
                '
                If rdr("DescripcionTipoAtrib") Is DBNull.Value Then
                    det.DescripcionTipoAtrib = Nothing
                Else
                    det.DescripcionTipoAtrib = rdr("DescripcionTipoAtrib").ToString
                End If
                '
                If rdr("TipoDatoVisualizado") Is DBNull.Value Then
                    det.TipoDatoVisualizado = Nothing
                Else
                    det.TipoDatoVisualizado = rdr("TipoDatoVisualizado").ToString
                End If
                '
                If rdr("TipoDatoSalvado") Is DBNull.Value Then
                    det.TipoDatoSalvado = Nothing
                Else
                    det.TipoDatoSalvado = rdr("TipoDatoSalvado").ToString
                End If
                '
                If rdr("FuenteDelValor") Is DBNull.Value Then
                    det.FuenteDelValor = Nothing
                Else
                    det.FuenteDelValor = rdr("FuenteDelValor").ToString
                End If
                '
                det.Mascarilla = CInt(rdr("Mascarilla"))
                If rdr("Validacion") Is DBNull.Value Then
                    det.Validacion = Nothing
                Else
                    det.Validacion = rdr("Validacion").ToString
                End If
                '
                det.Interrogable = CInt(rdr("Interrogable"))
                det.Multi_idioma = CInt(rdr("Multi_idioma"))
                If rdr("AmbitoAtrib") Is DBNull.Value Then
                    det.AmbitoAtrib = Nothing
                Else
                    det.AmbitoAtrib = rdr("AmbitoAtrib").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_TipoAtributos) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_TipoAtributos  " &
        "       ( Codigo, DescripcionTipoAtrib, TipoDatoVisualizado, TipoDatoSalvado, " &
        "           FuenteDelValor, Mascarilla, Validacion, Interrogable, [Multi-idioma], AmbitoAtrib " &
        "values ( @Codigo, @DescripcionTipoAtrib, @TipoDatoVisualizado, @TipoDatoSalvado, " &
        "           @FuenteDelValor, @Mascarilla, @Validacion, @Interrogable, @Multi_idioma, @AmbitoAtrib ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '        
        If det.Codigo Is Nothing Then
            cmd.Parameters.AddWithValue("@Codigo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Codigo", det.Codigo)
        End If
        '
        If det.DescripcionTipoAtrib Is Nothing Then
            cmd.Parameters.AddWithValue("@DescripcionTipoAtrib", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescripcionTipoAtrib", det.DescripcionTipoAtrib)
        End If
        '
        If det.TipoDatoVisualizado Is Nothing Then
            cmd.Parameters.AddWithValue("@TipoDatoVisualizado", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TipoDatoVisualizado", det.TipoDatoVisualizado)
        End If
        '
        If det.TipoDatoSalvado Is Nothing Then
            cmd.Parameters.AddWithValue("@TipoDatoSalvado", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TipoDatoSalvado", det.TipoDatoSalvado)
        End If
        '
        If det.FuenteDelValor Is Nothing Then
            cmd.Parameters.AddWithValue("@FuenteDelValor", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@FuenteDelValor", det.FuenteDelValor)
        End If
        '
        cmd.Parameters.AddWithValue("@Mascarilla", det.Mascarilla)
        If det.Validacion Is Nothing Then
            cmd.Parameters.AddWithValue("@Validacion", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Validacion", det.Validacion)
        End If
        '
        cmd.Parameters.AddWithValue("@Interrogable", det.Interrogable)
        cmd.Parameters.AddWithValue("@Multi_idioma", det.Multi_idioma)
        If det.AmbitoAtrib Is Nothing Then
            cmd.Parameters.AddWithValue("@AmbitoAtrib", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@AmbitoAtrib", det.AmbitoAtrib)
        End If
        '
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Dim strPKEY As String =
                "SELECT IDENT_CURRENT('Ind_TipoAtributos') FROM Ind_TipoAtributos"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_TipoAtributos) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_TipoAtributos " &
            "SET " &
            "       Codigo                  = @Codigo, " &
            "       DescripcionTipoAtrib    = @DescripcionTipoAtrib, " &
            "       TipoDatoVisualizado     = @TipoDatoVisualizado, " &
            "       TipoDatoSalvado         = @TipoDatoSalvado, " &
            "       FuenteDelValor          = @FuenteDelValor, " &
            "       Mascarilla              = @Mascarilla, " &
            "       Validacion              = @Validacion, " &
            "       Interrogable            = @Interrogable, " &
            "       [Multi-idioma]          = @Multi_idioma, " &
            "       AmbitoAtrib             = @AmbitoAtrib, " &
            "WHERE  IdTipoAtributo          = @IdTipoAtributo "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        If det.Codigo Is Nothing Then
            cmd.Parameters.AddWithValue("@Codigo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Codigo", det.Codigo)
        End If
        '
        If det.DescripcionTipoAtrib Is Nothing Then
            cmd.Parameters.AddWithValue("@DescripcionTipoAtrib", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescripcionTipoAtrib", det.DescripcionTipoAtrib)
        End If
        '
        If det.TipoDatoVisualizado Is Nothing Then
            cmd.Parameters.AddWithValue("@TipoDatoVisualizado", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TipoDatoVisualizado", det.TipoDatoVisualizado)
        End If
        '
        If det.TipoDatoSalvado Is Nothing Then
            cmd.Parameters.AddWithValue("@TipoDatoSalvado", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TipoDatoSalvado", det.TipoDatoSalvado)
        End If
        '
        If det.FuenteDelValor Is Nothing Then
            cmd.Parameters.AddWithValue("@FuenteDelValor", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@FuenteDelValor", det.FuenteDelValor)
        End If
        '
        cmd.Parameters.AddWithValue("@Mascarilla", det.Mascarilla)
        If det.Validacion Is Nothing Then
            cmd.Parameters.AddWithValue("@Validacion", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Validacion", det.Validacion)
        End If
        '
        cmd.Parameters.AddWithValue("@Interrogable", det.Interrogable)
        cmd.Parameters.AddWithValue("@Multi_idioma", det.Multi_idioma)
        If det.AmbitoAtrib Is Nothing Then
            cmd.Parameters.AddWithValue("@AmbitoAtrib", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@AmbitoAtrib", det.AmbitoAtrib)
        End If
        '
        cmd.Parameters.AddWithValue("@IdTipoAtributo", det.IdTipoAtributo)
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
