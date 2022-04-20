<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtAngka1 = New System.Windows.Forms.TextBox()
        Me.txtAngka2 = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKurang = New System.Windows.Forms.Button()
        Me.btnKali = New System.Windows.Forms.Button()
        Me.btnBagi = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Angka Kedua"
        '
        'txtAngka1
        '
        Me.txtAngka1.Location = New System.Drawing.Point(153, 32)
        Me.txtAngka1.Name = "txtAngka1"
        Me.txtAngka1.Size = New System.Drawing.Size(100, 23)
        Me.txtAngka1.TabIndex = 1
        '
        'txtAngka2
        '
        Me.txtAngka2.Location = New System.Drawing.Point(153, 61)
        Me.txtAngka2.Name = "txtAngka2"
        Me.txtAngka2.Size = New System.Drawing.Size(100, 23)
        Me.txtAngka2.TabIndex = 1
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(53, 101)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(40, 23)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "+"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnKurang
        '
        Me.btnKurang.Location = New System.Drawing.Point(99, 101)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(40, 23)
        Me.btnKurang.TabIndex = 2
        Me.btnKurang.Text = "-"
        Me.btnKurang.UseVisualStyleBackColor = True
        '
        'btnKali
        '
        Me.btnKali.Location = New System.Drawing.Point(145, 101)
        Me.btnKali.Name = "btnKali"
        Me.btnKali.Size = New System.Drawing.Size(40, 23)
        Me.btnKali.TabIndex = 2
        Me.btnKali.Text = "x"
        Me.btnKali.UseVisualStyleBackColor = True
        '
        'btnBagi
        '
        Me.btnBagi.Location = New System.Drawing.Point(191, 101)
        Me.btnBagi.Name = "btnBagi"
        Me.btnBagi.Size = New System.Drawing.Size(40, 23)
        Me.btnBagi.TabIndex = 2
        Me.btnBagi.Text = "/"
        Me.btnBagi.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasil"
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(153, 139)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(100, 23)
        Me.txtHasil.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 204)
        Me.Controls.Add(Me.btnBagi)
        Me.Controls.Add(Me.btnKali)
        Me.Controls.Add(Me.btnKurang)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.txtAngka2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAngka1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Kalkulator Sederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAngka1 As TextBox
    Friend WithEvents txtAngka2 As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnKali As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHasil As TextBox
End Class
