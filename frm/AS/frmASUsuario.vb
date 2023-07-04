Imports clsDataLib
Public Class frmASUsuario
    Private lista As List(Of clsUsuario)
    Private perfil As List(Of clsPerfil)
    Private det As clsUsuario
    Private newUsuario As clsUsuario
    '
    Private bs As New BindingSource
    Private perfilAdmin As Boolean = False
    Private cargado As Boolean = False
    '
    Private Sub frmASUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Try
            perfil = New List(Of clsPerfil)
            perfil = clsPerfilDB.lista(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato)
            cboPerfil.DataSource = perfil
            '
            perfilAdmin = clsUsuarioDB.selPerfilTipo(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, 1)
            tabCtrl.Visible = True
            If perfilAdmin Then
                tabLista.Parent = tabCtrl
                tabDetalle.Parent = Nothing
                tabPermisos.Parent = Nothing
                Me.cargaListado()
                cargado = True
            Else
                tabLista.Parent = Nothing
                tabDetalle.Parent = tabCtrl
                tabPermisos.Parent = Nothing
                cargaUsuario(Proy_Yves.m_IDUsuario)
                Me.Text = "EDITAR USUARIO"
                cboPerfil.Enabled = False
                cboPerfil.Select()
            End If
            '            
            tsbNuevo.Enabled = perfilAdmin
            '
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub
    '
    Private Sub cargaListado()
        '
        lista = clsUsuarioDB.lista(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato)
        bs.DataSource = lista
        bn.BindingSource = bs
        dgv.DataSource = bs
        '
    End Sub
    '
    Private Sub cargaUsuario(ByVal id As Integer)
        det = New clsUsuario
        det = clsUsuarioDB.seleccionar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, id)
        txtIdUsuario.Text = det.idUsuario.ToString
        txtUsuario.Text = det.Usuario
        txtPasswd.Text = det.PassEncrypt
        txtNombres.Text = det.Nombres
        cboPerfil.SelectedValue = det.idPerfil
        txtEmail.Text = det.Correo_Electronico
        txtCelular.Text = det.Celular
        chkActivo.Checked = det.Estado = "1"
        chkEsAdministrador.Checked = det.Es_Administrador = 1
        chkTipoAcceso.Checked = det.Tipo_Acceso = 1
        chkExpiraClave.Checked = det.Req_Cambio_Clave = 1
        '
        txtDiasVencimiento.Text = det.Frecuencia_Clave.ToString
        txtLimiteIntentos.Text = det.Limite_Intentos.ToString
        dtpUltimoCambio.Value = det.Fecha_Ult_Clave
        '
        grpExpiraClave.Enabled = perfilAdmin
        txtDiasVencimiento.Enabled = False
        txtLimiteIntentos.Enabled = False
        dtpUltimoCambio.Enabled = False
        '
        chkActivo.Enabled = perfilAdmin
        chkEsAdministrador.Enabled = perfilAdmin
        chkTipoAcceso.Enabled = perfilAdmin
        cboPerfil.Enabled = perfilAdmin
        '
        txtIdUsuario.Focus()
    End Sub
    '
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex <= 2 Then
            '            
            '   idUsuario, Usuario, Nombres, PassEncrypt, idPerfil, UsuarioCrea, FechaCrea, UsuarioModifica, FechaModifica, Estado, Perfil, cEstado
            '
            tabLista.Parent = Nothing
            tabDetalle.Parent = tabCtrl
            tabPermisos.Parent = tabCtrl
            '
            txtNombres.Enabled = True
            '
            tsbNuevo.Enabled = False
            '
            grpExpiraClave.Enabled = True
            '            
            cargaUsuario(CInt(dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value.ToString))
            'cargaPermisos(CInt(dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value.ToString))
            '
            grpCambiarPwd.Enabled = True
            desactivaCambiarClave()
            cboPerfil.Select()
            '
        End If
    End Sub
    '
    Private Sub bn_RefreshItems(sender As Object, e As EventArgs) Handles bn.RefreshItems
        If cargado Then
            cargaUsuario(CInt(dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value.ToString))
        End If
    End Sub
    '
    Private Sub chkEsAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles chkEsAdministrador.CheckedChanged
        If chkEsAdministrador.Checked Then
            chkTipoAcceso.Checked = False
        End If
    End Sub

    Private Sub chkTipoAcceso_CheckedChanged(sender As Object, e As EventArgs) Handles chkTipoAcceso.CheckedChanged
        If chkTipoAcceso.Checked Then
            chkEsAdministrador.Checked = False
        End If
    End Sub
    '
    Private Sub chkCambiarClave_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCambiarClave.CheckedChanged
        If chkCambiarClave.Checked Then
            Me.activaCambiarClave()
        Else
            Me.desactivaCambiarClave()
        End If
    End Sub
    '
    Private Sub chkExpiraClave_CheckedChanged(sender As Object, e As EventArgs) Handles chkExpiraClave.CheckedChanged
        If chkExpiraClave.Checked Then
            txtDiasVencimiento.Enabled = True
            txtLimiteIntentos.Enabled = True
        Else
            txtDiasVencimiento.Enabled = False
            txtLimiteIntentos.Enabled = False
        End If
    End Sub
    '
    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        tabLista.Parent = Nothing
        tabDetalle.Parent = tabCtrl
        '
        txtUsuario.Enabled = True
        txtPasswd.Enabled = True
        txtIdUsuario.Text = "0"
        txtUsuario.Text = ""
        txtPasswd.Text = ""
        txtNombres.Text = ""
        cboPerfil.SelectedValue = -1
        '        
        Me.Text = "AGREGAR USUARIO"
        grpCambiarPwd.Enabled = False
        txtUsuario.Focus()
    End Sub
    '
    Private Sub activaCambiarClave()
        txtNombres.Enabled = False
        cboPerfil.Enabled = False
        txtEmail.Enabled = False
        txtCelular.Enabled = False
        grpExpiraClave.Enabled = False
        '
        txtClave.Enabled = True
        txtNuevaClave.Enabled = True
        txtRepetirClave.Enabled = True
        txtClave.Text = ""
        txtNuevaClave.Text = ""
        txtRepetirClave.Text = ""
    End Sub
    '
    Private Sub desactivaCambiarClave()
        txtNombres.Enabled = True
        txtEmail.Enabled = True
        txtCelular.Enabled = True
        cboPerfil.Enabled = perfilAdmin
        grpExpiraClave.Enabled = perfilAdmin
        '
        txtClave.Enabled = False
        txtNuevaClave.Enabled = False
        txtRepetirClave.Enabled = False
        txtClave.Text = ""
        txtNuevaClave.Text = ""
        txtRepetirClave.Text = ""
    End Sub
    ' 
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        '
        If perfilAdmin Then
            tsbNuevo.Enabled = True
            txtUsuario.Enabled = False
            txtPasswd.Enabled = False
            '
            tabDetalle.Parent = Nothing
            tabLista.Parent = tabCtrl
            '
            Me.cargaListado()
        Else
            Me.Close()
        End If
    End Sub
    '
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If datosValidos() Then
            newUsuario = New clsUsuario
            With newUsuario
                .Usuario = txtUsuario.Text
                .PassEncrypt = txtPasswd.Text
                .Nombres = txtNombres.Text
                .idPerfil = CInt(cboPerfil.SelectedValue.ToString)
                .Correo_Electronico = txtEmail.Text
                .Celular = txtCelular.Text
                .Estado = IIf(chkActivo.Checked, "1", "0")
                .Es_Administrador = IIf(chkEsAdministrador.Checked And chkTipoAcceso.Checked = False, 1, 0)
                .Tipo_Acceso = IIf(chkEsAdministrador.Checked = False And chkTipoAcceso.Checked = True, 1, 0)
                .Req_Cambio_Clave = IIf(chkExpiraClave.Checked, 1, 0)
                .Frecuencia_Clave = CInt(txtDiasVencimiento.Text)
                .Limite_Intentos = CInt(txtLimiteIntentos.Text)
                .Fecha_Ult_Clave = dtpUltimoCambio.Value
                '
                .UsuarioCrea = Proy_Yves.m_Usuario
                .UsuarioModifica = Proy_Yves.m_Usuario
            End With
            If txtIdUsuario.Text = "0" Then
                Try
                    newUsuario.idUsuario = clsUsuarioDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, newUsuario)
                    clsUsuarioDB.insertarLogin(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txtUsuario.Text.ToLower(), txtPasswd.Text)
                    clsUsuarioDB.actClave(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txtPasswd.Text, newUsuario.idUsuario)
                    MessageBox.Show("Usuario insertado correctamente ...", "AGREGAR USUARIO")
                    Me.DialogResult = DialogResult.OK
                    btnRegresar.PerformClick()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.GetType.ToString)
                End Try
            Else
                Try
                    If chkCambiarClave.Checked Then
                        clsUsuarioDB.actLoginPasswd(Proy_Yves.m_Usuario, Proy_Yves.m_Clave.ToLower(), Proy_Yves.m_BaseDato, txtNuevaClave.Text)
                        clsUsuarioDB.actClave(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txtNuevaClave.Text, CInt(txtIdUsuario.Text))
                        Proy_Yves.m_Clave = txtNuevaClave.Text
                    Else
                        newUsuario.idUsuario = CInt(txtIdUsuario.Text)
                        clsUsuarioDB.actualizar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, newUsuario)
                    End If
                    MessageBox.Show("Datos actualizados correctamente ... ", "ACTUALIZA USUARIO")
                    btnRegresar.PerformClick()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Otro usuario ha actualizado o borrado este USUARIO", "Error en Base de Datos")
                    Me.DialogResult = DialogResult.Retry
                End Try
            End If
        End If
    End Sub
    '
    Private Function datosValidos() As Boolean
        Dim m_Ok As Boolean = False
        If chkCambiarClave.Checked = True Then
            If txtClave.Text <> Proy_Yves.m_Clave Then
                MessageBox.Show("Contraseña no válida ... ", "ERROR EN CONTRASEÑA")
            Else
                If Validar.existe(txtNuevaClave) And Validar.existe(txtRepetirClave) Then
                    If txtClave.Text <> txtNuevaClave.Text And txtNuevaClave.Text = txtRepetirClave.Text Then
                        m_Ok = True
                    Else
                        MessageBox.Show("Error en validación de nueva contraseña ... ", "CAMBIO DE CONTRASEÑA")
                    End If
                End If
            End If
        Else
            If clsUsuarioDB.existeUsuario(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txtUsuario.Text) Then
                If txtIdUsuario.Text = "0" Then
                    MessageBox.Show("Error en validación, Usuario registrado anteriormente. ", "USUARIO " & txtUsuario.Text & " YA EXISTE...")
                End If
            End If
            If Validar.existe(txtUsuario) And Validar.existe(txtNombres) And Validar.existe(cboPerfil) Then
                m_Ok = True
            End If
        End If
        Return m_Ok
        '
    End Function
    '
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
    '
End Class