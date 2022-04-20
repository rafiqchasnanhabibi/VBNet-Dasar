Public Class Form4
    Public hrgmakanan, hrgminuman As Integer

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                Label2.Text = "Rp 3.000"
                hrgmakanan = 3000
            Case "Teh Manis"
                Label2.Text = "Rp 4.000"
                hrgmakanan = 4000
            Case "Jus Alpukat"
                Label2.Text = "Rp 7000"
                hrgmakanan = 7000
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Uduk"
                Label1.Text = "Rp 3.500"
                hrgminuman = 3500
            Case "Bakso"
                Label1.Text = "Rp 6.000"
                hrgminuman = 6000
            Case "Mie Ayam"
                Label1.Text = "Rp 7000"
                hrgminuman = 7000
        End Select
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ComboBox2.Visible = False
        Label2.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Enabled = False Then
            ComboBox2.Visible = False
        End If

        If CheckBox1.Enabled = True Then
            ComboBox2.Visible = True
            Label2.Visible = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim porsimakan, porsiminum, jumlah As Integer
        porsimakan = TextBox4.Text
        porsiminum = TextBox3.Text
        jumlah = (hrgmakanan * porsimakan) + (hrgminuman * porsiminum)
        Hasil.Text = "Rp " & jumlah.ToString
    End Sub
End Class