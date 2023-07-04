Public Class clsInd_RelVITx
    Private m_IdRelVITx As Integer
    Private m_IdITx1 As Integer
    Private m_IdITx2 As Integer
    Private m_IdRelVTx As Integer
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
    '
    Public Property IdRelVITx As Integer
        Get
            Return m_IdRelVITx
        End Get
        Set(value As Integer)
            If m_IdRelVITx = value Then Return
            m_IdRelVITx = value
        End Set
    End Property
    '
    Public Property IdITx1 As Integer
        Get
            Return m_IdITx1
        End Get
        Set(value As Integer)
            If m_IdITx1 = value Then Return
            m_IdITx1 = value
        End Set
    End Property
    '
    Public Property IdITx2 As Integer
        Get
            Return m_IdITx2
        End Get
        Set(value As Integer)
            If m_IdITx2 = value Then Return
            m_IdITx2 = value
        End Set
    End Property
    '
    Public Property IdRelVTx As Integer
        Get
            Return m_IdRelVTx
        End Get
        Set(value As Integer)
            If m_IdRelVTx = value Then Return
            m_IdRelVTx = value
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
