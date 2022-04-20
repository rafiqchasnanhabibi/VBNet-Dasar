<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbojeniskelamin = New System.Windows.Forms.ComboBox()
        Me.cboprodi = New System.Windows.Forms.ComboBox()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(131, 24)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(186, 23)
        Me.txtnama.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Prodi"
        '
        'cbojeniskelamin
        '
        Me.cbojeniskelamin.FormattingEnabled = True
        Me.cbojeniskelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbojeniskelamin.Location = New System.Drawing.Point(131, 53)
        Me.cbojeniskelamin.Name = "cbojeniskelamin"
        Me.cbojeniskelamin.Size = New System.Drawing.Size(186, 23)
        Me.cbojeniskelamin.TabIndex = 2
        '
        'cboprodi
        '
        Me.cboprodi.FormattingEnabled = True
        Me.cboprodi.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi"})
        Me.cboprodi.Location = New System.Drawing.Point(131, 80)
        Me.cboprodi.Name = "cboprodi"
        Me.cboprodi.Size = New System.Drawing.Size(186, 23)
        Me.cboprodi.TabIndex = 2
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(78, 109)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(192, 23)
        Me.btnTampilkan.TabIndex = 3
        Me.btnTampilkan.Text = "Tampilkan Pesan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 161)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.cboprodi)
        Me.Controls.Add(Me.cbojeniskelamin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnama)
        Me.Name = "Form1"
        Me.Text = "Percobaan Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbojeniskelamin As ComboBox
    Friend WithEvents cboprodi As ComboBox
    Friend WithEvents btnTampilkan As Button
End Class
