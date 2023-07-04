Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class clsDB
    Public Shared Function Conectar(ByVal usuario As String, pwd As String, bd As String) As SqlConnection
        Return New SqlConnection("data source=.; initial catalog=" & bd & "; integrated security=false; user=" & usuario & "; pwd=" & pwd & "; ")
        ' 
    End Function
    '
    Public Shared Function ConectarRoot(ByVal usuario As String, pwd As String, bd As String) As SqlConnection
        Return New SqlConnection("data source=.; initial catalog=" & bd & "; integrated security=true; ")
        ' 
    End Function
    '
    Public Shared Function ConectarAdmin(ByVal usuario As String, pwd As String, bd As String) As SqlConnection
        Return New SqlConnection("data source=.; initial catalog=ACLAdmin; integrated security=true; ")
        ' 
    End Function
    '
    Public Shared Function ConectarAccess(bd As String) As OleDbConnection
        Return New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\App\Proy_Yves\Datos\" & bd & ".accdb;")
        'Return New OleDbConnection("Provider = {Microsoft Access Driver (*.mdb, *.accdb)};DBQ=C:\App\Proy_Yves\Datos\" & bd & ".accdb;")
        ' 
    End Function
    '
    Public Shared Function Respalda(ByVal usuario As String, pwd As String, bd As String) As Boolean
        Dim destino As String = "C:\App\Proy_Yves\Datos\" & bd & "DB"
        Dim dayWeekName As String = Today.DayOfWeek.ToString
        If dayWeekName = "Monday" Then
            destino = destino & "_Lunes.bak"
        ElseIf dayWeekName = "Tuesday" Then
            destino = destino & "_Martes.bak"
        ElseIf dayWeekName = "Wednesday" Then
            destino = destino & "_Miercoles.bak"
        ElseIf dayWeekName = "Thursday" Then
            destino = destino & "_Jueves.bak"
        ElseIf dayWeekName = "Friday" Then
            destino = destino & "_Viernes.bak"
        ElseIf dayWeekName = "Saturday" Then
            destino = destino & "_Sabado.bak"
        Else
            destino = destino & "_Domingo.bak"
        End If
        'If Month(Today) < 10 Then
        '    destino = destino & "0"
        'End If
        'destino = destino & Month(Today)
        'If Day(Today) < 10 Then
        '    destino = destino & "0"
        'End If
        'destino = destino & Day(Today) & ".bak"
        '
        Dim cnn As SqlConnection = clsDB.ConectarRoot(usuario, pwd, bd)
        Dim strSQL As String =
            "BACKUP DATABASE [" & bd & "] " &
            "TO  DISK = @destino " &
            "WITH NOFORMAT, INIT, NAME = N'" & bd & "-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        '
        Dim cmd As New SqlCommand(strSQL, cnn)
        cmd.Parameters.AddWithValue("@destino", destino)
        '
        ' Return True
        '
        Try
            cnn.Open()
            Dim count As Integer = cmd.ExecuteNonQuery()
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Function
    '   
End Class
