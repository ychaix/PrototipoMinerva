<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaTxFiltro
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
        Me.lblCodTx = New System.Windows.Forms.Label()
        Me.txtCodTxDesde = New System.Windows.Forms.TextBox()
        Me.txtCodTxHasta = New System.Windows.Forms.TextBox()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.txtIdiomaDesde = New System.Windows.Forms.TextBox()
        Me.txtNivelHasta = New System.Windows.Forms.TextBox()
        Me.txtNivelDesde = New System.Windows.Forms.TextBox()
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCodTx
        '
        Me.lblCodTx.AutoSize = True
        Me.lblCodTx.Location = New System.Drawing.Point(48, 137)
        Me.lblCodTx.Name = "lblCodTx"
        Me.lblCodTx.Size = New System.Drawing.Size(99, 16)
        Me.lblCodTx.TabIndex = 0
        Me.lblCodTx.Text = "Código Taxón :"
        '
        'txtCodTxDesde
        '
        Me.txtCodTxDesde.Location = New System.Drawing.Point(164, 134)
        Me.txtCodTxDesde.Name = "txtCodTxDesde"
        Me.txtCodTxDesde.Size = New System.Drawing.Size(100, 22)
        Me.txtCodTxDesde.TabIndex = 1
        '
        'txtCodTxHasta
        '
        Me.txtCodTxHasta.Location = New System.Drawing.Point(303, 134)
        Me.txtCodTxHasta.Name = "txtCodTxHasta"
        Me.txtCodTxHasta.Size = New System.Drawing.Size(100, 22)
        Me.txtCodTxHasta.TabIndex = 2
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(191, 96)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(49, 16)
        Me.lblDesde.TabIndex = 3
        Me.lblDesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(327, 96)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(44, 16)
        Me.lblHasta.TabIndex = 4
        Me.lblHasta.Text = "Hasta"
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(102, 195)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(45, 16)
        Me.lblNivel.TabIndex = 5
        Me.lblNivel.Text = "Nivel :"
        '
        'txtIdiomaDesde
        '
        Me.txtIdiomaDesde.Location = New System.Drawing.Point(164, 251)
        Me.txtIdiomaDesde.Name = "txtIdiomaDesde"
        Me.txtIdiomaDesde.Size = New System.Drawing.Size(100, 22)
        Me.txtIdiomaDesde.TabIndex = 6
        '
        'txtNivelHasta
        '
        Me.txtNivelHasta.Location = New System.Drawing.Point(303, 192)
        Me.txtNivelHasta.Name = "txtNivelHasta"
        Me.txtNivelHasta.Size = New System.Drawing.Size(100, 22)
        Me.txtNivelHasta.TabIndex = 9
        '
        'txtNivelDesde
        '
        Me.txtNivelDesde.Location = New System.Drawing.Point(164, 192)
        Me.txtNivelDesde.Name = "txtNivelDesde"
        Me.txtNivelDesde.Size = New System.Drawing.Size(100, 22)
        Me.txtNivelDesde.TabIndex = 8
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Location = New System.Drawing.Point(92, 254)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(55, 16)
        Me.lblIdioma.TabIndex = 10
        Me.lblIdioma.Text = "Idioma :"
        '
        'btnQuitar
        '
        Me.btnQuitar.Enabled = False
        Me.btnQuitar.Location = New System.Drawing.Point(303, 331)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(110, 23)
        Me.btnQuitar.TabIndex = 11
        Me.btnQuitar.Text = "Quitar Filtros"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(155, 331)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(109, 23)
        Me.btnAplicar.TabIndex = 12
        Me.btnAplicar.Text = "Aplicar Filtro"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(177, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(164, 16)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "DEFINICIÓN DE FILTROS"
        '
        'frmConsultaTxFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 419)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.lblIdioma)
        Me.Controls.Add(Me.txtNivelHasta)
        Me.Controls.Add(Me.txtNivelDesde)
        Me.Controls.Add(Me.txtIdiomaDesde)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.txtCodTxHasta)
        Me.Controls.Add(Me.txtCodTxDesde)
        Me.Controls.Add(Me.lblCodTx)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaTxFiltro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ConsultaTx - Filtros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodTx As Label
    Friend WithEvents txtCodTxDesde As TextBox
    Friend WithEvents txtCodTxHasta As TextBox
    Friend WithEvents lblDesde As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents lblNivel As Label
    Friend WithEvents txtIdiomaDesde As TextBox
    Friend WithEvents txtNivelHasta As TextBox
    Friend WithEvents txtNivelDesde As TextBox
    Friend WithEvents lblIdioma As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAplicar As Button
    Friend WithEvents lblTitulo As Label
End Class
