Public Class clsUsuario
    Private m_idUsuario As Integer
    Private m_Usuario As String
    Private m_Nombres As String
    Private m_PassEncrypt As String
    Private m_idPerfil As Integer
    Private m_Es_Administrador As Integer
    Private m_Correo_Electronico As String
    Private m_Celular As String
    Private m_Tipo_Acceso As Integer
    Private m_Req_Cambio_Clave As Integer
    Private m_Frecuencia_Clave As Integer
    Private m_Limite_Intentos As Integer
    Private m_Fecha_Ult_Clave As Date
    '
    Private m_UsuarioCrea As String
    Private m_FechaCrea As Date
    Private m_UsuarioModifica As String
    Private m_FechaModifica As Nullable(Of Date)
    Private m_Estado As String
    Private m_Perfil As String
    Private m_cEstado As String
    '
    Public Property idUsuario As Integer
        Get
            Return m_idUsuario
        End Get
        Set(ByVal value As Integer)
            m_idUsuario = value
        End Set
    End Property
    '
    Public Property Usuario As String
        Get
            Return m_Usuario
        End Get
        Set(ByVal value As String)
            m_Usuario = value
        End Set
    End Property
    '
    Public Property Nombres As String
        Get
            Return m_Nombres
        End Get
        Set(ByVal value As String)
            m_Nombres = value
        End Set
    End Property
    '
    Public Property PassEncrypt As String
        Get
            Return m_PassEncrypt
        End Get
        Set(ByVal value As String)
            m_PassEncrypt = value
        End Set
    End Property
    '
    Public Property idPerfil As Integer
        Get
            Return m_idPerfil
        End Get
        Set(ByVal value As Integer)
            m_idPerfil = value
        End Set
    End Property
    '
    Public Property Es_Administrador As Integer
        Get
            Return m_Es_Administrador
        End Get
        Set(ByVal value As Integer)
            m_Es_Administrador = value
        End Set
    End Property
    '
    Public Property Correo_Electronico As String
        Get
            Return m_Correo_Electronico
        End Get
        Set(ByVal value As String)
            m_Correo_Electronico = value
        End Set
    End Property
    '
    Public Property Celular As String
        Get
            Return m_Celular
        End Get
        Set(ByVal value As String)
            m_Celular = value
        End Set
    End Property
    '
    Public Property Tipo_Acceso As Integer
        Get
            Return m_Tipo_Acceso
        End Get
        Set(ByVal value As Integer)
            m_Tipo_Acceso = value
        End Set
    End Property
    '
    Public Property Req_Cambio_Clave As Integer
        Get
            Return m_Req_Cambio_Clave
        End Get
        Set(ByVal value As Integer)
            m_Req_Cambio_Clave = value
        End Set
    End Property
    '
    Public Property Frecuencia_Clave As Integer
        Get
            Return m_Frecuencia_Clave
        End Get
        Set(ByVal value As Integer)
            m_Frecuencia_Clave = value
        End Set
    End Property
    '
    Public Property Limite_Intentos As Integer
        Get
            Return m_Limite_Intentos
        End Get
        Set(ByVal value As Integer)
            m_Limite_Intentos = value
        End Set
    End Property
    '
    Public Property Fecha_Ult_Clave As Date
        Get
            Return m_Fecha_Ult_Clave
        End Get
        Set(ByVal value As Date)
            m_Fecha_Ult_Clave = value
        End Set
    End Property
    '
    Public Property UsuarioCrea As String
        Get
            Return m_UsuarioCrea
        End Get
        Set(ByVal value As String)
            m_UsuarioCrea = value
        End Set
    End Property
    '
    Public Property FechaCrea As Date
        Get
            Return m_FechaCrea
        End Get
        Set(ByVal value As Date)
            m_FechaCrea = value
        End Set
    End Property
    '
    Public Property UsuarioModifica As String
        Get
            Return m_UsuarioModifica
        End Get
        Set(ByVal value As String)
            m_UsuarioModifica = value
        End Set
    End Property
    '
    Public Property FechaModifica As Nullable(Of Date)
        Get
            If m_FechaModifica.HasValue Then
                Return CDate(m_FechaModifica)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_FechaModifica = value
        End Set
    End Property
    '
    Public Property Estado As String
        Get
            Return m_Estado
        End Get
        Set(ByVal value As String)
            m_Estado = value
        End Set
    End Property
    '
    Public Property Perfil As String
        Get
            Return m_Perfil
        End Get
        Set(ByVal value As String)
            m_Perfil = value
        End Set
    End Property
    '
    Public Property cEstado As String
        Get
            Return m_cEstado
        End Get
        Set(ByVal value As String)
            m_cEstado = value
        End Set
    End Property
    '
End Class
