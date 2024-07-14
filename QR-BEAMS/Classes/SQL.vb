Imports MySql.Data.MySqlClient
Public Class SQL
    Public Function LoginUser(User As String, Pass As String) As Boolean
        Try
            Dim reader As MySqlDataReader = Nothing
            _CONNECTION.open()
            Dim LogSQL As String = "SELECT * FROM tbl_account where username=@User AND password=@Pass"
            Dim LogCMD As New MySqlCommand(LogSQL, _CONNECTION)
            LogCMD.Parameters.AddWithValue("@User", User)
            LogCMD.Parameters.AddWithValue("@Pass", Pass)
            reader = LogCMD.ExecuteReader()
            If reader.HasRows Then
                Return True
            Else
                Return False
            End If
            Console.WriteLine(reader.ToString)
        Catch ex As Exception
            Return False
        Finally
            If _CONNECTION.state = ConnectionState.Open Then
                _CONNECTION.close()
            End If
        End Try
    End Function
End Class
