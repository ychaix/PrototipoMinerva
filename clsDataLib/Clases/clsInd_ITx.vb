Public Class clsInd_ITx
    Private m_IdITx As Integer
    Private m_IdTxDITx As Integer
    Private m_CodigoCategoría As String
    Private m_CodSec As String
    Private m_IdMarca As Integer
    Private m_ReferenciaFrabricante As String
    Private m_EmpaqueVenta As String
    Private m_UnidadVenta As String
    Private m_FraccionVenta As Double
    Private m_TamanioVenta As Double
    Private m_CodigoArrancelario As String
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
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
    Public Property CodigoCategoría As String
        Get
            Return m_CodigoCategoría
        End Get
        Set(value As String)
            If m_CodigoCategoría = value Then Return
            m_CodigoCategoría = value
        End Set
    End Property
    '
    Public Property CodSec As String
        Get
            Return m_CodSec
        End Get
        Set(value As String)
            If m_CodSec = value Then Return
            m_CodSec = value
        End Set
    End Property
    '
    Public Property IdMarca As Integer
        Get
            Return m_IdMarca
        End Get
        Set(value As Integer)
            If m_IdMarca = value Then Return
            m_IdMarca = value
        End Set
    End Property
    '
    Public Property ReferenciaFrabricante As String
        Get
            Return m_ReferenciaFrabricante
        End Get
        Set(value As String)
            If m_ReferenciaFrabricante = value Then Return
            m_ReferenciaFrabricante = value
        End Set
    End Property
    '
    Public Property EmpaqueVenta As String
        Get
            Return m_EmpaqueVenta
        End Get
        Set(value As String)
            If m_EmpaqueVenta = value Then Return
            m_EmpaqueVenta = value
        End Set
    End Property
    '
    Public Property UnidadVenta As String
        Get
            Return m_UnidadVenta
        End Get
        Set(value As String)
            If m_UnidadVenta = value Then Return
            m_UnidadVenta = value
        End Set
    End Property
    '
    Public Property FraccionVenta As Double
        Get
            Return m_FraccionVenta
        End Get
        Set(value As Double)
            If m_FraccionVenta = value Then Return
            m_FraccionVenta = value
        End Set
    End Property
    '
    Public Property TamanioVenta As Double
        Get
            Return m_TamanioVenta
        End Get
        Set(value As Double)
            If m_TamanioVenta = value Then Return
            m_TamanioVenta = value
        End Set
    End Property
    '
    Public Property CodigoArrancelario As String
        Get
            Return m_CodigoArrancelario
        End Get
        Set(value As String)
            If m_CodigoArrancelario = value Then Return
            m_CodigoArrancelario = value
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
