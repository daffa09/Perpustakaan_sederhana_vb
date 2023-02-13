<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataBuku
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btn_edit = New System.Windows.Forms.Button()
		Me.btn_close = New System.Windows.Forms.Button()
		Me.btn_delete = New System.Windows.Forms.Button()
		Me.btn_tambah = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.btn_search = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn_edit
		'
		Me.btn_edit.Location = New System.Drawing.Point(354, 477)
		Me.btn_edit.Name = "btn_edit"
		Me.btn_edit.Size = New System.Drawing.Size(95, 35)
		Me.btn_edit.TabIndex = 127
		Me.btn_edit.Text = "Edit"
		Me.btn_edit.UseVisualStyleBackColor = True
		'
		'btn_close
		'
		Me.btn_close.Location = New System.Drawing.Point(609, 477)
		Me.btn_close.Name = "btn_close"
		Me.btn_close.Size = New System.Drawing.Size(95, 35)
		Me.btn_close.TabIndex = 126
		Me.btn_close.Text = "Close"
		Me.btn_close.UseVisualStyleBackColor = True
		'
		'btn_delete
		'
		Me.btn_delete.Location = New System.Drawing.Point(477, 477)
		Me.btn_delete.Name = "btn_delete"
		Me.btn_delete.Size = New System.Drawing.Size(95, 35)
		Me.btn_delete.TabIndex = 125
		Me.btn_delete.Text = "Delete"
		Me.btn_delete.UseVisualStyleBackColor = True
		'
		'btn_tambah
		'
		Me.btn_tambah.Location = New System.Drawing.Point(218, 477)
		Me.btn_tambah.Name = "btn_tambah"
		Me.btn_tambah.Size = New System.Drawing.Size(95, 35)
		Me.btn_tambah.TabIndex = 124
		Me.btn_tambah.Text = "Tambah"
		Me.btn_tambah.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label7.Location = New System.Drawing.Point(391, 389)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(91, 20)
		Me.Label7.TabIndex = 123
		Me.Label7.Text = "Jumlah Buku"
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(524, 386)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(63, 23)
		Me.TextBox5.TabIndex = 122
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label5.Location = New System.Drawing.Point(392, 346)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(115, 20)
		Me.Label5.TabIndex = 121
		Me.Label5.Text = "Pengarang Buku"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(525, 347)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(178, 23)
		Me.TextBox4.TabIndex = 120
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label3.Location = New System.Drawing.Point(391, 302)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(79, 20)
		Me.Label3.TabIndex = 119
		Me.Label3.Text = "Judul Buku"
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(524, 303)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(178, 23)
		Me.TextBox3.TabIndex = 118
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(391, 256)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 20)
		Me.Label2.TabIndex = 117
		Me.Label2.Text = "Kode Buku"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(525, 257)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(47, 23)
		Me.TextBox2.TabIndex = 116
		'
		'btn_search
		'
		Me.btn_search.Location = New System.Drawing.Point(204, 243)
		Me.btn_search.Name = "btn_search"
		Me.btn_search.Size = New System.Drawing.Size(90, 32)
		Me.btn_search.TabIndex = 115
		Me.btn_search.Text = "Search"
		Me.btn_search.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(60, 248)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(137, 23)
		Me.TextBox1.TabIndex = 114
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(60, 75)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowTemplate.Height = 25
		Me.DataGridView1.Size = New System.Drawing.Size(681, 150)
		Me.DataGridView1.TabIndex = 113
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(263, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(292, 45)
		Me.Label1.TabIndex = 112
		Me.Label1.Text = "Form Tambah Buku"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label4.Location = New System.Drawing.Point(393, 430)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(99, 20)
		Me.Label4.TabIndex = 129
		Me.Label4.Text = "Penerbit Buku"
		'
		'TextBox6
		'
		Me.TextBox6.Location = New System.Drawing.Point(526, 427)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(178, 23)
		Me.TextBox6.TabIndex = 128
		'
		'dataBuku
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 540)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.btn_edit)
		Me.Controls.Add(Me.btn_close)
		Me.Controls.Add(Me.btn_delete)
		Me.Controls.Add(Me.btn_tambah)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.btn_search)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "dataBuku"
		Me.Text = "Data Buku"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btn_edit As Button
	Friend WithEvents btn_close As Button
	Friend WithEvents btn_delete As Button
	Friend WithEvents btn_tambah As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents btn_search As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label1 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox6 As TextBox
End Class
