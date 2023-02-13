Imports MySql.Data.MySqlClient

Public Class Form1

	Sub munculDataGridView()

		Call koneksidb()
		da = New MySqlDataAdapter("SELECT * FROM buku", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "buku")
		DataGridView1.DataSource = (ds.Tables("buku"))

	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		munculDataGridView()
	End Sub

	Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim msg As String = "Anda yakin ingin keluar dari aplikasi?"
		Dim title As String = "Form closing"
		Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		If MsgBox("Anda Ingin Masuk Mode Admin?", MsgBoxStyle.YesNo, "Warning!") = MsgBoxResult.Yes Then

			Me.Hide()
			mainMenuAdmin.Show()

		End If

	End Sub
End Class
