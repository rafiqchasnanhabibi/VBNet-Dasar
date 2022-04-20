<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txtTeks = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.bProses = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTeks
        '
        Me.txtTeks.Location = New System.Drawing.Point(126, 6)
        Me.txtTeks.Name = "txtTeks"
        Me.txtTeks.Size = New System.Drawing.Size(100, 23)
        Me.txtTeks.TabIndex = 0
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(126, 35)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 23)
        Me.txtJumlah.TabIndex = 0
        '
        'bProses
        '
        Me.bProses.Location = New System.Drawing.Point(84, 64)
        Me.bProses.Name = "bProses"
        Me.bProses.Size = New System.Drawing.Size(75, 23)
        Me.bProses.TabIndex = 1
        Me.bProses.Text = "Proses"
        Me.bProses.UseVisualStyleBackColor = True
        '
        'bClear
        '
        Me.bClear.Location = New System.Drawing.Point(35, 196)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(75, 23)
        Me.bClear.TabIndex = 1
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(126, 196)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(75, 23)
        Me.bKeluar.TabIndex = 1
        Me.bKeluar.Text = "Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'List1
        '
        Me.List1.Location = New System.Drawing.Point(12, 93)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(214, 97)
        Me.List1.TabIndex = 2
        Me.List1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tuliskan Teks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jumlah Perulangan"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 235)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.bKeluar)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.bProses)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtTeks)
        Me.Name = "Form5"
        Me.Text = "Program Perulangan Teks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTeks As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents bProses As Button
    Friend WithEvents bClear As Button
    Friend WithEvents bKeluar As Button
    Friend WithEvents List1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
