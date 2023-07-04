Imports System.Data.SqlClient
Public Class clsFiltrosDB
    '
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsFiltros) As Integer
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(usuario, pwd, bd)
        ' 
        Dim strSQL As String =
            "Insert Into Filtros " &
            " (mUsuario, mModulo, Filtro ) " &
            " values " &
            " (@mUsuario, @mModulo, @Filtro ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@mUsuario", usuario)
        cmd.Parameters.AddWithValue("@mModulo", det.mModulo)
        cmd.Parameters.AddWithValue("@Filtro", det.Filtro)
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            Dim strPKEY As String =
                "SELECT IDENT_CURRENT('Filtros') FROM Filtros"
            Dim cmdPKEY As New SqlCommand(strPKEY, cnn)
            Return CInt(cmdPKEY.ExecuteScalar)
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Function
    '
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsFiltros) As Boolean
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(usuario, pwd, bd)
        Dim strSQl As String =
            "Update Filtros " &
            "set    Filtro  = @Filtro, " &
            "       Estado  = @Estado " &
            "where  mModulo = @mModulo  and mUsuario = @mUsuario "
        '
        Dim cmd As New SqlCommand(strSQl, cnn)
        cmd.Parameters.AddWithValue("@Filtro", det.Filtro)
        cmd.Parameters.AddWithValue("@Estado", det.Estado)
        cmd.Parameters.AddWithValue("@mModulo", det.mModulo)
        cmd.Parameters.AddWithValue("@mUsuario", usuario)
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
    Public Shared Function ExisteFiltro(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal mModulo As String) As Boolean
        Dim mCuenta As Integer = 0
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(usuario, pwd, bd)
        Dim strSQL As String =
            "select count(*) from Filtros where mUsuario = @mUsuario and mModulo = @mModulo "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@mUsuario", usuario)
        cmd.Parameters.AddWithValue("@mModulo", mModulo)
        '
        Try
            cnn.Open()
            mCuenta = cmd.ExecuteScalar
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        If mCuenta = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    '
    Public Shared Function LeerFiltro(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal mModulo As String) As String
        Dim mFiltro_Actual As String = String.Empty
        Dim cnn As SqlConnection = clsDB.ConectarAdmin(usuario, pwd, bd)
        Dim strSQL As String =
            "select Filtro from Filtros where mUsuario = @mUsuario and mModulo = @mModulo "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@mUsuario", usuario)
        cmd.Parameters.AddWithValue("@mModulo", mModulo)
        '
        Try
            cnn.Open()
            mFiltro_Actual = cmd.ExecuteScalar
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
        If Len(mFiltro_Actual) <= 1 Then Return String.Empty
        Return mFiltro_Actual
        '
    End Function
    '
End Class
