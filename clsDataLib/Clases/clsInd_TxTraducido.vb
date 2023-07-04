Public Class clsInd_TxTraducido
    Private m_IdTxTraducido As Integer
    Private m_IdTx As Integer
    Private m_IdIdioma As Integer
    Private m_DescripciónParaFormulario As String
    Private m_DescCortaTxTraducida As String
    Private m_DescrDetTxTraducida As String
    Private m_Aclaraciones As String
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
    '
    Public Property IdTxTraducido As Integer
        Get
            Return m_IdTxTraducido
        End Get
        Set(value As Integer)
            If m_IdTxTraducido = value Then Return
            m_IdTxTraducido = value
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
    Public Property IdIdioma As Integer
        Get
            Return m_IdIdioma
        End Get
        Set(value As Integer)
            If m_IdIdioma = value Then Return
            m_IdIdioma = value
        End Set
    End Property
    '
    Public Property DescripciónParaFormulario As String
        Get
            Return m_DescripciónParaFormulario
        End Get
        Set(value As String)
            If m_DescripciónParaFormulario = value Then Return
            m_DescripciónParaFormulario = value
        End Set
    End Property
    '
    Public Property DescCortaTxTraducida As String
        Get
            Return m_DescCortaTxTraducida
        End Get
        Set(value As String)
            If m_DescCortaTxTraducida = value Then Return
            m_DescCortaTxTraducida = value
        End Set
    End Property
    '
    Public Property DescrDetTxTraducida As String
        Get
            Return m_DescrDetTxTraducida
        End Get
        Set(value As String)
            If m_DescrDetTxTraducida = value Then Return
            m_DescrDetTxTraducida = value
        End Set
    End Property
    '
    Public Property Aclaraciones As String
        Get
            Return m_Aclaraciones
        End Get
        Set(value As String)
            If m_Aclaraciones = value Then Return
            m_Aclaraciones = value
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
