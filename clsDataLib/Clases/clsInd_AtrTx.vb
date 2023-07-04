Public Class clsInd_AtrTx
    Private m_IdAtrTx As Integer
    Private m_Categoria As String
    Private m_DescripcionCategoria As String
    Private m_IdTx As Integer
    Private m_IdTipoAtributo As Integer
    Private m_NombreAtributo As String
    Private m_NumeroOrdenAtributo As Integer
    Private m_UnidadMedidaAtributo As String
    Private m_IdUnidadDeMedida As Integer
    Private m_TipoValidacion As String
    Private m_AbreviacionTabla As String
    Private m_IdTablaValidacion As Integer
    Private m_NombreTabla As String
    Private m_ValorMinimo As String
    Private m_ValorMaximo As String
    Private m_Incremento As String
    Private m_Icono As String
    Private m_Modificable As Boolean
    Private m_Obligatorio As Boolean
    Private m_Mascarilla As Integer
    Private m_Interrogable As Boolean
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
    '
    Private m_TipoAtributo As String
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
    Public Property Categoria As String
        Get
            Return m_Categoria
        End Get
        Set(value As String)
            If m_Categoria = value Then Return
            m_Categoria = value
        End Set
    End Property
    '
    Public Property DescripcionCategoria As String
        Get
            Return m_DescripcionCategoria
        End Get
        Set(value As String)
            If m_DescripcionCategoria = value Then Return
            m_DescripcionCategoria = value
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
    Public Property IdTipoAtributo As Integer
        Get
            Return m_IdTipoAtributo
        End Get
        Set(value As Integer)
            If m_IdTipoAtributo = value Then Return
            m_IdTipoAtributo = value
        End Set
    End Property
    '
    Public Property NombreAtributo As String
        Get
            Return m_NombreAtributo
        End Get
        Set(value As String)
            If m_NombreAtributo = value Then Return
            m_NombreAtributo = value
        End Set
    End Property
    '
    Public Property NumeroOrdenAtributo As Integer
        Get
            Return m_NumeroOrdenAtributo
        End Get
        Set(value As Integer)
            If m_NumeroOrdenAtributo = value Then Return
            m_NumeroOrdenAtributo = value
        End Set
    End Property
    '
    Public Property UnidadMedidaAtributo As String
        Get
            Return m_UnidadMedidaAtributo
        End Get
        Set(value As String)
            If m_UnidadMedidaAtributo = value Then Return
            m_UnidadMedidaAtributo = value
        End Set
    End Property
    '
    Public Property IdUnidadDeMedida As Integer
        Get
            Return m_IdUnidadDeMedida
        End Get
        Set(value As Integer)
            If m_IdUnidadDeMedida = value Then Return
            m_IdUnidadDeMedida = value
        End Set
    End Property
    '
    Public Property TipoValidacion As String
        Get
            Return m_TipoValidacion
        End Get
        Set(value As String)
            If m_TipoValidacion = value Then Return
            m_TipoValidacion = value
        End Set
    End Property
    '
    Public Property AbreviacionTabla As String
        Get
            Return m_AbreviacionTabla
        End Get
        Set(value As String)
            If m_AbreviacionTabla = value Then Return
            m_AbreviacionTabla = value
        End Set
    End Property
    '
    Public Property IdTablaValidacion As Integer
        Get
            Return m_IdTablaValidacion
        End Get
        Set(value As Integer)
            If m_IdTablaValidacion = value Then Return
            m_IdTablaValidacion = value
        End Set
    End Property
    '
    Public Property NombreTabla As String
        Get
            Return m_NombreTabla
        End Get
        Set(value As String)
            If m_NombreTabla = value Then Return
            m_NombreTabla = value
        End Set
    End Property
    '
    Public Property ValorMinimo As String
        Get
            Return m_ValorMinimo
        End Get
        Set(value As String)
            If m_ValorMinimo = value Then Return
            m_ValorMinimo = value
        End Set
    End Property
    '
    Public Property ValorMaximo As String
        Get
            Return m_ValorMaximo
        End Get
        Set(value As String)
            If m_ValorMaximo = value Then Return
            m_ValorMaximo = value
        End Set
    End Property
    '
    Public Property Incremento As String
        Get
            Return m_Incremento
        End Get
        Set(value As String)
            If m_Incremento = value Then Return
            m_Incremento = value
        End Set
    End Property
    '
    Public Property Icono As String
        Get
            Return m_Icono
        End Get
        Set(value As String)
            If m_Icono = value Then Return
            m_Icono = value
        End Set
    End Property
    '
    Public Property Modificable As Boolean
        Get
            Return m_Modificable
        End Get
        Set(value As Boolean)
            If m_Modificable = value Then Return
            m_Modificable = value
        End Set
    End Property
    '
    Public Property Obligatorio As Boolean
        Get
            Return m_Obligatorio
        End Get
        Set(value As Boolean)
            If m_Obligatorio = value Then Return
            m_Obligatorio = value
        End Set
    End Property
    '
    Public Property Mascarilla As Integer
        Get
            Return m_Mascarilla
        End Get
        Set(value As Integer)
            If m_Mascarilla = value Then Return
            m_Mascarilla = value
        End Set
    End Property
    '
    Public Property Interrogable As Boolean
        Get
            Return m_Interrogable
        End Get
        Set(value As Boolean)
            If m_Interrogable = value Then Return
            m_Interrogable = value
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
    Public Property TipoAtributo As String
        Get
            Return m_TipoAtributo
        End Get
        Set(value As String)
            If m_TipoAtributo = value Then Return
            m_TipoAtributo = value
        End Set
    End Property
    '
End Class
