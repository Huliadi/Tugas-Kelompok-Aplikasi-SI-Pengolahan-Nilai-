Imports MySql.Data.MySqlClient
Module ModuleKoneksi
    Public Conn As MySqlConnection
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public cmd As MySqlCommand
    Public Rd As MySqlDataReader
    Public MyDB As String
    Sub OpenConnection()
        MyDB = ("server=localhost; user id=root; password=; Database=db_universitas")
        Conn = New MySqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
