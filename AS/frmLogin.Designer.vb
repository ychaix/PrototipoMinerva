<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.cboBaseDato = New System.Windows.Forms.ComboBox()
        Me.lblBaseDato = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboBaseDato
        '
        Me.cboBaseDato.FormattingEnabled = True
        Me.cboBaseDato.Items.AddRange(New Object() {"Minerva_V25", "Minerva_Desarrollo"})
        Me.cboBaseDato.Location = New System.Drawing.Point(109, 156)
        Me.cboBaseDato.Name = "cboBaseDato"
        Me.cboBaseDato.Size = New System.Drawing.Size(148, 21)
        Me.cboBaseDato.TabIndex = 15
        Me.cboBaseDato.Tag = "Base de Datos"
        Me.cboBaseDato.Text = "Minerva_V25"
        '
        'lblBaseDato
        '
        Me.lblBaseDato.Location = New System.Drawing.Point(106, 137)
        Me.lblBaseDato.Name = "lblBaseDato"
        Me.lblBaseDato.Size = New System.Drawing.Size(126, 23)
        Me.lblBaseDato.TabIndex = 16
        Me.lblBaseDato.Text = "&Base de Datos"
        Me.lblBaseDato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.NavajoWhite
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Image = CType(resources.GetObject("Cancel.Image"), System.Drawing.Image)
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.Location = New System.Drawing.Point(188, 209)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(90, 28)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.NavajoWhite
        Me.OK.Image = CType(resources.GetObject("OK.Image"), System.Drawing.Image)
        Me.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK.Location = New System.Drawing.Point(92, 209)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(90, 28)
        Me.OK.TabIndex = 13
        Me.OK.Text = "&Aceptar"
        Me.OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK.UseVisualStyleBackColor = False
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(108, 110)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(149, 20)
        Me.txtClave.TabIndex = 12
        Me.txtClave.Tag = "Contraseña"
        Me.txtClave.Text = "Pa$$w0rd1*"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(107, 63)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(150, 20)
        Me.txtUsuario.TabIndex = 10
        Me.txtUsuario.Tag = "Nombre de Usuario"
        Me.txtUsuario.Text = "ACALERO"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(106, 90)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(126, 23)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "&Contraseña"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(105, 43)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(127, 23)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "&Nombre de usuario"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 269)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboBaseDato)
        Me.Controls.Add(Me.lblBaseDato)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboBaseDato As ComboBox
    Friend WithEvents lblBaseDato As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents txtClave As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
End Class
