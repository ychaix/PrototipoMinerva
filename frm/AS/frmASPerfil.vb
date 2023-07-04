Imports clsDataLib
Public Class frmASPerfil
    Private lista As List(Of clsPerfil)
    Private det As clsPerfil
    Private bs As New BindingSource
    Private perfilAdmin As Boolean = False
    '
    ' ## Cargado de Datos
    '
    Private Sub frmASPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Try
            tabCtrl.Visible = True
            tabLista.Parent = tabCtrl
            tabDetalle.Parent = Nothing
            '
            perfilAdmin = clsUsuarioDB.selPerfilTipo(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, 1)
            tsbNuevo.Enabled = perfilAdmin
            Me.cargaListado()
            '
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub
    '
    Private Sub cargaListado()
        '
        lista = clsPerfilDB.lista(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato)
        bs.DataSource = lista
        bn.BindingSource = bs
        dgv.DataSource = bs
    End Sub
    '
    ' ## Manejo de Eventos
    '
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex <= 2 Then
            '
            '   IdPerfil, Perfil, UsuarioCrea, FechaCrea, UsuarioModifica, FechaModifica, Estado
            '
            tabLista.Parent = Nothing
            tabDetalle.Parent = tabCtrl
            '
            txtPerfil.Enabled = True
            '
            txtID.DataBindings.Add(New Binding("text", bs, "IdPerfil"))
            txtPerfil.DataBindings.Add(New Binding("text", bs, "Perfil"))
            '
            txtEstado.DataBindings.Add(New Binding("text", bs, "Estado"))

            chkActivo.Checked = (txtEstado.Text = "1")
            '
            txtUsuCrea.DataBindings.Add(New Binding("text", bs, "UsuarioCrea"))
            ' txtNomCrea.DataBindings.Add(New Binding("text", bs, "NombreCrea"))
            txtUsuModi.DataBindings.Add(New Binding("text", bs, "UsuarioModifica"))
            ' txtNomModi.DataBindings.Add(New Binding("text", bs, "NombreModifica"))
            txtFecCrea.DataBindings.Add(New Binding("text", bs, "FechaCrea"))
            txtFecModi.DataBindings.Add(New Binding("text", bs, "FechaModifica"))
            '
            tsbNuevo.Enabled = False
            '
            txtPerfil.Select()
            '
        End If
    End Sub
    '
    Private Sub chkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivo.CheckedChanged
        If chkActivo.Checked Then
            txtEstado.Text = "1"
        Else
            txtEstado.Text = "0"
        End If
    End Sub
    '
    Private Sub limpiaControles()
        txtID.DataBindings.Clear()
        txtPerfil.DataBindings.Clear()
        txtEstado.DataBindings.Clear()
        '
        txtUsuCrea.DataBindings.Clear()
        ' txtNomCrea.DataBindings.Clear()
        txtUsuModi.DataBindings.Clear()
        ' txtNomModi.DataBindings.Clear()
        txtFecCrea.DataBindings.Clear()
        txtFecModi.DataBindings.Clear()
    End Sub
    '
    ' ## Botones
    '
    Private Sub bn_RefreshItems(sender As Object, e As EventArgs) Handles bn.RefreshItems
        chkActivo.Checked = (txtEstado.Text = "1")
    End Sub
    '
    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        bn.BindingSource = Nothing
        tabLista.Parent = Nothing
        tabDetalle.Parent = tabCtrl
        '
        txtID.Text = ""
        txtPerfil.Text = ""
        txtEstado.Text = "1"
        tsbNuevo.Enabled = False
        txtID.Select()
    End Sub
    '
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
    '
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.limpiaControles()
        '
        tsbNuevo.Enabled = True
        '
        tabDetalle.Parent = Nothing
        tabLista.Parent = tabCtrl
        '
        Me.cargaListado()
        '
    End Sub
    '
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '
        '   IdPerfil, Perfil, UsuarioCrea, FechaCrea, UsuarioModifica, FechaModifica, Estado
        '
        If datosValidos() Then
            det = New clsPerfil
            '
            With det
                .Perfil = txtPerfil.Text
                .UsuarioCrea = Proy_Yves.m_Usuario
                .UsuarioModifica = Proy_Yves.m_Usuario
                .Estado = txtEstado.Text
            End With
            '
            If txtID.Text <> String.Empty Then
                det.IdPerfil = CInt(txtID.Text)
                clsPerfilDB.actualizar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, det)
            Else
                clsPerfilDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, det)
            End If
            '
            Me.cargaListado()
            btnRegresar.PerformClick()
            '
        End If
        '
    End Sub
    '
    ' ## Validaciones
    '
    Private Function datosValidos() As Boolean
        If txtPerfil.Text = String.Empty Then
            MessageBox.Show("Nombre de Perfil es un dato requerido, por favor revisar.", "Error")
            txtPerfil.Select()
            Return False
        Else
            Return True
        End If
        '
    End Function
    '
End Class