﻿Imports MySql.Data.MySqlClient

Public Class dataAggota

	Sub kondisiAwal()

		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox4.Text = ""
		TextBox5.Text = ""

		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		TextBox5.Enabled = False

		DataGridView1.Enabled = True

		btn_tambah.Enabled = True
		btn_delete.Enabled = True
		btn_search.Enabled = True
		btn_edit.Enabled = True
		btn_tambah.Text = "Tambah"
		btn_close.Text = "Close"
		btn_edit.Text = "Edit"

	End Sub

	Sub munculDataGridView()

		Call koneksidb()
		da = New MySqlDataAdapter("SELECT * FROM anggota", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "anggota")
		DataGridView1.DataSource = (ds.Tables("anggota"))

	End Sub

	Sub autonumeric()

		Call koneksidb()
		cmd = New MySqlCommand("select * from anggota order by id_anggota desc", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		If Not dr.HasRows Then
			TextBox2.Text = "A" + "001"
		Else
			TextBox2.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_anggota").ToString, 4, 3)) + 1
			If Len(TextBox2.Text) = 1 Then
				TextBox2.Text = "A00" & TextBox2.Text & ""
			ElseIf Len(TextBox2.Text) = 2 Then
				TextBox2.Text = "A0" & TextBox2.Text & ""
			ElseIf Len(TextBox2.Text) = 3 Then
				TextBox2.Text = "A" & TextBox2.Text & ""
			End If
		End If

	End Sub

	Private Sub dataAggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		kondisiAwal()
		munculDataGridView()
	End Sub

	Private Sub dataAggota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


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
				TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
				TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value


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
			munculDataGridView()

		End If
	End Sub

	Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click

		If btn_tambah.Text = "Tambah" Then

			btn_tambah.Text = "Save"
			btn_delete.Enabled = False
			btn_edit.Enabled = False
			btn_close.Text = "Cancel"

			TextBox3.Enabled = True
			TextBox4.Enabled = True
			TextBox5.Enabled = True
			DataGridView1.Enabled = False

			TextBox2.Text = ""
			TextBox3.Text = ""
			TextBox4.Text = ""
			TextBox5.Text = ""

			autoNumeric()

		Else

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menyimpan data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksidb()
					cmd = New MySqlCommand("INSERT INTO anggota VALUES('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '0')", conn)
					cmd.ExecuteNonQuery()
					MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
					MsgBox("Data gagal disimpan")
				End If


			End If

		End If

	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
			MsgBox("Silahkan pilih data pada tabel, lalu hapus")
		Else

			btn_tambah.Enabled = False
			btn_close.Text = "Cancel"



			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksidb()
					cmd = New MySqlCommand("DELETE FROM anggota WHERE id_anggota='" & TextBox2.Text & "'", conn)
					cmd.ExecuteNonQuery()
					MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If

		End If

	End Sub

	Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

		Call koneksidb()
		cmd = New MySqlCommand("SELECT * FROM anggota WHERE	nama_anggota='" & TextBox1.Text & "' OR alamat_anggota='" & TextBox1.Text & "' OR status_anggota='" & TextBox1.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If TextBox1.Text = "" Then
			munculDataGridView()

		ElseIf dr.HasRows Then

			Call koneksidb()
			da = New MySqlDataAdapter("SELECT * FROM anggota WHERE	nama_anggota='" & TextBox1.Text & "' OR alamat_anggota='" & TextBox1.Text & "' OR status_anggota='" & TextBox1.Text & "'", conn)
			ds = New DataSet
			da.Fill(ds, "anggota")
			DataGridView1.DataSource = ds.Tables("anggota")


		Else
			MsgBox("Data tidak ditemukan")
			munculDataGridView()
			kondisiAwal()
		End If

	End Sub

	Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

		If btn_edit.Text = "Edit" Then

			btn_edit.Text = "Save"
			btn_delete.Enabled = False
			btn_tambah.Enabled = False
			btn_close.Text = "Cancel"

			TextBox3.Enabled = True
			TextBox4.Enabled = True
			TextBox5.Enabled = True
			DataGridView1.Enabled = False


		Else
			If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin merubah data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksidb()
					cmd = New MySqlCommand("UPDATE anggota SET nama_anggota='" & TextBox3.Text & "', alamat_anggota='" & TextBox4.Text & "', status_anggota='" & TextBox5.Text & "', denda='0'  WHERE idguru='" & TextBox2.Text & "'", conn)
					cmd.ExecuteNonQuery()
					MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If
		End If

	End Sub
End Class