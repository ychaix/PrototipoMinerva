Public Class clsPerfil
    Private m_IdPerfil As Integer
    Private m_Perfil As String
    Private m_UsuarioCrea As String
    Private m_FechaCrea As Date
    Private m_UsuarioModifica As String
    Private m_FechaModifica As Nullable(Of Date)
    Private m_Estado As String
    Private m_cEstado As String
    '
    Public Property IdPerfil As Integer
        Get
            Return m_IdPerfil
        End Get
        Set(ByVal value As Integer)
            m_IdPerfil = value
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
