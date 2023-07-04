<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmASPerfil
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmASPerfil))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabCtrl = New System.Windows.Forms.TabControl()
        Me.tabLista = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.IdPerfilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flecha = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PerfilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioModificaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaModificaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsPerfil = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabDetalle = New System.Windows.Forms.TabPage()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.etqID = New System.Windows.Forms.Label()
        Me.txtPerfil = New System.Windows.Forms.TextBox()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.grpAudit = New System.Windows.Forms.GroupBox()
        Me.txtFecModi = New System.Windows.Forms.TextBox()
        Me.txtFecCrea = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNomModi = New System.Windows.Forms.TextBox()
        Me.txtNomCrea = New System.Windows.Forms.TextBox()
        Me.txtUsuModi = New System.Windows.Forms.TextBox()
        Me.txtUsuCrea = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblUsuModi = New System.Windows.Forms.Label()
        Me.lblUsuCrea = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        CType(Me.bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bn.SuspendLayout()
        Me.tabCtrl.SuspendLayout()
        Me.tabLista.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalle.SuspendLayout()
        Me.grpAudit.SuspendLayout()
        Me.SuspendLayout()
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
        Me.bn.Size = New System.Drawing.Size(860, 25)
        Me.bn.TabIndex = 7
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
        Me.tsbNuevo.Size = New System.Drawing.Size(92, 22)
        Me.tsbNuevo.Text = "Nuevo Perfil"
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
        Me.tsbSalir.ToolTipText = "Cerrar formulario"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tabCtrl
        '
        Me.tabCtrl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCtrl.Controls.Add(Me.tabLista)
        Me.tabCtrl.Controls.Add(Me.tabDetalle)
        Me.tabCtrl.Location = New System.Drawing.Point(0, 28)
        Me.tabCtrl.Name = "tabCtrl"
        Me.tabCtrl.SelectedIndex = 0
        Me.tabCtrl.Size = New System.Drawing.Size(860, 414)
        Me.tabCtrl.TabIndex = 8
        '
        'tabLista
        '
        Me.tabLista.Controls.Add(Me.dgv)
        Me.tabLista.Location = New System.Drawing.Point(4, 22)
        Me.tabLista.Name = "tabLista"
        Me.tabLista.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLista.Size = New System.Drawing.Size(852, 388)
        Me.tabLista.TabIndex = 0
        Me.tabLista.Text = "PERFILES"
        Me.tabLista.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPerfilDataGridViewTextBoxColumn, Me.flecha, Me.PerfilDataGridViewTextBoxColumn, Me.UsuarioModificaDataGridViewTextBoxColumn, Me.FechaModificaDataGridViewTextBoxColumn, Me.cEstado})
        Me.dgv.DataSource = Me.bsPerfil
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(846, 382)
        Me.dgv.TabIndex = 0
        '
        'IdPerfilDataGridViewTextBoxColumn
        '
        Me.IdPerfilDataGridViewTextBoxColumn.DataPropertyName = "IdPerfil"
        Me.IdPerfilDataGridViewTextBoxColumn.HeaderText = "IdPerfil"
        Me.IdPerfilDataGridViewTextBoxColumn.Name = "IdPerfilDataGridViewTextBoxColumn"
        Me.IdPerfilDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPerfilDataGridViewTextBoxColumn.Visible = False
        '
        'flecha
        '
        Me.flecha.HeaderText = ""
        Me.flecha.Image = CType(resources.GetObject("flecha.Image"), System.Drawing.Image)
        Me.flecha.Name = "flecha"
        Me.flecha.ReadOnly = True
        Me.flecha.Width = 20
        '
        'PerfilDataGridViewTextBoxColumn
        '
        Me.PerfilDataGridViewTextBoxColumn.DataPropertyName = "Perfil"
        Me.PerfilDataGridViewTextBoxColumn.HeaderText = "Perfil"
        Me.PerfilDataGridViewTextBoxColumn.Name = "PerfilDataGridViewTextBoxColumn"
        Me.PerfilDataGridViewTextBoxColumn.ReadOnly = True
        Me.PerfilDataGridViewTextBoxColumn.Width = 250
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
        'cEstado
        '
        Me.cEstado.DataPropertyName = "cEstado"
        Me.cEstado.HeaderText = "Estado"
        Me.cEstado.Name = "cEstado"
        Me.cEstado.ReadOnly = True
        Me.cEstado.Width = 120
        '
        'bsPerfil
        '
        Me.bsPerfil.DataSource = GetType(clsDataLib.clsPerfil)
        '
        'tabDetalle
        '
        Me.tabDetalle.Controls.Add(Me.txtID)
        Me.tabDetalle.Controls.Add(Me.chkActivo)
        Me.tabDetalle.Controls.Add(Me.etqID)
        Me.tabDetalle.Controls.Add(Me.txtPerfil)
        Me.tabDetalle.Controls.Add(Me.lblPerfil)
        Me.tabDetalle.Controls.Add(Me.grpAudit)
        Me.tabDetalle.Controls.Add(Me.btnRegresar)
        Me.tabDetalle.Controls.Add(Me.btnGuardar)
        Me.tabDetalle.Controls.Add(Me.txtEstado)
        Me.tabDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalle.Size = New System.Drawing.Size(852, 388)
        Me.tabDetalle.TabIndex = 1
        Me.tabDetalle.Text = "PERFIL"
        Me.tabDetalle.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(184, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(54, 20)
        Me.txtID.TabIndex = 47
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(348, 55)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 46
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'etqID
        '
        Me.etqID.AutoSize = True
        Me.etqID.Location = New System.Drawing.Point(150, 59)
        Me.etqID.Name = "etqID"
        Me.etqID.Size = New System.Drawing.Size(21, 13)
        Me.etqID.TabIndex = 45
        Me.etqID.Text = "ID:"
        Me.etqID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerfil
        '
        Me.txtPerfil.Location = New System.Drawing.Point(184, 93)
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(220, 20)
        Me.txtPerfil.TabIndex = 35
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Location = New System.Drawing.Point(131, 96)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(33, 13)
        Me.lblPerfil.TabIndex = 34
        Me.lblPerfil.Text = "Perfil:"
        '
        'grpAudit
        '
        Me.grpAudit.Controls.Add(Me.txtFecModi)
        Me.grpAudit.Controls.Add(Me.txtFecCrea)
        Me.grpAudit.Controls.Add(Me.Label6)
        Me.grpAudit.Controls.Add(Me.txtNomModi)
        Me.grpAudit.Controls.Add(Me.txtNomCrea)
        Me.grpAudit.Controls.Add(Me.txtUsuModi)
        Me.grpAudit.Controls.Add(Me.txtUsuCrea)
        Me.grpAudit.Controls.Add(Me.lblNombres)
        Me.grpAudit.Controls.Add(Me.lblUsuario)
        Me.grpAudit.Controls.Add(Me.lblUsuModi)
        Me.grpAudit.Controls.Add(Me.lblUsuCrea)
        Me.grpAudit.Enabled = False
        Me.grpAudit.Location = New System.Drawing.Point(83, 158)
        Me.grpAudit.Name = "grpAudit"
        Me.grpAudit.Size = New System.Drawing.Size(653, 105)
        Me.grpAudit.TabIndex = 27
        Me.grpAudit.TabStop = False
        Me.grpAudit.Text = "Auditoría"
        '
        'txtFecModi
        '
        Me.txtFecModi.Location = New System.Drawing.Point(501, 65)
        Me.txtFecModi.Name = "txtFecModi"
        Me.txtFecModi.Size = New System.Drawing.Size(121, 20)
        Me.txtFecModi.TabIndex = 18
        Me.txtFecModi.TabStop = False
        '
        'txtFecCrea
        '
        Me.txtFecCrea.Location = New System.Drawing.Point(501, 37)
        Me.txtFecCrea.Name = "txtFecCrea"
        Me.txtFecCrea.Size = New System.Drawing.Size(121, 20)
        Me.txtFecCrea.TabIndex = 17
        Me.txtFecCrea.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(524, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Fecha y Hora"
        '
        'txtNomModi
        '
        Me.txtNomModi.Location = New System.Drawing.Point(217, 65)
        Me.txtNomModi.Name = "txtNomModi"
        Me.txtNomModi.Size = New System.Drawing.Size(278, 20)
        Me.txtNomModi.TabIndex = 15
        Me.txtNomModi.TabStop = False
        '
        'txtNomCrea
        '
        Me.txtNomCrea.Location = New System.Drawing.Point(217, 37)
        Me.txtNomCrea.Name = "txtNomCrea"
        Me.txtNomCrea.Size = New System.Drawing.Size(278, 20)
        Me.txtNomCrea.TabIndex = 14
        Me.txtNomCrea.TabStop = False
        '
        'txtUsuModi
        '
        Me.txtUsuModi.Location = New System.Drawing.Point(111, 65)
        Me.txtUsuModi.Name = "txtUsuModi"
        Me.txtUsuModi.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuModi.TabIndex = 13
        Me.txtUsuModi.TabStop = False
        '
        'txtUsuCrea
        '
        Me.txtUsuCrea.Location = New System.Drawing.Point(111, 37)
        Me.txtUsuCrea.Name = "txtUsuCrea"
        Me.txtUsuCrea.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuCrea.TabIndex = 12
        Me.txtUsuCrea.TabStop = False
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(291, 21)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres.TabIndex = 11
        Me.lblNombres.Text = "Nombres"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(142, 21)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 10
        Me.lblUsuario.Text = "Usuario"
        '
        'lblUsuModi
        '
        Me.lblUsuModi.AutoSize = True
        Me.lblUsuModi.Location = New System.Drawing.Point(25, 65)
        Me.lblUsuModi.Name = "lblUsuModi"
        Me.lblUsuModi.Size = New System.Drawing.Size(80, 13)
        Me.lblUsuModi.TabIndex = 9
        Me.lblUsuModi.Text = "Modificado por:"
        '
        'lblUsuCrea
        '
        Me.lblUsuCrea.AutoSize = True
        Me.lblUsuCrea.Location = New System.Drawing.Point(25, 40)
        Me.lblUsuCrea.Name = "lblUsuCrea"
        Me.lblUsuCrea.Size = New System.Drawing.Size(62, 13)
        Me.lblUsuCrea.TabIndex = 8
        Me.lblUsuCrea.Text = "Creado por:"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.Location = New System.Drawing.Point(646, 93)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(90, 28)
        Me.btnRegresar.TabIndex = 7
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(646, 55)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 28)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(678, 97)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(51, 20)
        Me.txtEstado.TabIndex = 31
        '
        'frmASPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.bn)
        Me.Controls.Add(Me.tabCtrl)
        Me.Name = "frmASPerfil"
        Me.Text = "AS - Perfiles de Usuarios"
        CType(Me.bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bn.ResumeLayout(False)
        Me.bn.PerformLayout()
        Me.tabCtrl.ResumeLayout(False)
        Me.tabLista.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalle.ResumeLayout(False)
        Me.tabDetalle.PerformLayout()
        Me.grpAudit.ResumeLayout(False)
        Me.grpAudit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents etqID As Label
    Friend WithEvents txtPerfil As TextBox
    Friend WithEvents lblPerfil As Label
    Friend WithEvents grpAudit As GroupBox
    Friend WithEvents txtFecModi As TextBox
    Friend WithEvents txtFecCrea As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNomModi As TextBox
    Friend WithEvents txtNomCrea As TextBox
    Friend WithEvents txtUsuModi As TextBox
    Friend WithEvents txtUsuCrea As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblUsuModi As Label
    Friend WithEvents lblUsuCrea As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents bsPerfil As BindingSource
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents IdPerfilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents flecha As DataGridViewImageColumn
    Friend WithEvents PerfilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioModificaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaModificaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cEstado As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
