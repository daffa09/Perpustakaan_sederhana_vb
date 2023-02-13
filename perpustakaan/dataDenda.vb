Imports MySql.Data.MySqlClient


Public Class dataDenda

	Sub kondisiAwal()

		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox5.Text = ""
		ComboBox1.Text = "-"

		TextBox1.Enabled = False
		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox5.Enabled = False
		DateTimePicker1.Enabled = False
		DateTimePicker2.Enabled = False
		ComboBox1.Enabled = False

		DataGridView1.Enabled = True

		btn_edit.Enabled = True
		btn_delete.Enabled = True
		btn_edit.Text = "Edit"
		btn_close.Text = "Close"

	End Sub

	Sub munculDataGridViewBukuPeminjaman()

		Call koneksidb()
		da = New MySqlDataAdapter("SELECT * FROM peminjaman", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "pinjam")
		DataGridView1.ReadOnly = True
		DataGridView1.DataSource = (ds.Tables("pinjam"))

	End Sub

	Sub munculDataGridViewDenda()

		Call koneksidb()
		da = New MySqlDataAdapter("SELECT * FROM denda", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "denda")
		DataGridView2.ReadOnly = True
		DataGridView2.DataSource = (ds.Tables("denda"))

	End Sub

	Private Sub dataDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		kondisiAwal()
		munculDataGridViewBukuPeminjaman()
		munculDataGridViewDenda()
		ComboBox1.Items.Add("-")
		ComboBox1.Items.Add("Hilang")
		ComboBox1.Items.Add("Rusak")
		ComboBox1.Items.Add("Cacat")
	End Sub

	Private Sub dataDenda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim msg As String = "Anda yakin ingin keluar dari aplikasi?"
		Dim title As String = "Form closing"
		Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		Else
			Me.Hide()
			Form1.Show()
		End If
	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
				DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
				DateTimePicker2.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
				TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
				ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub

	Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
		If btn_close.Text = "Close" Then

			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

				Me.Hide()
				mainMenuAdmin.Show()

			End If

		Else
			kondisiAwal()
			munculDataGridViewBukuPeminjaman()
		End If
	End Sub

	Sub cekDenda()

		If ComboBox1.Text = "Cacat" Then

			cmd = New MySqlCommand("INSERT INTO denda VALUES ('" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "', 'Rp. 10000')", conn)
			cmd.ExecuteNonQuery()
			cmd.Dispose()

		ElseIf ComboBox1.Text = "Hilang" Then

			cmd = New MySqlCommand("INSERT INTO denda VALUES ('" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "', 'Rp. 50000')", conn)
			cmd.ExecuteNonQuery()
			cmd.Dispose()

		ElseIf ComboBox1.Text = "Rusak" Then

			cmd = New MySqlCommand("INSERT INTO denda VALUES ('" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "', 'Rp. 30000')", conn)
			cmd.ExecuteNonQuery()
			cmd.Dispose()

		End If

	End Sub

	Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

		If btn_edit.Text = "Edit" Then

			btn_edit.Text = "Save"
			btn_delete.Enabled = False
			btn_close.Text = "Cancel"

			DataGridView1.Enabled = False
			ComboBox1.Enabled = True


		Else
			If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin merubah data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksidb()
					cmd = New MySqlCommand("UPDATE peminjaman SET keadaan_buku='" & ComboBox1.Text & "'  WHERE kode_buku='" & TextBox3.Text & "'", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()

					cekDenda()

					MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridViewBukuPeminjaman()
					munculDataGridViewDenda()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If
		End If

	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If TextBox1.Text = "" Or TextBox3.Text = "" Then
			MsgBox("Silahkan pilih data pada tabel, lalu hapus")
		Else

			btn_edit.Enabled = False
			btn_close.Text = "Cancel"



			If TextBox1.Text = "" Or TextBox3.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksidb()
					cmd = New MySqlCommand("DELETE FROM denda WHERE id_anggota='" & TextBox1.Text & "'", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()

					cmd = New MySqlCommand("UPDATE peminjaman SET keadaan_buku='-'", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()

					MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridViewBukuPeminjaman()
					munculDataGridViewDenda()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If

		End If

	End Sub

	Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick

		Try

			If DataGridView2.RowCount > 0 Then

				DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
				TextBox3.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
				ComboBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub
End Class