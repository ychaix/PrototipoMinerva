Public Class clsInd_TxDITx
    Private m_IdTxDITx As Integer
    Private m_IdITx As Integer
    Private m_IdTx As Integer
    Private m_IdTipoRel As Integer
    Private m_CodigoTx As String
    Private m_IsPrimaryCategory As Boolean
    Private m_IdTipoRelacion As Integer
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
    '
    Public Property IdTxDITx As Integer
        Get
            Return m_IdTxDITx
        End Get
        Set(value As Integer)
            If m_IdTxDITx = value Then Return
            m_IdTxDITx = value
        End Set
    End Property
    '
    Public Property IdITx As Integer
        Get
            Return m_IdITx
        End Get
        Set(value As Integer)
            If m_IdITx = value Then Return
            m_IdITx = value
        End Set
    End Property
    '
    Public Property IdTx As Integer
        Get
            Return m_IdTx
        End Get
        Set(value As Integer)
            If m_IdTx = value Then Return
            m_IdTx = value
        End Set
    End Property
    '
    Public Property IdTipoRel As Integer
        Get
            Return m_IdTipoRel
        End Get
        Set(value As Integer)
            If m_IdTipoRel = value Then Return
            m_IdTipoRel = value
        End Set
    End Property
    '
    Public Property CodigoTx As String
        Get
            Return m_CodigoTx
        End Get
        Set(value As String)
            If m_CodigoTx = value Then Return
            m_CodigoTx = value
        End Set
    End Property
    '
    Public Property IsPrimaryCategory As Boolean
        Get
            Return m_IsPrimaryCategory
        End Get
        Set(value As Boolean)
            If m_IsPrimaryCategory = value Then Return
            m_IsPrimaryCategory = value
        End Set
    End Property
    '
    Public Property IdTipoRelacion As Integer
        Get
            Return m_IdTipoRelacion
        End Get
        Set(value As Integer)
            If m_IdTipoRelacion = value Then Return
            m_IdTipoRelacion = value
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
