Imports clsDataLib
'
Public Class frmConsultaTaxon
    '
    Private lista As listInd_Tx
    Private det As clsInd_Tx
    Private bs As New BindingSource
    Private perfilAdmin As Boolean = False
    Private cargado As Boolean = False
    '
    Public Property filtroViejo As String = String.Empty
    '
    Private Sub frmConsultaTaxon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabDetalle.Parent = Nothing
        tabLista.Parent = tabCtrl
        '        
        perfilAdmin = clsUsuarioDB.selPerfilTipo(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, 1)
        tsbNuevo.Enabled = perfilAdmin
        Me.cargaListado()
        cargado = True
        '
    End Sub
    '
    Private Sub cargaListado()
        '
        tstFiltro.Image = My.Resources.filtrovacio_icon
        If clsFiltrosDB.ExisteFiltro(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, "ConsultaTaxon") Then
            filtroViejo = clsFiltrosDB.LeerFiltro(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, "ConsultaTaxon")
            If filtroViejo <> String.Empty Then
                tstFiltro.Image = My.Resources.filtrolleno_icon
            End If
        End If
        '
        lista = New listInd_Tx
        lista = clsInd_TxDB.listaDescrip(Proy_Yves.m_Usuario, Proy_Yves.m_Clave, Proy_Yves.m_BaseDato, filtroViejo)
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

    Private Sub tstFiltro_Click(sender As Object, e As EventArgs) Handles tstFiltro.Click
        Dim abcBuscar As New frmConsultaTxFiltro
        Dim result As DialogResult = abcBuscar.ShowDialog
        If result = DialogResult.OK Then
            Me.cargaListado()
            If filtroViejo <> String.Empty Then
                tstFiltro.Image = My.Resources.filtrolleno_icon
            Else
                tstFiltro.Image = My.Resources.filtrovacio_icon
            End If
        End If
        Me.cargaListado()
        '
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
    '
End Class