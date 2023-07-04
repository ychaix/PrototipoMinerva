Imports clsDataLib
Public Class frmArbolTx
    '
    Public idTx As Integer
    '
    Private detList As listInd_Tx
    Private detTrad As clsInd_TxTraducido
    Private listaAtr As listInd_AtrTx
    Private detAtrTx As clsInd_AtrTx
    Private bs As New BindingSource
    Private perfilAdmin As Boolean = False
    Private cargado As Boolean = False
    '
    Private Sub frmArbolTx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabDetalle.Parent = Nothing
        tabDatos.Parent = tabCtrl
        Me.cargaDetalles(idTx)
        cargado = True
    End Sub
    '
    Private Sub frmArbolTx_GotFocus(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        Me.cargaDetalles(idTx)
    End Sub
    '
    Private Sub cargaDetalles(idTx As Integer)
        detList = New listInd_Tx
        detList = clsInd_TxDB.listaDescripTodas(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, idTx)
        '
        lblID.Text = detList(0).IdTxTrad
        txtDescForm_ES.Text = detList(0).DescripParaFormulario
        txtDescCorta_ES.Text = detList(0).DescripCortaTxTrad
        txtDescDet_ES.Text = detList(0).DescripDetalleTxTrad
        txtAclarac_ES.Text = detList(0).Aclaraciones
        '
        txtDescForm_EN.Text = detList(1).DescripParaFormulario
        txtDescCorta_EN.Text = detList(1).DescripCortaTxTrad
        txtDescDet_EN.Text = detList(1).DescripDetalleTxTrad
        txtAclarac_EN.Text = detList(1).Aclaraciones
        '
        txtDescForm_FR.Text = detList(2).DescripParaFormulario
        txtDescCorta_FR.Text = detList(2).DescripCortaTxTrad
        txtDescDet_FR.Text = detList(2).DescripDetalleTxTrad
        txtAclarac_FR.Text = detList(2).Aclaraciones
        '
        listaAtr = New listInd_AtrTx
        listaAtr = clsInd_AtrTxDB.listaTx(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, idTx)
        bs.DataSource = listaAtr
        bnAtrTx.BindingSource = bs
        dgvIndAtrTx.DataSource = bs
        ' JUST FOR THE LOOK
        dgvIndAtrTx.GridColor = Color.FromArgb(211, 222, 229)
        dgvIndAtrTx.RowsDefaultCellStyle.BackColor = Color.AliceBlue
        dgvIndAtrTx.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue
        dgvIndAtrTx.RowsDefaultCellStyle.SelectionForeColor = Color.White
        '
        tsbNuevo.Enabled = True
        tsbBorrar.Enabled = True
        tsbRegresar.Enabled = False
        tabListaAtrTx.Parent = tabAtrTx
        tabDetAtrTx.Parent = Nothing
        '
    End Sub
    '
    Private Sub tsbBorrar_Click(sender As Object, e As EventArgs) Handles tsbBorrar.Click
        ' Borrar Atributo de Taxon
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Guardar Descripciones
        '   IdTxTraducido, IdTx, IdIdioma, DescripciónParaFormulario, DescCortaTxTraducida, 
        '   DescrDetTxTraducida, Aclaraciones, IdCreado, IdUltimoCambio, IdBorradoL        
        '
        detTrad = New clsInd_TxTraducido
        '
        With detTrad
            .IdTx = idTx
            .IdIdioma = 5831
            .DescripciónParaFormulario = txtDescForm_ES.Text
            .DescCortaTxTraducida = txtDescCorta_ES.Text
            .DescrDetTxTraducida = txtDescDet_ES.Text
            .Aclaraciones = txtAclarac_ES.Text
            .IdCreado = 0
            .IdUltimoCambio = 0
            .IdBorradoL = 0
        End With
        '
        If lblID.Text <> String.Empty Then
            detTrad.IdTxTraducido = detList(0).IdTxTrad
            clsInd_TxTraducidoDB.actualizar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, detTrad)
            ' Actualizar cambio en Árbol            
            If Proy_Yves.m_IdIdioma = 5831 Then
                Dim mPos As Integer = InStr(Proy_Yves.treeTx.SelectedNode.Text, "-")
                Proy_Yves.treeTx.SelectedNode.Text = Mid(Proy_Yves.treeTx.SelectedNode.Text, 1, mPos) + " " + txtDescCorta_ES.Text
            End If
        Else
            clsInd_TxTraducidoDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, detTrad)
            '
        End If
        '
        detTrad = New clsInd_TxTraducido
        '
        With detTrad
            .IdTx = idTx
            .IdIdioma = 5832
            .DescripciónParaFormulario = txtDescForm_EN.Text
            .DescCortaTxTraducida = txtDescCorta_EN.Text
            .DescrDetTxTraducida = txtDescDet_EN.Text
            .Aclaraciones = txtAclarac_EN.Text
            .IdCreado = 0
            .IdUltimoCambio = 0
            .IdBorradoL = 0
        End With
        '
        If lblID.Text <> String.Empty Then
            detTrad.IdTxTraducido = detList(1).IdTxTrad
            clsInd_TxTraducidoDB.actualizar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, detTrad)
            ' Actualizar cambio en Árbol            
            If Proy_Yves.m_IdIdioma = 5832 Then
                Dim mPos As Integer = InStr(Proy_Yves.treeTx.SelectedNode.Text, "-")
                Proy_Yves.treeTx.SelectedNode.Text = Mid(Proy_Yves.treeTx.SelectedNode.Text, 1, mPos) + " " + txtDescCorta_EN.Text
            End If
        Else
            clsInd_TxTraducidoDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, detTrad)
            '
        End If
        '
        detTrad = New clsInd_TxTraducido
        '
        With detTrad
            .IdTx = idTx
            .IdIdioma = 5833
            .DescripciónParaFormulario = txtDescForm_FR.Text
            .DescCortaTxTraducida = txtDescCorta_FR.Text
            .DescrDetTxTraducida = txtDescDet_FR.Text
            .Aclaraciones = txtAclarac_FR.Text
            .IdCreado = 0
            .IdUltimoCambio = 0
            .IdBorradoL = 0
        End With
        '
        If lblID.Text <> String.Empty Then
            detTrad.IdTxTraducido = detList(2).IdTxTrad
            clsInd_TxTraducidoDB.actualizar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, detTrad)
            ' Actualizar cambio en Árbol            
            If Proy_Yves.m_IdIdioma = 5833 Then
                Dim mPos As Integer = InStr(Proy_Yves.treeTx.SelectedNode.Text, "-")
                Proy_Yves.treeTx.SelectedNode.Text = Mid(Proy_Yves.treeTx.SelectedNode.Text, 1, mPos) + " " + txtDescCorta_FR.Text
            End If
        Else
            clsInd_TxTraducidoDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, detTrad)
            '
        End If
        '
        MessageBox.Show("Datos guardados exitosamente ...")
        '
    End Sub
    '
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub
    '
    Private Sub cargaAtrTx(ByVal id As Integer)
        detAtrTx = New clsInd_AtrTx
        detAtrTx = clsInd_AtrTxDB.seleccionar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, id)
        '
        txtIdAtrTx.Text = detAtrTx.IdAtrTx.ToString
        txtCategoria.Text = detAtrTx.Categoria
        txtIdTipoAtrib.Text = detAtrTx.IdTipoAtributo
        txtNombAtrib.Text = detAtrTx.NombreAtributo
        txtOrden.Text = detAtrTx.NumeroOrdenAtributo.ToString
        '
        txtIDUniMed.Text = detAtrTx.IdUnidadDeMedida.ToString
        txtUniMed.Text = detAtrTx.UnidadMedidaAtributo
        '
        txtIdTablaValidac.Text = detAtrTx.IdTablaValidacion.ToString
        txtTablaValidac.Text = detAtrTx.NombreTabla
        txtTipoValidac.Text = detAtrTx.TipoValidacion
        txtValMin.Text = detAtrTx.ValorMinimo
        txtValMax.Text = detAtrTx.ValorMaximo
        txtIncrem.Text = detAtrTx.Incremento
        '
        chkModificable.Checked = detAtrTx.Modificable
        chkObligatorio.Checked = detAtrTx.Obligatorio
        chkMascarilla.Checked = detAtrTx.Mascarilla
        chkInterrogable.Checked = detAtrTx.Interrogable
        '
        lblIDAtrTx.Select()
        '
    End Sub
    '
    Private Sub dgvIndAtrTx_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIndAtrTx.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex <= 2 Then
            '            
            '   IdAtrTx, Categoria, DescripcionCategoria, IdTx, IdTipoAtributo, NombreAtributo, NumeroOrdenAtributo, UnidadMedidaAtributo, 
            '   IdUnidadDeMedida, TipoValidacion, AbreviacionTabla, IdTablaValidacion, NombreTabla, ValorMinimo, ValorMaximo, Incremento, 
            '   Icono, Modificable, Obligatorio, Mascarilla, Interrogable, IdCreado, IdUltimoCambio, IdBorradoL
            '
            tabListaAtrTx.Parent = Nothing
            tabDetAtrTx.Parent = tabAtrTx
            '
            tsbNuevo.Enabled = False
            tsbBorrar.Enabled = False
            tsbRegresar.Enabled = True
            '                       
            cargaAtrTx(CInt(dgvIndAtrTx.Rows(dgvIndAtrTx.CurrentRow.Index).Cells(0).Value.ToString))
            '
        End If
    End Sub
    '
    Private Sub bnAtrTx_RefreshItems(sender As Object, e As EventArgs) Handles bnAtrTx.RefreshItems
        If cargado Then
            If tsbRegresar.Enabled And dgvIndAtrTx.CurrentRow IsNot Nothing Then
                If dgvIndAtrTx.Rows(dgvIndAtrTx.CurrentRow.Index).Cells(0).Value IsNot Nothing Then
                    cargaAtrTx(CInt(dgvIndAtrTx.Rows(dgvIndAtrTx.CurrentRow.Index).Cells(0).Value.ToString))
                Else
                    tsbRegresar.PerformClick()
                End If
            Else
                tsbRegresar.PerformClick()
            End If
        End If
    End Sub
    '
    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        tabListaAtrTx.Parent = Nothing
        tabDetAtrTx.Parent = tabAtrTx
        '
        tsbNuevo.Enabled = False
        tsbBorrar.Enabled = False
        tsbRegresar.Enabled = True
        '
        txtIdAtrTx.Text = "0"
        txtCategoria.Text = detList(0).CodigoTx
        txtIdTipoAtrib.Text = ""
        txtNombAtrib.Text = ""
        txtOrden.Text = ""
        '
        txtIDUniMed.Text = ""
        txtUniMed.Text = ""
        '
        txtIdTablaValidac.Text = ""
        txtTablaValidac.Text = ""
        txtTipoValidac.Text = ""
        txtValMin.Text = ""
        txtValMax.Text = ""
        txtIncrem.Text = ""
        '
        chkModificable.Checked = False
        chkObligatorio.Checked = False
        chkMascarilla.Checked = False
        chkInterrogable.Checked = False
        '        
        lblIDAtrTx.Select()
        '
    End Sub
    '
    Private Sub tsbRegresar_Click(sender As Object, e As EventArgs) Handles tsbRegresar.Click
        tabListaAtrTx.Parent = tabAtrTx
        tabDetAtrTx.Parent = Nothing
        '
        tsbNuevo.Enabled = True
        tsbBorrar.Enabled = True
        tsbRegresar.Enabled = False
        '
    End Sub

    Private Sub btnGuardarAtr_Click(sender As Object, e As EventArgs) Handles btnGuardarAtr.Click

    End Sub
    '
End Class