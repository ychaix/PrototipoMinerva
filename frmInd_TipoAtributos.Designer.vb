<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInd_TipoAtributos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInd_TipoAtributos))
        Me.tabCtrl = New System.Windows.Forms.TabControl()
        Me.tabLista = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tabDetalle = New System.Windows.Forms.TabPage()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblDescripción = New System.Windows.Forms.Label()
        Me.txtClasificacion = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.grpAudit = New System.Windows.Forms.GroupBox()
        Me.txtFecModi = New System.Windows.Forms.TextBox()
        Me.txtFecCrea = New System.Windows.Forms.TextBox()
        Me.lblFecHor = New System.Windows.Forms.Label()
        Me.txtNomModi = New System.Windows.Forms.TextBox()
        Me.txtNomCrea = New System.Windows.Forms.TextBox()
        Me.txtUsuModi = New System.Windows.Forms.TextBox()
        Me.txtUsuCrea = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblUsuModi = New System.Windows.Forms.Label()
        Me.lblUsuCrea = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtActivo = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
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
        Me.bsIndTipoAtributos = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTipoAtributoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Arrow1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionTipoAtribDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDatoVisualizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDatoSalvadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FuenteDelValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MascarillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterrogableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultiidiomaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmbitoAtribDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabCtrl.SuspendLayout()
        Me.tabLista.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalle.SuspendLayout()
        Me.grpAudit.SuspendLayout()
        CType(Me.bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bn.SuspendLayout()
        CType(Me.bsIndTipoAtributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCtrl
        '
        Me.tabCtrl.Controls.Add(Me.tabLista)
        Me.tabCtrl.Controls.Add(Me.tabDetalle)
        Me.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrl.Location = New System.Drawing.Point(0, 25)
        Me.tabCtrl.Name = "tabCtrl"
        Me.tabCtrl.SelectedIndex = 0
        Me.tabCtrl.Size = New System.Drawing.Size(1056, 625)
        Me.tabCtrl.TabIndex = 122
        '
        'tabLista
        '
        Me.tabLista.Controls.Add(Me.dgv)
        Me.tabLista.Location = New System.Drawing.Point(4, 22)
        Me.tabLista.Name = "tabLista"
        Me.tabLista.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLista.Size = New System.Drawing.Size(1048, 599)
        Me.tabLista.TabIndex = 0
        Me.tabLista.Text = "Clsificaciones"
        Me.tabLista.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoAtributoDataGridViewTextBoxColumn, Me.Arrow1, Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionTipoAtribDataGridViewTextBoxColumn, Me.TipoDatoVisualizadoDataGridViewTextBoxColumn, Me.TipoDatoSalvadoDataGridViewTextBoxColumn, Me.FuenteDelValorDataGridViewTextBoxColumn, Me.MascarillaDataGridViewTextBoxColumn, Me.ValidacionDataGridViewTextBoxColumn, Me.InterrogableDataGridViewTextBoxColumn, Me.MultiidiomaDataGridViewTextBoxColumn, Me.AmbitoAtribDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.bsIndTipoAtributos
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(1042, 593)
        Me.dgv.TabIndex = 1
        '
        'tabDetalle
        '
        Me.tabDetalle.Controls.Add(Me.btnGuardar)
        Me.tabDetalle.Controls.Add(Me.lblDescripción)
        Me.tabDetalle.Controls.Add(Me.txtClasificacion)
        Me.tabDetalle.Controls.Add(Me.chkActivo)
        Me.tabDetalle.Controls.Add(Me.grpAudit)
        Me.tabDetalle.Controls.Add(Me.lblCodigo)
        Me.tabDetalle.Controls.Add(Me.txtDescripcion)
        Me.tabDetalle.Controls.Add(Me.txtId)
        Me.tabDetalle.Controls.Add(Me.txtActivo)
        Me.tabDetalle.Controls.Add(Me.btnRegresar)
        Me.tabDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalle.Size = New System.Drawing.Size(1048, 599)
        Me.tabDetalle.TabIndex = 1
        Me.tabDetalle.Text = "Clasificación"
        Me.tabDetalle.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(922, 68)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 32)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblDescripción
        '
        Me.lblDescripción.AutoSize = True
        Me.lblDescripción.Location = New System.Drawing.Point(177, 55)
        Me.lblDescripción.Name = "lblDescripción"
        Me.lblDescripción.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripción.TabIndex = 83
        Me.lblDescripción.Text = "Descripción:"
        '
        'txtClasificacion
        '
        Me.txtClasificacion.Location = New System.Drawing.Point(38, 74)
        Me.txtClasificacion.MaxLength = 12
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(116, 20)
        Me.txtClasificacion.TabIndex = 82
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(748, 76)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 50
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'grpAudit
        '
        Me.grpAudit.Controls.Add(Me.txtFecModi)
        Me.grpAudit.Controls.Add(Me.txtFecCrea)
        Me.grpAudit.Controls.Add(Me.lblFecHor)
        Me.grpAudit.Controls.Add(Me.txtNomModi)
        Me.grpAudit.Controls.Add(Me.txtNomCrea)
        Me.grpAudit.Controls.Add(Me.txtUsuModi)
        Me.grpAudit.Controls.Add(Me.txtUsuCrea)
        Me.grpAudit.Controls.Add(Me.lblNombres)
        Me.grpAudit.Controls.Add(Me.lblUsuario)
        Me.grpAudit.Controls.Add(Me.lblUsuModi)
        Me.grpAudit.Controls.Add(Me.lblUsuCrea)
        Me.grpAudit.Enabled = False
        Me.grpAudit.Location = New System.Drawing.Point(72, 327)
        Me.grpAudit.Name = "grpAudit"
        Me.grpAudit.Size = New System.Drawing.Size(762, 121)
        Me.grpAudit.TabIndex = 49
        Me.grpAudit.TabStop = False
        Me.grpAudit.Text = "Auditoría"
        '
        'txtFecModi
        '
        Me.txtFecModi.Location = New System.Drawing.Point(584, 75)
        Me.txtFecModi.Name = "txtFecModi"
        Me.txtFecModi.Size = New System.Drawing.Size(140, 20)
        Me.txtFecModi.TabIndex = 18
        Me.txtFecModi.TabStop = False
        '
        'txtFecCrea
        '
        Me.txtFecCrea.Location = New System.Drawing.Point(584, 43)
        Me.txtFecCrea.Name = "txtFecCrea"
        Me.txtFecCrea.Size = New System.Drawing.Size(140, 20)
        Me.txtFecCrea.TabIndex = 17
        Me.txtFecCrea.TabStop = False
        '
        'lblFecHor
        '
        Me.lblFecHor.AutoSize = True
        Me.lblFecHor.Location = New System.Drawing.Point(611, 24)
        Me.lblFecHor.Name = "lblFecHor"
        Me.lblFecHor.Size = New System.Drawing.Size(71, 13)
        Me.lblFecHor.TabIndex = 16
        Me.lblFecHor.Text = "Fecha y Hora"
        '
        'txtNomModi
        '
        Me.txtNomModi.Location = New System.Drawing.Point(253, 75)
        Me.txtNomModi.Name = "txtNomModi"
        Me.txtNomModi.Size = New System.Drawing.Size(324, 20)
        Me.txtNomModi.TabIndex = 15
        Me.txtNomModi.TabStop = False
        '
        'txtNomCrea
        '
        Me.txtNomCrea.Location = New System.Drawing.Point(253, 43)
        Me.txtNomCrea.Name = "txtNomCrea"
        Me.txtNomCrea.Size = New System.Drawing.Size(324, 20)
        Me.txtNomCrea.TabIndex = 14
        Me.txtNomCrea.TabStop = False
        '
        'txtUsuModi
        '
        Me.txtUsuModi.Location = New System.Drawing.Point(129, 75)
        Me.txtUsuModi.Name = "txtUsuModi"
        Me.txtUsuModi.Size = New System.Drawing.Size(116, 20)
        Me.txtUsuModi.TabIndex = 13
        Me.txtUsuModi.TabStop = False
        '
        'txtUsuCrea
        '
        Me.txtUsuCrea.Location = New System.Drawing.Point(129, 43)
        Me.txtUsuCrea.Name = "txtUsuCrea"
        Me.txtUsuCrea.Size = New System.Drawing.Size(116, 20)
        Me.txtUsuCrea.TabIndex = 12
        Me.txtUsuCrea.TabStop = False
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(339, 24)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres.TabIndex = 11
        Me.lblNombres.Text = "Nombres"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(166, 24)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 10
        Me.lblUsuario.Text = "Usuario"
        '
        'lblUsuModi
        '
        Me.lblUsuModi.AutoSize = True
        Me.lblUsuModi.Location = New System.Drawing.Point(29, 75)
        Me.lblUsuModi.Name = "lblUsuModi"
        Me.lblUsuModi.Size = New System.Drawing.Size(80, 13)
        Me.lblUsuModi.TabIndex = 9
        Me.lblUsuModi.Text = "Modificado por:"
        '
        'lblUsuCrea
        '
        Me.lblUsuCrea.AutoSize = True
        Me.lblUsuCrea.Location = New System.Drawing.Point(29, 46)
        Me.lblUsuCrea.Name = "lblUsuCrea"
        Me.lblUsuCrea.Size = New System.Drawing.Size(62, 13)
        Me.lblUsuCrea.TabIndex = 8
        Me.lblUsuCrea.Text = "Creado por:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(35, 55)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 28
        Me.lblCodigo.Text = "Código:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(177, 74)
        Me.txtDescripcion.MaxLength = 60
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(545, 20)
        Me.txtDescripcion.TabIndex = 25
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(972, 74)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(11, 20)
        Me.txtId.TabIndex = 23
        '
        'txtActivo
        '
        Me.txtActivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActivo.Location = New System.Drawing.Point(972, 74)
        Me.txtActivo.MaxLength = 4
        Me.txtActivo.Name = "txtActivo"
        Me.txtActivo.ReadOnly = True
        Me.txtActivo.Size = New System.Drawing.Size(11, 20)
        Me.txtActivo.TabIndex = 58
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.Location = New System.Drawing.Point(922, 117)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(117, 32)
        Me.btnRegresar.TabIndex = 22
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.UseVisualStyleBackColor = False
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
        Me.bn.Size = New System.Drawing.Size(1056, 25)
        Me.bn.TabIndex = 121
        Me.bn.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbNuevo
        '
        Me.tsbNuevo.BackColor = System.Drawing.Color.NavajoWhite
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(131, 22)
        Me.tsbNuevo.Text = "Nueva Clasificación"
        Me.tsbNuevo.ToolTipText = "Nueva Clasificación"
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
        'bsIndTipoAtributos
        '
        Me.bsIndTipoAtributos.DataSource = GetType(clsDataLib.clsInd_TipoAtributos)
        '
        'IdTipoAtributoDataGridViewTextBoxColumn
        '
        Me.IdTipoAtributoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoAtributo"
        Me.IdTipoAtributoDataGridViewTextBoxColumn.HeaderText = "IdTipoAtributo"
        Me.IdTipoAtributoDataGridViewTextBoxColumn.Name = "IdTipoAtributoDataGridViewTextBoxColumn"
        Me.IdTipoAtributoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTipoAtributoDataGridViewTextBoxColumn.Visible = False
        '
        'Arrow1
        '
        Me.Arrow1.HeaderText = ""
        Me.Arrow1.Image = CType(resources.GetObject("Arrow1.Image"), System.Drawing.Image)
        Me.Arrow1.Name = "Arrow1"
        Me.Arrow1.ReadOnly = True
        Me.Arrow1.Width = 20
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionTipoAtribDataGridViewTextBoxColumn
        '
        Me.DescripcionTipoAtribDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTipoAtrib"
        Me.DescripcionTipoAtribDataGridViewTextBoxColumn.HeaderText = "DescripcionTipoAtrib"
        Me.DescripcionTipoAtribDataGridViewTextBoxColumn.Name = "DescripcionTipoAtribDataGridViewTextBoxColumn"
        Me.DescripcionTipoAtribDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDatoVisualizadoDataGridViewTextBoxColumn
        '
        Me.TipoDatoVisualizadoDataGridViewTextBoxColumn.DataPropertyName = "TipoDatoVisualizado"
        Me.TipoDatoVisualizadoDataGridViewTextBoxColumn.HeaderText = "TipoDatoVisualizado"
        Me.TipoDatoVisualizadoDataGridViewTextBoxColumn.Name = "TipoDatoVisualizadoDataGridViewTextBoxColumn"
        Me.TipoDatoVisualizadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDatoSalvadoDataGridViewTextBoxColumn
        '
        Me.TipoDatoSalvadoDataGridViewTextBoxColumn.DataPropertyName = "TipoDatoSalvado"
        Me.TipoDatoSalvadoDataGridViewTextBoxColumn.HeaderText = "TipoDatoSalvado"
        Me.TipoDatoSalvadoDataGridViewTextBoxColumn.Name = "TipoDatoSalvadoDataGridViewTextBoxColumn"
        Me.TipoDatoSalvadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FuenteDelValorDataGridViewTextBoxColumn
        '
        Me.FuenteDelValorDataGridViewTextBoxColumn.DataPropertyName = "FuenteDelValor"
        Me.FuenteDelValorDataGridViewTextBoxColumn.HeaderText = "FuenteDelValor"
        Me.FuenteDelValorDataGridViewTextBoxColumn.Name = "FuenteDelValorDataGridViewTextBoxColumn"
        Me.FuenteDelValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MascarillaDataGridViewTextBoxColumn
        '
        Me.MascarillaDataGridViewTextBoxColumn.DataPropertyName = "Mascarilla"
        Me.MascarillaDataGridViewTextBoxColumn.HeaderText = "Mascarilla"
        Me.MascarillaDataGridViewTextBoxColumn.Name = "MascarillaDataGridViewTextBoxColumn"
        Me.MascarillaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValidacionDataGridViewTextBoxColumn
        '
        Me.ValidacionDataGridViewTextBoxColumn.DataPropertyName = "Validacion"
        Me.ValidacionDataGridViewTextBoxColumn.HeaderText = "Validacion"
        Me.ValidacionDataGridViewTextBoxColumn.Name = "ValidacionDataGridViewTextBoxColumn"
        Me.ValidacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InterrogableDataGridViewTextBoxColumn
        '
        Me.InterrogableDataGridViewTextBoxColumn.DataPropertyName = "Interrogable"
        Me.InterrogableDataGridViewTextBoxColumn.HeaderText = "Interrogable"
        Me.InterrogableDataGridViewTextBoxColumn.Name = "InterrogableDataGridViewTextBoxColumn"
        Me.InterrogableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MultiidiomaDataGridViewTextBoxColumn
        '
        Me.MultiidiomaDataGridViewTextBoxColumn.DataPropertyName = "Multi_idioma"
        Me.MultiidiomaDataGridViewTextBoxColumn.HeaderText = "Multi_idioma"
        Me.MultiidiomaDataGridViewTextBoxColumn.Name = "MultiidiomaDataGridViewTextBoxColumn"
        Me.MultiidiomaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmbitoAtribDataGridViewTextBoxColumn
        '
        Me.AmbitoAtribDataGridViewTextBoxColumn.DataPropertyName = "AmbitoAtrib"
        Me.AmbitoAtribDataGridViewTextBoxColumn.HeaderText = "AmbitoAtrib"
        Me.AmbitoAtribDataGridViewTextBoxColumn.Name = "AmbitoAtribDataGridViewTextBoxColumn"
        Me.AmbitoAtribDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmInd_TipoAtributos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabCtrl)
        Me.Controls.Add(Me.bn)
        Me.Name = "frmInd_TipoAtributos"
        Me.Text = "frmInd_TipoAtributos"
        Me.tabCtrl.ResumeLayout(False)
        Me.tabLista.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalle.ResumeLayout(False)
        Me.tabDetalle.PerformLayout()
        Me.grpAudit.ResumeLayout(False)
        Me.grpAudit.PerformLayout()
        CType(Me.bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bn.ResumeLayout(False)
        Me.bn.PerformLayout()
        CType(Me.bsIndTipoAtributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabCtrl As TabControl
    Friend WithEvents tabLista As TabPage
    Friend WithEvents dgv As DataGridView
    Friend WithEvents tabDetalle As TabPage
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblDescripción As Label
    Friend WithEvents txtClasificacion As TextBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents grpAudit As GroupBox
    Friend WithEvents txtFecModi As TextBox
    Friend WithEvents txtFecCrea As TextBox
    Friend WithEvents lblFecHor As Label
    Friend WithEvents txtNomModi As TextBox
    Friend WithEvents txtNomCrea As TextBox
    Friend WithEvents txtUsuModi As TextBox
    Friend WithEvents txtUsuCrea As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblUsuModi As Label
    Friend WithEvents lblUsuCrea As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtActivo As TextBox
    Friend WithEvents btnRegresar As Button
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents IdTipoAtributoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Arrow1 As DataGridViewImageColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionTipoAtribDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDatoVisualizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDatoSalvadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FuenteDelValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MascarillaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValidacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterrogableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MultiidiomaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmbitoAtribDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsIndTipoAtributos As BindingSource
End Class
