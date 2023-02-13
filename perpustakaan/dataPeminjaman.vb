Imports MySql.Data.MySqlClient


Public Class dataPeminjaman

	Sub kondisiAwal()

		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox4.Text = ""
		TextBox5.Text = ""
		ComboBox1.Text = "-"

		TextBox1.Enabled = False
		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		TextBox5.Enabled = False
		DateTimePicker1.Enabled = False
		DateTimePicker2.Enabled = False
		ComboBox1.Enabled = False

		DataGridView1.Enabled = True

		btn_tambah.Enabled = True
		btn_delete.Enabled = True
		btn_tambah.Text = "Tambah"
		btn_close.Text = "Close"

	End Sub

	Sub munculDataGridViewAnggota()

		Call koneksidb()
		da = New MySqlDataAdapter("SELECT * FROM anggota", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "anggota")
		DataGridView1.ReadOnly = True
		DataGridView1.DataSource = (ds.Tables("anggota"))

	End Sub

	Sub munculDataGridViewBuku()

		Call koneksidb()
		da = New MySqlDataAdapter("SELECT * FROM buku", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "buku")
		DataGridView2.ReadOnly = True
		DataGridView2.DataSource = (ds.Tables("buku"))

	End Sub

	Sub munculDataGridViewBukuPeminjaman()

		Call koneksidb()
		da = New MySqlDataAdapter("SELECT * FROM peminjaman", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "pinjam")
		DataGridView3.ReadOnly = True
		DataGridView3.DataSource = (ds.Tables("pinjam"))

	End Sub

	Sub KuranginBuku()

		Dim hasil As Integer

		hasil = lbl_stok_buku.Text - 1

		Call koneksidb()
		cmd = New MySqlCommand("UPDATE buku SET jumlah_buku='" & hasil & "' WHERE kode_buku='" & TextBox3.Text & "'", conn)
		cmd.ExecuteNonQuery()
		cmd.Dispose()

	End Sub

	Sub keadaanAwalBuku()

		Dim hasil As Integer
		cmd = New MySqlCommand("SELECT jumlah_buku FROM buku WHERE kode_buku='" & TextBox3.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		lbl_stok_buku.Text = dr.Item("jumlah_buku")
		hasil = lbl_stok_buku.Text + 1
		dr.Close()
		cmd.Dispose()

		Call koneksidb()
		cmd = New MySqlCommand("UPDATE buku SET jumlah_buku='" & hasil & "' WHERE kode_buku='" & TextBox3.Text & "'", conn)
		cmd.ExecuteNonQuery()
		cmd.Dispose()

	End Sub

	Private Sub dataPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		kondisiAwal()
		munculDataGridViewAnggota()
		munculDataGridViewBuku()
		munculDataGridViewBukuPeminjaman()
		ComboBox1.Items.Add("-")
		ComboBox1.Items.Add("Hilang")
		ComboBox1.Items.Add("Rusak")
		ComboBox1.Items.Add("Cacat")
	End Sub

	Private Sub dataPeminjaman_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

	Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

		If btn_close.Text = "Close" Then

			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

				Me.Hide()
				mainMenuAdmin.Show()

			End If

		Else
			kondisiAwal()
			munculDataGridViewAnggota()
			munculDataGridViewBuku()

		End If

	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub

	Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick

		Try

			If DataGridView2.RowCount > 0 Then

				DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox3.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
				TextBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
				lbl_stok_buku.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub

	Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click

		If btn_tambah.Text = "Tambah" Then

			btn_tambah.Text = "Save"
			btn_delete.Enabled = False
			btn_close.Text = "Cancel"

			DateTimePicker1.Enabled = True
			DateTimePicker2.Enabled = True
			TextBox5.Enabled = True
			ComboBox1.Enabled = True

			TextBox2.Text = ""
			TextBox3.Text = ""
			TextBox4.Text = ""
			TextBox5.Text = ""

		Else

			If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menyimpan data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksidb()
					cmd = New MySqlCommand("INSERT INTO peminjaman VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd") & "', '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd") & "', '" & TextBox5.Text & "', '" & ComboBox1.Text & "')", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()

					KuranginBuku()

					MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridViewBukuPeminjaman()
					munculDataGridViewAnggota()
					munculDataGridViewBuku()

				ElseIf MsgBoxResult.Cancel Then
					MsgBox("Data gagal disimpan")
				End If


			End If

		End If

	End Sub

	Private Sub DataGridView3_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseClick

		Try

			If DataGridView3.RowCount > 0 Then

				DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox1.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value
				TextBox2.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value
				TextBox3.Text = DataGridView3.Rows(e.RowIndex).Cells(2).Value
				DateTimePicker1.Text = DataGridView3.Rows(e.RowIndex).Cells(3).Value
				DateTimePicker2.Text = DataGridView3.Rows(e.RowIndex).Cells(4).Value
				TextBox5.Text = DataGridView3.Rows(e.RowIndex).Cells(5).Value
				ComboBox1.Text = DataGridView3.Rows(e.RowIndex).Cells(6).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
			MsgBox("Silahkan pilih data pada tabel paling bawah, lalu hapus")
		Else

			btn_tambah.Enabled = False
			btn_close.Text = "Cancel"



			If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksidb()
					cmd = New MySqlCommand("DELETE FROM peminjaman WHERE id_anggota='" & TextBox1.Text & "'", conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()

					keadaanAwalBuku()

					MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridViewAnggota()
					munculDataGridViewBuku()
					munculDataGridViewBukuPeminjaman()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If

		End If

	End Sub

End Class