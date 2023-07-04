<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddTx))
        Me.txtCodigoTx = New System.Windows.Forms.TextBox()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.txtIdTxPadre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblCodigoTx = New System.Windows.Forms.Label()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.lblIdTxPadre = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCodigoTx
        '
        Me.txtCodigoTx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoTx.Location = New System.Drawing.Point(41, 99)
        Me.txtCodigoTx.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoTx.Name = "txtCodigoTx"
        Me.txtCodigoTx.Size = New System.Drawing.Size(132, 22)
        Me.txtCodigoTx.TabIndex = 0
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(202, 99)
        Me.txtNivel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(132, 22)
        Me.txtNivel.TabIndex = 1
        '
        'txtIdTxPadre
        '
        Me.txtIdTxPadre.Location = New System.Drawing.Point(367, 99)
        Me.txtIdTxPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdTxPadre.Name = "txtIdTxPadre"
        Me.txtIdTxPadre.ReadOnly = True
        Me.txtIdTxPadre.Size = New System.Drawing.Size(132, 22)
        Me.txtIdTxPadre.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(41, 160)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(458, 62)
        Me.txtDescripcion.TabIndex = 3
        '
        'lblCodigoTx
        '
        Me.lblCodigoTx.AutoSize = True
        Me.lblCodigoTx.Location = New System.Drawing.Point(38, 79)
        Me.lblCodigoTx.Name = "lblCodigoTx"
        Me.lblCodigoTx.Size = New System.Drawing.Size(67, 16)
        Me.lblCodigoTx.TabIndex = 5
        Me.lblCodigoTx.Text = "CódigoTx"
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(199, 79)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(39, 16)
        Me.lblNivel.TabIndex = 6
        Me.lblNivel.Text = "Nivel"
        '
        'lblIdTxPadre
        '
        Me.lblIdTxPadre.AutoSize = True
        Me.lblIdTxPadre.Location = New System.Drawing.Point(364, 79)
        Me.lblIdTxPadre.Name = "lblIdTxPadre"
        Me.lblIdTxPadre.Size = New System.Drawing.Size(71, 16)
        Me.lblIdTxPadre.TabIndex = 7
        Me.lblIdTxPadre.Text = "IdTxPadre"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(38, 140)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(142, 16)
        Me.lblDescripcion.TabIndex = 8
        Me.lblDescripcion.Text = "Descripción Temporal"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(202, 249)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(113, 28)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(41, 249)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(105, 28)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(193, 26)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(122, 20)
        Me.lblTitulo.TabIndex = 17
        Me.lblTitulo.Text = "Agregar IndTx"
        '
        'frmAddTx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblIdTxPadre)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.lblCodigoTx)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdTxPadre)
        Me.Controls.Add(Me.txtNivel)
        Me.Controls.Add(Me.txtCodigoTx)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddTx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar IndTx"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigoTx As TextBox
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents txtIdTxPadre As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblCodigoTx As Label
    Friend WithEvents lblNivel As Label
    Friend WithEvents lblIdTxPadre As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblTitulo As Label
End Class
