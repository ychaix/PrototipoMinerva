Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class clsInd_TxDB
    '
    '   IdTx, Nivel, CodigoTx, IdTxPadre, DescripcionTemporal, Notas, TaxonPadre,
    '   TaxonTieneHijo, Sistema, IdCreado, IdUltimoCambio, IdBorradoL,
    '
    Public Shared Function lista(ByVal usuario As String, ByVal pwd As String, ByVal bd As String) As listInd_Tx
        Dim detList As New listInd_Tx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT IdTx, Nivel, CodigoTx, IdTxPadre, DescripcionTemporal, TaxonPadre, Notas, " &
            "       TaxonTieneHijo, Sistema, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_Tx " &
            "ORDER BY IdTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_Tx
            Do While rdr.Read
                det = New clsInd_Tx
                det.IdTx = CInt(rdr("IdTx"))
                If rdr("Nivel") Is DBNull.Value Then
                    det.Nivel = Nothing
                Else
                    det.Nivel = rdr("Nivel").ToString
                End If
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxPadre") Is DBNull.Value Then
                    det.IdTxPadre = Nothing
                Else
                    det.IdTxPadre = rdr("IdTxPadre").ToString
                End If
                '
                If rdr("DescripcionTemporal") Is DBNull.Value Then
                    det.DescripcionTemporal = Nothing
                Else
                    det.DescripcionTemporal = rdr("DescripcionTemporal").ToString
                End If
                '
                If rdr("TaxonPadre") Is DBNull.Value Then
                    det.TaxonPadre = Nothing
                Else
                    det.TaxonPadre = rdr("TaxonPadre").ToString
                End If
                '
                If rdr("TaxonTieneHijo") Is DBNull.Value Then
                    det.TaxonTieneHijo = Nothing
                Else
                    det.TaxonTieneHijo = rdr("TaxonTieneHijo").ToString
                End If
                '
                If rdr("Sistema") Is DBNull.Value Then
                    det.Sistema = Nothing
                Else
                    det.Sistema = rdr("Sistema").ToString
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
    Public Shared Function seleccionar(ByVal login As String, ByVal pwd As String, ByVal bd As String, ByVal id As Integer) As clsInd_Tx
        '
        Dim det As New clsInd_Tx
        Dim cnn As SqlConnection = clsDB.Conectar(login, pwd, bd)
        Dim strSQL As String =
            "SELECT IdTx, Nivel, CodigoTx, IdTxPadre, DescripcionTemporal, TaxonPadre, " &
            "       TaxonTieneHijo, Sistema, IdCreado, IdUltimoCambio, IdBorradoL " &
            "FROM   Ind_Tx " &
            "Where  IdTx = @IdTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTx", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdTx = CInt(rdr("IdTx"))
                If rdr("Nivel") Is DBNull.Value Then
                    det.Nivel = Nothing
                Else
                    det.Nivel = rdr("Nivel").ToString
                End If
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxPadre") Is DBNull.Value Then
                    det.IdTxPadre = Nothing
                Else
                    det.IdTxPadre = rdr("IdTxPadre").ToString
                End If
                '
                If rdr("DescripcionTemporal") Is DBNull.Value Then
                    det.DescripcionTemporal = Nothing
                Else
                    det.DescripcionTemporal = rdr("DescripcionTemporal").ToString
                End If
                '
                If rdr("TaxonPadre") Is DBNull.Value Then
                    det.TaxonPadre = Nothing
                Else
                    det.TaxonPadre = rdr("TaxonPadre").ToString
                End If
                '
                If rdr("TaxonTieneHijo") Is DBNull.Value Then
                    det.TaxonTieneHijo = Nothing
                Else
                    det.TaxonTieneHijo = rdr("TaxonTieneHijo").ToString
                End If
                '
                If rdr("Sistema") Is DBNull.Value Then
                    det.Sistema = Nothing
                Else
                    det.Sistema = rdr("Sistema").ToString
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
    Public Shared Function insertar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_Tx) As Integer
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
        "INSERT Ind_Tx  " &
        "       ( Nivel, CodigoTx, IdTxPadre, DescripcionTemporal, TaxonPadre, " &
        "           TaxonTieneHijo, Sistema, IdCreado, IdUltimoCambio, IdBorradoL ) " &
        "values ( @Nivel, @CodigoTx, @IdTxPadre, @DescripcionTemporal, @TaxonPadre, " &
        "           @TaxonTieneHijo, @Sistema, @IdCreado, @IdUltimoCambio, @IdBorradoL ) "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        '
        If det.Nivel = Nothing Then
            cmd.Parameters.AddWithValue("@Nivel", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Nivel", det.Nivel)
        End If
        '
        If det.CodigoTx Is Nothing Then
            cmd.Parameters.AddWithValue("@CodigoTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodigoTx", det.CodigoTx)
        End If
        '
        If det.IdTxPadre = Nothing Then
            cmd.Parameters.AddWithValue("@IdTxPadre", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTxPadre", det.IdTxPadre)
        End If
        '
        If det.DescripcionTemporal Is Nothing Then
            cmd.Parameters.AddWithValue("@DescripcionTemporal", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescripcionTemporal", det.DescripcionTemporal)
        End If
        '
        If det.TaxonPadre Is Nothing Then
            cmd.Parameters.AddWithValue("@TaxonPadre", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TaxonPadre", det.TaxonPadre)
        End If
        '
        cmd.Parameters.AddWithValue("@TaxonTieneHijo", det.TaxonTieneHijo)
        cmd.Parameters.AddWithValue("@Sistema", det.Sistema)
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
                "SELECT IDENT_CURRENT('Ind_Tx') FROM Ind_Tx"
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
    Public Shared Function actualizar(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal det As clsInd_Tx) As Boolean
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQL As String =
            "UPDATE Ind_Tx " &
            "SET " &
            "       Nivel                   = @Nivel,  " &
            "       CodigoTx                = @CodigoTx,  " &
            "       IdTxPadre               = @IdTxPadre,  " &
            "       DescripcionTemporal     = @DescripcionTemporal,  " &
            "       TaxonPadre              = @TaxonPadre,  " &
            "       TaxonTieneHijo          = @TaxonTieneHijo,  " &
            "       Sistema                 = @Sistema,  " &
            "       IdCreado                = @IdCreado,  " &
            "       IdUltimoCambio          = @IdUltimoCambio,  " &
            "       IdBorradoL              = @IdBorradoL  " &
            "WHERE  IdTx                    = @IdTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        If det.Nivel = Nothing Then
            cmd.Parameters.AddWithValue("@Nivel", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Nivel", det.Nivel)
        End If
        '
        If det.CodigoTx Is Nothing Then
            cmd.Parameters.AddWithValue("@CodigoTx", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@CodigoTx", det.CodigoTx)
        End If
        '
        If det.IdTxPadre = Nothing Then
            cmd.Parameters.AddWithValue("@IdTxPadre", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IdTxPadre", det.IdTxPadre)
        End If
        '
        If det.DescripcionTemporal Is Nothing Then
            cmd.Parameters.AddWithValue("@DescripcionTemporal", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DescripcionTemporal", det.DescripcionTemporal)
        End If
        '
        If det.TaxonPadre Is Nothing Then
            cmd.Parameters.AddWithValue("@TaxonPadre", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TaxonPadre", det.TaxonPadre)
        End If
        '
        If det.TaxonTieneHijo = Nothing Then
            cmd.Parameters.AddWithValue("@TaxonTieneHijo", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@TaxonTieneHijo", det.TaxonTieneHijo)
        End If
        '
        If det.Sistema = Nothing Then
            cmd.Parameters.AddWithValue("@Sistema", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@Sistema", det.Sistema)
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
        cmd.Parameters.AddWithValue("@IdTx", det.IdTx)
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
    Public Shared Function listaDescrip(ByVal usuario As String, ByVal pwd As String, ByVal bd As String, ByVal mFiltro As String) As listInd_Tx
        '
        '   IdTx, Nivel, CodigoTx, IdTxPadre, DescripcionTemporal, TaxonPadre,
        '   TaxonTieneHijo, Sistema, IdCreado, IdUltimoCambio, IdBorradoL,
        '   IdTxTrad, IdIdioma, DescripParaFormulario, DescripCortaTxTrad, DescripDetalleTxTrad, Aclaraciones
        '
        Dim detList As New listInd_Tx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT A.IdTx, A.Nivel, A.CodigoTx, B.IdTxTraducido as IdTxTrad, B.IdIdioma, " &
            "       B.DescripciónParaFormulario as DescripParaFormulario, " &
            "       B.DescCortaTxTraducida as DescripCortaTxTrad, " &
            "       B.DescrDetTxTraducida as DescripDetalleTxTrad, B.Aclaraciones " &
            "FROM   Ind_Tx A " &
            "   LEFT JOIN Ind_TxTraducido B on B.IdTx = A.IdTx "
        If mFiltro <> "" Then
            strSQL += " Where " + mFiltro
        End If
        strSQL += " ORDER BY A.Nivel, A.CodigoTx, B.IdIdioma "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_Tx
            Do While rdr.Read
                det = New clsInd_Tx
                det.IdTx = CInt(rdr("IdTx"))
                If rdr("Nivel") Is DBNull.Value Then
                    det.Nivel = Nothing
                Else
                    det.Nivel = rdr("Nivel").ToString
                End If
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxTrad") Is DBNull.Value Then
                    det.IdTxTrad = Nothing
                Else
                    det.IdTxTrad = CInt(rdr("IdTxTrad"))
                End If
                '
                If rdr("IdIdioma") Is DBNull.Value Then
                    det.IdIdioma = Nothing
                Else
                    det.IdIdioma = CInt(rdr("IdIdioma"))
                End If
                '
                If rdr("DescripParaFormulario") Is DBNull.Value Then
                    det.DescripParaFormulario = Nothing
                Else
                    det.DescripParaFormulario = rdr("DescripParaFormulario").ToString
                End If
                '
                If rdr("DescripCortaTxTrad") Is DBNull.Value Then
                    det.DescripCortaTxTrad = Nothing
                Else
                    det.DescripCortaTxTrad = rdr("DescripCortaTxTrad").ToString
                End If
                '
                If rdr("DescripDetalleTxTrad") Is DBNull.Value Then
                    det.DescripDetalleTxTrad = Nothing
                Else
                    det.DescripDetalleTxTrad = rdr("DescripDetalleTxTrad").ToString
                End If
                '
                If rdr("Aclaraciones") Is DBNull.Value Then
                    det.Aclaraciones = Nothing
                Else
                    det.Aclaraciones = rdr("Aclaraciones").ToString
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
    Public Shared Function listaArbol(usuario As String, pwd As String, bd As String, CodigoTx As String, IdIDioma As Integer) As listInd_Tx
        '
        '   IdTx, CodigoTx, IdTxPadre, DescripCortaTxTrad
        '
        Dim detList As New listInd_Tx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)

        '
        Dim strSQL As String =
            "WITH cteTx AS " &
            "(   " &
            "   Select IdTx, CodigoTx, IdTxPadre " &
            "   From Ind_Tx " &
            "   Where CodigoTx Like @CodigoTx and CodigoTx <> '*' and Len(CodigoTx) = Len(@CodigoTx) " &
            "   UNION ALL " &
            "   Select t.IdTx, t.CodigoTx, t.IdTxPadre " &
            "   From Ind_Tx As t  " &
            "   INNER Join	cteTx ON t.IdTx = t.IdTxPadre " &
            ") " &
            "Select X.IdTx, X.CodigoTx, X.IdTxPadre, X.CodigoTx + ' - ' + IsNull(D.DescCortaTxTraducida,'') DescripCortaTxTrad " &
            "From cteTx As X " &
            "     Join Ind_TxTraducido D on D.IdTx = X.IdTx " &
            "Where D.IdIdioma = @IdIdioma " &
            "Order By CodigoTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@CodigoTx", CodigoTx + "%")
        cmd.Parameters.AddWithValue("@IdIdioma", IdIDioma)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_Tx
            Do While rdr.Read
                det = New clsInd_Tx
                det.IdTx = CInt(rdr("IdTx"))
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxPadre") Is DBNull.Value Then
                    det.IdTxPadre = Nothing
                Else
                    det.IdTxPadre = CInt(rdr("IdTxPadre"))
                End If
                '     
                If rdr("DescripCortaTxTrad") Is DBNull.Value Then
                    det.DescripCortaTxTrad = Nothing
                Else
                    det.DescripCortaTxTrad = rdr("DescripCortaTxTrad").ToString
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
    Public Shared Function listaArbolCompleto(usuario As String, pwd As String, bd As String, IdIDioma As Integer) As listInd_Tx
        '
        '   IdTx, CodigoTx, IdTxPadre, DescripCortaTxTrad
        '
        Dim detList As New listInd_Tx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)

        '
        Dim strSQL As String =
            "WITH cteTx AS " &
            "(   " &
            "   Select IdTx, CodigoTx, IdTxPadre " &
            "   From Ind_Tx " &
            "   Where CodigoTx Like @CodigoTx and CodigoTx <> '*' and Len(CodigoTx) = Len(@CodigoTx) " &
            "   UNION ALL " &
            "   Select t.IdTx, t.CodigoTx, t.IdTxPadre " &
            "   From Ind_Tx As t  " &
            "   INNER Join cteTx C ON C.IdTx = t.IdTxPadre " &
            ") " &
            "Select X.IdTx, X.CodigoTx, X.IdTxPadre, X.CodigoTx + ' - ' + IsNull(D.DescCortaTxTraducida,'') DescripCortaTxTrad " &
            "From cteTx As X " &
            "     Join Ind_TxTraducido D on D.IdTx = X.IdTx " &
            "Where D.IdIdioma = @IdIdioma " &
            "Order By CodigoTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@CodigoTx", "%")
        cmd.Parameters.AddWithValue("@IdIdioma", IdIDioma)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_Tx
            Do While rdr.Read
                det = New clsInd_Tx
                det.IdTx = CInt(rdr("IdTx"))
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxPadre") Is DBNull.Value Then
                    det.IdTxPadre = Nothing
                Else
                    det.IdTxPadre = CInt(rdr("IdTxPadre"))
                End If
                '     
                If rdr("DescripCortaTxTrad") Is DBNull.Value Then
                    det.DescripCortaTxTrad = Nothing
                Else
                    det.DescripCortaTxTrad = rdr("DescripCortaTxTrad").ToString
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
    Public Shared Function listaTxHijosAccess(bd As String, IdTxpadre As Integer, IdIDioma As Integer) As listInd_Tx
        '
        '   IdTx, CodigoTx, IdTxPadre, DescripCortaTxTrad
        '
        Dim detList As New listInd_Tx
        Dim cnn As OleDbConnection = clsDB.ConectarAccess(bd)
        '
        Dim strSQL As String =
            "Select Ind_Tx.IdTx, Ind_Tx.CodigoTx, Ind_Tx.IdTxPadre, Ind_TxTraducido.DescCortaTxTraducida " &
            "From Ind_Tx " &
            "     Right Join Ind_TxTraducido on Ind_TxTraducido.IdTx = Ind_Tx.IdTx " &
            "Where Ind_Tx.IdTxPadre = @IdTxpadre and Ind_TxTraducido.IdIdioma = @IdIdioma " &
            "Order By Ind_Tx.CodigoTx "
        '
        Dim cmd As New OleDbCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTxPadre", IdTxpadre)
        cmd.Parameters.AddWithValue("@IdIdioma", IdIDioma)
        Try
            cnn.Open()
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            Dim det As clsInd_Tx

            Do While rdr.Read
                det = New clsInd_Tx
                det.IdTx = CInt(rdr("IdTx"))
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxPadre") Is DBNull.Value Then
                    det.IdTxPadre = Nothing
                Else
                    det.IdTxPadre = CInt(rdr("IdTxPadre"))
                End If
                '     
                If rdr("DescCortaTxTraducida") Is DBNull.Value Then
                    det.DescCortaTxTraducida = Nothing
                    det.DescripCortaTxTrad = Nothing
                Else
                    det.DescCortaTxTraducida = rdr("DescCortaTxTraducida").ToString
                    det.DescripCortaTxTrad = rdr("CodigoTx").ToString + " - " + rdr("DescCortaTxTraducida").ToString
                End If
                '               
                detList.Add(det)
            Loop
            rdr.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            cnn.Close()
        End Try
        Return detList
        '
    End Function
    '
    Public Shared Function listaTxHijosSQL(usuario As String, pwd As String, bd As String, IdTxpadre As Integer, IdIDioma As Integer) As listInd_Tx
        '
        '   IdTx, CodigoTx, IdTxPadre, DescripCortaTxTrad
        '
        Dim detList As New listInd_Tx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "Select A.IdTx, A.CodigoTx, A.IdTxPadre, A.CodigoTx + ' - ' + IsNull(B.DescCortaTxTraducida,'') DescripCortaTxTrad " &
            "From Ind_Tx A " &
            "     Join Ind_TxTraducido B on B.IdTx = A.IdTx " &
            "Where IdTxPadre = @IdTxpadre and B.IdIdioma = @IdIdioma " &
            "Order By CodigoTx "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTxPadre", IdTxpadre)
        cmd.Parameters.AddWithValue("@IdIdioma", IdIDioma)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_Tx
            Do While rdr.Read
                det = New clsInd_Tx
                det.IdTx = CInt(rdr("IdTx"))
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxPadre") Is DBNull.Value Then
                    det.IdTxPadre = Nothing
                Else
                    det.IdTxPadre = CInt(rdr("IdTxPadre"))
                End If
                '     
                If rdr("DescripCortaTxTrad") Is DBNull.Value Then
                    det.DescripCortaTxTrad = Nothing
                Else
                    det.DescripCortaTxTrad = rdr("DescripCortaTxTrad").ToString
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
    Public Shared Function existenHijos(usuario As String, pwd As String, bd As String, mTx As String) As Boolean
        '
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQl As String =
            "Select count(*) as cuenta from Ind_Tx " &
            "where  CodigoTx like @CodigoTx "
        '
        Dim cmd As New SqlCommand(strSQl, cnn)
        cmd.Parameters.AddWithValue("@CodigoTx", mTx & "%")
        ' 
        Try
            cnn.Open()
            Dim count As Integer = cmd.ExecuteScalar
            If count > 1 Then
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
    Public Shared Function existeCodigoTx(usuario As String, pwd As String, bd As String, mTx As String) As Boolean
        '
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQl As String =
            "Select count(*) as cuenta from Ind_Tx " &
            "where  CodigoTx = @CodigoTx "
        '
        Dim cmd As New SqlCommand(strSQl, cnn)
        cmd.Parameters.AddWithValue("@CodigoTx", mTx)
        ' 
        Try
            cnn.Open()
            Dim count As Integer = cmd.ExecuteScalar
            If count = 1 Then
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
    Public Shared Function permiteMasHijos(usuario As String, pwd As String, bd As String, mTx As String) As Boolean
        '
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        Dim strSQl As String =
            "Select count(*) as cuenta from Ind_Tx " &
            "where  IdTxPadre = @IdTxPadre "
        '
        Dim cmd As New SqlCommand(strSQl, cnn)
        cmd.Parameters.AddWithValue("@IdTxPadre", mTx)
        ' 
        Try
            cnn.Open()
            Dim count As Integer = cmd.ExecuteScalar
            If count < 34 Then
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
    Public Shared Function seleccionarDescrip(usuario As String, pwd As String, bd As String, id As Integer, IdIdioma As Integer) As clsInd_Tx
        '
        '   IdTx, Nivel, CodigoTx, IdTxPadre, DescripcionTemporal, TaxonPadre,
        '   TaxonTieneHijo, Sistema, IdCreado, IdUltimoCambio, IdBorradoL,
        '   IdTxTrad, IdIdioma, DescripciónParaFormulario, DescripCortaTxTrad, DescripDetalleTxTrad, Aclaraciones
        '
        Dim det As New clsInd_Tx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT A.IdTx, A.Nivel, A.CodigoTx, B.IdTxTraducido as IdTxTrad, B.IdIdioma, " &
            "       B.DescripciónParaFormulario as DescripParaFormulario, B.DescCortaTxTraducida as DescripCortaTxTrad, " &
            "       B.DescrDetTxTraducida as DescripDetalleTxTrad, B.Aclaraciones " &
            "FROM   Ind_Tx A " &
            "       LEFT JOIN Ind_TxTraducido B on B.IdTx = A.IdTx " &
            "Where  A.IdTx = @IdTx and B.IdIdioma = @IdIdioma "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTx", id)
        cmd.Parameters.AddWithValue("@IdIdioma", IdIdioma)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If rdr.Read Then
                det.IdTx = CInt(rdr("IdTx"))
                If rdr("Nivel") Is DBNull.Value Then
                    det.Nivel = Nothing
                Else
                    det.Nivel = rdr("Nivel").ToString
                End If
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxTrad") Is DBNull.Value Then
                    det.IdTxTrad = Nothing
                Else
                    det.IdTxTrad = CInt(rdr("IdTxTrad"))
                End If
                '
                If rdr("IdIdioma") Is DBNull.Value Then
                    det.IdIdioma = Nothing
                Else
                    det.IdIdioma = CInt(rdr("IdIdioma"))
                End If
                '
                If rdr("DescripParaFormulario") Is DBNull.Value Then
                    det.DescripParaFormulario = Nothing
                Else
                    det.DescripParaFormulario = rdr("DescripParaFormulario").ToString
                End If
                '
                If rdr("DescripCortaTxTrad") Is DBNull.Value Then
                    det.DescripCortaTxTrad = Nothing
                Else
                    det.DescripCortaTxTrad = rdr("DescripCortaTxTrad").ToString
                End If
                '
                If rdr("DescripDetalleTxTrad") Is DBNull.Value Then
                    det.DescripDetalleTxTrad = Nothing
                Else
                    det.DescripDetalleTxTrad = rdr("DescripDetalleTxTrad").ToString
                End If
                '
                If rdr("Aclaraciones") Is DBNull.Value Then
                    det.Aclaraciones = Nothing
                Else
                    det.Aclaraciones = rdr("Aclaraciones").ToString
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
    Public Shared Function listaDescripTodas(usuario As String, pwd As String, bd As String, id As Integer) As listInd_Tx
        '
        '   IdTx, Nivel, CodigoTx, IdTxPadre, DescripcionTemporal, TaxonPadre,
        '   TaxonTieneHijo, Sistema, IdCreado, IdUltimoCambio, IdBorradoL,
        '   IdTxTrad, IdIdioma, DescripParaFormulario, DescripCortaTxTrad, DescripDetalleTxTrad, Aclaraciones
        '
        Dim detList As New listInd_Tx
        Dim cnn As SqlConnection = clsDB.Conectar(usuario, pwd, bd)
        '
        Dim strSQL As String =
            "SELECT A.IdTx, A.Nivel, A.CodigoTx, B.IdTxTraducido as IdTxTrad, B.IdIdioma, " &
            "       B.[DescripciónParaFormulario] as DescripParaFormulario, " &
            "       B.DescCortaTxTraducida as DescripCortaTxTrad, " &
            "       B.DescrDetTxTraducida as DescripDetalleTxTrad, B.Aclaraciones " &
            "FROM   Ind_Tx A " &
            "       LEFT JOIN Ind_TxTraducido B on B.IdTx = A.IdTx " &
            " Where A.IdTx = @IdTx " &
            " ORDER BY A.Nivel, A.CodigoTx, B.IdIdioma "
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@IdTx", id)
        Try
            cnn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim det As clsInd_Tx
            Do While rdr.Read
                det = New clsInd_Tx
                det.IdTx = CInt(rdr("IdTx"))
                If rdr("Nivel") Is DBNull.Value Then
                    det.Nivel = Nothing
                Else
                    det.Nivel = rdr("Nivel").ToString
                End If
                '
                If rdr("CodigoTx") Is DBNull.Value Then
                    det.CodigoTx = Nothing
                Else
                    det.CodigoTx = rdr("CodigoTx").ToString
                End If
                '
                If rdr("IdTxTrad") Is DBNull.Value Then
                    det.IdTxTrad = Nothing
                Else
                    det.IdTxTrad = CInt(rdr("IdTxTrad"))
                End If
                '
                If rdr("IdIdioma") Is DBNull.Value Then
                    det.IdIdioma = Nothing
                Else
                    det.IdIdioma = CInt(rdr("IdIdioma"))
                End If
                '
                If rdr("DescripParaFormulario") Is DBNull.Value Then
                    det.DescripParaFormulario = Nothing
                Else
                    det.DescripParaFormulario = rdr("DescripParaFormulario").ToString
                End If
                '
                If rdr("DescripCortaTxTrad") Is DBNull.Value Then
                    det.DescripCortaTxTrad = Nothing
                Else
                    det.DescripCortaTxTrad = rdr("DescripCortaTxTrad").ToString
                End If
                '
                If rdr("DescripDetalleTxTrad") Is DBNull.Value Then
                    det.DescripDetalleTxTrad = Nothing
                Else
                    det.DescripDetalleTxTrad = rdr("DescripDetalleTxTrad").ToString
                End If
                '
                If rdr("Aclaraciones") Is DBNull.Value Then
                    det.Aclaraciones = Nothing
                Else
                    det.Aclaraciones = rdr("Aclaraciones").ToString
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
