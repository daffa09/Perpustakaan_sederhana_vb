<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenuAdmin
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button1.Location = New System.Drawing.Point(67, 52)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(198, 42)
		Me.Button1.TabIndex = 16
		Me.Button1.Text = "Data Anggota"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button2.Location = New System.Drawing.Point(67, 116)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(198, 42)
		Me.Button2.TabIndex = 17
		Me.Button2.Text = "Data Buku"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button3.Location = New System.Drawing.Point(67, 184)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(198, 42)
		Me.Button3.TabIndex = 18
		Me.Button3.Text = "Data Peminjaman"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button4.Location = New System.Drawing.Point(67, 252)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(198, 42)
		Me.Button4.TabIndex = 19
		Me.Button4.Text = "Data Denda"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button5.Location = New System.Drawing.Point(67, 310)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(198, 41)
		Me.Button5.TabIndex = 20
		Me.Button5.Text = "kembali"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'mainMenuAdmin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(330, 394)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Name = "mainMenuAdmin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Menu Admin"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
End Class
