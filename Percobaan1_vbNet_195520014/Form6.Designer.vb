﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.bNext = New System.Windows.Forms.Button()
        Me.bWhile = New System.Windows.Forms.Button()
        Me.bUntil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(165, 229)
        Me.ListBox1.TabIndex = 0
        '
        'bNext
        '
        Me.bNext.Location = New System.Drawing.Point(183, 153)
        Me.bNext.Name = "bNext"
        Me.bNext.Size = New System.Drawing.Size(75, 23)
        Me.bNext.TabIndex = 1
        Me.bNext.Text = "For Next"
        Me.bNext.UseVisualStyleBackColor = True
        '
        'bWhile
        '
        Me.bWhile.Location = New System.Drawing.Point(183, 182)
        Me.bWhile.Name = "bWhile"
        Me.bWhile.Size = New System.Drawing.Size(75, 23)
        Me.bWhile.TabIndex = 1
        Me.bWhile.Text = "Do While"
        Me.bWhile.UseVisualStyleBackColor = True
        '
        'bUntil
        '
        Me.bUntil.Location = New System.Drawing.Point(183, 211)
        Me.bUntil.Name = "bUntil"
        Me.bUntil.Size = New System.Drawing.Size(75, 23)
        Me.bUntil.TabIndex = 1
        Me.bUntil.Text = "Do Until"
        Me.bUntil.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 261)
        Me.Controls.Add(Me.bUntil)
        Me.Controls.Add(Me.bWhile)
        Me.Controls.Add(Me.bNext)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form6"
        Me.Text = "Perulangan ke-2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents bNext As Button
    Friend WithEvents bWhile As Button
    Friend WithEvents bUntil As Button
End Class
