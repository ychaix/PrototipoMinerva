<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmASUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblClave As System.Windows.Forms.Label
        Dim lblUsuario As System.Windows.Forms.Label
        Dim lblPerfil As System.Windows.Forms.Label
        Dim lblNombres As System.Windows.Forms.Label
        Dim lblRepetir As System.Windows.Forms.Label
        Dim lblNueva As System.Windows.Forms.Label
        Dim lblActual As System.Windows.Forms.Label
        Dim lblID As System.Windows.Forms.Label
        Dim lblEmail As System.Windows.Forms.Label
        Dim lblCelular As System.Windows.Forms.Label
        Dim lblDias As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmASUsuario))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.cboPerfil = New System.Windows.Forms.ComboBox()
        Me.bsPerfil = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.grpCambiarPwd = New System.Windows.Forms.GroupBox()
        Me.chkCambiarClave = New System.Windows.Forms.CheckBox()
        Me.txtRepetirClave = New System.Windows.Forms.TextBox()
        Me.txtNuevaClave = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tabCtrl = New System.Windows.Forms.TabControl()
        Me.tabLista = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flecha = New System.Windows.Forms.DataGridViewImageColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElectronicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerfilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioModificaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaModificaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassEncryptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPerfilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsAdministradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoAccesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReqCambioClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrecuenciaClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimiteIntentosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioCreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsUsuario = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabDetalle = New System.Windows.Forms.TabPage()
        Me.chkEsAdministrador = New System.Windows.Forms.CheckBox()
        Me.grpExpiraClave = New System.Windows.Forms.GroupBox()
        Me.dtpUltimoCambio = New System.Windows.Forms.DateTimePicker()
        Me.chkExpiraClave = New System.Windows.Forms.CheckBox()
        Me.txtDiasVencimiento = New System.Windows.Forms.TextBox()
        Me.txtLimiteIntentos = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.chkTipoAcceso = New System.Windows.Forms.CheckBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtIdUsuario = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tabPermisos = New System.Windows.Forms.TabPage()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        lblClave = New System.Windows.Forms.Label()
        lblUsuario = New System.Windows.Forms.Label()
        lblPerfil = New System.Windows.Forms.Label()
        lblNombres = New System.Windows.Forms.Label()
        lblRepetir = New System.Windows.Forms.Label()
        lblNueva = New System.Windows.Forms.Label()
        lblActual = New System.Windows.Forms.Label()
        lblID = New System.Windows.Forms.Label()
        lblEmail = New System.Windows.Forms.Label()
        lblCelular = New System.Windows.Forms.Label()
        lblDias = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.bsPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCambiarPwd.SuspendLayout()
        CType(Me.bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bn.SuspendLayout()
        Me.tabCtrl.SuspendLayout()
        Me.tabLista.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalle.SuspendLayout()
        Me.grpExpiraClave.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClave
        '
        lblClave.AutoSize = True
        lblClave.Location = New System.Drawing.Point(54, 131)
        lblClave.Name = "lblClave"
        lblClave.Size = New System.Drawing.Size(37, 13)
        lblClave.TabIndex = 38
        lblClave.Text = "Clave:"
        '
        'lblUsuario
        '
        lblUsuario.AutoSize = True
        lblUsuario.Location = New System.Drawing.Point(54, 92)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New System.Drawing.Size(46, 13)
        lblUsuario.TabIndex = 33
        lblUsuario.Text = "Usuario:"
        '
        'lblPerfil
        '
        lblPerfil.AutoSize = True
        lblPerfil.Location = New System.Drawing.Point(67, 227)
        lblPerfil.Name = "lblPerfil"
        lblPerfil.Size = New System.Drawing.Size(33, 13)
        lblPerfil.TabIndex = 24
        lblPerfil.Text = "Perfil:"
        '
        'lblNombres
        '
        lblNombres.AutoSize = True
        lblNombres.Location = New System.Drawing.Point(48, 190)
        lblNombres.Name = "lblNombres"
        lblNombres.Size = New System.Drawing.Size(52, 13)
        lblNombres.TabIndex = 28
        lblNombres.Text = "Nombres:"
        '
        'lblRepetir
        '
        lblRepetir.AutoSize = True
        lblRepetir.Location = New System.Drawing.Point(11, 103)
        lblRepetir.Name = "lblRepetir"
        lblRepetir.Size = New System.Drawing.Size(44, 13)
        lblRepetir.TabIndex = 5
        lblRepetir.Text = "Repetir:"
        lblRepetir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNueva
        '
        lblNueva.AutoSize = True
        lblNueva.Location = New System.Drawing.Point(11, 74)
        lblNueva.Name = "lblNueva"
        lblNueva.Size = New System.Drawing.Size(42, 13)
        lblNueva.TabIndex = 3
        lblNueva.Text = "Nueva:"
        '
        'lblActual
        '
        lblActual.AutoSize = True
        lblActual.Location = New System.Drawing.Point(11, 48)
        lblActual.Name = "lblActual"
        lblActual.Size = New System.Drawing.Size(40, 13)
        lblActual.TabIndex = 1
        lblActual.Text = "Actual:"
        '
        'lblID
        '
        lblID.AutoSize = True
        lblID.Location = New System.Drawing.Point(79, 53)
        lblID.Name = "lblID"
        lblID.Size = New System.Drawing.Size(21, 13)
        lblID.TabIndex = 43
        lblID.Text = "ID:"
        '
        'lblEmail
        '
        lblEmail.AutoSize = True
        lblEmail.Location = New System.Drawing.Point(65, 265)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New System.Drawing.Size(35, 13)
        lblEmail.TabIndex = 47
        lblEmail.Text = "Email:"
        '
        'lblCelular
        '
        lblCelular.AutoSize = True
        lblCelular.Location = New System.Drawing.Point(58, 301)
        lblCelular.Name = "lblCelular"
        lblCelular.Size = New System.Drawing.Size(42, 13)
        lblCelular.TabIndex = 49
        lblCelular.Text = "Celular:"
        '
        'lblDias
        '
        lblDias.AutoSize = True
        lblDias.Location = New System.Drawing.Point(238, 21)
        lblDias.Name = "lblDias"
        lblDias.Size = New System.Drawing.Size(91, 13)
        lblDias.TabIndex = 52
        lblDias.Text = "Dias vencimiento:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(21, 57)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(94, 13)
        Label1.TabIndex = 54
        Label1.Text = "Límite de intentos:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(200, 57)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(76, 13)
        Label2.TabIndex = 56
        Label2.Text = "Último cambio:"
        '
        'txtPasswd
        '
        Me.txtPasswd.Enabled = False
        Me.txtPasswd.Location = New System.Drawing.Point(106, 120)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswd.Size = New System.Drawing.Size(100, 20)
        Me.txtPasswd.TabIndex = 1
        Me.txtPasswd.Tag = "Clave"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(106, 85)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Tag = "Usuario"
        '
        'cboPerfil
        '
        Me.cboPerfil.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsPerfil, "IdPerfil", True))
        Me.cboPerfil.DataSource = Me.bsPerfil
        Me.cboPerfil.DisplayMember = "Perfil"
        Me.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPerfil.FormattingEnabled = True
        Me.cboPerfil.Location = New System.Drawing.Point(106, 225)
        Me.cboPerfil.Name = "cboPerfil"
        Me.cboPerfil.Size = New System.Drawing.Size(237, 21)
        Me.cboPerfil.TabIndex = 3
        Me.cboPerfil.Tag = "Perfil"
        Me.cboPerfil.ValueMember = "idPerfil"
        '
        'bsPerfil
        '
        Me.bsPerfil.DataSource = GetType(clsDataLib.clsPerfil)
        '
        'txtNombres
        '
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Location = New System.Drawing.Point(106, 190)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(367, 20)
        Me.txtNombres.TabIndex = 2
        Me.txtNombres.Tag = "Nombres"
        '
        'grpCambiarPwd
        '
        Me.grpCambiarPwd.Controls.Add(Me.chkCambiarClave)
        Me.grpCambiarPwd.Controls.Add(Me.txtRepetirClave)
        Me.grpCambiarPwd.Controls.Add(lblRepetir)
        Me.grpCambiarPwd.Controls.Add(Me.txtNuevaClave)
        Me.grpCambiarPwd.Controls.Add(lblNueva)
        Me.grpCambiarPwd.Controls.Add(Me.txtClave)
        Me.grpCambiarPwd.Controls.Add(lblActual)
        Me.grpCambiarPwd.Location = New System.Drawing.Point(256, 30)
        Me.grpCambiarPwd.Name = "grpCambiarPwd"
        Me.grpCambiarPwd.Size = New System.Drawing.Size(217, 139)
        Me.grpCambiarPwd.TabIndex = 36
        Me.grpCambiarPwd.TabStop = False
        '
        'chkCambiarClave
        '
        Me.chkCambiarClave.AutoSize = True
        Me.chkCambiarClave.Location = New System.Drawing.Point(45, 18)
        Me.chkCambiarClave.Name = "chkCambiarClave"
        Me.chkCambiarClave.Size = New System.Drawing.Size(132, 17)
        Me.chkCambiarClave.TabIndex = 7
        Me.chkCambiarClave.Text = "Cambio de contraseña"
        Me.chkCambiarClave.UseVisualStyleBackColor = True
        '
        'txtRepetirClave
        '
        Me.txtRepetirClave.Location = New System.Drawing.Point(61, 100)
        Me.txtRepetirClave.Name = "txtRepetirClave"
        Me.txtRepetirClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepetirClave.Size = New System.Drawing.Size(145, 20)
        Me.txtRepetirClave.TabIndex = 2
        Me.txtRepetirClave.Tag = "Repetir Nueva Clave"
        '
        'txtNuevaClave
        '
        Me.txtNuevaClave.Location = New System.Drawing.Point(61, 72)
        Me.txtNuevaClave.Name = "txtNuevaClave"
        Me.txtNuevaClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevaClave.Size = New System.Drawing.Size(145, 20)
        Me.txtNuevaClave.TabIndex = 1
        Me.txtNuevaClave.Tag = "Nueva Clave"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(61, 45)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(145, 20)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Tag = "Clave Actual"
        '
        'bn
        '
        Me.bn.AddNewItem = Nothing
        Me.bn.CountItem = Me.BindingNavigatorCountItem
        Me.bn.DeleteItem = Nothing
        Me.bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsbNuevo, Me.ToolStripSeparator1, Me.tsbSalir, Me.ToolStripSeparator2})
        Me.bn.Location = New System.Drawing.Point(0, 0)
        Me.bn.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bn.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bn.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bn.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bn.Name = "bn"
        Me.bn.PositionItem = Me.BindingNavigatorPositionItem
        Me.bn.Size = New System.Drawing.Size(922, 25)
        Me.bn.TabIndex = 39
        Me.bn.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(105, 22)
        Me.tsbNuevo.Text = "Nuevo Usuario"
        '
        'tabCtrl
        '
        Me.tabCtrl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCtrl.Controls.Add(Me.tabLista)
        Me.tabCtrl.Controls.Add(Me.tabDetalle)
        Me.tabCtrl.Controls.Add(Me.tabPermisos)
        Me.tabCtrl.Location = New System.Drawing.Point(0, 28)
        Me.tabCtrl.Name = "tabCtrl"
        Me.tabCtrl.SelectedIndex = 0
        Me.tabCtrl.Size = New System.Drawing.Size(922, 520)
        Me.tabCtrl.TabIndex = 40
        '
        'tabLista
        '
        Me.tabLista.Controls.Add(Me.dgv)
        Me.tabLista.Location = New System.Drawing.Point(4, 22)
        Me.tabLista.Name = "tabLista"
        Me.tabLista.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLista.Size = New System.Drawing.Size(914, 494)
        Me.tabLista.TabIndex = 0
        Me.tabLista.Text = "USUARIOS"
        Me.tabLista.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuarioDataGridViewTextBoxColumn, Me.flecha, Me.UsuarioDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.CorreoElectronicoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.PerfilDataGridViewTextBoxColumn, Me.CEstadoDataGridViewTextBoxColumn, Me.UsuarioModificaDataGridViewTextBoxColumn, Me.FechaModificaDataGridViewTextBoxColumn, Me.PassEncryptDataGridViewTextBoxColumn, Me.IdPerfilDataGridViewTextBoxColumn, Me.EsAdministradorDataGridViewTextBoxColumn, Me.TipoAccesoDataGridViewTextBoxColumn, Me.ReqCambioClaveDataGridViewTextBoxColumn, Me.FrecuenciaClaveDataGridViewTextBoxColumn, Me.LimiteIntentosDataGridViewTextBoxColumn, Me.FechaUltClaveDataGridViewTextBoxColumn, Me.UsuarioCreaDataGridViewTextBoxColumn, Me.FechaCreaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.bsUsuario
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(908, 488)
        Me.dgv.TabIndex = 0
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        Me.IdUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'flecha
        '
        Me.flecha.HeaderText = ""
        Me.flecha.Image = CType(resources.GetObject("flecha.Image"), System.Drawing.Image)
        Me.flecha.Name = "flecha"
        Me.flecha.ReadOnly = True
        Me.flecha.Width = 25
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Width = 250
        '
        'CorreoElectronicoDataGridViewTextBoxColumn
        '
        Me.CorreoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "Correo_Electronico"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo_Electronico"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.Name = "CorreoElectronicoDataGridViewTextBoxColumn"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoElectronicoDataGridViewTextBoxColumn.Width = 250
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        Me.CelularDataGridViewTextBoxColumn.Width = 200
        '
        'PerfilDataGridViewTextBoxColumn
        '
        Me.PerfilDataGridViewTextBoxColumn.DataPropertyName = "Perfil"
        Me.PerfilDataGridViewTextBoxColumn.HeaderText = "Perfil"
        Me.PerfilDataGridViewTextBoxColumn.Name = "PerfilDataGridViewTextBoxColumn"
        Me.PerfilDataGridViewTextBoxColumn.ReadOnly = True
        Me.PerfilDataGridViewTextBoxColumn.Width = 150
        '
        'CEstadoDataGridViewTextBoxColumn
        '
        Me.CEstadoDataGridViewTextBoxColumn.DataPropertyName = "cEstado"
        Me.CEstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.CEstadoDataGridViewTextBoxColumn.Name = "CEstadoDataGridViewTextBoxColumn"
        Me.CEstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioModificaDataGridViewTextBoxColumn
        '
        Me.UsuarioModificaDataGridViewTextBoxColumn.DataPropertyName = "UsuarioModifica"
        Me.UsuarioModificaDataGridViewTextBoxColumn.HeaderText = "UsuarioModifica"
        Me.UsuarioModificaDataGridViewTextBoxColumn.Name = "UsuarioModificaDataGridViewTextBoxColumn"
        Me.UsuarioModificaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaModificaDataGridViewTextBoxColumn
        '
        Me.FechaModificaDataGridViewTextBoxColumn.DataPropertyName = "FechaModifica"
        Me.FechaModificaDataGridViewTextBoxColumn.HeaderText = "FechaModifica"
        Me.FechaModificaDataGridViewTextBoxColumn.Name = "FechaModificaDataGridViewTextBoxColumn"
        Me.FechaModificaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PassEncryptDataGridViewTextBoxColumn
        '
        Me.PassEncryptDataGridViewTextBoxColumn.DataPropertyName = "PassEncrypt"
        Me.PassEncryptDataGridViewTextBoxColumn.HeaderText = "PassEncrypt"
        Me.PassEncryptDataGridViewTextBoxColumn.Name = "PassEncryptDataGridViewTextBoxColumn"
        Me.PassEncryptDataGridViewTextBoxColumn.ReadOnly = True
        Me.PassEncryptDataGridViewTextBoxColumn.Visible = False
        '
        'IdPerfilDataGridViewTextBoxColumn
        '
        Me.IdPerfilDataGridViewTextBoxColumn.DataPropertyName = "idPerfil"
        Me.IdPerfilDataGridViewTextBoxColumn.HeaderText = "idPerfil"
        Me.IdPerfilDataGridViewTextBoxColumn.Name = "IdPerfilDataGridViewTextBoxColumn"
        Me.IdPerfilDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPerfilDataGridViewTextBoxColumn.Visible = False
        '
        'EsAdministradorDataGridViewTextBoxColumn
        '
        Me.EsAdministradorDataGridViewTextBoxColumn.DataPropertyName = "Es_Administrador"
        Me.EsAdministradorDataGridViewTextBoxColumn.HeaderText = "Es_Administrador"
        Me.EsAdministradorDataGridViewTextBoxColumn.Name = "EsAdministradorDataGridViewTextBoxColumn"
        Me.EsAdministradorDataGridViewTextBoxColumn.ReadOnly = True
        Me.EsAdministradorDataGridViewTextBoxColumn.Visible = False
        '
        'TipoAccesoDataGridViewTextBoxColumn
        '
        Me.TipoAccesoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Acceso"
        Me.TipoAccesoDataGridViewTextBoxColumn.HeaderText = "Tipo_Acceso"
        Me.TipoAccesoDataGridViewTextBoxColumn.Name = "TipoAccesoDataGridViewTextBoxColumn"
        Me.TipoAccesoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoAccesoDataGridViewTextBoxColumn.Visible = False
        '
        'ReqCambioClaveDataGridViewTextBoxColumn
        '
        Me.ReqCambioClaveDataGridViewTextBoxColumn.DataPropertyName = "Req_Cambio_Clave"
        Me.ReqCambioClaveDataGridViewTextBoxColumn.HeaderText = "Req_Cambio_Clave"
        Me.ReqCambioClaveDataGridViewTextBoxColumn.Name = "ReqCambioClaveDataGridViewTextBoxColumn"
        Me.ReqCambioClaveDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReqCambioClaveDataGridViewTextBoxColumn.Visible = False
        '
        'FrecuenciaClaveDataGridViewTextBoxColumn
        '
        Me.FrecuenciaClaveDataGridViewTextBoxColumn.DataPropertyName = "Frecuencia_Clave"
        Me.FrecuenciaClaveDataGridViewTextBoxColumn.HeaderText = "Frecuencia_Clave"
        Me.FrecuenciaClaveDataGridViewTextBoxColumn.Name = "FrecuenciaClaveDataGridViewTextBoxColumn"
        Me.FrecuenciaClaveDataGridViewTextBoxColumn.ReadOnly = True
        Me.FrecuenciaClaveDataGridViewTextBoxColumn.Visible = False
        '
        'LimiteIntentosDataGridViewTextBoxColumn
        '
        Me.LimiteIntentosDataGridViewTextBoxColumn.DataPropertyName = "Limite_Intentos"
        Me.LimiteIntentosDataGridViewTextBoxColumn.HeaderText = "Limite_Intentos"
        Me.LimiteIntentosDataGridViewTextBoxColumn.Name = "LimiteIntentosDataGridViewTextBoxColumn"
        Me.LimiteIntentosDataGridViewTextBoxColumn.ReadOnly = True
        Me.LimiteIntentosDataGridViewTextBoxColumn.Visible = False
        '
        'FechaUltClaveDataGridViewTextBoxColumn
        '
        Me.FechaUltClaveDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Ult_Clave"
        Me.FechaUltClaveDataGridViewTextBoxColumn.HeaderText = "Fecha_Ult_Clave"
        Me.FechaUltClaveDataGridViewTextBoxColumn.Name = "FechaUltClaveDataGridViewTextBoxColumn"
        Me.FechaUltClaveDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaUltClaveDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioCreaDataGridViewTextBoxColumn
        '
        Me.UsuarioCreaDataGridViewTextBoxColumn.DataPropertyName = "UsuarioCrea"
        Me.UsuarioCreaDataGridViewTextBoxColumn.HeaderText = "UsuarioCrea"
        Me.UsuarioCreaDataGridViewTextBoxColumn.Name = "UsuarioCreaDataGridViewTextBoxColumn"
        Me.UsuarioCreaDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioCreaDataGridViewTextBoxColumn.Visible = False
        '
        'FechaCreaDataGridViewTextBoxColumn
        '
        Me.FechaCreaDataGridViewTextBoxColumn.DataPropertyName = "FechaCrea"
        Me.FechaCreaDataGridViewTextBoxColumn.HeaderText = "FechaCrea"
        Me.FechaCreaDataGridViewTextBoxColumn.Name = "FechaCreaDataGridViewTextBoxColumn"
        Me.FechaCreaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCreaDataGridViewTextBoxColumn.Visible = False
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        '
        'bsUsuario
        '
        Me.bsUsuario.DataSource = GetType(clsDataLib.clsUsuario)
        '
        'tabDetalle
        '
        Me.tabDetalle.Controls.Add(Me.chkEsAdministrador)
        Me.tabDetalle.Controls.Add(Me.grpExpiraClave)
        Me.tabDetalle.Controls.Add(Me.txtCelular)
        Me.tabDetalle.Controls.Add(lblCelular)
        Me.tabDetalle.Controls.Add(Me.txtEmail)
        Me.tabDetalle.Controls.Add(lblEmail)
        Me.tabDetalle.Controls.Add(Me.chkTipoAcceso)
        Me.tabDetalle.Controls.Add(Me.chkActivo)
        Me.tabDetalle.Controls.Add(lblID)
        Me.tabDetalle.Controls.Add(Me.txtIdUsuario)
        Me.tabDetalle.Controls.Add(Me.btnRegresar)
        Me.tabDetalle.Controls.Add(Me.btnGuardar)
        Me.tabDetalle.Controls.Add(Me.grpCambiarPwd)
        Me.tabDetalle.Controls.Add(Me.txtNombres)
        Me.tabDetalle.Controls.Add(lblClave)
        Me.tabDetalle.Controls.Add(lblNombres)
        Me.tabDetalle.Controls.Add(Me.txtPasswd)
        Me.tabDetalle.Controls.Add(Me.cboPerfil)
        Me.tabDetalle.Controls.Add(lblUsuario)
        Me.tabDetalle.Controls.Add(lblPerfil)
        Me.tabDetalle.Controls.Add(Me.txtUsuario)
        Me.tabDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalle.Size = New System.Drawing.Size(914, 494)
        Me.tabDetalle.TabIndex = 1
        Me.tabDetalle.Text = "USUARIO"
        Me.tabDetalle.UseVisualStyleBackColor = True
        '
        'chkEsAdministrador
        '
        Me.chkEsAdministrador.AutoSize = True
        Me.chkEsAdministrador.Location = New System.Drawing.Point(106, 155)
        Me.chkEsAdministrador.Name = "chkEsAdministrador"
        Me.chkEsAdministrador.Size = New System.Drawing.Size(104, 17)
        Me.chkEsAdministrador.TabIndex = 4
        Me.chkEsAdministrador.Text = "Es Administrador"
        Me.chkEsAdministrador.UseVisualStyleBackColor = True
        '
        'grpExpiraClave
        '
        Me.grpExpiraClave.Controls.Add(lblDias)
        Me.grpExpiraClave.Controls.Add(Me.dtpUltimoCambio)
        Me.grpExpiraClave.Controls.Add(Me.chkExpiraClave)
        Me.grpExpiraClave.Controls.Add(Label2)
        Me.grpExpiraClave.Controls.Add(Me.txtDiasVencimiento)
        Me.grpExpiraClave.Controls.Add(Label1)
        Me.grpExpiraClave.Controls.Add(Me.txtLimiteIntentos)
        Me.grpExpiraClave.Location = New System.Drawing.Point(70, 330)
        Me.grpExpiraClave.Name = "grpExpiraClave"
        Me.grpExpiraClave.Size = New System.Drawing.Size(407, 89)
        Me.grpExpiraClave.TabIndex = 58
        Me.grpExpiraClave.TabStop = False
        '
        'dtpUltimoCambio
        '
        Me.dtpUltimoCambio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpUltimoCambio.Location = New System.Drawing.Point(282, 54)
        Me.dtpUltimoCambio.Name = "dtpUltimoCambio"
        Me.dtpUltimoCambio.Size = New System.Drawing.Size(95, 20)
        Me.dtpUltimoCambio.TabIndex = 3
        '
        'chkExpiraClave
        '
        Me.chkExpiraClave.AutoSize = True
        Me.chkExpiraClave.Location = New System.Drawing.Point(26, 20)
        Me.chkExpiraClave.Name = "chkExpiraClave"
        Me.chkExpiraClave.Size = New System.Drawing.Size(147, 17)
        Me.chkExpiraClave.TabIndex = 0
        Me.chkExpiraClave.Text = "Expiración de Contraseña"
        Me.chkExpiraClave.UseVisualStyleBackColor = True
        '
        'txtDiasVencimiento
        '
        Me.txtDiasVencimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasVencimiento.Location = New System.Drawing.Point(335, 18)
        Me.txtDiasVencimiento.Name = "txtDiasVencimiento"
        Me.txtDiasVencimiento.Size = New System.Drawing.Size(42, 20)
        Me.txtDiasVencimiento.TabIndex = 1
        Me.txtDiasVencimiento.Tag = "Dias vencimiento"
        Me.txtDiasVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLimiteIntentos
        '
        Me.txtLimiteIntentos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLimiteIntentos.Location = New System.Drawing.Point(121, 54)
        Me.txtLimiteIntentos.Name = "txtLimiteIntentos"
        Me.txtLimiteIntentos.Size = New System.Drawing.Size(52, 20)
        Me.txtLimiteIntentos.TabIndex = 2
        Me.txtLimiteIntentos.Tag = "Usuario"
        Me.txtLimiteIntentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Location = New System.Drawing.Point(106, 295)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(367, 20)
        Me.txtCelular.TabIndex = 5
        Me.txtCelular.Tag = "Celular"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(106, 260)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(367, 20)
        Me.txtEmail.TabIndex = 4
        Me.txtEmail.Tag = "Correo Electrónico"
        '
        'chkTipoAcceso
        '
        Me.chkTipoAcceso.AutoSize = True
        Me.chkTipoAcceso.Location = New System.Drawing.Point(377, 225)
        Me.chkTipoAcceso.Name = "chkTipoAcceso"
        Me.chkTipoAcceso.Size = New System.Drawing.Size(91, 17)
        Me.chkTipoAcceso.TabIndex = 45
        Me.chkTipoAcceso.Text = "Solo Consulta"
        Me.chkTipoAcceso.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(178, 53)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 44
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.Enabled = False
        Me.txtIdUsuario.Location = New System.Drawing.Point(106, 50)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(42, 20)
        Me.txtIdUsuario.TabIndex = 0
        Me.txtIdUsuario.Tag = "ID"
        Me.txtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.Location = New System.Drawing.Point(256, 439)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(90, 28)
        Me.btnRegresar.TabIndex = 40
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(383, 439)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 28)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tabPermisos
        '
        Me.tabPermisos.Location = New System.Drawing.Point(4, 22)
        Me.tabPermisos.Name = "tabPermisos"
        Me.tabPermisos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPermisos.Size = New System.Drawing.Size(914, 494)
        Me.tabPermisos.TabIndex = 2
        Me.tabPermisos.Text = "PERMISOS DE USUARIO"
        Me.tabPermisos.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PassEncrypt"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PassEncrypt"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(59, 22)
        Me.tsbSalir.Text = "Cerrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'frmASUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabCtrl)
        Me.Controls.Add(Me.bn)
        Me.Name = "frmASUsuario"
        Me.Text = "Control de Usuarios del Sistema"
        CType(Me.bsPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCambiarPwd.ResumeLayout(False)
        Me.grpCambiarPwd.PerformLayout()
        CType(Me.bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bn.ResumeLayout(False)
        Me.bn.PerformLayout()
        Me.tabCtrl.ResumeLayout(False)
        Me.tabLista.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalle.ResumeLayout(False)
        Me.tabDetalle.PerformLayout()
        Me.grpExpiraClave.ResumeLayout(False)
        Me.grpExpiraClave.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents cboPerfil As ComboBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents grpCambiarPwd As GroupBox
    Friend WithEvents chkCambiarClave As CheckBox
    Friend WithEvents txtRepetirClave As TextBox
    Friend WithEvents txtNuevaClave As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents bn As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tabCtrl As TabControl
    Friend WithEvents tabLista As TabPage
    Friend WithEvents dgv As DataGridView
    Friend WithEvents tabDetalle As TabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents bsPerfil As BindingSource
    Friend WithEvents txtIdUsuario As TextBox
    Friend WithEvents grpExpiraClave As GroupBox
    Friend WithEvents dtpUltimoCambio As DateTimePicker
    Friend WithEvents chkExpiraClave As CheckBox
    Friend WithEvents txtDiasVencimiento As TextBox
    Friend WithEvents txtLimiteIntentos As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents chkTipoAcceso As CheckBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents chkEsAdministrador As CheckBox
    Friend WithEvents bsUsuario As BindingSource
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents flecha As DataGridViewImageColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoElectronicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerfilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioModificaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaModificaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassEncryptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPerfilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EsAdministradorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoAccesoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReqCambioClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FrecuenciaClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimiteIntentosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioCreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tabPermisos As TabPage
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
