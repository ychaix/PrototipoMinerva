Public Class clsInd_MetaDatoTraducidoDAtrTx
    Private m_IdMetaDatoAtrTxTrad As Integer
    Private m_IdAtrTx As Integer
    Private m_IdIdioma As Integer
    Private m_NombreAtri As String
    Private m_DescriptionDetalle As String
    Private m_EncabezadoColumna As String
    Private m_ValorPorOmision As String
    Private m_Prompt As String
    Private m_MensajeError As String
    Private m_Ayuda As String
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
    '
    Public Property IdMetaDatoAtrTxTrad As Integer
        Get
            Return m_IdMetaDatoAtrTxTrad
        End Get
        Set(value As Integer)
            If m_IdMetaDatoAtrTxTrad = value Then Return
            m_IdMetaDatoAtrTxTrad = value
        End Set
    End Property
    '
    Public Property IdAtrTx As Integer
        Get
            Return m_IdAtrTx
        End Get
        Set(value As Integer)
            If m_IdAtrTx = value Then Return
            m_IdAtrTx = value
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
    Public Property DescriptionDetalle As String
        Get
            Return m_DescriptionDetalle
        End Get
        Set(value As String)
            If m_DescriptionDetalle = value Then Return
            m_DescriptionDetalle = value
        End Set
    End Property
    '
    Public Property EncabezadoColumna As String
        Get
            Return m_EncabezadoColumna
        End Get
        Set(value As String)
            If m_EncabezadoColumna = value Then Return
            m_EncabezadoColumna = value
        End Set
    End Property
    '
    Public Property ValorPorOmision As String
        Get
            Return m_ValorPorOmision
        End Get
        Set(value As String)
            If m_ValorPorOmision = value Then Return
            m_ValorPorOmision = value
        End Set
    End Property
    '
    Public Property Prompt As String
        Get
            Return m_Prompt
        End Get
        Set(value As String)
            If m_Prompt = value Then Return
            m_Prompt = value
        End Set
    End Property
    '
    Public Property MensajeError As String
        Get
            Return m_MensajeError
        End Get
        Set(value As String)
            If m_MensajeError = value Then Return
            m_MensajeError = value
        End Set
    End Property
    '
    Public Property Ayuda As String
        Get
            Return m_Ayuda
        End Get
        Set(value As String)
            If m_Ayuda = value Then Return
            m_Ayuda = value
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
End Class
