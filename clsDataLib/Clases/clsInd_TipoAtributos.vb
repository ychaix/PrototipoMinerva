Public Class clsInd_TipoAtributos
    Private m_IdTipoAtributo As Integer
    Private m_Codigo As String
    Private m_DescripcionTipoAtrib As String
    Private m_TipoDatoVisualizado As String
    Private m_TipoDatoSalvado As String
    Private m_FuenteDelValor As String
    Private m_Mascarilla As Integer
    Private m_Validacion As String
    Private m_Interrogable As Integer
    Private m_Multi_idioma As Integer
    Private m_AmbitoAtrib As String
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
    Public Property Codigo As String
        Get
            Return m_Codigo
        End Get
        Set(value As String)
            If m_Codigo = value Then Return
            m_Codigo = value
        End Set
    End Property
    '
    Public Property DescripcionTipoAtrib As String
        Get
            Return m_DescripcionTipoAtrib
        End Get
        Set(value As String)
            If m_DescripcionTipoAtrib = value Then Return
            m_DescripcionTipoAtrib = value
        End Set
    End Property
    '
    Public Property TipoDatoVisualizado As String
        Get
            Return m_TipoDatoVisualizado
        End Get
        Set(value As String)
            If m_TipoDatoVisualizado = value Then Return
            m_TipoDatoVisualizado = value
        End Set
    End Property
    '
    Public Property TipoDatoSalvado As String
        Get
            Return m_TipoDatoSalvado
        End Get
        Set(value As String)
            If m_TipoDatoSalvado = value Then Return
            m_TipoDatoSalvado = value
        End Set
    End Property
    '
    Public Property FuenteDelValor As String
        Get
            Return m_FuenteDelValor
        End Get
        Set(value As String)
            If m_FuenteDelValor = value Then Return
            m_FuenteDelValor = value
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
    Public Property Validacion As String
        Get
            Return m_Validacion
        End Get
        Set(value As String)
            If m_Validacion = value Then Return
            m_Validacion = value
        End Set
    End Property
    '
    Public Property Interrogable As Integer
        Get
            Return m_Interrogable
        End Get
        Set(value As Integer)
            If m_Interrogable = value Then Return
            m_Interrogable = value
        End Set
    End Property
    '
    Public Property Multi_idioma As Integer
        Get
            Return m_Multi_idioma
        End Get
        Set(value As Integer)
            If m_Multi_idioma = value Then Return
            m_Multi_idioma = value
        End Set
    End Property
    '
    Public Property AmbitoAtrib As String
        Get
            Return m_AmbitoAtrib
        End Get
        Set(value As String)
            If m_AmbitoAtrib = value Then Return
            m_AmbitoAtrib = value
        End Set
    End Property
    '
End Class
