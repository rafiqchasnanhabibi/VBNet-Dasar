Public Class Form5
    Private Sub bProses_Click(sender As Object, e As EventArgs) Handles bProses.Click
        Dim teks As String
        Dim jumlah As Integer
        teks = txtTeks.Text
        jumlah = txtJumlah.Text
        For i = 1 To jumlah
            List1.Items.Add(teks)
        Next i
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        txtTeks.Text = ""
        txtJumlah.Text = ""
        List1.Items.Clear()
    End Sub

    Private Sub bKeluar_Click(sender As Object, e As EventArgs) Handles bKeluar.Click
        End
    End Sub
End Class