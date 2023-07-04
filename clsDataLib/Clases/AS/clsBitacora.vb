Public Class clsBitacora
    Private m_idBitacora As Integer
    Private m_Modulo As String
    Private m_Accion As String
    Private m_Descripcion As String
    Private m_Documento As String
    Private m_ValorAnterior As String
    Private m_ValorActual As String
    Private m_Observaciones As String
    Private m_UsuarioCrea As String
    Private m_FechaCrea As Date
    '
    Public Property idBitacora As Integer
        Get
            Return m_idBitacora
        End Get
        Set(value As Integer)
            If m_idBitacora = value Then Return
            m_idBitacora = value
        End Set
    End Property
    '
    Public Property Modulo As String
        Get
            Return m_Modulo
        End Get
        Set(value As String)
            If m_Modulo = value Then Return
            m_Modulo = value
        End Set
    End Property
    '
    Public Property Accion As String
        Get
            Return m_Accion
        End Get
        Set(value As String)
            If m_Accion = value Then Return
            m_Accion = value
        End Set
    End Property
    '
    Public Property Descripcion As String
        Get
            Return m_Descripcion
        End Get
        Set(value As String)
            If m_Descripcion = value Then Return
            m_Descripcion = value
        End Set
    End Property
    '
    Public Property Documento As String
        Get
            Return m_Documento
        End Get
        Set(value As String)
            If m_Documento = value Then Return
            m_Documento = value
        End Set
    End Property
    '
    Public Property ValorAnterior As String
        Get
            Return m_ValorAnterior
        End Get
        Set(value As String)
            If m_ValorAnterior = value Then Return
            m_ValorAnterior = value
        End Set
    End Property
    '
    Public Property ValorActual As String
        Get
            Return m_ValorActual
        End Get
        Set(value As String)
            If m_ValorActual = value Then Return
            m_ValorActual = value
        End Set
    End Property
    '
    Public Property Observaciones As String
        Get
            Return m_Observaciones
        End Get
        Set(value As String)
            If m_Observaciones = value Then Return
            m_Observaciones = value
        End Set
    End Property
    '
    Public Property UsuarioCrea As String
        Get
            Return m_UsuarioCrea
        End Get
        Set(value As String)
            If m_UsuarioCrea = value Then Return
            m_UsuarioCrea = value
        End Set
    End Property
    '
    Public Property FechaCrea As String
        Get
            Return m_FechaCrea
        End Get
        Set(value As String)
            If m_FechaCrea = value Then Return
            m_FechaCrea = value
        End Set
    End Property
    '
End Class
