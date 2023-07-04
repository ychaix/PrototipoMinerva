Public Class clsInd_Tx
    Private m_IdTx As Integer
    Private m_Nivel As Integer
    Private m_CodigoTx As String
    Private m_IdTxPadre As Integer
    Private m_DescripcionTemporal As String
    Private m_TaxonPadre As String
    Private m_TaxonTieneHijo As Boolean
    Private m_Sistema As Boolean
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
    '
    Private m_IdTxTrad As Integer
    Private m_IdIdioma As Integer
    Private m_DescripParaFormulario As String
    Private m_DescripCortaTxTrad As String
    Private m_DescripDetalleTxTrad As String
    Private m_Aclaraciones As String
    Private m_DescCortaTxTraducida As String
    '
    Private m_NombreAtri As String
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
    Public Property Nivel As Integer
        Get
            Return m_Nivel
        End Get
        Set(value As Integer)
            If m_Nivel = value Then Return
            m_Nivel = value
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
    Public Property IdTxPadre As Integer
        Get
            Return m_IdTxPadre
        End Get
        Set(value As Integer)
            If m_IdTxPadre = value Then Return
            m_IdTxPadre = value
        End Set
    End Property
    '
    Public Property DescripcionTemporal As String
        Get
            Return m_DescripcionTemporal
        End Get
        Set(value As String)
            If m_DescripcionTemporal = value Then Return
            m_DescripcionTemporal = value
        End Set
    End Property
    '
    Public Property TaxonPadre As String
        Get
            Return m_TaxonPadre
        End Get
        Set(value As String)
            If m_TaxonPadre = value Then Return
            m_TaxonPadre = value
        End Set
    End Property
    '
    Public Property TaxonTieneHijo As Boolean
        Get
            Return m_TaxonTieneHijo
        End Get
        Set(value As Boolean)
            If m_TaxonTieneHijo = value Then Return
            m_TaxonTieneHijo = value
        End Set
    End Property
    '
    Public Property Sistema As Boolean
        Get
            Return m_Sistema
        End Get
        Set(value As Boolean)
            If m_Sistema = value Then Return
            m_Sistema = value
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
    '
    Public Property IdTxTrad As Integer
        Get
            Return m_IdTxTrad
        End Get
        Set(value As Integer)
            If m_IdTxTrad = value Then Return
            m_IdTxTrad = value
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
    Public Property DescripParaFormulario As String
        Get
            Return m_DescripParaFormulario
        End Get
        Set(value As String)
            If m_DescripParaFormulario = value Then Return
            m_DescripParaFormulario = value
        End Set
    End Property
    '
    Public Property DescripCortaTxTrad As String
        Get
            Return m_DescripCortaTxTrad
        End Get
        Set(value As String)
            If m_DescripCortaTxTrad = value Then Return
            m_DescripCortaTxTrad = value
        End Set
    End Property
    '
    Public Property DescripDetalleTxTrad As String
        Get
            Return m_DescripDetalleTxTrad
        End Get
        Set(value As String)
            If m_DescripDetalleTxTrad = value Then Return
            m_DescripDetalleTxTrad = value
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
    Public Property NombreAtri As String
        Get
            Return m_NombreAtri
        End Get
        Set(value As String)
            If m_NombreAtri = value Then Return
            m_NombreAtri = value
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
End Class
