<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHitungNilai
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
        Me.txtTM = New System.Windows.Forms.TextBox()
        Me.txtMid = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tatap Muka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mid Test"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Final Test"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nilai Akhir"
        '
        'txtTM
        '
        Me.txtTM.Location = New System.Drawing.Point(152, 35)
        Me.txtTM.Name = "txtTM"
        Me.txtTM.Size = New System.Drawing.Size(100, 23)
        Me.txtTM.TabIndex = 1
        '
        'txtMid
        '
        Me.txtMid.Location = New System.Drawing.Point(152, 64)
        Me.txtMid.Name = "txtMid"
        Me.txtMid.Size = New System.Drawing.Size(100, 23)
        Me.txtMid.TabIndex = 1
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(152, 93)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 23)
        Me.txtFinal.TabIndex = 1
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(152, 152)
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(100, 23)
        Me.txtNilaiAkhir.TabIndex = 1
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(109, 123)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 2
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'frmHitungNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 224)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtNilaiAkhir)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtMid)
        Me.Controls.Add(Me.txtTM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHitungNilai"
        Me.Text = "Program Hitung Nilai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTM As TextBox
    Friend WithEvents txtMid As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents btnHitung As Button
End Class
