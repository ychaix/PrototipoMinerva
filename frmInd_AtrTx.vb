Imports clsDataLib
Public Class frmInd_AtrTx
    Private lista As listInd_AtrTx
    Private det As clsInd_Tx
    Private bs As New BindingSource
    Private perfilAdmin As Boolean = False
    Private cargado As Boolean = False
    '
    Private Sub frmAtrTx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabDetalle.Parent = Nothing
        tabLista.Parent = tabCtrl
        '        
        perfilAdmin = clsUsuarioDB.selPerfilTipo(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, 1)
        tsbNuevo.Enabled = perfilAdmin
        Me.cargaListado()
        cargado = True
    End Sub
    Private Sub cargaListado()
        lista = New listInd_AtrTx
        lista = clsInd_AtrTxDB.lista(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato)
        bs.DataSource = lista
        bn.BindingSource = bs
        dgv.DataSource = bs
        '
        ' JUST FOR THE LOOK
        dgv.GridColor = Color.FromArgb(211, 222, 229)
        dgv.RowsDefaultCellStyle.BackColor = Color.AliceBlue
        dgv.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue
        dgv.RowsDefaultCellStyle.SelectionForeColor = Color.White
        '
    End Sub
    '
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
    '
End Class