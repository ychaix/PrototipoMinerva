Imports clsDataLib
Public Class frmAddTx
    Public txNew As clsInd_Tx
    Private txTrad As clsInd_TxTraducido
    Private letrasPermitidas As String = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ"
    Private cargado As Boolean = False
    Private Sub frmAddTx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigoTx.Text = txNew.CodigoTx
        txtNivel.Text = txNew.Nivel
        txtIdTxPadre.Text = txNew.IdTxPadre.ToString
        txtDescripcion.Text = txNew.DescripcionTemporal
        txtDescripcion.Select()
        cargado = True
    End Sub
    '
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            With txNew
                .CodigoTx = txtCodigoTx.Text
                .DescripcionTemporal = txtDescripcion.Text
            End With
            Dim mIdTx As Integer = clsInd_TxDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txNew)
            '
            txTrad = New clsInd_TxTraducido
            With txTrad
                .IdTx = mIdTx
                .IdIdioma = 5831
                .DescCortaTxTraducida = txNew.DescripcionTemporal
            End With
            clsInd_TxTraducidoDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txTrad)
            '
            txTrad = New clsInd_TxTraducido
            With txTrad
                .IdTx = mIdTx
                .IdIdioma = 5832
                .DescCortaTxTraducida = txNew.DescripcionTemporal
            End With
            clsInd_TxTraducidoDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txTrad)
            '
            txTrad = New clsInd_TxTraducido
            With txTrad
                .IdTx = mIdTx
                .IdIdioma = 5833
                .DescCortaTxTraducida = txNew.DescripcionTemporal
            End With
            clsInd_TxTraducidoDB.insertar(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txTrad)
            '
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    '
    Private Sub txtCodigoTx_Leave(sender As Object, e As EventArgs) Handles txtCodigoTx.Leave
        If cargado Then
            Dim caracter = Mid(txtCodigoTx.Text, txNew.Nivel, 1)
            If Len(txtCodigoTx.Text) <> txNew.Nivel Or Mid(txtCodigoTx.Text, 1, txNew.Nivel - 1) <> Mid(txNew.CodigoTx, 1, txNew.Nivel - 1) Then
                MessageBox.Show("Error en Código, favor verificar ... ")
                txtCodigoTx.Text = txNew.CodigoTx
            ElseIf letrasPermitidas.Contains(caracter) = False Then
                MessageBox.Show("Error carácter '" & caracter & "' no es válido favor verificar ... ")
                txtCodigoTx.Text = txNew.CodigoTx
            ElseIf clsInd_TxDB.existeCodigoTx(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, txtCodigoTx.text) Then
                MessageBox.Show("Error código '" & txtCodigoTx.Text & "' registrado anteriormente, favor verificar ... ")
                txtCodigoTx.Text = txNew.CodigoTx
            End If
        End If
    End Sub
    '
End Class