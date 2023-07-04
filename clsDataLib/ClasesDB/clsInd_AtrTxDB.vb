Imports System.Data.SqlClient
Public Class clsInd_AtrTxDB
    '
    '   IdAtrTx, Categoria, DescripcionCategoria, IdTx, IdTipoAtributo, NombreAtributo, NumeroOrdenAtributo, UnidadMedidaAtributo, 
    '   IdUnidadDeMedida, TipoValidacion, AbreviacionTabla, IdTablaValidacion, NombreTabla, ValorMinimo, ValorMaximo, Incremento, 
    '   Icono, Modificable, Obligatorio, Mascarilla, Interrogable, IdCreado, IdUltimoCambio, IdBorradoL
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_AtrTx
        Dim detList As New listInd_AtrTx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdAtrTx, Categoria, DescripcionCategoria, IdTx, IdTipoAtributo, NombreAtributo, NumeroOrdenAtributo, UnidadMedidaAtributo, " &
            "       IdUnidadDeMedida, TipoValidacion, AbreviacionTabla, IdTablaValidacion, NombreTabla, ValorMinimo, ValorMaximo, Incremento, " &
            "       Icono, Modificable, Obligatorio, Mascarilla, Interrogable, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_AtrTx " &
            "ORDER BY Categoria "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_AtrTx
            Do While rdr.Read
                det = New clsInd_AtrTx
                det.IdAtrTx = CInt(rdr("IdAtrTx"))
                If rdr("Categoria") Is DBNull.Value Then
                    det.Categoria = Nothing
                Else
                    det.Categoria = rdr("Categoria").ToString
                End If
                '
                If rdr("DescripcionCategoria") Is DBNull.Value Then
                    det.DescripcionCategoria = Nothing
                Else
                    det.DescripcionCategoria = rdr("DescripcionCategoria").ToString
                End If
                '
                If rdr("IdTx") Is DBNull.Value Then
                    det.IdTx = Nothing
                Else
                    det.IdTx = rdr("IdTx").ToString
                End If
                '
                If rdr("IdTipoAtributo") Is DBNull.Value Then
                    det.IdTipoAtributo = Nothing
                Else
                    det.IdTipoAtributo = rdr("IdTipoAtributo").ToString
                End If
                '
                If rdr("NombreAtributo") Is DBNull.Value Then
                    det.NombreAtributo = Nothing
                Else
                    det.NombreAtributo = rdr("NombreAtributo").ToString
                End If
                '
                If rdr("NumeroOrdenAtributo") Is DBNull.Value Then
                    det.NumeroOrdenAtributo = Nothing
                Else
                    det.NumeroOrdenAtributo = rdr("NumeroOrdenAtributo").ToString
                End If
                '
                If rdr("UnidadMedidaAtributo") Is DBNull.Value Then
                    det.UnidadMedidaAtributo = Nothing
                Else
                    det.UnidadMedidaAtributo = rdr("UnidadMedidaAtributo").ToString
                End If
                '
                If rdr("IdUnidadDeMedida") Is DBNull.Value Then
                    det.IdUnidadDeMedida = Nothing
                Else
                    det.IdUnidadDeMedida = rdr("IdUnidadDeMedida").ToString
                End If
                '
                If rdr("TipoValidacion") Is DBNull.Value Then
                    det.TipoValidacion = Nothing
                Else
                    det.TipoValidacion = rdr("TipoValidacion").ToString
                End If
                '
                If rdr("AbreviacionTabla") Is DBNull.Value Then
                    det.AbreviacionTabla = Nothing
                Else
                    det.AbreviacionTabla = rdr("AbreviacionTabla").ToString
                End If
                '
                If rdr("IdTablaValidacion") Is DBNull.Value Then
                    det.IdTablaValidacion = Nothing
                Else
                    det.IdTablaValidacion = rdr("IdTablaValidacion").ToString
                End If
                '
                If rdr("NombreTabla") Is DBNull.Value Then
                    det.NombreTabla = Nothing
                Else
                    det.NombreTabla = rdr("NombreTabla").ToString
                End If
                '
                If rdr("ValorMinimo") Is DBNull.Value Then
                    det.ValorMinimo = Nothing
                Else
                    det.ValorMinimo = rdr("ValorMinimo").ToString
                End If
                '
                If rdr("ValorMaximo") Is DBNull.Value Then
                    det.ValorMaximo = Nothing
                Else
                    det.ValorMaximo = rdr("ValorMaximo").ToString
                End If
                '
                If rdr("Incremento") Is DBNull.Value Then
                    det.Incremento = Nothing
                Else
                    det.Incremento = rdr("Incremento").ToString
                End If
                '
                If rdr("Icono") Is DBNull.Value Then
                    det.Icono = Nothing
                Else
                    det.Icono = rdr("Icono").ToString
                End If
                '
                If rdr("Modificable") Is DBNull.Value Then
                    det.Modificable = Nothing
                Else
                    det.Modificable = rdr("Modificable").ToString
                End If
                '
                If rdr("Obligatorio") Is DBNull.Value Then
                    det.Obligatorio = Nothing
                Else
                    det.Obligatorio = rdr("Obligatorio").ToString
                End If
                '
                If rdr("Mascarilla") Is DBNull.Value Then
                    det.Mascarilla = Nothing
                Else
                    det.Mascarilla = rdr("Mascarilla").ToString
                End If
                '
                If rdr("Interrogable") Is DBNull.Value Then
                    det.Interrogable = Nothing
                Else
                    det.Interrogable = rdr("Interrogable").ToString
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
    Public Shared Function lista_Cbo(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As List(Of clsInd_AtrTx)
        Dim detList As New List(Of clsInd_AtrTx)
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdAtrTx, Categoria + ' - ' + DescripcionCategoria DescripcionCategoria " &
            "FROM   Ind_AtrTx " &
            "ORDER BY Categoria, DescripcionCategoria "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_AtrTx
            Do While rdr.Read
                det = New clsInd_AtrTx
                det.IdAtrTx = CInt(rdr("IdAtrTx"))
                det.DescripcionCategoria = rdr("DescripcionCategoria").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_AtrTx
        '
        Dim det As New clsInd_AtrTx
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdAtrTx, Categoria, DescripcionCategoria, IdTx, IdTipoAtributo, NombreAtributo, NumeroOrdenAtributo, UnidadMedidaAtributo, " &
            "       IdUnidadDeMedida, TipoValidacion, AbreviacionTabla, IdTablaValidacion, NombreTabla, ValorMinimo, ValorMaximo, Incremento, " &
            "       Icono, Modificable, Obligatorio, Mascarilla, Interrogable, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_AtrTx " &
            "Where  IdAtrTx = @idAtrTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@idAtrTx", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdAtrTx = CInt(rdr("IdAtrTx"))
                If rdr("Categoria") Is DBNull.Value Then
                    det.Categoria = Nothing
                Else
                    det.Categoria = rdr("Categoria").ToString
                End If
                '
                If rdr("DescripcionCategoria") Is DBNull.Value Then
                    det.DescripcionCategoria = Nothing
                Else
                    det.DescripcionCategoria = rdr("DescripcionCategoria").ToString
                End If
                '
                If rdr("IdTx") Is DBNull.Value Then
                    det.IdTx = Nothing
                Else
                    det.IdTx = rdr("IdTx").ToString
                End If
                '
                If rdr("IdTipoAtributo") Is DBNull.Value Then
                    det.IdTipoAtributo = Nothing
                Else
                    det.IdTipoAtributo = rdr("IdTipoAtributo").ToString
                End If
                '
                If rdr("NombreAtributo") Is DBNull.Value Then
                    det.NombreAtributo = Nothing
                Else
                    det.NombreAtributo = rdr("NombreAtributo").ToString
                End If
                '
                If rdr("NumeroOrdenAtributo") Is DBNull.Value Then
                    det.NumeroOrdenAtributo = Nothing
                Else
                    det.NumeroOrdenAtributo = rdr("NumeroOrdenAtributo").ToString
                End If
                '
                If rdr("UnidadMedidaAtributo") Is DBNull.Value Then
                    det.UnidadMedidaAtributo = Nothing
                Else
                    det.UnidadMedidaAtributo = rdr("UnidadMedidaAtributo").ToString
                End If
                '
                If rdr("IdUnidadDeMedida") Is DBNull.Value Then
                    det.IdUnidadDeMedida = Nothing
                Else
                    det.IdUnidadDeMedida = rdr("IdUnidadDeMedida").ToString
                End If
                '
                If rdr("TipoValidacion") Is DBNull.Value Then
                    det.TipoValidacion = Nothing
                Else
                    det.TipoValidacion = rdr("TipoValidacion").ToString
                End If
                '
                If rdr("AbreviacionTabla") Is DBNull.Value Then
                    det.AbreviacionTabla = Nothing
                Else
                    det.AbreviacionTabla = rdr("AbreviacionTabla").ToString
                End If
                '
                If rdr("IdTablaValidacion") Is DBNull.Value Then
                    det.IdTablaValidacion = Nothing
                Else
                    det.IdTablaValidacion = rdr("IdTablaValidacion").ToString
                End If
                '
                If rdr("NombreTabla") Is DBNull.Value Then
                    det.NombreTabla = Nothing
                Else
                    det.NombreTabla = rdr("NombreTabla").ToString
                End If
                '
                If rdr("ValorMinimo") Is DBNull.Value Then
                    det.ValorMinimo = Nothing
                Else
                    det.ValorMinimo = rdr("ValorMinimo").ToString
                End If
                '
                If rdr("ValorMaximo") Is DBNull.Value Then
                    det.ValorMaximo = Nothing
                Else
                    det.ValorMaximo = rdr("ValorMaximo").ToString
                End If
                '
                If rdr("Incremento") Is DBNull.Value Then
                    det.Incremento = Nothing
                Else
                    det.Incremento = rdr("Incremento").ToString
                End If
                '
                If rdr("Icono") Is DBNull.Value Then
                    det.Icono = Nothing
                Else
                    det.Icono = rdr("Icono").ToString
                End If
                '
                If rdr("Modificable") Is DBNull.Value Then
                    det.Modificable = Nothing
                Else
                    det.Modificable = rdr("Modificable").ToString
                End If
                '
                If rdr("Obligatorio") Is DBNull.Value Then
                    det.Obligatorio = Nothing
                Else
                    det.Obligatorio = rdr("Obligatorio").ToString
                End If
                '
                If rdr("Mascarilla") Is DBNull.Value Then
                    det.Mascarilla = Nothing
                Else
                    det.Mascarilla = rdr("Mascarilla").ToString
                End If
                '
                If rdr("Interrogable") Is DBNull.Value Then
                    det.Interrogable = Nothing
                Else
                    det.Interrogable = rdr("Interrogable").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_AtrTx) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_AtrTx  " &
        "       ( Categoria, DescripcionCategoria, IdTx, IdTipoAtributo, NombreAtributo, NumeroOrdenAtributo, UnidadMedidaAtributo, " &
        "           IdUnidadDeMedida, TipoValidacion, AbreviacionTabla, IdTablaValidacion, NombreTabla, ValorMinimo, ValorMaximo, " &
        "           Incremento, Icono, Modificable, Obligatorio, Mascarilla, Interrogable, IdCreado, IdUltimoCambio, IdBorradoL ) " &
        "values ( @Categoria, @DescripcionCategoria, @IdTx, @IdTipoAtributo, @NombreAtributo, @NumeroOrdenAtributo, @UnidadMedidaAtributo, " &
        "           @IdUnidadDeMedida, @TipoValidacion, @AbreviacionTabla, @IdTablaValidacion, @NombreTabla, @ValorMinimo, @ValorMaximo, " &
        "           @Incremento, @Icono, @Modificable, @Obligatorio, @Mascarilla, @Interrogable, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.Categoria Is Nothing Then
            cmd.Parameters.AddWithValue("@Categoria", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Categoria", det.Categoria)
        End If
        '
        If det.DescripcionCategoria Is Nothing Then
            cmd.Parameters.AddWithValue("@DescripcionCategoria", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescripcionCategoria", det.DescripcionCategoria)
        End If
        '
        If det.IdTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx", det.IdTx)
        End If
        '
        If det.IdTipoAtributo = Nothing Then
            cmd.Parameters.AddWithValue("@IdTipoAtributo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTipoAtributo", det.IdTipoAtributo)
        End If
        '
        If det.NombreAtributo Is Nothing Then
            cmd.Parameters.AddWithValue("@NombreAtributo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@NombreAtributo", det.NombreAtributo)
        End If
        '
        If det.NumeroOrdenAtributo = Nothing Then
            cmd.Parameters.AddWithValue("@NumeroOrdenAtributo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@NumeroOrdenAtributo", det.NumeroOrdenAtributo)
        End If
        '
        If det.UnidadMedidaAtributo Is Nothing Then
            cmd.Parameters.AddWithValue("@UnidadMedidaAtributo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@UnidadMedidaAtributo", det.UnidadMedidaAtributo)
        End If
        '
        If det.IdUnidadDeMedida = Nothing Then
            cmd.Parameters.AddWithValue("@IdUnidadDeMedida", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdUnidadDeMedida", det.IdUnidadDeMedida)
        End If
        '
        If det.TipoValidacion Is Nothing Then
            cmd.Parameters.AddWithValue("@TipoValidacion", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TipoValidacion", det.TipoValidacion)
        End If
        '
        If det.AbreviacionTabla Is Nothing Then
            cmd.Parameters.AddWithValue("@AbreviacionTabla", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@AbreviacionTabla", det.AbreviacionTabla)
        End If
        '
        If det.IdTablaValidacion = Nothing Then
            cmd.Parameters.AddWithValue("@IdTablaValidacion", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTablaValidacion", det.IdTablaValidacion)
        End If
        '
        If det.NombreTabla Is Nothing Then
            cmd.Parameters.AddWithValue("@NombreTabla", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@NombreTabla", det.NombreTabla)
        End If
        '
        If det.ValorMinimo Is Nothing Then
            cmd.Parameters.AddWithValue("@ValorMinimo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@ValorMinimo", det.ValorMinimo)
        End If
        '
        If det.ValorMaximo Is Nothing Then
            cmd.Parameters.AddWithValue("@ValorMaximo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@ValorMaximo", det.ValorMaximo)
        End If
        '
        If det.Incremento Is Nothing Then
            cmd.Parameters.AddWithValue("@Incremento", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Incremento", det.Incremento)
        End If
        '
        If det.Icono Is Nothing Then
            cmd.Parameters.AddWithValue("@Icono", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Icono", det.Icono)
        End If
        '
        If det.Modificable = Nothing Then
            cmd.Parameters.AddWithValue("@Modificable", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Modificable", det.Modificable)
        End If
        '
        If det.Obligatorio = Nothing Then
            cmd.Parameters.AddWithValue("@Obligatorio", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Obligatorio", det.Obligatorio)
        End If
        '
        If det.Mascarilla = Nothing Then
            cmd.Parameters.AddWithValue("@Mascarilla", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Mascarilla", det.Mascarilla)
        End If
        '
        If det.Interrogable = Nothing Then
            cmd.Parameters.AddWithValue("@Interrogable", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Interrogable", det.Interrogable)
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
                "SELECT IDENT_CURRENT('Ind_AtrTx') FROM Ind_AtrTx"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_AtrTx) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_AtrTx " &
            "SET " &
            "       Categoria              = @Categoria, " &
            "       DescripcionCategoria   = @DescripcionCategoria, " &
            "       IdTx                   = @IdTx, " &
            "       IdTipoAtributo         = @IdTipoAtributo, " &
            "       NombreAtributo         = @NombreAtributo, " &
            "       NumeroOrdenAtributo    = @NumeroOrdenAtributo, " &
            "       UnidadMedidaAtributo   = @UnidadMedidaAtributo, " &
            "       IdUnidadDeMedida       = @IdUnidadDeMedida, " &
            "       TipoValidacion         = @TipoValidacion, " &
            "       AbreviacionTabla       = @AbreviacionTabla, " &
            "       IdTablaValidacion      = @IdTablaValidacion, " &
            "       NombreTabla            = @NombreTabla, " &
            "       ValorMinimo            = @ValorMinimo, " &
            "       ValorMaximo            = @ValorMaximo, " &
            "       Incremento             = @Incremento, " &
            "       Icono                  = @Icono, " &
            "       Modificable            = @Modificable, " &
            "       Obligatorio            = @Obligatorio, " &
            "       Mascarilla             = @Mascarilla, " &
            "       Interrogable           = @Interrogable, " &
            "       IdCreado               = @IdCreado, " &
            "       IdUltimoCambio         = @IdUltimoCambio, " &
            "       IdBorradoL             = @IdBorradoL " &
            "WHERE  IdAtrTx                = @IdAtrTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.Categoria Is Nothing Then
            cmd.Parameters.AddWithValue("@Categoria", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Categoria", det.Categoria)
        End If
        '
        If det.DescripcionCategoria Is Nothing Then
            cmd.Parameters.AddWithValue("@DescripcionCategoria", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescripcionCategoria", det.DescripcionCategoria)
        End If
        '
        If det.IdTx = Nothing Then
            cmd.Parameters.AddWithValue("@IdTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTx", det.IdTx)
        End If
        '
        If det.IdTipoAtributo = Nothing Then
            cmd.Parameters.AddWithValue("@IdTipoAtributo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTipoAtributo", det.IdTipoAtributo)
        End If
        '
        If det.NombreAtributo Is Nothing Then
            cmd.Parameters.AddWithValue("@NombreAtributo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@NombreAtributo", det.NombreAtributo)
        End If
        '
        If det.NumeroOrdenAtributo = Nothing Then
            cmd.Parameters.AddWithValue("@NumeroOrdenAtributo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@NumeroOrdenAtributo", det.NumeroOrdenAtributo)
        End If
        '
        If det.UnidadMedidaAtributo Is Nothing Then
            cmd.Parameters.AddWithValue("@UnidadMedidaAtributo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@UnidadMedidaAtributo", det.UnidadMedidaAtributo)
        End If
        '
        If det.IdUnidadDeMedida = Nothing Then
            cmd.Parameters.AddWithValue("@IdUnidadDeMedida", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdUnidadDeMedida", det.IdUnidadDeMedida)
        End If
        '
        If det.TipoValidacion Is Nothing Then
            cmd.Parameters.AddWithValue("@TipoValidacion", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TipoValidacion", det.TipoValidacion)
        End If
        '
        If det.AbreviacionTabla Is Nothing Then
            cmd.Parameters.AddWithValue("@AbreviacionTabla", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@AbreviacionTabla", det.AbreviacionTabla)
        End If
        '
        If det.IdTablaValidacion = Nothing Then
            cmd.Parameters.AddWithValue("@IdTablaValidacion", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTablaValidacion", det.IdTablaValidacion)
        End If
        '
        If det.NombreTabla Is Nothing Then
            cmd.Parameters.AddWithValue("@NombreTabla", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@NombreTabla", det.NombreTabla)
        End If
        '
        If det.ValorMinimo Is Nothing Then
            cmd.Parameters.AddWithValue("@ValorMinimo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@ValorMinimo", det.ValorMinimo)
        End If
        '
        If det.ValorMaximo Is Nothing Then
            cmd.Parameters.AddWithValue("@ValorMaximo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@ValorMaximo", det.ValorMaximo)
        End If
        '
        If det.Incremento Is Nothing Then
            cmd.Parameters.AddWithValue("@Incremento", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Incremento", det.Incremento)
        End If
        '
        If det.Icono Is Nothing Then
            cmd.Parameters.AddWithValue("@Icono", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Icono", det.Icono)
        End If
        '
        If det.Modificable = Nothing Then
            cmd.Parameters.AddWithValue("@Modificable", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Modificable", det.Modificable)
        End If
        '
        If det.Obligatorio = Nothing Then
            cmd.Parameters.AddWithValue("@Obligatorio", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Obligatorio", det.Obligatorio)
        End If
        '
        If det.Mascarilla = Nothing Then
            cmd.Parameters.AddWithValue("@Mascarilla", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Mascarilla", det.Mascarilla)
        End If
        '
        If det.Interrogable = Nothing Then
            cmd.Parameters.AddWithValue("@Interrogable", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Interrogable", det.Interrogable)
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
        cmd.Parameters.AddWithValue("@IdAtrTx", det.IdAtrTx)
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
    Public Shared Function listaTx(usuario As String, pwd As String, bd As String, IdTx As Integer) As listInd_AtrTx
        Dim detList As New listInd_AtrTx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT A.IdAtrTx, A.Categoria, A.DescripcionCategoria, A.IdTx, A.IdTipoAtributo, B.Codigo + ' - '+ B.DescripcionTipoAtrib as TipoAtributo,  " &
            "       A.NombreAtributo, A.NumeroOrdenAtributo, A.UnidadMedidaAtributo, A.IdUnidadDeMedida, A.TipoValidacion, A.AbreviacionTabla, " &
            "       A.IdTablaValidacion, A.NombreTabla, A.ValorMinimo, A.ValorMaximo, A.Incremento, A.Icono, A.Modificable, A.Obligatorio, " &
            "       A.Mascarilla, A.Interrogable, A.IdCreado, A.IdUltimoCambio, A.IdBorradoL " &
            "FROM   Ind_AtrTx A " &
            "       Left Join Ind_TipoAtributos B on B.IdTipoAtributo = A.IdTipoAtributo " &
            "WHERE  A.IdTx = @Idtx " &
            "ORDER BY A.Categoria "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("Idtx", IdTx)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_AtrTx
            Do While rdr.Read
                det = New clsInd_AtrTx
                det.IdAtrTx = CInt(rdr("IdAtrTx"))
                If rdr("Categoria") Is DBNull.Value Then
                    det.Categoria = Nothing
                Else
                    det.Categoria = rdr("Categoria").ToString
                End If
                '
                If rdr("DescripcionCategoria") Is DBNull.Value Then
                    det.DescripcionCategoria = Nothing
                Else
                    det.DescripcionCategoria = rdr("DescripcionCategoria").ToString
                End If
                '
                If rdr("IdTx") Is DBNull.Value Then
                    det.IdTx = Nothing
                Else
                    det.IdTx = rdr("IdTx").ToString
                End If
                '
                If rdr("IdTipoAtributo") Is DBNull.Value Then
                    det.IdTipoAtributo = Nothing
                Else
                    det.IdTipoAtributo = rdr("IdTipoAtributo").ToString
                End If
                '
                If rdr("TipoAtributo") Is DBNull.Value Then
                    det.TipoAtributo = Nothing
                Else
                    det.TipoAtributo = rdr("TipoAtributo").ToString
                End If
                '
                If rdr("NombreAtributo") Is DBNull.Value Then
                    det.NombreAtributo = Nothing
                Else
                    det.NombreAtributo = rdr("NombreAtributo").ToString
                End If
                '
                If rdr("NumeroOrdenAtributo") Is DBNull.Value Then
                    det.NumeroOrdenAtributo = Nothing
                Else
                    det.NumeroOrdenAtributo = rdr("NumeroOrdenAtributo").ToString
                End If
                '
                If rdr("UnidadMedidaAtributo") Is DBNull.Value Then
                    det.UnidadMedidaAtributo = Nothing
                Else
                    det.UnidadMedidaAtributo = rdr("UnidadMedidaAtributo").ToString
                End If
                '
                If rdr("IdUnidadDeMedida") Is DBNull.Value Then
                    det.IdUnidadDeMedida = Nothing
                Else
                    det.IdUnidadDeMedida = rdr("IdUnidadDeMedida").ToString
                End If
                '
                If rdr("TipoValidacion") Is DBNull.Value Then
                    det.TipoValidacion = Nothing
                Else
                    det.TipoValidacion = rdr("TipoValidacion").ToString
                End If
                '
                If rdr("AbreviacionTabla") Is DBNull.Value Then
                    det.AbreviacionTabla = Nothing
                Else
                    det.AbreviacionTabla = rdr("AbreviacionTabla").ToString
                End If
                '
                If rdr("IdTablaValidacion") Is DBNull.Value Then
                    det.IdTablaValidacion = Nothing
                Else
                    det.IdTablaValidacion = rdr("IdTablaValidacion").ToString
                End If
                '
                If rdr("NombreTabla") Is DBNull.Value Then
                    det.NombreTabla = Nothing
                Else
                    det.NombreTabla = rdr("NombreTabla").ToString
                End If
                '
                If rdr("ValorMinimo") Is DBNull.Value Then
                    det.ValorMinimo = Nothing
                Else
                    det.ValorMinimo = rdr("ValorMinimo").ToString
                End If
                '
                If rdr("ValorMaximo") Is DBNull.Value Then
                    det.ValorMaximo = Nothing
                Else
                    det.ValorMaximo = rdr("ValorMaximo").ToString
                End If
                '
                If rdr("Incremento") Is DBNull.Value Then
                    det.Incremento = Nothing
                Else
                    det.Incremento = rdr("Incremento").ToString
                End If
                '
                If rdr("Icono") Is DBNull.Value Then
                    det.Icono = Nothing
                Else
                    det.Icono = rdr("Icono").ToString
                End If
                '
                If rdr("Modificable") Is DBNull.Value Then
                    det.Modificable = Nothing
                Else
                    det.Modificable = rdr("Modificable").ToString
                End If
                '
                If rdr("Obligatorio") Is DBNull.Value Then
                    det.Obligatorio = Nothing
                Else
                    det.Obligatorio = rdr("Obligatorio").ToString
                End If
                '
                If rdr("Mascarilla") Is DBNull.Value Then
                    det.Mascarilla = Nothing
                Else
                    det.Mascarilla = rdr("Mascarilla").ToString
                End If
                '
                If rdr("Interrogable") Is DBNull.Value Then
                    det.Interrogable = Nothing
                Else
                    det.Interrogable = rdr("Interrogable").ToString
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
End Class
