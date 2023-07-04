<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArbolTx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArbolTx))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabCtrl = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.panAtrTx = New System.Windows.Forms.Panel()
        Me.panAtrData = New System.Windows.Forms.Panel()
        Me.tabAtrTx = New System.Windows.Forms.TabControl()
        Me.tabListaAtrTx = New System.Windows.Forms.TabPage()
        Me.dgvIndAtrTx = New System.Windows.Forms.DataGridView()
        Me.flecha = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TipoAtributo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabDetAtrTx = New System.Windows.Forms.TabPage()
        Me.btnGuardarAtr = New System.Windows.Forms.Button()
        Me.chkInterrogable = New System.Windows.Forms.CheckBox()
        Me.chkMascarilla = New System.Windows.Forms.CheckBox()
        Me.chkObligatorio = New System.Windows.Forms.CheckBox()
        Me.chkModificable = New System.Windows.Forms.CheckBox()
        Me.grpValidacion = New System.Windows.Forms.GroupBox()
        Me.lblValIncrem = New System.Windows.Forms.Label()
        Me.txtIncrem = New System.Windows.Forms.TextBox()
        Me.lblValMax = New System.Windows.Forms.Label()
        Me.txtValMax = New System.Windows.Forms.TextBox()
        Me.lblValMin = New System.Windows.Forms.Label()
        Me.txtValMin = New System.Windows.Forms.TextBox()
        Me.lblTablaValidac = New System.Windows.Forms.Label()
        Me.txtIdTablaValidac = New System.Windows.Forms.TextBox()
        Me.lblIdTablaValidac = New System.Windows.Forms.Label()
        Me.lblTipoValid = New System.Windows.Forms.Label()
        Me.txtTablaValidac = New System.Windows.Forms.TextBox()
        Me.txtTipoValidac = New System.Windows.Forms.TextBox()
        Me.grpUniMed = New System.Windows.Forms.GroupBox()
        Me.lblIDUniMed = New System.Windows.Forms.Label()
        Me.txtIDUniMed = New System.Windows.Forms.TextBox()
        Me.lblUniMed = New System.Windows.Forms.Label()
        Me.txtUniMed = New System.Windows.Forms.TextBox()
        Me.grpTipoAtrib = New System.Windows.Forms.GroupBox()
        Me.txtIdTipoAtrib = New System.Windows.Forms.TextBox()
        Me.lblTipoAtributo = New System.Windows.Forms.Label()
        Me.txtNombAtrib = New System.Windows.Forms.TextBox()
        Me.lblNombAtrib = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.lblIDAtrTx = New System.Windows.Forms.Label()
        Me.txtIdAtrTx = New System.Windows.Forms.TextBox()
        Me.bnAtrTx = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRegresar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.panBotones = New System.Windows.Forms.Panel()
        Me.panDescrip = New System.Windows.Forms.Panel()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtDescCorta_ES = New System.Windows.Forms.TextBox()
        Me.txtDescDet_ES = New System.Windows.Forms.TextBox()
        Me.lblDescCorta_ES = New System.Windows.Forms.Label()
        Me.lblAclarac_ES = New System.Windows.Forms.Label()
        Me.lblDescForm_ES = New System.Windows.Forms.Label()
        Me.txtDescForm_ES = New System.Windows.Forms.TextBox()
        Me.lblDescDet_ES = New System.Windows.Forms.Label()
        Me.txtAclarac_ES = New System.Windows.Forms.TextBox()
        Me.tabDetalle = New System.Windows.Forms.TabPage()
        Me.txtDescCorta_EN = New System.Windows.Forms.TextBox()
        Me.txtDescDet_EN = New System.Windows.Forms.TextBox()
        Me.lblDescCorta_EN = New System.Windows.Forms.Label()
        Me.lblAclarac_EN = New System.Windows.Forms.Label()
        Me.lblDescForm_EN = New System.Windows.Forms.Label()
        Me.txtDescForm_EN = New System.Windows.Forms.TextBox()
        Me.lblDescDet_EN = New System.Windows.Forms.Label()
        Me.txtAclarac_EN = New System.Windows.Forms.TextBox()
        Me.txtDescCorta_FR = New System.Windows.Forms.TextBox()
        Me.txtDescDet_FR = New System.Windows.Forms.TextBox()
        Me.lblDescCorta_FR = New System.Windows.Forms.Label()
        Me.lblAclarac_FR = New System.Windows.Forms.Label()
        Me.lblDescForm_FR = New System.Windows.Forms.Label()
        Me.txtDescForm_FR = New System.Windows.Forms.TextBox()
        Me.lblDescDet_FR = New System.Windows.Forms.Label()
        Me.txtAclarac_FR = New System.Windows.Forms.TextBox()
        Me.lbl_ES = New System.Windows.Forms.Label()
        Me.lbl_EN = New System.Windows.Forms.Label()
        Me.lbl_FR = New System.Windows.Forms.Label()
        Me.IdAtrTxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroOrdenAtributoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAtributoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedidaAtributoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoAtributoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUnidadDeMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoValidacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTablaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbreviacionTablaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTablaValidacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorMinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorMaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncrementoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModificableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ObligatorioDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MascarillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterrogableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdCreadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUltimoCambioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdBorradoLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAtrTx = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTx = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabCtrl.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.panAtrTx.SuspendLayout()
        Me.panAtrData.SuspendLayout()
        Me.tabAtrTx.SuspendLayout()
        Me.tabListaAtrTx.SuspendLayout()
        CType(Me.dgvIndAtrTx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetAtrTx.SuspendLayout()
        Me.grpValidacion.SuspendLayout()
        Me.grpUniMed.SuspendLayout()
        Me.grpTipoAtrib.SuspendLayout()
        CType(Me.bnAtrTx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnAtrTx.SuspendLayout()
        Me.panDescrip.SuspendLayout()
        CType(Me.bsAtrTx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCtrl
        '
        Me.tabCtrl.Controls.Add(Me.tabDatos)
        Me.tabCtrl.Controls.Add(Me.tabDetalle)
        Me.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrl.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrl.Name = "tabCtrl"
        Me.tabCtrl.SelectedIndex = 0
        Me.tabCtrl.Size = New System.Drawing.Size(1159, 682)
        Me.tabCtrl.TabIndex = 120
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.panAtrTx)
        Me.tabDatos.Location = New System.Drawing.Point(4, 22)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatos.Size = New System.Drawing.Size(1151, 656)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Descripciones"
        Me.tabDatos.UseVisualStyleBackColor = True
        '
        'panAtrTx
        '
        Me.panAtrTx.Controls.Add(Me.panAtrData)
        Me.panAtrTx.Controls.Add(Me.panBotones)
        Me.panAtrTx.Controls.Add(Me.panDescrip)
        Me.panAtrTx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAtrTx.Location = New System.Drawing.Point(3, 3)
        Me.panAtrTx.Name = "panAtrTx"
        Me.panAtrTx.Size = New System.Drawing.Size(1145, 650)
        Me.panAtrTx.TabIndex = 9
        '
        'panAtrData
        '
        Me.panAtrData.Controls.Add(Me.tabAtrTx)
        Me.panAtrData.Controls.Add(Me.bnAtrTx)
        Me.panAtrData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAtrData.Location = New System.Drawing.Point(0, 313)
        Me.panAtrData.Name = "panAtrData"
        Me.panAtrData.Size = New System.Drawing.Size(1145, 337)
        Me.panAtrData.TabIndex = 10
        '
        'tabAtrTx
        '
        Me.tabAtrTx.Controls.Add(Me.tabListaAtrTx)
        Me.tabAtrTx.Controls.Add(Me.tabDetAtrTx)
        Me.tabAtrTx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAtrTx.Location = New System.Drawing.Point(0, 25)
        Me.tabAtrTx.Name = "tabAtrTx"
        Me.tabAtrTx.SelectedIndex = 0
        Me.tabAtrTx.Size = New System.Drawing.Size(1145, 312)
        Me.tabAtrTx.TabIndex = 119
        '
        'tabListaAtrTx
        '
        Me.tabListaAtrTx.Controls.Add(Me.dgvIndAtrTx)
        Me.tabListaAtrTx.Location = New System.Drawing.Point(4, 22)
        Me.tabListaAtrTx.Name = "tabListaAtrTx"
        Me.tabListaAtrTx.Padding = New System.Windows.Forms.Padding(3)
        Me.tabListaAtrTx.Size = New System.Drawing.Size(1137, 286)
        Me.tabListaAtrTx.TabIndex = 0
        Me.tabListaAtrTx.Text = "Atributos"
        Me.tabListaAtrTx.UseVisualStyleBackColor = True
        '
        'dgvIndAtrTx
        '
        Me.dgvIndAtrTx.AllowUserToAddRows = False
        Me.dgvIndAtrTx.AllowUserToDeleteRows = False
        Me.dgvIndAtrTx.AutoGenerateColumns = False
        Me.dgvIndAtrTx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIndAtrTx.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAtrTxDataGridViewTextBoxColumn, Me.flecha, Me.NumeroOrdenAtributoDataGridViewTextBoxColumn, Me.NombreAtributoDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.DescripcionCategoriaDataGridViewTextBoxColumn, Me.UnidadMedidaAtributoDataGridViewTextBoxColumn, Me.IdTxDataGridViewTextBoxColumn, Me.IdTipoAtributoDataGridViewTextBoxColumn, Me.TipoAtributo, Me.IdUnidadDeMedidaDataGridViewTextBoxColumn, Me.TipoValidacionDataGridViewTextBoxColumn, Me.NombreTablaDataGridViewTextBoxColumn, Me.AbreviacionTablaDataGridViewTextBoxColumn, Me.IdTablaValidacionDataGridViewTextBoxColumn, Me.ValorMinimoDataGridViewTextBoxColumn, Me.ValorMaximoDataGridViewTextBoxColumn, Me.IncrementoDataGridViewTextBoxColumn, Me.IconoDataGridViewTextBoxColumn, Me.ModificableDataGridViewCheckBoxColumn, Me.ObligatorioDataGridViewCheckBoxColumn, Me.MascarillaDataGridViewTextBoxColumn, Me.InterrogableDataGridViewCheckBoxColumn, Me.IdCreadoDataGridViewTextBoxColumn, Me.IdUltimoCambioDataGridViewTextBoxColumn, Me.IdBorradoLDataGridViewTextBoxColumn})
        Me.dgvIndAtrTx.DataSource = Me.bsAtrTx
        Me.dgvIndAtrTx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIndAtrTx.Location = New System.Drawing.Point(3, 3)
        Me.dgvIndAtrTx.Name = "dgvIndAtrTx"
        Me.dgvIndAtrTx.ReadOnly = True
        Me.dgvIndAtrTx.RowHeadersVisible = False
        Me.dgvIndAtrTx.Size = New System.Drawing.Size(1131, 280)
        Me.dgvIndAtrTx.TabIndex = 0
        '
        'flecha
        '
        Me.flecha.HeaderText = ""
        Me.flecha.Image = CType(resources.GetObject("flecha.Image"), System.Drawing.Image)
        Me.flecha.Name = "flecha"
        Me.flecha.ReadOnly = True
        Me.flecha.Width = 24
        '
        'TipoAtributo
        '
        Me.TipoAtributo.DataPropertyName = "TipoAtributo"
        Me.TipoAtributo.HeaderText = "TipoAtributo"
        Me.TipoAtributo.Name = "TipoAtributo"
        Me.TipoAtributo.ReadOnly = True
        '
        'tabDetAtrTx
        '
        Me.tabDetAtrTx.Controls.Add(Me.btnGuardarAtr)
        Me.tabDetAtrTx.Controls.Add(Me.chkInterrogable)
        Me.tabDetAtrTx.Controls.Add(Me.chkMascarilla)
        Me.tabDetAtrTx.Controls.Add(Me.chkObligatorio)
        Me.tabDetAtrTx.Controls.Add(Me.chkModificable)
        Me.tabDetAtrTx.Controls.Add(Me.grpValidacion)
        Me.tabDetAtrTx.Controls.Add(Me.grpUniMed)
        Me.tabDetAtrTx.Controls.Add(Me.grpTipoAtrib)
        Me.tabDetAtrTx.Controls.Add(Me.lblCategoria)
        Me.tabDetAtrTx.Controls.Add(Me.txtCategoria)
        Me.tabDetAtrTx.Controls.Add(Me.lblIDAtrTx)
        Me.tabDetAtrTx.Controls.Add(Me.txtIdAtrTx)
        Me.tabDetAtrTx.Location = New System.Drawing.Point(4, 22)
        Me.tabDetAtrTx.Name = "tabDetAtrTx"
        Me.tabDetAtrTx.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetAtrTx.Size = New System.Drawing.Size(1137, 316)
        Me.tabDetAtrTx.TabIndex = 1
        Me.tabDetAtrTx.Text = "Atributo"
        Me.tabDetAtrTx.UseVisualStyleBackColor = True
        '
        'btnGuardarAtr
        '
        Me.btnGuardarAtr.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnGuardarAtr.Image = CType(resources.GetObject("btnGuardarAtr.Image"), System.Drawing.Image)
        Me.btnGuardarAtr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarAtr.Location = New System.Drawing.Point(28, 260)
        Me.btnGuardarAtr.Name = "btnGuardarAtr"
        Me.btnGuardarAtr.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnGuardarAtr.Size = New System.Drawing.Size(132, 32)
        Me.btnGuardarAtr.TabIndex = 27
        Me.btnGuardarAtr.Text = "Guardar Atributo"
        Me.btnGuardarAtr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarAtr.UseVisualStyleBackColor = False
        '
        'chkInterrogable
        '
        Me.chkInterrogable.AutoSize = True
        Me.chkInterrogable.Location = New System.Drawing.Point(433, 224)
        Me.chkInterrogable.Name = "chkInterrogable"
        Me.chkInterrogable.Size = New System.Drawing.Size(82, 17)
        Me.chkInterrogable.TabIndex = 26
        Me.chkInterrogable.Text = "Interrogable"
        Me.chkInterrogable.UseVisualStyleBackColor = True
        '
        'chkMascarilla
        '
        Me.chkMascarilla.AutoSize = True
        Me.chkMascarilla.Location = New System.Drawing.Point(313, 224)
        Me.chkMascarilla.Name = "chkMascarilla"
        Me.chkMascarilla.Size = New System.Drawing.Size(73, 17)
        Me.chkMascarilla.TabIndex = 25
        Me.chkMascarilla.Text = "Mascarilla"
        Me.chkMascarilla.UseVisualStyleBackColor = True
        '
        'chkObligatorio
        '
        Me.chkObligatorio.AutoSize = True
        Me.chkObligatorio.Location = New System.Drawing.Point(179, 224)
        Me.chkObligatorio.Name = "chkObligatorio"
        Me.chkObligatorio.Size = New System.Drawing.Size(76, 17)
        Me.chkObligatorio.TabIndex = 24
        Me.chkObligatorio.Text = "Obligatorio"
        Me.chkObligatorio.UseVisualStyleBackColor = True
        '
        'chkModificable
        '
        Me.chkModificable.AutoSize = True
        Me.chkModificable.Location = New System.Drawing.Point(51, 224)
        Me.chkModificable.Name = "chkModificable"
        Me.chkModificable.Size = New System.Drawing.Size(80, 17)
        Me.chkModificable.TabIndex = 23
        Me.chkModificable.Text = "Modificable"
        Me.chkModificable.UseVisualStyleBackColor = True
        '
        'grpValidacion
        '
        Me.grpValidacion.Controls.Add(Me.lblValIncrem)
        Me.grpValidacion.Controls.Add(Me.txtIncrem)
        Me.grpValidacion.Controls.Add(Me.lblValMax)
        Me.grpValidacion.Controls.Add(Me.txtValMax)
        Me.grpValidacion.Controls.Add(Me.lblValMin)
        Me.grpValidacion.Controls.Add(Me.txtValMin)
        Me.grpValidacion.Controls.Add(Me.lblTablaValidac)
        Me.grpValidacion.Controls.Add(Me.txtIdTablaValidac)
        Me.grpValidacion.Controls.Add(Me.lblIdTablaValidac)
        Me.grpValidacion.Controls.Add(Me.lblTipoValid)
        Me.grpValidacion.Controls.Add(Me.txtTablaValidac)
        Me.grpValidacion.Controls.Add(Me.txtTipoValidac)
        Me.grpValidacion.Location = New System.Drawing.Point(28, 132)
        Me.grpValidacion.Name = "grpValidacion"
        Me.grpValidacion.Size = New System.Drawing.Size(731, 70)
        Me.grpValidacion.TabIndex = 22
        Me.grpValidacion.TabStop = False
        Me.grpValidacion.Text = "Validación"
        '
        'lblValIncrem
        '
        Me.lblValIncrem.AutoSize = True
        Me.lblValIncrem.Location = New System.Drawing.Point(593, 18)
        Me.lblValIncrem.Name = "lblValIncrem"
        Me.lblValIncrem.Size = New System.Drawing.Size(60, 13)
        Me.lblValIncrem.TabIndex = 25
        Me.lblValIncrem.Text = "Incremento"
        '
        'txtIncrem
        '
        Me.txtIncrem.Location = New System.Drawing.Point(596, 34)
        Me.txtIncrem.Name = "txtIncrem"
        Me.txtIncrem.Size = New System.Drawing.Size(100, 20)
        Me.txtIncrem.TabIndex = 24
        '
        'lblValMax
        '
        Me.lblValMax.AutoSize = True
        Me.lblValMax.Location = New System.Drawing.Point(470, 18)
        Me.lblValMax.Name = "lblValMax"
        Me.lblValMax.Size = New System.Drawing.Size(70, 13)
        Me.lblValMax.TabIndex = 23
        Me.lblValMax.Text = "Valor Máximo"
        '
        'txtValMax
        '
        Me.txtValMax.Location = New System.Drawing.Point(473, 34)
        Me.txtValMax.Name = "txtValMax"
        Me.txtValMax.Size = New System.Drawing.Size(100, 20)
        Me.txtValMax.TabIndex = 22
        '
        'lblValMin
        '
        Me.lblValMin.AutoSize = True
        Me.lblValMin.Location = New System.Drawing.Point(349, 17)
        Me.lblValMin.Name = "lblValMin"
        Me.lblValMin.Size = New System.Drawing.Size(69, 13)
        Me.lblValMin.TabIndex = 21
        Me.lblValMin.Text = "Valor Mínimo"
        '
        'txtValMin
        '
        Me.txtValMin.Location = New System.Drawing.Point(352, 34)
        Me.txtValMin.Name = "txtValMin"
        Me.txtValMin.Size = New System.Drawing.Size(100, 20)
        Me.txtValMin.TabIndex = 20
        '
        'lblTablaValidac
        '
        Me.lblTablaValidac.AutoSize = True
        Me.lblTablaValidac.Location = New System.Drawing.Point(98, 18)
        Me.lblTablaValidac.Name = "lblTablaValidac"
        Me.lblTablaValidac.Size = New System.Drawing.Size(34, 13)
        Me.lblTablaValidac.TabIndex = 19
        Me.lblTablaValidac.Text = "Tabla"
        '
        'txtIdTablaValidac
        '
        Me.txtIdTablaValidac.Location = New System.Drawing.Point(21, 34)
        Me.txtIdTablaValidac.Name = "txtIdTablaValidac"
        Me.txtIdTablaValidac.Size = New System.Drawing.Size(62, 20)
        Me.txtIdTablaValidac.TabIndex = 16
        '
        'lblIdTablaValidac
        '
        Me.lblIdTablaValidac.AutoSize = True
        Me.lblIdTablaValidac.Location = New System.Drawing.Point(18, 18)
        Me.lblIdTablaValidac.Name = "lblIdTablaValidac"
        Me.lblIdTablaValidac.Size = New System.Drawing.Size(48, 13)
        Me.lblIdTablaValidac.TabIndex = 17
        Me.lblIdTablaValidac.Text = "ID Tabla"
        '
        'lblTipoValid
        '
        Me.lblTipoValid.AutoSize = True
        Me.lblTipoValid.Location = New System.Drawing.Point(286, 18)
        Me.lblTipoValid.Name = "lblTipoValid"
        Me.lblTipoValid.Size = New System.Drawing.Size(28, 13)
        Me.lblTipoValid.TabIndex = 15
        Me.lblTipoValid.Text = "Tipo"
        '
        'txtTablaValidac
        '
        Me.txtTablaValidac.Location = New System.Drawing.Point(101, 34)
        Me.txtTablaValidac.Name = "txtTablaValidac"
        Me.txtTablaValidac.Size = New System.Drawing.Size(166, 20)
        Me.txtTablaValidac.TabIndex = 18
        '
        'txtTipoValidac
        '
        Me.txtTipoValidac.Location = New System.Drawing.Point(289, 34)
        Me.txtTipoValidac.Name = "txtTipoValidac"
        Me.txtTipoValidac.Size = New System.Drawing.Size(41, 20)
        Me.txtTipoValidac.TabIndex = 14
        '
        'grpUniMed
        '
        Me.grpUniMed.Controls.Add(Me.lblIDUniMed)
        Me.grpUniMed.Controls.Add(Me.txtIDUniMed)
        Me.grpUniMed.Controls.Add(Me.lblUniMed)
        Me.grpUniMed.Controls.Add(Me.txtUniMed)
        Me.grpUniMed.Location = New System.Drawing.Point(448, 36)
        Me.grpUniMed.Name = "grpUniMed"
        Me.grpUniMed.Size = New System.Drawing.Size(311, 70)
        Me.grpUniMed.TabIndex = 21
        Me.grpUniMed.TabStop = False
        Me.grpUniMed.Text = "Unidad de Medida"
        '
        'lblIDUniMed
        '
        Me.lblIDUniMed.AutoSize = True
        Me.lblIDUniMed.Location = New System.Drawing.Point(18, 23)
        Me.lblIDUniMed.Name = "lblIDUniMed"
        Me.lblIDUniMed.Size = New System.Drawing.Size(43, 13)
        Me.lblIDUniMed.TabIndex = 11
        Me.lblIDUniMed.Text = "ID U/M"
        '
        'txtIDUniMed
        '
        Me.txtIDUniMed.Location = New System.Drawing.Point(21, 39)
        Me.txtIDUniMed.Name = "txtIDUniMed"
        Me.txtIDUniMed.Size = New System.Drawing.Size(62, 20)
        Me.txtIDUniMed.TabIndex = 10
        '
        'lblUniMed
        '
        Me.lblUniMed.AutoSize = True
        Me.lblUniMed.Location = New System.Drawing.Point(98, 23)
        Me.lblUniMed.Name = "lblUniMed"
        Me.lblUniMed.Size = New System.Drawing.Size(94, 13)
        Me.lblUniMed.TabIndex = 13
        Me.lblUniMed.Text = "Unidad de Medida"
        '
        'txtUniMed
        '
        Me.txtUniMed.Location = New System.Drawing.Point(101, 39)
        Me.txtUniMed.Name = "txtUniMed"
        Me.txtUniMed.Size = New System.Drawing.Size(189, 20)
        Me.txtUniMed.TabIndex = 12
        '
        'grpTipoAtrib
        '
        Me.grpTipoAtrib.Controls.Add(Me.txtIdTipoAtrib)
        Me.grpTipoAtrib.Controls.Add(Me.lblTipoAtributo)
        Me.grpTipoAtrib.Controls.Add(Me.txtNombAtrib)
        Me.grpTipoAtrib.Controls.Add(Me.lblNombAtrib)
        Me.grpTipoAtrib.Controls.Add(Me.txtOrden)
        Me.grpTipoAtrib.Controls.Add(Me.lblOrden)
        Me.grpTipoAtrib.Location = New System.Drawing.Point(113, 35)
        Me.grpTipoAtrib.Name = "grpTipoAtrib"
        Me.grpTipoAtrib.Size = New System.Drawing.Size(311, 70)
        Me.grpTipoAtrib.TabIndex = 20
        Me.grpTipoAtrib.TabStop = False
        Me.grpTipoAtrib.Text = "Tipo de Atributo"
        '
        'txtIdTipoAtrib
        '
        Me.txtIdTipoAtrib.Location = New System.Drawing.Point(21, 34)
        Me.txtIdTipoAtrib.Name = "txtIdTipoAtrib"
        Me.txtIdTipoAtrib.Size = New System.Drawing.Size(62, 20)
        Me.txtIdTipoAtrib.TabIndex = 4
        '
        'lblTipoAtributo
        '
        Me.lblTipoAtributo.AutoSize = True
        Me.lblTipoAtributo.Location = New System.Drawing.Point(18, 18)
        Me.lblTipoAtributo.Name = "lblTipoAtributo"
        Me.lblTipoAtributo.Size = New System.Drawing.Size(18, 13)
        Me.lblTipoAtributo.TabIndex = 5
        Me.lblTipoAtributo.Text = "ID"
        '
        'txtNombAtrib
        '
        Me.txtNombAtrib.Location = New System.Drawing.Point(101, 34)
        Me.txtNombAtrib.MaxLength = 40
        Me.txtNombAtrib.Name = "txtNombAtrib"
        Me.txtNombAtrib.Size = New System.Drawing.Size(118, 20)
        Me.txtNombAtrib.TabIndex = 6
        '
        'lblNombAtrib
        '
        Me.lblNombAtrib.AutoSize = True
        Me.lblNombAtrib.Location = New System.Drawing.Point(98, 16)
        Me.lblNombAtrib.Name = "lblNombAtrib"
        Me.lblNombAtrib.Size = New System.Drawing.Size(44, 13)
        Me.lblNombAtrib.TabIndex = 7
        Me.lblNombAtrib.Text = "Nombre"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(235, 34)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(55, 20)
        Me.txtOrden.TabIndex = 8
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Location = New System.Drawing.Point(232, 18)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(36, 13)
        Me.lblOrden.TabIndex = 9
        Me.lblOrden.Text = "Orden"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(25, 69)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(57, 13)
        Me.lblCategoria.TabIndex = 3
        Me.lblCategoria.Text = "Categoría:"
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(28, 85)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(60, 20)
        Me.txtCategoria.TabIndex = 2
        '
        'lblIDAtrTx
        '
        Me.lblIDAtrTx.AutoSize = True
        Me.lblIDAtrTx.Location = New System.Drawing.Point(25, 20)
        Me.lblIDAtrTx.Name = "lblIDAtrTx"
        Me.lblIDAtrTx.Size = New System.Drawing.Size(21, 13)
        Me.lblIDAtrTx.TabIndex = 1
        Me.lblIDAtrTx.Text = "ID:"
        '
        'txtIdAtrTx
        '
        Me.txtIdAtrTx.Location = New System.Drawing.Point(28, 36)
        Me.txtIdAtrTx.Name = "txtIdAtrTx"
        Me.txtIdAtrTx.ReadOnly = True
        Me.txtIdAtrTx.Size = New System.Drawing.Size(60, 20)
        Me.txtIdAtrTx.TabIndex = 0
        '
        'bnAtrTx
        '
        Me.bnAtrTx.AddNewItem = Nothing
        Me.bnAtrTx.CountItem = Me.BindingNavigatorCountItem
        Me.bnAtrTx.DeleteItem = Nothing
        Me.bnAtrTx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsbNuevo, Me.ToolStripSeparator1, Me.tsbBorrar, Me.ToolStripSeparator2, Me.tsbRegresar, Me.ToolStripSeparator3})
        Me.bnAtrTx.Location = New System.Drawing.Point(0, 0)
        Me.bnAtrTx.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnAtrTx.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnAtrTx.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnAtrTx.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnAtrTx.Name = "bnAtrTx"
        Me.bnAtrTx.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnAtrTx.Size = New System.Drawing.Size(1145, 25)
        Me.bnAtrTx.TabIndex = 118
        Me.bnAtrTx.Text = "BindingNavigator1"
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
        Me.tsbNuevo.BackColor = System.Drawing.Color.YellowGreen
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(109, 22)
        Me.tsbNuevo.Text = "Nuevo Atributo"
        Me.tsbNuevo.ToolTipText = "Nueva Clasificación"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbBorrar
        '
        Me.tsbBorrar.BackColor = System.Drawing.Color.NavajoWhite
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(106, 22)
        Me.tsbBorrar.Text = "Borrar Atributo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbRegresar
        '
        Me.tsbRegresar.BackColor = System.Drawing.Color.NavajoWhite
        Me.tsbRegresar.Image = CType(resources.GetObject("tsbRegresar.Image"), System.Drawing.Image)
        Me.tsbRegresar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRegresar.Name = "tsbRegresar"
        Me.tsbRegresar.Size = New System.Drawing.Size(84, 22)
        Me.tsbRegresar.Text = "Ver Listado"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'panBotones
        '
        Me.panBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.panBotones.Location = New System.Drawing.Point(0, 302)
        Me.panBotones.Name = "panBotones"
        Me.panBotones.Size = New System.Drawing.Size(1145, 11)
        Me.panBotones.TabIndex = 10
        '
        'panDescrip
        '
        Me.panDescrip.Controls.Add(Me.lbl_FR)
        Me.panDescrip.Controls.Add(Me.lbl_EN)
        Me.panDescrip.Controls.Add(Me.lbl_ES)
        Me.panDescrip.Controls.Add(Me.txtDescCorta_FR)
        Me.panDescrip.Controls.Add(Me.txtDescDet_FR)
        Me.panDescrip.Controls.Add(Me.lblDescCorta_FR)
        Me.panDescrip.Controls.Add(Me.lblAclarac_FR)
        Me.panDescrip.Controls.Add(Me.lblDescForm_FR)
        Me.panDescrip.Controls.Add(Me.txtDescForm_FR)
        Me.panDescrip.Controls.Add(Me.lblDescDet_FR)
        Me.panDescrip.Controls.Add(Me.txtAclarac_FR)
        Me.panDescrip.Controls.Add(Me.txtDescCorta_EN)
        Me.panDescrip.Controls.Add(Me.txtDescDet_EN)
        Me.panDescrip.Controls.Add(Me.lblDescCorta_EN)
        Me.panDescrip.Controls.Add(Me.lblAclarac_EN)
        Me.panDescrip.Controls.Add(Me.lblDescForm_EN)
        Me.panDescrip.Controls.Add(Me.txtDescForm_EN)
        Me.panDescrip.Controls.Add(Me.lblDescDet_EN)
        Me.panDescrip.Controls.Add(Me.txtAclarac_EN)
        Me.panDescrip.Controls.Add(Me.btnBorrar)
        Me.panDescrip.Controls.Add(Me.btnNuevo)
        Me.panDescrip.Controls.Add(Me.btnGuardar)
        Me.panDescrip.Controls.Add(Me.lblID)
        Me.panDescrip.Controls.Add(Me.txtDescCorta_ES)
        Me.panDescrip.Controls.Add(Me.txtDescDet_ES)
        Me.panDescrip.Controls.Add(Me.lblDescCorta_ES)
        Me.panDescrip.Controls.Add(Me.lblAclarac_ES)
        Me.panDescrip.Controls.Add(Me.lblDescForm_ES)
        Me.panDescrip.Controls.Add(Me.txtDescForm_ES)
        Me.panDescrip.Controls.Add(Me.lblDescDet_ES)
        Me.panDescrip.Controls.Add(Me.txtAclarac_ES)
        Me.panDescrip.Dock = System.Windows.Forms.DockStyle.Top
        Me.panDescrip.Location = New System.Drawing.Point(0, 0)
        Me.panDescrip.Name = "panDescrip"
        Me.panDescrip.Size = New System.Drawing.Size(1145, 302)
        Me.panDescrip.TabIndex = 10
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(231, 262)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnBorrar.Size = New System.Drawing.Size(100, 32)
        Me.btnBorrar.TabIndex = 27
        Me.btnBorrar.Text = "Borrar   "
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrar.UseVisualStyleBackColor = False
        Me.btnBorrar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.YellowGreen
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(125, 262)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(100, 32)
        Me.btnNuevo.TabIndex = 26
        Me.btnNuevo.Text = "Agregar  "
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(19, 262)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(100, 32)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.Text = "Guardar "
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(71, 281)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 25
        Me.lblID.Text = "0"
        '
        'txtDescCorta_ES
        '
        Me.txtDescCorta_ES.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripCortaTxTrad", True))
        Me.txtDescCorta_ES.Location = New System.Drawing.Point(19, 68)
        Me.txtDescCorta_ES.MaxLength = 255
        Me.txtDescCorta_ES.Multiline = True
        Me.txtDescCorta_ES.Name = "txtDescCorta_ES"
        Me.txtDescCorta_ES.Size = New System.Drawing.Size(340, 33)
        Me.txtDescCorta_ES.TabIndex = 1
        '
        'txtDescDet_ES
        '
        Me.txtDescDet_ES.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripDetalleTxTrad", True))
        Me.txtDescDet_ES.Location = New System.Drawing.Point(19, 120)
        Me.txtDescDet_ES.MaxLength = 255
        Me.txtDescDet_ES.Multiline = True
        Me.txtDescDet_ES.Name = "txtDescDet_ES"
        Me.txtDescDet_ES.Size = New System.Drawing.Size(340, 50)
        Me.txtDescDet_ES.TabIndex = 2
        '
        'lblDescCorta_ES
        '
        Me.lblDescCorta_ES.AutoSize = True
        Me.lblDescCorta_ES.Location = New System.Drawing.Point(16, 52)
        Me.lblDescCorta_ES.Name = "lblDescCorta_ES"
        Me.lblDescCorta_ES.Size = New System.Drawing.Size(91, 13)
        Me.lblDescCorta_ES.TabIndex = 4
        Me.lblDescCorta_ES.Text = "Descripción Corta"
        '
        'lblAclarac_ES
        '
        Me.lblAclarac_ES.AutoSize = True
        Me.lblAclarac_ES.Location = New System.Drawing.Point(16, 173)
        Me.lblAclarac_ES.Name = "lblAclarac_ES"
        Me.lblAclarac_ES.Size = New System.Drawing.Size(68, 13)
        Me.lblAclarac_ES.TabIndex = 7
        Me.lblAclarac_ES.Text = "Aclaraciones"
        '
        'lblDescForm_ES
        '
        Me.lblDescForm_ES.AutoSize = True
        Me.lblDescForm_ES.Location = New System.Drawing.Point(16, 13)
        Me.lblDescForm_ES.Name = "lblDescForm_ES"
        Me.lblDescForm_ES.Size = New System.Drawing.Size(138, 13)
        Me.lblDescForm_ES.TabIndex = 3
        Me.lblDescForm_ES.Text = "Descripción para Formulario"
        '
        'txtDescForm_ES
        '
        Me.txtDescForm_ES.Location = New System.Drawing.Point(19, 29)
        Me.txtDescForm_ES.MaxLength = 25
        Me.txtDescForm_ES.Name = "txtDescForm_ES"
        Me.txtDescForm_ES.Size = New System.Drawing.Size(340, 20)
        Me.txtDescForm_ES.TabIndex = 0
        '
        'lblDescDet_ES
        '
        Me.lblDescDet_ES.AutoSize = True
        Me.lblDescDet_ES.Location = New System.Drawing.Point(16, 104)
        Me.lblDescDet_ES.Name = "lblDescDet_ES"
        Me.lblDescDet_ES.Size = New System.Drawing.Size(111, 13)
        Me.lblDescDet_ES.TabIndex = 5
        Me.lblDescDet_ES.Text = "Descripción Detallada"
        '
        'txtAclarac_ES
        '
        Me.txtAclarac_ES.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripDetalleTxTrad", True))
        Me.txtAclarac_ES.Location = New System.Drawing.Point(19, 189)
        Me.txtAclarac_ES.MaxLength = 999
        Me.txtAclarac_ES.Multiline = True
        Me.txtAclarac_ES.Name = "txtAclarac_ES"
        Me.txtAclarac_ES.Size = New System.Drawing.Size(340, 67)
        Me.txtAclarac_ES.TabIndex = 6
        '
        'tabDetalle
        '
        Me.tabDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalle.Size = New System.Drawing.Size(1151, 656)
        Me.tabDetalle.TabIndex = 1
        Me.tabDetalle.Text = "Atributos"
        Me.tabDetalle.UseVisualStyleBackColor = True
        '
        'txtDescCorta_EN
        '
        Me.txtDescCorta_EN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripCortaTxTrad", True))
        Me.txtDescCorta_EN.Location = New System.Drawing.Point(392, 68)
        Me.txtDescCorta_EN.MaxLength = 255
        Me.txtDescCorta_EN.Multiline = True
        Me.txtDescCorta_EN.Name = "txtDescCorta_EN"
        Me.txtDescCorta_EN.Size = New System.Drawing.Size(340, 33)
        Me.txtDescCorta_EN.TabIndex = 29
        '
        'txtDescDet_EN
        '
        Me.txtDescDet_EN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripDetalleTxTrad", True))
        Me.txtDescDet_EN.Location = New System.Drawing.Point(392, 120)
        Me.txtDescDet_EN.MaxLength = 255
        Me.txtDescDet_EN.Multiline = True
        Me.txtDescDet_EN.Name = "txtDescDet_EN"
        Me.txtDescDet_EN.Size = New System.Drawing.Size(340, 50)
        Me.txtDescDet_EN.TabIndex = 30
        '
        'lblDescCorta_EN
        '
        Me.lblDescCorta_EN.AutoSize = True
        Me.lblDescCorta_EN.Location = New System.Drawing.Point(389, 52)
        Me.lblDescCorta_EN.Name = "lblDescCorta_EN"
        Me.lblDescCorta_EN.Size = New System.Drawing.Size(91, 13)
        Me.lblDescCorta_EN.TabIndex = 32
        Me.lblDescCorta_EN.Text = "Descripción Corta"
        '
        'lblAclarac_EN
        '
        Me.lblAclarac_EN.AutoSize = True
        Me.lblAclarac_EN.Location = New System.Drawing.Point(389, 173)
        Me.lblAclarac_EN.Name = "lblAclarac_EN"
        Me.lblAclarac_EN.Size = New System.Drawing.Size(68, 13)
        Me.lblAclarac_EN.TabIndex = 35
        Me.lblAclarac_EN.Text = "Aclaraciones"
        '
        'lblDescForm_EN
        '
        Me.lblDescForm_EN.AutoSize = True
        Me.lblDescForm_EN.Location = New System.Drawing.Point(389, 13)
        Me.lblDescForm_EN.Name = "lblDescForm_EN"
        Me.lblDescForm_EN.Size = New System.Drawing.Size(138, 13)
        Me.lblDescForm_EN.TabIndex = 31
        Me.lblDescForm_EN.Text = "Descripción para Formulario"
        '
        'txtDescForm_EN
        '
        Me.txtDescForm_EN.Location = New System.Drawing.Point(392, 29)
        Me.txtDescForm_EN.MaxLength = 25
        Me.txtDescForm_EN.Name = "txtDescForm_EN"
        Me.txtDescForm_EN.Size = New System.Drawing.Size(340, 20)
        Me.txtDescForm_EN.TabIndex = 28
        '
        'lblDescDet_EN
        '
        Me.lblDescDet_EN.AutoSize = True
        Me.lblDescDet_EN.Location = New System.Drawing.Point(389, 104)
        Me.lblDescDet_EN.Name = "lblDescDet_EN"
        Me.lblDescDet_EN.Size = New System.Drawing.Size(111, 13)
        Me.lblDescDet_EN.TabIndex = 33
        Me.lblDescDet_EN.Text = "Descripción Detallada"
        '
        'txtAclarac_EN
        '
        Me.txtAclarac_EN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripDetalleTxTrad", True))
        Me.txtAclarac_EN.Location = New System.Drawing.Point(392, 189)
        Me.txtAclarac_EN.MaxLength = 999
        Me.txtAclarac_EN.Multiline = True
        Me.txtAclarac_EN.Name = "txtAclarac_EN"
        Me.txtAclarac_EN.Size = New System.Drawing.Size(340, 67)
        Me.txtAclarac_EN.TabIndex = 34
        '
        'txtDescCorta_FR
        '
        Me.txtDescCorta_FR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripCortaTxTrad", True))
        Me.txtDescCorta_FR.Location = New System.Drawing.Point(766, 68)
        Me.txtDescCorta_FR.MaxLength = 255
        Me.txtDescCorta_FR.Multiline = True
        Me.txtDescCorta_FR.Name = "txtDescCorta_FR"
        Me.txtDescCorta_FR.Size = New System.Drawing.Size(340, 33)
        Me.txtDescCorta_FR.TabIndex = 37
        '
        'txtDescDet_FR
        '
        Me.txtDescDet_FR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripDetalleTxTrad", True))
        Me.txtDescDet_FR.Location = New System.Drawing.Point(766, 120)
        Me.txtDescDet_FR.MaxLength = 255
        Me.txtDescDet_FR.Multiline = True
        Me.txtDescDet_FR.Name = "txtDescDet_FR"
        Me.txtDescDet_FR.Size = New System.Drawing.Size(340, 50)
        Me.txtDescDet_FR.TabIndex = 38
        '
        'lblDescCorta_FR
        '
        Me.lblDescCorta_FR.AutoSize = True
        Me.lblDescCorta_FR.Location = New System.Drawing.Point(763, 52)
        Me.lblDescCorta_FR.Name = "lblDescCorta_FR"
        Me.lblDescCorta_FR.Size = New System.Drawing.Size(91, 13)
        Me.lblDescCorta_FR.TabIndex = 40
        Me.lblDescCorta_FR.Text = "Descripción Corta"
        '
        'lblAclarac_FR
        '
        Me.lblAclarac_FR.AutoSize = True
        Me.lblAclarac_FR.Location = New System.Drawing.Point(763, 173)
        Me.lblAclarac_FR.Name = "lblAclarac_FR"
        Me.lblAclarac_FR.Size = New System.Drawing.Size(68, 13)
        Me.lblAclarac_FR.TabIndex = 43
        Me.lblAclarac_FR.Text = "Aclaraciones"
        '
        'lblDescForm_FR
        '
        Me.lblDescForm_FR.AutoSize = True
        Me.lblDescForm_FR.Location = New System.Drawing.Point(763, 13)
        Me.lblDescForm_FR.Name = "lblDescForm_FR"
        Me.lblDescForm_FR.Size = New System.Drawing.Size(138, 13)
        Me.lblDescForm_FR.TabIndex = 39
        Me.lblDescForm_FR.Text = "Descripción para Formulario"
        '
        'txtDescForm_FR
        '
        Me.txtDescForm_FR.Location = New System.Drawing.Point(766, 29)
        Me.txtDescForm_FR.MaxLength = 25
        Me.txtDescForm_FR.Name = "txtDescForm_FR"
        Me.txtDescForm_FR.Size = New System.Drawing.Size(340, 20)
        Me.txtDescForm_FR.TabIndex = 36
        '
        'lblDescDet_FR
        '
        Me.lblDescDet_FR.AutoSize = True
        Me.lblDescDet_FR.Location = New System.Drawing.Point(763, 104)
        Me.lblDescDet_FR.Name = "lblDescDet_FR"
        Me.lblDescDet_FR.Size = New System.Drawing.Size(111, 13)
        Me.lblDescDet_FR.TabIndex = 41
        Me.lblDescDet_FR.Text = "Descripción Detallada"
        '
        'txtAclarac_FR
        '
        Me.txtAclarac_FR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTx, "DescripDetalleTxTrad", True))
        Me.txtAclarac_FR.Location = New System.Drawing.Point(766, 189)
        Me.txtAclarac_FR.MaxLength = 999
        Me.txtAclarac_FR.Multiline = True
        Me.txtAclarac_FR.Name = "txtAclarac_FR"
        Me.txtAclarac_FR.Size = New System.Drawing.Size(340, 67)
        Me.txtAclarac_FR.TabIndex = 42
        '
        'lbl_ES
        '
        Me.lbl_ES.AutoSize = True
        Me.lbl_ES.Location = New System.Drawing.Point(294, 13)
        Me.lbl_ES.Name = "lbl_ES"
        Me.lbl_ES.Size = New System.Drawing.Size(45, 13)
        Me.lbl_ES.TabIndex = 44
        Me.lbl_ES.Text = "Español"
        '
        'lbl_EN
        '
        Me.lbl_EN.AutoSize = True
        Me.lbl_EN.Location = New System.Drawing.Point(677, 13)
        Me.lbl_EN.Name = "lbl_EN"
        Me.lbl_EN.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EN.TabIndex = 45
        Me.lbl_EN.Text = "Inglés"
        '
        'lbl_FR
        '
        Me.lbl_FR.AutoSize = True
        Me.lbl_FR.Location = New System.Drawing.Point(1041, 13)
        Me.lbl_FR.Name = "lbl_FR"
        Me.lbl_FR.Size = New System.Drawing.Size(45, 13)
        Me.lbl_FR.TabIndex = 46
        Me.lbl_FR.Text = "Francés"
        '
        'IdAtrTxDataGridViewTextBoxColumn
        '
        Me.IdAtrTxDataGridViewTextBoxColumn.DataPropertyName = "IdAtrTx"
        Me.IdAtrTxDataGridViewTextBoxColumn.HeaderText = "IdAtrTx"
        Me.IdAtrTxDataGridViewTextBoxColumn.Name = "IdAtrTxDataGridViewTextBoxColumn"
        Me.IdAtrTxDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAtrTxDataGridViewTextBoxColumn.Visible = False
        '
        'NumeroOrdenAtributoDataGridViewTextBoxColumn
        '
        Me.NumeroOrdenAtributoDataGridViewTextBoxColumn.DataPropertyName = "NumeroOrdenAtributo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumeroOrdenAtributoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NumeroOrdenAtributoDataGridViewTextBoxColumn.HeaderText = "Orden"
        Me.NumeroOrdenAtributoDataGridViewTextBoxColumn.Name = "NumeroOrdenAtributoDataGridViewTextBoxColumn"
        Me.NumeroOrdenAtributoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroOrdenAtributoDataGridViewTextBoxColumn.Width = 60
        '
        'NombreAtributoDataGridViewTextBoxColumn
        '
        Me.NombreAtributoDataGridViewTextBoxColumn.DataPropertyName = "NombreAtributo"
        Me.NombreAtributoDataGridViewTextBoxColumn.HeaderText = "Atributo"
        Me.NombreAtributoDataGridViewTextBoxColumn.Name = "NombreAtributoDataGridViewTextBoxColumn"
        Me.NombreAtributoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreAtributoDataGridViewTextBoxColumn.Width = 150
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoriaDataGridViewTextBoxColumn.Width = 60
        '
        'DescripcionCategoriaDataGridViewTextBoxColumn
        '
        Me.DescripcionCategoriaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCategoria"
        Me.DescripcionCategoriaDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionCategoriaDataGridViewTextBoxColumn.Name = "DescripcionCategoriaDataGridViewTextBoxColumn"
        Me.DescripcionCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionCategoriaDataGridViewTextBoxColumn.Width = 150
        '
        'UnidadMedidaAtributoDataGridViewTextBoxColumn
        '
        Me.UnidadMedidaAtributoDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedidaAtributo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UnidadMedidaAtributoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.UnidadMedidaAtributoDataGridViewTextBoxColumn.HeaderText = "U / M"
        Me.UnidadMedidaAtributoDataGridViewTextBoxColumn.Name = "UnidadMedidaAtributoDataGridViewTextBoxColumn"
        Me.UnidadMedidaAtributoDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnidadMedidaAtributoDataGridViewTextBoxColumn.Width = 60
        '
        'IdTxDataGridViewTextBoxColumn
        '
        Me.IdTxDataGridViewTextBoxColumn.DataPropertyName = "IdTx"
        Me.IdTxDataGridViewTextBoxColumn.HeaderText = "IdTx"
        Me.IdTxDataGridViewTextBoxColumn.Name = "IdTxDataGridViewTextBoxColumn"
        Me.IdTxDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTxDataGridViewTextBoxColumn.Visible = False
        '
        'IdTipoAtributoDataGridViewTextBoxColumn
        '
        Me.IdTipoAtributoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoAtributo"
        Me.IdTipoAtributoDataGridViewTextBoxColumn.HeaderText = "IdTipoAtributo"
        Me.IdTipoAtributoDataGridViewTextBoxColumn.Name = "IdTipoAtributoDataGridViewTextBoxColumn"
        Me.IdTipoAtributoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTipoAtributoDataGridViewTextBoxColumn.Visible = False
        '
        'IdUnidadDeMedidaDataGridViewTextBoxColumn
        '
        Me.IdUnidadDeMedidaDataGridViewTextBoxColumn.DataPropertyName = "IdUnidadDeMedida"
        Me.IdUnidadDeMedidaDataGridViewTextBoxColumn.HeaderText = "IdUnidadDeMedida"
        Me.IdUnidadDeMedidaDataGridViewTextBoxColumn.Name = "IdUnidadDeMedidaDataGridViewTextBoxColumn"
        Me.IdUnidadDeMedidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUnidadDeMedidaDataGridViewTextBoxColumn.Visible = False
        '
        'TipoValidacionDataGridViewTextBoxColumn
        '
        Me.TipoValidacionDataGridViewTextBoxColumn.DataPropertyName = "TipoValidacion"
        Me.TipoValidacionDataGridViewTextBoxColumn.HeaderText = "TipoValidacion"
        Me.TipoValidacionDataGridViewTextBoxColumn.Name = "TipoValidacionDataGridViewTextBoxColumn"
        Me.TipoValidacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreTablaDataGridViewTextBoxColumn
        '
        Me.NombreTablaDataGridViewTextBoxColumn.DataPropertyName = "NombreTabla"
        Me.NombreTablaDataGridViewTextBoxColumn.HeaderText = "NombreTabla"
        Me.NombreTablaDataGridViewTextBoxColumn.Name = "NombreTablaDataGridViewTextBoxColumn"
        Me.NombreTablaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AbreviacionTablaDataGridViewTextBoxColumn
        '
        Me.AbreviacionTablaDataGridViewTextBoxColumn.DataPropertyName = "AbreviacionTabla"
        Me.AbreviacionTablaDataGridViewTextBoxColumn.HeaderText = "AbreviacionTabla"
        Me.AbreviacionTablaDataGridViewTextBoxColumn.Name = "AbreviacionTablaDataGridViewTextBoxColumn"
        Me.AbreviacionTablaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTablaValidacionDataGridViewTextBoxColumn
        '
        Me.IdTablaValidacionDataGridViewTextBoxColumn.DataPropertyName = "IdTablaValidacion"
        Me.IdTablaValidacionDataGridViewTextBoxColumn.HeaderText = "IdTablaValidacion"
        Me.IdTablaValidacionDataGridViewTextBoxColumn.Name = "IdTablaValidacionDataGridViewTextBoxColumn"
        Me.IdTablaValidacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTablaValidacionDataGridViewTextBoxColumn.Visible = False
        '
        'ValorMinimoDataGridViewTextBoxColumn
        '
        Me.ValorMinimoDataGridViewTextBoxColumn.DataPropertyName = "ValorMinimo"
        Me.ValorMinimoDataGridViewTextBoxColumn.HeaderText = "ValorMinimo"
        Me.ValorMinimoDataGridViewTextBoxColumn.Name = "ValorMinimoDataGridViewTextBoxColumn"
        Me.ValorMinimoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorMaximoDataGridViewTextBoxColumn
        '
        Me.ValorMaximoDataGridViewTextBoxColumn.DataPropertyName = "ValorMaximo"
        Me.ValorMaximoDataGridViewTextBoxColumn.HeaderText = "ValorMaximo"
        Me.ValorMaximoDataGridViewTextBoxColumn.Name = "ValorMaximoDataGridViewTextBoxColumn"
        Me.ValorMaximoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IncrementoDataGridViewTextBoxColumn
        '
        Me.IncrementoDataGridViewTextBoxColumn.DataPropertyName = "Incremento"
        Me.IncrementoDataGridViewTextBoxColumn.HeaderText = "Incremento"
        Me.IncrementoDataGridViewTextBoxColumn.Name = "IncrementoDataGridViewTextBoxColumn"
        Me.IncrementoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IconoDataGridViewTextBoxColumn
        '
        Me.IconoDataGridViewTextBoxColumn.DataPropertyName = "Icono"
        Me.IconoDataGridViewTextBoxColumn.HeaderText = "Icono"
        Me.IconoDataGridViewTextBoxColumn.Name = "IconoDataGridViewTextBoxColumn"
        Me.IconoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModificableDataGridViewCheckBoxColumn
        '
        Me.ModificableDataGridViewCheckBoxColumn.DataPropertyName = "Modificable"
        Me.ModificableDataGridViewCheckBoxColumn.HeaderText = "Modificable"
        Me.ModificableDataGridViewCheckBoxColumn.Name = "ModificableDataGridViewCheckBoxColumn"
        Me.ModificableDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ObligatorioDataGridViewCheckBoxColumn
        '
        Me.ObligatorioDataGridViewCheckBoxColumn.DataPropertyName = "Obligatorio"
        Me.ObligatorioDataGridViewCheckBoxColumn.HeaderText = "Obligatorio"
        Me.ObligatorioDataGridViewCheckBoxColumn.Name = "ObligatorioDataGridViewCheckBoxColumn"
        Me.ObligatorioDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'MascarillaDataGridViewTextBoxColumn
        '
        Me.MascarillaDataGridViewTextBoxColumn.DataPropertyName = "Mascarilla"
        Me.MascarillaDataGridViewTextBoxColumn.HeaderText = "Mascarilla"
        Me.MascarillaDataGridViewTextBoxColumn.Name = "MascarillaDataGridViewTextBoxColumn"
        Me.MascarillaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InterrogableDataGridViewCheckBoxColumn
        '
        Me.InterrogableDataGridViewCheckBoxColumn.DataPropertyName = "Interrogable"
        Me.InterrogableDataGridViewCheckBoxColumn.HeaderText = "Interrogable"
        Me.InterrogableDataGridViewCheckBoxColumn.Name = "InterrogableDataGridViewCheckBoxColumn"
        Me.InterrogableDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'IdCreadoDataGridViewTextBoxColumn
        '
        Me.IdCreadoDataGridViewTextBoxColumn.DataPropertyName = "IdCreado"
        Me.IdCreadoDataGridViewTextBoxColumn.HeaderText = "IdCreado"
        Me.IdCreadoDataGridViewTextBoxColumn.Name = "IdCreadoDataGridViewTextBoxColumn"
        Me.IdCreadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdUltimoCambioDataGridViewTextBoxColumn
        '
        Me.IdUltimoCambioDataGridViewTextBoxColumn.DataPropertyName = "IdUltimoCambio"
        Me.IdUltimoCambioDataGridViewTextBoxColumn.HeaderText = "IdUltimoCambio"
        Me.IdUltimoCambioDataGridViewTextBoxColumn.Name = "IdUltimoCambioDataGridViewTextBoxColumn"
        Me.IdUltimoCambioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdBorradoLDataGridViewTextBoxColumn
        '
        Me.IdBorradoLDataGridViewTextBoxColumn.DataPropertyName = "IdBorradoL"
        Me.IdBorradoLDataGridViewTextBoxColumn.HeaderText = "IdBorradoL"
        Me.IdBorradoLDataGridViewTextBoxColumn.Name = "IdBorradoLDataGridViewTextBoxColumn"
        Me.IdBorradoLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsAtrTx
        '
        Me.bsAtrTx.DataSource = GetType(clsDataLib.clsInd_AtrTx)
        '
        'bsTx
        '
        Me.bsTx.DataSource = GetType(clsDataLib.listInd_Tx)
        '
        'frmArbolTx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 682)
        Me.Controls.Add(Me.tabCtrl)
        Me.Name = "frmArbolTx"
        Me.Text = "Detalles de ArbolTx"
        Me.tabCtrl.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.panAtrTx.ResumeLayout(False)
        Me.panAtrData.ResumeLayout(False)
        Me.panAtrData.PerformLayout()
        Me.tabAtrTx.ResumeLayout(False)
        Me.tabListaAtrTx.ResumeLayout(False)
        CType(Me.dgvIndAtrTx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetAtrTx.ResumeLayout(False)
        Me.tabDetAtrTx.PerformLayout()
        Me.grpValidacion.ResumeLayout(False)
        Me.grpValidacion.PerformLayout()
        Me.grpUniMed.ResumeLayout(False)
        Me.grpUniMed.PerformLayout()
        Me.grpTipoAtrib.ResumeLayout(False)
        Me.grpTipoAtrib.PerformLayout()
        CType(Me.bnAtrTx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnAtrTx.ResumeLayout(False)
        Me.bnAtrTx.PerformLayout()
        Me.panDescrip.ResumeLayout(False)
        Me.panDescrip.PerformLayout()
        CType(Me.bsAtrTx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrl As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents tabDetalle As TabPage
    Friend WithEvents txtDescDet_ES As TextBox
    Friend WithEvents txtDescCorta_ES As TextBox
    Friend WithEvents txtDescForm_ES As TextBox
    Friend WithEvents bsTx As BindingSource
    Friend WithEvents lblDescDet_ES As Label
    Friend WithEvents lblDescCorta_ES As Label
    Friend WithEvents lblDescForm_ES As Label
    Friend WithEvents lblAclarac_ES As Label
    Friend WithEvents txtAclarac_ES As TextBox
    Friend WithEvents panAtrTx As Panel
    Friend WithEvents panAtrData As Panel
    Friend WithEvents dgvIndAtrTx As DataGridView
    Friend WithEvents bsAtrTx As BindingSource
    Friend WithEvents panDescrip As Panel
    Friend WithEvents panBotones As Panel
    Friend WithEvents bnAtrTx As BindingNavigator
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
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblID As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents tabAtrTx As TabControl
    Friend WithEvents tabListaAtrTx As TabPage
    Friend WithEvents tabDetAtrTx As TabPage
    Friend WithEvents txtIdAtrTx As TextBox
    Friend WithEvents lblIDAtrTx As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents lblNombAtrib As Label
    Friend WithEvents txtNombAtrib As TextBox
    Friend WithEvents lblTipoAtributo As Label
    Friend WithEvents txtIdTipoAtrib As TextBox
    Friend WithEvents lblOrden As Label
    Friend WithEvents txtOrden As TextBox
    Friend WithEvents lblUniMed As Label
    Friend WithEvents txtUniMed As TextBox
    Friend WithEvents lblIDUniMed As Label
    Friend WithEvents txtIDUniMed As TextBox
    Friend WithEvents chkInterrogable As CheckBox
    Friend WithEvents chkMascarilla As CheckBox
    Friend WithEvents chkObligatorio As CheckBox
    Friend WithEvents chkModificable As CheckBox
    Friend WithEvents grpValidacion As GroupBox
    Friend WithEvents lblValIncrem As Label
    Friend WithEvents txtIncrem As TextBox
    Friend WithEvents lblValMax As Label
    Friend WithEvents txtValMax As TextBox
    Friend WithEvents lblValMin As Label
    Friend WithEvents txtValMin As TextBox
    Friend WithEvents lblTablaValidac As Label
    Friend WithEvents txtIdTablaValidac As TextBox
    Friend WithEvents lblIdTablaValidac As Label
    Friend WithEvents lblTipoValid As Label
    Friend WithEvents txtTablaValidac As TextBox
    Friend WithEvents txtTipoValidac As TextBox
    Friend WithEvents grpUniMed As GroupBox
    Friend WithEvents grpTipoAtrib As GroupBox
    Friend WithEvents tsbRegresar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnGuardarAtr As Button
    Friend WithEvents IdAtrTxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents flecha As DataGridViewImageColumn
    Friend WithEvents NumeroOrdenAtributoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreAtributoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaAtributoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdTxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoAtributoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoAtributo As DataGridViewTextBoxColumn
    Friend WithEvents IdUnidadDeMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoValidacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreTablaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbreviacionTablaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdTablaValidacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncrementoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IconoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModificableDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ObligatorioDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MascarillaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterrogableDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdCreadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdUltimoCambioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdBorradoLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtDescCorta_FR As TextBox
    Friend WithEvents txtDescDet_FR As TextBox
    Friend WithEvents lblDescCorta_FR As Label
    Friend WithEvents lblAclarac_FR As Label
    Friend WithEvents lblDescForm_FR As Label
    Friend WithEvents txtDescForm_FR As TextBox
    Friend WithEvents lblDescDet_FR As Label
    Friend WithEvents txtAclarac_FR As TextBox
    Friend WithEvents txtDescCorta_EN As TextBox
    Friend WithEvents txtDescDet_EN As TextBox
    Friend WithEvents lblDescCorta_EN As Label
    Friend WithEvents lblAclarac_EN As Label
    Friend WithEvents lblDescForm_EN As Label
    Friend WithEvents txtDescForm_EN As TextBox
    Friend WithEvents lblDescDet_EN As Label
    Friend WithEvents txtAclarac_EN As TextBox
    Friend WithEvents lbl_FR As Label
    Friend WithEvents lbl_EN As Label
    Friend WithEvents lbl_ES As Label
End Class
