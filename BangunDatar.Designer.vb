<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BangunDatar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panjang = New System.Windows.Forms.TextBox()
        Me.lebar = New System.Windows.Forms.TextBox()
        Me.keliling = New System.Windows.Forms.TextBox()
        Me.luas = New System.Windows.Forms.TextBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(636, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KELILING DAN LUAS PERSEGI PANJANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Panjang (cm)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lebar (cm)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(206, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(206, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(206, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 29)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(206, 399)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 29)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 29)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Luas (cm2)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 29)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Keliling (cm)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 356)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 29)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Output"
        '
        'panjang
        '
        Me.panjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panjang.Location = New System.Drawing.Point(231, 204)
        Me.panjang.Name = "panjang"
        Me.panjang.Size = New System.Drawing.Size(180, 34)
        Me.panjang.TabIndex = 11
        '
        'lebar
        '
        Me.lebar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lebar.Location = New System.Drawing.Point(231, 259)
        Me.lebar.Name = "lebar"
        Me.lebar.Size = New System.Drawing.Size(180, 34)
        Me.lebar.TabIndex = 12
        '
        'keliling
        '
        Me.keliling.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keliling.Location = New System.Drawing.Point(231, 399)
        Me.keliling.Name = "keliling"
        Me.keliling.Size = New System.Drawing.Size(180, 34)
        Me.keliling.TabIndex = 13
        '
        'luas
        '
        Me.luas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luas.Location = New System.Drawing.Point(231, 449)
        Me.luas.Name = "luas"
        Me.luas.Size = New System.Drawing.Size(180, 34)
        Me.luas.TabIndex = 14
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(493, 209)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(193, 79)
        Me.btnhitung.TabIndex = 15
        Me.btnhitung.Text = "Hitung!"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(493, 399)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(193, 79)
        Me.btnhapus.TabIndex = 16
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'BangunDatar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 622)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.luas)
        Me.Controls.Add(Me.keliling)
        Me.Controls.Add(Me.lebar)
        Me.Controls.Add(Me.panjang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "BangunDatar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bangun Datar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents panjang As TextBox
    Friend WithEvents lebar As TextBox
    Friend WithEvents keliling As TextBox
    Friend WithEvents luas As TextBox
    Friend WithEvents btnhitung As Button
    Friend WithEvents btnhapus As Button
End Class
