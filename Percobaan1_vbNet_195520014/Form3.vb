Public Class frmHitungNilai
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim TM, Mid, Final, Hasil As Double
        TM = Val(txtTM.Text)
        Mid = Val(txtMid.Text)
        Final = Val(txtFinal.Text)
        Hasil = (TM + Mid + Final) / 3
        txtNilaiAkhir.Text = Hasil
    End Sub
End Class