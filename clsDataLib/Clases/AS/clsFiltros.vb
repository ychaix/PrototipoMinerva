Public Class clsFiltros
    Private m_ID As Integer
    Private m_mUsuario As String
	Private m_mModulo As String
	Private m_Filtro As String
    Private m_UsuarioCrea As String
    Private m_FechaCrea As Date
    Private m_UsuarioModifica As String
    Private m_FechaModifica As Nullable(Of Date)
    Private m_Estado As String
    '
    Public Property ID As Integer
        Get
            Return m_ID
        End Get
        Set(value As Integer)
            If m_ID = value Then Return
            m_ID = value
        End Set
    End Property
    '
    Public Property mUsuario As String
        Get
            Return m_mUsuario
        End Get
        Set(value As String)
            If m_mUsuario = value Then Return
            m_mUsuario = value
        End Set
    End Property
    '
    Public Property mModulo As String
        Get
            Return m_mModulo
        End Get
        Set(value As String)
            If m_mModulo = value Then Return
            m_mModulo = value
        End Set
    End Property
    '
    Public Property Filtro As String
        Get
            Return m_Filtro
        End Get
        Set(value As String)
            If m_Filtro = value Then Return
            m_Filtro = value
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
    Public Property FechaCrea As Date
        Get
            Return m_FechaCrea
        End Get
        Set(value As Date)
            If m_FechaCrea = value Then Return
            m_FechaCrea = value
        End Set
    End Property
    '
    Public Property UsuarioModifica As String
        Get
            Return m_UsuarioModifica
        End Get
        Set(value As String)
            If m_UsuarioModifica = value Then Return
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
        Set(value As Nullable(Of Date))
            If m_FechaModifica = value Then Return
            m_FechaModifica = value
        End Set
    End Property
    '
    Public Property Estado As String
        Get
            Return m_Estado
        End Get
        Set(ByVal value As String)
            If m_Estado = value Then Return
            m_Estado = value
        End Set
    End Property
    '
End Class
