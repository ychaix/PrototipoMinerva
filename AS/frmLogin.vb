Imports clsDataLib
Public Class frmLogin
    Public idUsuario As Integer
    Private bitacora As clsBitacora
    '
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Validar.existe(txtUsuario) And Validar.existe(txtClave) Then
                idUsuario = clsUsuarioDB.selUsuarioClave(txtUsuario.Text, txtClave.Text, cboBaseDato.Text)
                If idUsuario <= 0 Then
                    MessageBox.Show("Error en nombre de usuario y/o contraseña", "Usuario no existe")
                    txtClave.Text = ""
                    txtClave.Select()
                Else
                    Proy_Yves.m_IDUsuario = idUsuario
                    Proy_Yves.m_Usuario = txtUsuario.Text
                    Proy_Yves.m_Clave = txtClave.Text
                    Proy_Yves.m_BaseDato = cboBaseDato.SelectedItem.ToString
                    '
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        Catch ex As Exception
            If Mid(ex.Message, 1, 12) = "Login failed" Then
                MessageBox.Show("Error en nombre de usuario y/o contraseña", "Usuario no existe")
            End If
            ' MessageBox.Show(ex.Message)
            txtClave.Text = ""
            txtClave.Select()
        End Try
    End Sub
    '
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub
    '
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub
    '
    Private Sub NoEditarCombos(sender As Object, e As KeyPressEventArgs) Handles cboBaseDato.KeyPress
        e.Handled = True
        lblBaseDato.Select()
    End Sub

End Class