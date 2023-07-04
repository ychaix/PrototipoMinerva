Public Class clsInd_TipoRelVTx
    Private m_IdTipoRelVTx As Integer
    Private m_IdTiposRelPadre As Integer
    Private m_IdTx1 As Integer
    Private m_IdTx2 As Integer
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
    '
    Public Property IdTipoRelVTx As Integer
        Get
            Return m_IdTipoRelVTx
        End Get
        Set(value As Integer)
            If m_IdTipoRelVTx = value Then Return
            m_IdTipoRelVTx = value
        End Set
    End Property
    '
    Public Property IdTiposRelPadre As Integer
        Get
            Return m_IdTiposRelPadre
        End Get
        Set(value As Integer)
            If m_IdTiposRelPadre = value Then Return
            m_IdTiposRelPadre = value
        End Set
    End Property
    '
    Public Property IdTx1 As Integer
        Get
            Return m_IdTx1
        End Get
        Set(value As Integer)
            If m_IdTx1 = value Then Return
            m_IdTx1 = value
        End Set
    End Property
    '
    Public Property IdTx2 As Integer
        Get
            Return m_IdTx2
        End Get
        Set(value As Integer)
            If m_IdTx2 = value Then Return
            m_IdTx2 = value
        End Set
    End Property
    '
    Public Property IdCreado As Integer
        Get
            Return m_IdCreado
        End Get
        Set(value As Integer)
            If m_IdCreado = value Then Return
            m_IdCreado = value
        End Set
    End Property
    '
    Public Property IdUltimoCambio As Integer
        Get
            Return m_IdUltimoCambio
        End Get
        Set(value As Integer)
            If m_IdUltimoCambio = value Then Return
            m_IdUltimoCambio = value
        End Set
    End Property
    '
    Public Property IdBorradoL As Integer
        Get
            Return m_IdBorradoL
        End Get
        Set(value As Integer)
            If m_IdBorradoL = value Then Return
            m_IdBorradoL = value
        End Set
    End Property

End Class
