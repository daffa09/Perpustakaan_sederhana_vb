Imports MySql.Data.MySqlClient

Module koneksi
	Public conn As MySqlConnection
	Public da As MySqlDataAdapter
	Public ds As DataSet
	Public cmd As MySqlCommand
	Public dr As MySqlDataReader

	Public Sub koneksidb()
		conn = New MySqlConnection("server=localhost; database=db_perpus; uid=root; password=")
		conn.Open()
	End Sub
End Module
