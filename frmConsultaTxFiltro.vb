Imports clsDataLib
Public Class frmConsultaTxFiltro
    Private sFiltro As String = frmConsultaTaxon.filtroViejo
    '
    Private Sub frmConsultaTxFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sFiltro = clsFiltrosDB.LeerFiltro(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, "ConsultaTaxon")
        If sFiltro <> String.Empty Then
            btnQuitar.Enabled = True
            Me.indicarFiltros()
        End If
        lblTitulo.Select()
    End Sub
    '
    Private Sub indicarFiltros()
        Dim mPos1 As Integer
        Dim mPos2 As Integer
        Dim mTexto As String
        '
        mPos1 = InStr(sFiltro, "A.CodigoTx >= '")
        If mPos1 > 0 Then
            mPos1 = mPos1 + 15
            mPos2 = InStr(mPos1, sFiltro, "'")
            mTexto = Mid(sFiltro, mPos1, mPos2 - mPos1)
            txtCodTxDesde.Text = mTexto
        End If
        '
        mPos1 = InStr(sFiltro, "A.CodigoTx like '")
        If mPos1 > 0 Then
            mPos1 = mPos1 + 17
            mPos2 = InStr(mPos1, sFiltro, "%'")
            mTexto = Mid(sFiltro, mPos1, mPos2 - mPos1)
            txtCodTxDesde.Text = mTexto
        End If
        '
        mPos1 = InStr(sFiltro, "A.CodigoTx <= '")
        If mPos1 > 0 Then
            mPos1 = mPos1 + 15
            mPos2 = InStr(mPos1, sFiltro, "%'")
            mTexto = Mid(sFiltro, mPos1, mPos2 - mPos1)
            txtCodTxHasta.Text = mTexto
        End If
        '
        '
        mPos1 = InStr(sFiltro, "A.Nivel >= '")
        If mPos1 > 0 Then
            mPos1 = mPos1 + 12
            mPos2 = InStr(mPos1, sFiltro, "'")
            mTexto = Mid(sFiltro, mPos1, mPos2 - mPos1)
            txtNivelDesde.Text = mTexto
        End If
        '
        mPos1 = InStr(sFiltro, "A.Nivel = '")
        If mPos1 > 0 Then
            mPos1 = mPos1 + 11
            mPos2 = InStr(mPos1, sFiltro, "'")
            mTexto = Mid(sFiltro, mPos1, mPos2 - mPos1)
            txtNivelDesde.Text = mTexto
        End If
        '
        mPos1 = InStr(sFiltro, "A.Nivel <= '")
        If mPos1 > 0 Then
            mPos1 = mPos1 + 12
            mPos2 = InStr(mPos1, sFiltro, "'")
            mTexto = Mid(sFiltro, mPos1, mPos2 - mPos1)
            txtNivelHasta.Text = mTexto
        End If
        '
        '
        mPos1 = InStr(sFiltro, "B.IdIdioma = '")
        If mPos1 > 0 Then
            mPos1 = mPos1 + 14
            mPos2 = InStr(mPos1, sFiltro, "'")
            mTexto = Mid(sFiltro, mPos1, mPos2 - mPos1)
            txtIdiomaDesde.Text = mTexto
        End If
        '
    End Sub
    '
    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        sFiltro = String.Empty
        '
        If txtCodTxDesde.Text <> String.Empty Then
            If txtCodTxHasta.Text <> String.Empty Then
                sFiltro += " A.CodigoTx >= '" + txtCodTxDesde.Text + "' and A.CodigoTx <= '" + txtCodTxHasta.Text + "%' "
            Else
                sFiltro += " A.CodigoTx like '" + txtCodTxDesde.Text + "%' "
            End If
        Else
            If txtCodTxHasta.Text <> String.Empty Then
                sFiltro += " A.CodigoTx like '" + txtCodTxHasta.Text + "%' "
            End If
        End If
        '
        If txtNivelDesde.Text <> String.Empty Then
            If txtNivelHasta.Text <> String.Empty Then
                If sFiltro <> String.Empty Then
                    sFiltro += " And "
                End If
                sFiltro += " A.Nivel >= '" + txtNivelDesde.Text + "' and A.Nivel <= '" + txtNivelHasta.Text + "' "
            Else
                If sFiltro <> String.Empty Then
                    sFiltro += " And "
                End If
                sFiltro += " A.Nivel = '" + txtNivelDesde.Text + "' "
            End If
        Else
            If txtNivelHasta.Text <> String.Empty Then
                If sFiltro <> String.Empty Then
                    sFiltro += " And "
                End If
                sFiltro += " A.Nivel = '" + txtNivelHasta.Text + "' "
            End If
        End If
        '
        If txtIdiomaDesde.Text <> String.Empty Then
            If sFiltro <> String.Empty Then
                sFiltro += " And "
            End If
            sFiltro += " B.IdIdioma = '" + txtIdiomaDesde.Text + "' "
        End If
        '
        If sFiltro <> String.Empty Then
            Dim newFiltro As New clsFiltros
            With newFiltro
                .mModulo = "ConsultaTaxon"
                .Filtro = sFiltro
                .Estado = "1"
            End With
            If clsFiltrosDB.ExisteFiltro(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, "ConsultaTaxon") Then
                clsFiltrosDB.actualizar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, newFiltro)
            Else
                clsFiltrosDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, newFiltro)
            End If
        End If
        frmConsultaTaxon.filtroViejo = sFiltro
        Me.Close()
    End Sub
    '
    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If clsFiltrosDB.ExisteFiltro(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, "ConsultaTaxon") Then
            Dim newFiltro As New clsFiltros
            With newFiltro
                .mModulo = "ConsultaTaxon"
                .Filtro = " "
                .Estado = "0"
            End With
            clsFiltrosDB.actualizar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, newFiltro)
        End If
        frmConsultaTaxon.filtroViejo = String.Empty
        Me.Close()
    End Sub
    '
End Class