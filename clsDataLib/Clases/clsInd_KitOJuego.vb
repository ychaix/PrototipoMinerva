Public Class clsInd_KitOJuego
    Private m_IdKitOJuego As Integer
    Private m_IdITxJuegoGenerico As Integer
    Private m_IdITxJuegoPropietario As Integer
    Private m_IdITxGenerico As Integer
    Private m_IdArticulo As Integer
    Private m_CantidadDelJuego As Single
    Private m_IdUnidadMedidaDelJuego As Integer
    Private m_CodSec1 As String
    Private m_CodSec2 As String
    Private m_CantITxEnElJuego As Double
    Private m_IdUnidadIngrediente As Integer
    Private m_IdCreado As Integer
    Private m_IdUltimoCambio As Integer
    Private m_IdBorradoL As Integer
    '
    Public Property IdKitOJuego As Integer
        Get
            Return m_IdKitOJuego
        End Get
        Set(value As Integer)
            If m_IdKitOJuego = value Then Return
            m_IdKitOJuego = value
        End Set
    End Property
    '
    Public Property IdITxJuegoGenerico As Integer
        Get
            Return m_IdITxJuegoGenerico
        End Get
        Set(value As Integer)
            If m_IdITxJuegoGenerico = value Then Return
            m_IdITxJuegoGenerico = value
        End Set
    End Property
    '
    Public Property IdITxJuegoPropietario As Integer
        Get
            Return m_IdITxJuegoPropietario
        End Get
        Set(value As Integer)
            If m_IdITxJuegoPropietario = value Then Return
            m_IdITxJuegoPropietario = value
        End Set
    End Property
    '
    Public Property IdITxGenerico As Integer
        Get
            Return m_IdITxGenerico
        End Get
        Set(value As Integer)
            If m_IdITxGenerico = value Then Return
            m_IdITxGenerico = value
        End Set
    End Property
    '
    Public Property IdArticulo As Integer
        Get
            Return m_IdArticulo
        End Get
        Set(value As Integer)
            If m_IdArticulo = value Then Return
            m_IdArticulo = value
        End Set
    End Property
    '
    Public Property CantidadDelJuego As Single
        Get
            Return m_CantidadDelJuego
        End Get
        Set(value As Single)
            If m_CantidadDelJuego = value Then Return
            m_CantidadDelJuego = value
        End Set
    End Property
    '
    Public Property IdUnidadMedidaDelJuego As Integer
        Get
            Return m_IdUnidadMedidaDelJuego
        End Get
        Set(value As Integer)
            If m_IdUnidadMedidaDelJuego = value Then Return
            m_IdUnidadMedidaDelJuego = value
        End Set
    End Property
    '
    Public Property CodSec1 As String
        Get
            Return m_CodSec1
        End Get
        Set(value As String)
            If m_CodSec1 = value Then Return
            m_CodSec1 = value
        End Set
    End Property
    '
    Public Property CodSec2 As String
        Get
            Return m_CodSec2
        End Get
        Set(value As String)
            If m_CodSec2 = value Then Return
            m_CodSec2 = value
        End Set
    End Property
    '
    Public Property CantITxEnElJuego As Double
        Get
            Return m_CantITxEnElJuego
        End Get
        Set(value As Double)
            If m_CantITxEnElJuego = value Then Return
            m_CantITxEnElJuego = value
        End Set
    End Property
    '
    Public Property IdUnidadIngrediente As Integer
        Get
            Return m_IdUnidadIngrediente
        End Get
        Set(value As Integer)
            If m_IdUnidadIngrediente = value Then Return
            m_IdUnidadIngrediente = value
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
